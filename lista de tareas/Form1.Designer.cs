namespace lista_de_tareas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewTareas = new TextBox();
            lbtareas = new Label();
            BtnAgregar = new Button();
            BtnConfirmar = new Button();
            BtnEliminar = new Button();
            LstTareas = new ListBox();
            LblTareas = new Label();
            textDescripcion = new TextBox();
            btnExtraer = new Button();
            txtMostrarDescripcion = new TextBox();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // NewTareas
            // 
            NewTareas.Location = new Point(48, 70);
            NewTareas.Name = "NewTareas";
            NewTareas.Size = new Size(210, 27);
            NewTareas.TabIndex = 0;
            NewTareas.TextChanged += NewTareas_TextChanged;
            // 
            // lbtareas
            // 
            lbtareas.AutoSize = true;
            lbtareas.Location = new Point(48, 32);
            lbtareas.Name = "lbtareas";
            lbtareas.Size = new Size(123, 20);
            lbtareas.TabIndex = 1;
            lbtareas.Text = "Ingresa una tarea";
            lbtareas.Click += lbtareas_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(48, 159);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(123, 29);
            BtnAgregar.TabIndex = 2;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(48, 204);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(123, 29);
            BtnConfirmar.TabIndex = 3;
            BtnConfirmar.Text = "Confirmar";
            BtnConfirmar.UseVisualStyleBackColor = true;
            BtnConfirmar.Click += BtnConfirmar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(48, 299);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(123, 29);
            BtnEliminar.TabIndex = 4;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // LstTareas
            // 
            LstTareas.FormattingEnabled = true;
            LstTareas.Location = new Point(299, 70);
            LstTareas.Name = "LstTareas";
            LstTareas.Size = new Size(138, 264);
            LstTareas.TabIndex = 5;
            LstTareas.SelectedIndexChanged += LstTareas_SelectedIndexChanged;
            // 
            // LblTareas
            // 
            LblTareas.AutoSize = true;
            LblTareas.Location = new Point(308, 308);
            LblTareas.Name = "LblTareas";
            LblTareas.Size = new Size(50, 20);
            LblTareas.TabIndex = 6;
            LblTareas.Text = "Tareas";
            LblTareas.Click += LblTareas_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(48, 114);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(210, 27);
            textDescripcion.TabIndex = 7;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            // 
            // btnExtraer
            // 
            btnExtraer.Location = new Point(48, 255);
            btnExtraer.Name = "btnExtraer";
            btnExtraer.Size = new Size(123, 29);
            btnExtraer.TabIndex = 8;
            btnExtraer.Text = "Extraer";
            btnExtraer.UseVisualStyleBackColor = true;
            btnExtraer.Click += btnExtraer_Click;
            // 
            // txtMostrarDescripcion
            // 
            txtMostrarDescripcion.Location = new Point(443, 70);
            txtMostrarDescripcion.Name = "txtMostrarDescripcion";
            txtMostrarDescripcion.Size = new Size(321, 27);
            txtMostrarDescripcion.TabIndex = 9;
            txtMostrarDescripcion.TextChanged += txtMostrarDescripcion_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(443, 47);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescripcion);
            Controls.Add(txtMostrarDescripcion);
            Controls.Add(btnExtraer);
            Controls.Add(textDescripcion);
            Controls.Add(LblTareas);
            Controls.Add(LstTareas);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnConfirmar);
            Controls.Add(BtnAgregar);
            Controls.Add(lbtareas);
            Controls.Add(NewTareas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewTareas;
        private Label lbtareas;
        private Button BtnAgregar;
        private Button BtnConfirmar;
        private Button BtnEliminar;
        private ListBox LstTareas;
        private Label LblTareas;
        private TextBox textDescripcion;
        private Button btnExtraer;
        private TextBox txtMostrarDescripcion;
        private Label lblDescripcion;
    }
}
