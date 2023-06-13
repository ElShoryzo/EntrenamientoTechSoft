namespace Techsoft.Consultorio.Presentacion
{
    partial class frmDoctores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVolver = new Button();
            btnGuardar = new Button();
            label4 = new Label();
            txtTelefono = new TextBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(585, 86);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(71, 149);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(309, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 115);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 17;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(166, 112);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(214, 23);
            txtTelefono.TabIndex = 16;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(71, 86);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(44, 15);
            lblCedula.TabIndex = 15;
            lblCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(166, 83);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(214, 23);
            txtCedula.TabIndex = 14;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(71, 57);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(166, 54);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(214, 23);
            txtDireccion.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(71, 28);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(214, 23);
            txtNombre.TabIndex = 10;
            // 
            // frmDoctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 207);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(lblCedula);
            Controls.Add(txtCedula);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "frmDoctores";
            Text = "Doctores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnGuardar;
        private Label label4;
        private TextBox txtTelefono;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}