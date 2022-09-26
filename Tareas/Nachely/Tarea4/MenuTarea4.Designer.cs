
namespace DealerSystempt2.Tareas.Nachely.Tarea4
{
    partial class MenuTarea4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cCiudadesButton = new System.Windows.Forms.Button();
            this.cUsuariosButton = new System.Windows.Forms.Button();
            this.UsuariosButton = new System.Windows.Forms.Button();
            this.CiudadesButton = new System.Windows.Forms.Button();
            this.gTareaButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cCiudadesButton);
            this.groupBox1.Controls.Add(this.cUsuariosButton);
            this.groupBox1.Controls.Add(this.UsuariosButton);
            this.groupBox1.Controls.Add(this.CiudadesButton);
            this.groupBox1.Controls.Add(this.gTareaButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 165);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarea 4";
            // 
            // cCiudadesButton
            // 
            this.cCiudadesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCiudadesButton.Location = new System.Drawing.Point(242, 109);
            this.cCiudadesButton.Name = "cCiudadesButton";
            this.cCiudadesButton.Size = new System.Drawing.Size(97, 50);
            this.cCiudadesButton.TabIndex = 9;
            this.cCiudadesButton.Text = "Consulta Ciudades";
            this.cCiudadesButton.UseVisualStyleBackColor = true;
            this.cCiudadesButton.Click += new System.EventHandler(this.cCiudadesButton_Click);
            // 
            // cUsuariosButton
            // 
            this.cUsuariosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUsuariosButton.Location = new System.Drawing.Point(17, 109);
            this.cUsuariosButton.Name = "cUsuariosButton";
            this.cUsuariosButton.Size = new System.Drawing.Size(97, 50);
            this.cUsuariosButton.TabIndex = 8;
            this.cUsuariosButton.Text = "Consulta Usuarios";
            this.cUsuariosButton.UseVisualStyleBackColor = true;
            this.cUsuariosButton.Click += new System.EventHandler(this.cUsuariosButton_Click);
            // 
            // UsuariosButton
            // 
            this.UsuariosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosButton.Location = new System.Drawing.Point(17, 62);
            this.UsuariosButton.Name = "UsuariosButton";
            this.UsuariosButton.Size = new System.Drawing.Size(97, 32);
            this.UsuariosButton.TabIndex = 7;
            this.UsuariosButton.Text = "Usuarios";
            this.UsuariosButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UsuariosButton.UseVisualStyleBackColor = true;
            this.UsuariosButton.Click += new System.EventHandler(this.UsuariosButton_Click);
            // 
            // CiudadesButton
            // 
            this.CiudadesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadesButton.Location = new System.Drawing.Point(242, 62);
            this.CiudadesButton.Name = "CiudadesButton";
            this.CiudadesButton.Size = new System.Drawing.Size(97, 32);
            this.CiudadesButton.TabIndex = 6;
            this.CiudadesButton.Text = "Ciudades";
            this.CiudadesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CiudadesButton.UseVisualStyleBackColor = true;
            this.CiudadesButton.Click += new System.EventHandler(this.CiudadesButton_Click);
            // 
            // gTareaButton
            // 
            this.gTareaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTareaButton.Location = new System.Drawing.Point(92, 23);
            this.gTareaButton.Name = "gTareaButton";
            this.gTareaButton.Size = new System.Drawing.Size(168, 32);
            this.gTareaButton.TabIndex = 5;
            this.gTareaButton.Text = "Generar Tarea 4";
            this.gTareaButton.UseVisualStyleBackColor = true;
            // 
            // MenuTarea4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 230);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuTarea4";
            this.Text = "MenuTarea4";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cCiudadesButton;
        private System.Windows.Forms.Button cUsuariosButton;
        private System.Windows.Forms.Button UsuariosButton;
        private System.Windows.Forms.Button CiudadesButton;
        private System.Windows.Forms.Button gTareaButton;
    }
}