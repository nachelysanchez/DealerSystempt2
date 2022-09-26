
namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    partial class cTransporteTerrestre
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
            this.label8 = new System.Windows.Forms.Label();
            this.terrestresGrid = new System.Windows.Forms.DataGridView();
            this.MarcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CombustibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRuedasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPuertasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terrestresGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(321, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 33);
            this.label8.TabIndex = 35;
            this.label8.Text = "Vehiculos Terrestres";
            // 
            // terrestresGrid
            // 
            this.terrestresGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.terrestresGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terrestresGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarcaColumn,
            this.AnioColumn,
            this.PlacaColumn,
            this.CombustibleColumn,
            this.NumRuedasColumn,
            this.NumPuertasColumn,
            this.ReservadoColumn});
            this.terrestresGrid.Location = new System.Drawing.Point(13, 86);
            this.terrestresGrid.Margin = new System.Windows.Forms.Padding(4);
            this.terrestresGrid.Name = "terrestresGrid";
            this.terrestresGrid.RowHeadersWidth = 51;
            this.terrestresGrid.Size = new System.Drawing.Size(988, 185);
            this.terrestresGrid.TabIndex = 34;
            // 
            // MarcaColumn
            // 
            this.MarcaColumn.HeaderText = "Marca";
            this.MarcaColumn.MinimumWidth = 6;
            this.MarcaColumn.Name = "MarcaColumn";
            this.MarcaColumn.ReadOnly = true;
            this.MarcaColumn.Width = 125;
            // 
            // AnioColumn
            // 
            this.AnioColumn.HeaderText = "Año";
            this.AnioColumn.MinimumWidth = 6;
            this.AnioColumn.Name = "AnioColumn";
            this.AnioColumn.ReadOnly = true;
            this.AnioColumn.Width = 125;
            // 
            // PlacaColumn
            // 
            this.PlacaColumn.HeaderText = "Placa";
            this.PlacaColumn.MinimumWidth = 6;
            this.PlacaColumn.Name = "PlacaColumn";
            this.PlacaColumn.ReadOnly = true;
            this.PlacaColumn.Width = 125;
            // 
            // CombustibleColumn
            // 
            this.CombustibleColumn.HeaderText = "Combustible";
            this.CombustibleColumn.MinimumWidth = 6;
            this.CombustibleColumn.Name = "CombustibleColumn";
            this.CombustibleColumn.ReadOnly = true;
            this.CombustibleColumn.Width = 125;
            // 
            // NumRuedasColumn
            // 
            this.NumRuedasColumn.HeaderText = "Número de Ruedas";
            this.NumRuedasColumn.MinimumWidth = 6;
            this.NumRuedasColumn.Name = "NumRuedasColumn";
            this.NumRuedasColumn.ReadOnly = true;
            this.NumRuedasColumn.Width = 125;
            // 
            // NumPuertasColumn
            // 
            this.NumPuertasColumn.HeaderText = "Número de Puertas";
            this.NumPuertasColumn.MinimumWidth = 6;
            this.NumPuertasColumn.Name = "NumPuertasColumn";
            this.NumPuertasColumn.ReadOnly = true;
            this.NumPuertasColumn.Width = 125;
            // 
            // ReservadoColumn
            // 
            this.ReservadoColumn.HeaderText = "Reservado";
            this.ReservadoColumn.MinimumWidth = 6;
            this.ReservadoColumn.Name = "ReservadoColumn";
            this.ReservadoColumn.ReadOnly = true;
            this.ReservadoColumn.Width = 125;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(901, 50);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 28);
            this.BuscarButton.TabIndex = 36;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cTransporteTerrestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 313);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.terrestresGrid);
            this.Name = "cTransporteTerrestre";
            this.Text = "cTransporteTerrestre";
            ((System.ComponentModel.ISupportInitialize)(this.terrestresGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView terrestresGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CombustibleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRuedasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPuertasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservadoColumn;
        private System.Windows.Forms.Button BuscarButton;
    }
}