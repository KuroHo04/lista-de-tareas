using System.Text.Json; // Importa el espacio de nombres necesario para la serializaci�n y deserializaci�n JSON.

namespace lista_de_tareas // Define el espacio de nombres para la aplicaci�n.
{
    public partial class Form1 : Form // Declara la clase principal del formulario, heredando de Form.
    {

        List<Tareas> Lista_de_tareas = new List<Tareas>(); // Inicializa una nueva lista para almacenar objetos Tareas.

        public Form1() // Constructor para la clase Form1.
        {
            InitializeComponent(); // Inicializa los componentes definidos en el dise�ador.
            CargarTareas(); // Llama al m�todo para cargar las tareas cuando se inicia el formulario.
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing); // Adjunta un controlador de eventos para cuando el formulario se est� cerrando.
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Controlador de eventos para el evento de cierre del formulario.
        {
            GuardarTareas(); // Llama al m�todo para guardar las tareas antes de que el formulario se cierre.
        }


        // --- Controladores de eventos no utilizados (a menudo generados por el dise�ador pero no implementados) ---
        private void lbtareas_Click(object sender, EventArgs e) { }
        private void NewTareas_TextChanged(object sender, EventArgs e) { }
        private void textDescripcion_TextChanged(object sender, EventArgs e) { }
        private void LblTareas_Click(object sender, EventArgs e) { }
        private void txtMostrarDescripcion_TextChanged(object sender, EventArgs e) { }


        // --- M�todos de funcionalidad principal ---

