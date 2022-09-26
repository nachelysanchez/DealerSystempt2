
namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo2
{
    partial class FormSalir
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
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Gray;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.Location = new System.Drawing.Point(662, 384);
            this.SalirButton.Margin = new System.Windows.Forms.Padding(4);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(100, 41);
            this.SalirButton.TabIndex = 1;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // FormSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirButton);
            this.Name = "FormSalir";
            this.Text = "FormSalir";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button SalirButton;
    }
}