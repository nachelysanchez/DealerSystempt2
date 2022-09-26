
namespace DealerSystempt2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeAccesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeAccesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeAccesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeAccesoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.compraVehiculosLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VentasVehiculosLink = new System.Windows.Forms.LinkLabel();
            this.VentaAccesoriosLink = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.vehiculosToolStripMenuItem,
            this.accesoriosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.ventasDeAccesoriosToolStripMenuItem,
            this.comprasDeAccesoriosToolStripMenuItem,
            this.comprasDeVehiculosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click_1);
            // 
            // accesoriosToolStripMenuItem
            // 
            this.accesoriosToolStripMenuItem.Name = "accesoriosToolStripMenuItem";
            this.accesoriosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.accesoriosToolStripMenuItem.Text = "Accesorios";
            this.accesoriosToolStripMenuItem.Click += new System.EventHandler(this.accesoriosToolStripMenuItem_Click_1);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ventasToolStripMenuItem.Text = "Ventas de Vehículos";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
            // 
            // ventasDeAccesoriosToolStripMenuItem
            // 
            this.ventasDeAccesoriosToolStripMenuItem.Name = "ventasDeAccesoriosToolStripMenuItem";
            this.ventasDeAccesoriosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.ventasDeAccesoriosToolStripMenuItem.Text = "Ventas de Accesorios";
            this.ventasDeAccesoriosToolStripMenuItem.Click += new System.EventHandler(this.ventasDeAccesoriosToolStripMenuItem_Click);
            // 
            // comprasDeAccesoriosToolStripMenuItem
            // 
            this.comprasDeAccesoriosToolStripMenuItem.Name = "comprasDeAccesoriosToolStripMenuItem";
            this.comprasDeAccesoriosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.comprasDeAccesoriosToolStripMenuItem.Text = "Compras de Accesorios";
            this.comprasDeAccesoriosToolStripMenuItem.Click += new System.EventHandler(this.comprasDeAccesoriosToolStripMenuItem_Click);
            // 
            // comprasDeVehiculosToolStripMenuItem
            // 
            this.comprasDeVehiculosToolStripMenuItem.Name = "comprasDeVehiculosToolStripMenuItem";
            this.comprasDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.comprasDeVehiculosToolStripMenuItem.Text = "Compras de Vehiculos";
            this.comprasDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.comprasDeVehiculosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.accesoriosToolStripMenuItem1,
            this.compraDeAccesoriosToolStripMenuItem,
            this.compraDeVehiculosToolStripMenuItem,
            this.suplidoresToolStripMenuItem1,
            this.vehiculosToolStripMenuItem1,
            this.ventaDeAccesoriosToolStripMenuItem,
            this.ventaDeVehiculosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // accesoriosToolStripMenuItem1
            // 
            this.accesoriosToolStripMenuItem1.Name = "accesoriosToolStripMenuItem1";
            this.accesoriosToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.accesoriosToolStripMenuItem1.Text = "Accesorios";
            this.accesoriosToolStripMenuItem1.Click += new System.EventHandler(this.accesoriosToolStripMenuItem1_Click);
            // 
            // compraDeAccesoriosToolStripMenuItem
            // 
            this.compraDeAccesoriosToolStripMenuItem.Name = "compraDeAccesoriosToolStripMenuItem";
            this.compraDeAccesoriosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.compraDeAccesoriosToolStripMenuItem.Text = "Compra de Accesorios";
            this.compraDeAccesoriosToolStripMenuItem.Click += new System.EventHandler(this.compraDeAccesoriosToolStripMenuItem_Click);
            // 
            // compraDeVehiculosToolStripMenuItem
            // 
            this.compraDeVehiculosToolStripMenuItem.Name = "compraDeVehiculosToolStripMenuItem";
            this.compraDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.compraDeVehiculosToolStripMenuItem.Text = "Compra de Vehiculos";
            this.compraDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.compraDeVehiculosToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem1
            // 
            this.suplidoresToolStripMenuItem1.Name = "suplidoresToolStripMenuItem1";
            this.suplidoresToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.suplidoresToolStripMenuItem1.Text = "Suplidores";
            this.suplidoresToolStripMenuItem1.Click += new System.EventHandler(this.suplidoresToolStripMenuItem1_Click);
            // 
            // vehiculosToolStripMenuItem1
            // 
            this.vehiculosToolStripMenuItem1.Name = "vehiculosToolStripMenuItem1";
            this.vehiculosToolStripMenuItem1.Size = new System.Drawing.Size(241, 26);
            this.vehiculosToolStripMenuItem1.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem1.Click += new System.EventHandler(this.vehiculosToolStripMenuItem1_Click);
            // 
            // ventaDeAccesoriosToolStripMenuItem
            // 
            this.ventaDeAccesoriosToolStripMenuItem.Name = "ventaDeAccesoriosToolStripMenuItem";
            this.ventaDeAccesoriosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.ventaDeAccesoriosToolStripMenuItem.Text = "Venta de Accesorios";
            this.ventaDeAccesoriosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeAccesoriosToolStripMenuItem_Click);
            // 
            // ventaDeVehiculosToolStripMenuItem
            // 
            this.ventaDeVehiculosToolStripMenuItem.Name = "ventaDeVehiculosToolStripMenuItem";
            this.ventaDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.ventaDeVehiculosToolStripMenuItem.Text = "Venta de Vehiculos";
            this.ventaDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.ventaDeVehiculosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.compraVehiculosLabel);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(18, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Compras de Accesorios";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // compraVehiculosLabel
            // 
            this.compraVehiculosLabel.AutoSize = true;
            this.compraVehiculosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compraVehiculosLabel.Location = new System.Drawing.Point(18, 63);
            this.compraVehiculosLabel.Name = "compraVehiculosLabel";
            this.compraVehiculosLabel.Size = new System.Drawing.Size(158, 18);
            this.compraVehiculosLabel.TabIndex = 1;
            this.compraVehiculosLabel.TabStop = true;
            this.compraVehiculosLabel.Text = "Compras de Vehiculos";
            this.compraVehiculosLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.compraVehiculosLabel_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.VentasVehiculosLink);
            this.groupBox2.Controls.Add(this.VentaAccesoriosLink);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // VentasVehiculosLink
            // 
            this.VentasVehiculosLink.AutoSize = true;
            this.VentasVehiculosLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentasVehiculosLink.Location = new System.Drawing.Point(18, 63);
            this.VentasVehiculosLink.Name = "VentasVehiculosLink";
            this.VentasVehiculosLink.Size = new System.Drawing.Size(141, 18);
            this.VentasVehiculosLink.TabIndex = 1;
            this.VentasVehiculosLink.TabStop = true;
            this.VentasVehiculosLink.Text = "Ventas de Vehiculos";
            this.VentasVehiculosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VentasVehiculosLink_LinkClicked);
            // 
            // VentaAccesoriosLink
            // 
            this.VentaAccesoriosLink.AutoSize = true;
            this.VentaAccesoriosLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaAccesoriosLink.Location = new System.Drawing.Point(18, 32);
            this.VentaAccesoriosLink.Name = "VentaAccesoriosLink";
            this.VentaAccesoriosLink.Size = new System.Drawing.Size(152, 18);
            this.VentaAccesoriosLink.TabIndex = 0;
            this.VentaAccesoriosLink.TabStop = true;
            this.VentaAccesoriosLink.Text = "Ventas de Accesorios";
            this.VentaAccesoriosLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VentaAccesoriosLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Dealer System  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeAccesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeAccesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accesoriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraDeAccesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaDeAccesoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel compraVehiculosLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel VentasVehiculosLink;
        private System.Windows.Forms.LinkLabel VentaAccesoriosLink;
    }
}

