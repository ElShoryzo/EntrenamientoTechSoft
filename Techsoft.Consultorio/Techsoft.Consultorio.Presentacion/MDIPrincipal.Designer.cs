namespace Techsoft.Consultorio.Presentacion
{
    partial class MDIPrincipal
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
            btnPacientes = new Button();
            btnDoctores = new Button();
            SuspendLayout();
            // 
            // btnPacientes
            // 
            btnPacientes.Location = new Point(80, 60);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(75, 23);
            btnPacientes.TabIndex = 0;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnDoctores
            // 
            btnDoctores.Location = new Point(302, 60);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(75, 23);
            btnDoctores.TabIndex = 1;
            btnDoctores.Text = "Doctores";
            btnDoctores.UseVisualStyleBackColor = true;
            btnDoctores.Click += btnDoctores_Click;
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoctores);
            Controls.Add(btnPacientes);
            Name = "MDIPrincipal";
            Text = "Consultorio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPacientes;
        private Button btnDoctores;
    }
}