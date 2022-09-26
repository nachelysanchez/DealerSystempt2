
namespace DealerSystempt2.Tareas.Nachely.Tarea2.Ejercicio2
{
    partial class ReservaVehiculo
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.vehiculosGrid = new System.Windows.Forms.DataGridView();
            this.MarcaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CombustibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservadoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiculocombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReservarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(803, 102);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(100, 28);
            this.BuscarButton.TabIndex = 45;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // vehiculosGrid
            // 
            this.vehiculosGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.vehiculosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiculosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MarcaColumn,
            this.AnioColumn,
            this.PlacaColumn,
            this.CombustibleColumn,
            this.ReservadoColumn});
            this.vehiculosGrid.Location = new System.Drawing.Point(26, 192);
            this.vehiculosGrid.Margin = new System.Windows.Forms.Padding(4);
            this.vehiculosGrid.Name = "vehiculosGrid";
            this.vehiculosGrid.RowHeadersWidth = 51;
            this.vehiculosGrid.Size = new System.Drawing.Size(988, 185);
            this.vehiculosGrid.TabIndex = 44;
            // 
            // MarcaColumn
            // 
            this.MarcaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MarcaColumn.HeaderText = "Marca";
            this.MarcaColumn.MinimumWidth = 6;
            this.MarcaColumn.Name = "MarcaColumn";
            this.MarcaColumn.ReadOnly = true;
            // 
            // AnioColumn
            // 
            this.AnioColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnioColumn.HeaderText = "Año";
            this.AnioColumn.MinimumWidth = 6;
            this.AnioColumn.Name = "AnioColumn";
            this.AnioColumn.ReadOnly = true;
            // 
            // PlacaColumn
            // 
            this.PlacaColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlacaColumn.HeaderText = "Placa";
            this.PlacaColumn.MinimumWidth = 6;
            this.PlacaColumn.Name = "PlacaColumn";
            this.PlacaColumn.ReadOnly = true;
            // 
            // CombustibleColumn
            // 
            this.CombustibleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CombustibleColumn.HeaderText = "Combustible";
            this.CombustibleColumn.MinimumWidth = 6;
            this.CombustibleColumn.Name = "CombustibleColumn";
            this.CombustibleColumn.ReadOnly = true;
            // 
            // ReservadoColumn
            // 
            this.ReservadoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReservadoColumn.HeaderText = "Reservado";
            this.ReservadoColumn.MinimumWidth = 6;
            this.ReservadoColumn.Name = "ReservadoColumn";
            this.ReservadoColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(583, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Los vehiculos encontrados de la categoría seleccionada son:";
            // 
            // vehiculocombo
            // 
            this.vehiculocombo.FormattingEnabled = true;
            this.vehiculocombo.Items.AddRange(new object[] {
            "Maritimo",
            "Aereo",
            "Terrestre"});
            this.vehiculocombo.Location = new System.Drawing.Point(173, 102);
            this.vehiculocombo.Margin = new System.Windows.Forms.Padding(4);
            this.vehiculocombo.Name = "vehiculocombo";
            this.vehiculocombo.Size = new System.Drawing.Size(577, 24);
            this.vehiculocombo.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Vehiculo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(349, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(314, 33);
            this.label8.TabIndex = 40;
            this.label8.Text = "Reservas de Vehiculos";
            // 
            // ReservarButton
            // 
            this.ReservarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservarButton.Location = new System.Drawing.Point(859, 396);
            this.ReservarButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReservarButton.Name = "ReservarButton";
            this.ReservarButton.Size = new System.Drawing.Size(119, 41);
            this.ReservarButton.TabIndex = 46;
            this.ReservarButton.Text = "Reservar";
            this.ReservarButton.UseVisualStyleBackColor = true;
            this.ReservarButton.Click += new System.EventHandler(this.ReservarButton_Click);
            // 
            // ReservaVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.ReservarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.vehiculosGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehiculocombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "ReservaVehiculo";
            this.Text = "ReservaVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView vehiculosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CombustibleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservadoColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehiculocombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ReservarButton;
    }
}