        private void BtnAgregar_Click(object sender, EventArgs e) // Controlador de eventos para el clic del bot�n "Agregar Tarea".
        {
            string nombreTareas = NewTareas.Text.Trim(); // Obtiene el nombre de la tarea del campo de entrada y elimina los espacios en blanco iniciales/finales.
            string descripcionTarea = textDescripcion.Text.Trim(); // Obtiene la descripci�n de la tarea del campo de entrada y elimina los espacios en blanco iniciales/finales.

            if (!string.IsNullOrEmpty(nombreTareas)) // Comprueba si el nombre de la tarea no est� vac�o o es nulo.
            {
                // Crea un nuevo objeto Tareas con el nombre y la descripci�n proporcionados, estableciendo Completada en falso por defecto.
                Tareas nuevaTarea = new Tareas { Nombre = nombreTareas, Completada = false, Descripcion = descripcionTarea };
                Lista_de_tareas.Add(nuevaTarea); // Agrega la nueva tarea a la lista de tareas.
                LstTareas.Items.Add(nuevaTarea.Nombre); // Agrega el nombre de la tarea al ListBox para mostrarlo.

                NewTareas.Clear(); // Borra el campo de entrada del nombre de la tarea.
                textDescripcion.Clear(); // Borra el campo de entrada de la descripci�n de la tarea.

                GuardarTareas(); // Guarda la lista de tareas actualizada.
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e) // Controlador de eventos para el clic del bot�n "Confirmar (Completar) Tarea".
        {
            int indeceSelecionado = LstTareas.SelectedIndex; // Obtiene el �ndice del elemento seleccionado en el ListBox.

            if (indeceSelecionado >= 0) // Comprueba si se ha seleccionado un elemento.
            {

                // Actualiza el elemento del ListBox para mostrar "(Completada)" antes del nombre de la tarea.
                LstTareas.Items[indeceSelecionado] = $"(Completada) {Lista_de_tareas[indeceSelecionado].Nombre}";

                Lista_de_tareas[indeceSelecionado].Completada = true; // Establece la propiedad 'Completada' del objeto Tareas correspondiente en verdadero.

                LstTareas.SelectedIndex = -1; // Deselecciona cualquier elemento en el ListBox.
                LblTareas.Text = string.Empty; // Borra la etiqueta que muestra el nombre de la tarea seleccionada.
                BtnConfirmar.Enabled = false; // Deshabilita el bot�n "Confirmar".

                GuardarTareas(); // Guarda la lista de tareas actualizada.
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e) // Controlador de eventos para el clic del bot�n "Eliminar Tarea".
        {
            int indeceSelecionado = LstTareas.SelectedIndex; // Obtiene el �ndice del elemento seleccionado en el ListBox.

            if (indeceSelecionado >= 0) // Comprueba si se ha seleccionado un elemento.
            {
                Lista_de_tareas.RemoveAt(indeceSelecionado); // Elimina la tarea de la lista de tareas.
                LstTareas.Items.RemoveAt(indeceSelecionado); // Elimina la tarea de la pantalla del ListBox.

                LstTareas.SelectedIndex = -1; // Deselecciona cualquier elemento en el ListBox.
                lbtareas.Text = string.Empty; // Borra la etiqueta (nota: 'lbtareas' probablemente sea un error tipogr�fico y deber�a ser 'LblTareas').
                BtnConfirmar.Enabled = false; // Deshabilita el bot�n "Confirmar".

                GuardarTareas(); // Guarda la lista de tareas actualizada.
            }
        }

        private void LstTareas_SelectedIndexChanged(object sender, EventArgs e) // Controlador de eventos para cuando cambia el elemento seleccionado en el ListBox.
        {
            int indiceSeleccionado = LstTareas.SelectedIndex; // Obtiene el �ndice del elemento reci�n seleccionado.
            if (indiceSeleccionado >= 0) // Comprueba si se ha seleccionado un elemento.
            {
                Tareas tareaSeleccionadas = Lista_de_tareas[indiceSeleccionado]; // Obtiene el objeto Tareas correspondiente de la lista.
                LblTareas.Text = tareaSeleccionadas.Nombre; // Muestra el nombre de la tarea seleccionada en una etiqueta.

                // Habilita el bot�n "Confirmar" solo si la tarea seleccionada NO est� ya completada.
                BtnConfirmar.Enabled = !tareaSeleccionadas.Completada;

                txtMostrarDescripcion.Text = string.Empty; // Borra el cuadro de texto de visualizaci�n de la descripci�n (asumiendo que se debe borrar al cambiar la selecci�n antes de hacer clic expl�citamente en "Extraer").
            }
            else // Si no se selecciona ning�n elemento.
            {
                LblTareas.Text = string.Empty; // Borra la etiqueta que muestra el nombre de la tarea seleccionada.
                BtnConfirmar.Enabled = false; // Deshabilita el bot�n "Confirmar".

                txtMostrarDescripcion.Text = string.Empty; // Borra el cuadro de texto de visualizaci�n de la descripci�n.
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e) // Controlador de eventos para el clic del bot�n "Extraer Descripci�n".
        {
            { // Llaves adicionales, se pueden eliminar.
                int indiceSeleccionado = LstTareas.SelectedIndex; // Obtiene el �ndice del elemento seleccionado en el ListBox.

                if (indiceSeleccionado >= 0) // Comprueba si se ha seleccionado un elemento.
                {
                    // Muestra la descripci�n de la tarea seleccionada en el cuadro de texto 'txtMostrarDescripcion'.
                    txtMostrarDescripcion.Text = Lista_de_tareas[indiceSeleccionado].Descripcion;
                }
                else // Si no se selecciona ning�n elemento.
                {
                    // Muestra un mensaje indicando que se debe seleccionar una tarea.
                    txtMostrarDescripcion.Text = "Selecciona una tarea para ver su descripci�n.";
                }
            }
        }


        // --- M�todos de persistencia de datos ---

        private void GuardarTareas() // M�todo para guardar la lista de tareas en un archivo JSON.
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(Lista_de_tareas); // Serializa la lista de objetos Tareas a una cadena JSON.
                File.WriteAllText("tareas.json", jsonString); // Escribe la cadena JSON en un archivo llamado "tareas.json".
            }
            catch (Exception ex) // Captura cualquier excepci�n que ocurra durante el guardado.
            {
                // Muestra un cuadro de mensaje de error si el guardado falla.
                MessageBox.Show($"Error al guardar las tareas: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTareas() // M�todo para cargar la lista de tareas desde un archivo JSON.
        {
            try
            {
                if (File.Exists("tareas.json")) // Comprueba si existe el archivo "tareas.json".
                {
                    string jsonString = File.ReadAllText("tareas.json"); // Lee todo el texto del archivo "tareas.json".
                    Lista_de_tareas = JsonSerializer.Deserialize<List<Tareas>>(jsonString)!; // Deserializa la cadena JSON de nuevo a una lista de objetos Tareas.


                    LstTareas.Items.Clear(); // Limpia los elementos existentes en el ListBox.
                    foreach (var tarea in Lista_de_tareas) // Itera sobre cada tarea en la lista cargada.
                    {
                        // Agrega la tarea al ListBox, prefij�ndola con "(Completada)" si est� marcada como completada.
                        if (tarea.Completada)
                        {
                            LstTareas.Items.Add($"(Completada) {tarea.Nombre}");
                        }
                        else
                        {
                            LstTareas.Items.Add(tarea.Nombre);
                        }
                    }
                }
            }
            catch (Exception ex) // Captura cualquier excepci�n que ocurra durante la carga.
            {
                // Muestra un cuadro de mensaje de error si la carga falla.
                MessageBox.Show($"Error al cargar las tareas: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Lista_de_tareas = new List<Tareas>(); // Inicializa una nueva lista vac�a si hubo un error de carga para evitar problemas.
            }
        }
    }
}