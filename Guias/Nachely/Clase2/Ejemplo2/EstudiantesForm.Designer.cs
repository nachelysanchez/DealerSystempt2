﻿
namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo2
{
    partial class EstudiantesForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estudiantes";
            // 
            // EstudiantesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Name = "EstudiantesForm";
            this.Text = "EstudiantesForm";
            this.Load += new System.EventHandler(this.EstudiantesForm_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Valor1txt, 0);
            this.Controls.SetChildIndex(this.restxt, 0);
            this.Controls.SetChildIndex(this.valor2txt, 0);
            this.Controls.SetChildIndex(this.LimpiarButton, 0);
            this.Controls.SetChildIndex(this.ModificarButton, 0);
            this.Controls.SetChildIndex(this.GuardarButton, 0);
            this.Controls.SetChildIndex(this.SalirButton, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
    }
}