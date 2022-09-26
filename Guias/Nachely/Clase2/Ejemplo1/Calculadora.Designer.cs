
namespace DealerSystempt2.Guias.Nachely.Clase2.Ejemplo1
{
    partial class Calculadora
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
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.RestarButton = new System.Windows.Forms.Button();
            this.SumarButton = new System.Windows.Forms.Button();
            this.valor2txt = new System.Windows.Forms.TextBox();
            this.restxt = new System.Windows.Forms.TextBox();
            this.Valor1txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(328, 139);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(100, 28);
            this.LimpiarButton.TabIndex = 19;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Location = new System.Drawing.Point(328, 103);
            this.MultiplicarButton.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(100, 28);
            this.MultiplicarButton.TabIndex = 18;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // RestarButton
            // 
            this.RestarButton.Location = new System.Drawing.Point(328, 68);
            this.RestarButton.Margin = new System.Windows.Forms.Padding(4);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(100, 28);
            this.RestarButton.TabIndex = 17;
            this.RestarButton.Text = "Restar";
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(328, 32);
            this.SumarButton.Margin = new System.Windows.Forms.Padding(4);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(100, 28);
            this.SumarButton.TabIndex = 16;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // valor2txt
            // 
            this.valor2txt.Location = new System.Drawing.Point(155, 91);
            this.valor2txt.Margin = new System.Windows.Forms.Padding(4);
            this.valor2txt.Name = "valor2txt";
            this.valor2txt.Size = new System.Drawing.Size(132, 22);
            this.valor2txt.TabIndex = 15;
            // 
            // restxt
            // 
            this.restxt.Location = new System.Drawing.Point(155, 153);
            this.restxt.Margin = new System.Windows.Forms.Padding(4);
            this.restxt.Name = "restxt";
            this.restxt.Size = new System.Drawing.Size(132, 22);
            this.restxt.TabIndex = 14;
            // 
            // Valor1txt
            // 
            this.Valor1txt.Location = new System.Drawing.Point(155, 33);
            this.Valor1txt.Margin = new System.Windows.Forms.Padding(4);
            this.Valor1txt.Name = "Valor1txt";
            this.Valor1txt.Size = new System.Drawing.Size(132, 22);
            this.Valor1txt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = " Valor 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor 1";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 221);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.valor2txt);
            this.Controls.Add(this.restxt);
            this.Controls.Add(this.Valor1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.TextBox valor2txt;
        private System.Windows.Forms.TextBox restxt;
        private System.Windows.Forms.TextBox Valor1txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}