
namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo2
{
    partial class MenuForm
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
            this.EstudiantesButton = new System.Windows.Forms.Button();
            this.DocentesButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.RegistroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EstudiantesButton
            // 
            this.EstudiantesButton.Location = new System.Drawing.Point(57, 88);
            this.EstudiantesButton.Name = "EstudiantesButton";
            this.EstudiantesButton.Size = new System.Drawing.Size(102, 45);
            this.EstudiantesButton.TabIndex = 0;
            this.EstudiantesButton.Text = "Estudiantes";
            this.EstudiantesButton.UseVisualStyleBackColor = true;
            this.EstudiantesButton.Click += new System.EventHandler(this.EstudiantesButton_Click);
            // 
            // DocentesButton
            // 
            this.DocentesButton.Location = new System.Drawing.Point(242, 88);
            this.DocentesButton.Name = "DocentesButton";
            this.DocentesButton.Size = new System.Drawing.Size(102, 45);
            this.DocentesButton.TabIndex = 1;
            this.DocentesButton.Text = "Docentes";
            this.DocentesButton.UseVisualStyleBackColor = true;
            this.DocentesButton.Click += new System.EventHandler(this.DocentesButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(433, 88);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(102, 45);
            this.SalirButton.TabIndex = 2;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // RegistroButton
            // 
            this.RegistroButton.Location = new System.Drawing.Point(625, 88);
            this.RegistroButton.Name = "RegistroButton";
            this.RegistroButton.Size = new System.Drawing.Size(102, 45);
            this.RegistroButton.TabIndex = 3;
            this.RegistroButton.Text = "Registro";
            this.RegistroButton.UseVisualStyleBackColor = true;
            this.RegistroButton.Click += new System.EventHandler(this.RegistroButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.RegistroButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.DocentesButton);
            this.Controls.Add(this.EstudiantesButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EstudiantesButton;
        private System.Windows.Forms.Button DocentesButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button RegistroButton;
    }
}