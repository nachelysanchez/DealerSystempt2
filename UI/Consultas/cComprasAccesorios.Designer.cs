
namespace DealerSystempt2.UI.Consultas
{
    partial class cComprasAccesorios
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
            this.CompraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDTG
            // 
            this.ConsultaDTG.AllowUserToAddRows = false;
            this.ConsultaDTG.AllowUserToDeleteRows = false;
            this.ConsultaDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompraId,
            this.Fecha,
            this.Tipo,
            this.Total});
            this.ConsultaDTG.Location = new System.Drawing.Point(48, 132);
            this.ConsultaDTG.Name = "ConsultaDTG";
            this.ConsultaDTG.ReadOnly = true;
            this.ConsultaDTG.RowHeadersWidth = 51;
            this.ConsultaDTG.RowTemplate.Height = 24;
            this.ConsultaDTG.Size = new System.Drawing.Size(827, 311);
            this.ConsultaDTG.TabIndex = 121;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.Salmon;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(725, 64);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 36);
            this.btnBuscar.TabIndex = 120;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Criteriotxt
            // 
            this.Criteriotxt.Location = new System.Drawing.Point(339, 71);
            this.Criteriotxt.Name = "Criteriotxt";
            this.Criteriotxt.Size = new System.Drawing.Size(362, 22);
            this.Criteriotxt.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 118;
            this.label1.Text = "Criterio";
            // 
            // filtrocmb
            // 
            this.filtrocmb.FormattingEnabled = true;
            this.filtrocmb.Items.AddRange(new object[] {
            "CompraId",
            "SuplidorId"});
            this.filtrocmb.Location = new System.Drawing.Point(104, 71);
            this.filtrocmb.Name = "filtrocmb";
            this.filtrocmb.Size = new System.Drawing.Size(151, 24);
            this.filtrocmb.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 116;
            this.label4.Text = "Filtro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(223, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(437, 43);
            this.label14.TabIndex = 115;
            this.label14.Text = "Consulta de Compra de Accesorios";
            // 
            // CompraId
            // 
            this.CompraId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CompraId.HeaderText = "Compra Id";
            this.CompraId.MinimumWidth = 6;
            this.CompraId.Name = "CompraId";
            this.CompraId.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // cComprasAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 475);
            this.Controls.Add(this.ConsultaDTG);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.Criteriotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrocmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Name = "cComprasAccesorios";
            this.Text = "Consulta de ComprasAccesorios";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}