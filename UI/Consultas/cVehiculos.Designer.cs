
namespace DealerSystempt2.UI.Consultas
{
    partial class cVehiculos
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
            this.ConsultaDTG = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Criteriotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtrocmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.VehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDTG
            // 
            this.ConsultaDTG.AllowUserToAddRows = false;
            this.ConsultaDTG.AllowUserToDeleteRows = false;
            this.ConsultaDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehiculoId,
            this.Modelo,
            this.Precio,
            this.Anio,
            this.Existencia});
            this.ConsultaDTG.Location = new System.Drawing.Point(23, 142);
            this.ConsultaDTG.Name = "ConsultaDTG";
            this.ConsultaDTG.ReadOnly = true;
            this.ConsultaDTG.RowHeadersWidth = 51;
            this.ConsultaDTG.RowTemplate.Height = 24;
            this.ConsultaDTG.Size = new System.Drawing.Size(827, 311);
            this.ConsultaDTG.TabIndex = 128;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.Salmon;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(700, 74);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnBuscar.TabIndex = 127;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Criteriotxt
            // 
            this.Criteriotxt.Location = new System.Drawing.Point(314, 81);
            this.Criteriotxt.Name = "Criteriotxt";
            this.Criteriotxt.Size = new System.Drawing.Size(362, 22);
            this.Criteriotxt.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 125;
            this.label1.Text = "Criterio";
            // 
            // filtrocmb
            // 
            this.filtrocmb.FormattingEnabled = true;
            this.filtrocmb.Items.AddRange(new object[] {
            "VehiculoId",
            "Modelo"});
            this.filtrocmb.Location = new System.Drawing.Point(79, 81);
            this.filtrocmb.Name = "filtrocmb";
            this.filtrocmb.Size = new System.Drawing.Size(151, 24);
            this.filtrocmb.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 123;
            this.label4.Text = "Filtro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(331, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(280, 43);
            this.label14.TabIndex = 122;
            this.label14.Text = "Consulta de Vehiculos";
            // 
            // VehiculoId
            // 
            this.VehiculoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VehiculoId.HeaderText = "Vehiculo Id";
            this.VehiculoId.MinimumWidth = 6;
            this.VehiculoId.Name = "VehiculoId";
            this.VehiculoId.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.MinimumWidth = 6;
            this.Anio.Name = "Anio";
            this.Anio.ReadOnly = true;
            this.Anio.Width = 125;
            // 
            // Existencia
            // 
            this.Existencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.MinimumWidth = 6;
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // cVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 472);
            this.Controls.Add(this.ConsultaDTG);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Criteriotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrocmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Name = "cVehiculos";
            this.Text = "cVehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDTG;
        protected System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox Criteriotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filtrocmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
    }
}