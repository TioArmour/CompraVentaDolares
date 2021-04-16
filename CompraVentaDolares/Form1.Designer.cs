
namespace CompraVentaDolares
{
    partial class CompraVentaDolares
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTCV = new System.Windows.Forms.Label();
            this.lblTCC = new System.Windows.Forms.Label();
            this.lblMontoInicialUSD = new System.Windows.Forms.Label();
            this.lblMontoInicialBs = new System.Windows.Forms.Label();
            this.lblBs = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblMontoTotalUSD = new System.Windows.Forms.Label();
            this.lblMontoTotalBs = new System.Windows.Forms.Label();
            this.lblOperacionesDia = new System.Windows.Forms.Label();
            this.btnInicioDia = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTCV = new System.Windows.Forms.TextBox();
            this.txtTCC = new System.Windows.Forms.TextBox();
            this.txtMontoInicialUSD = new System.Windows.Forms.TextBox();
            this.txtMontoInicialBs = new System.Windows.Forms.TextBox();
            this.txtMontoTotalUSD = new System.Windows.Forms.TextBox();
            this.txtMontoTotalBs = new System.Windows.Forms.TextBox();
            this.txtVentaBs = new System.Windows.Forms.TextBox();
            this.txtVentaUSD = new System.Windows.Forms.TextBox();
            this.txtCompraBs = new System.Windows.Forms.TextBox();
            this.txtCompraUSD = new System.Windows.Forms.TextBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.gbDatosInicio = new System.Windows.Forms.GroupBox();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.gbProcesoCompraVenta = new System.Windows.Forms.GroupBox();
            this.gbDatosInicio.SuspendLayout();
            this.gbProcesoCompraVenta.SuspendLayout();
            this.gbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosInicio
            // 
            this.gbDatosInicio.BackColor = System.Drawing.Color.PeachPuff;
            this.gbDatosInicio.Controls.Add(this.btnInicioDia);
            this.gbDatosInicio.Controls.Add(this.txtTCV);
            this.gbDatosInicio.Controls.Add(this.txtTCC);
            this.gbDatosInicio.Controls.Add(this.txtMontoInicialUSD);
            this.gbDatosInicio.Controls.Add(this.txtMontoInicialBs);
            this.gbDatosInicio.Controls.Add(this.lblTCV);
            this.gbDatosInicio.Controls.Add(this.lblTCC);
            this.gbDatosInicio.Controls.Add(this.lblMontoInicialUSD);
            this.gbDatosInicio.Controls.Add(this.lblMontoInicialBs);
            this.gbDatosInicio.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbDatosInicio.Location = new System.Drawing.Point(24, 25);
            this.gbDatosInicio.Name = "gbDatosInicio";
            this.gbDatosInicio.Size = new System.Drawing.Size(715, 153);
            this.gbDatosInicio.TabIndex = 0;
            this.gbDatosInicio.TabStop = false;
            this.gbDatosInicio.Text = "Datos de Inicio del Día";
            // 
            // btnInicioDia
            // 
            this.btnInicioDia.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInicioDia.Location = new System.Drawing.Point(558, 40);
            this.btnInicioDia.Name = "btnInicioDia";
            this.btnInicioDia.Size = new System.Drawing.Size(140, 27);
            this.btnInicioDia.TabIndex = 8;
            this.btnInicioDia.Text = "Inicio del Día";
            this.btnInicioDia.UseVisualStyleBackColor = true;
            this.btnInicioDia.Click += new System.EventHandler(this.btnInicioDia_Click);
            // 
            // txtTCV
            // 
            this.txtTCV.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTCV.Location = new System.Drawing.Point(407, 98);
            this.txtTCV.Name = "txtTCV";
            this.txtTCV.Size = new System.Drawing.Size(125, 27);
            this.txtTCV.TabIndex = 7;
            // 
            // txtTCC
            // 
            this.txtTCC.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTCC.Location = new System.Drawing.Point(407, 40);
            this.txtTCC.Name = "txtTCC";
            this.txtTCC.Size = new System.Drawing.Size(125, 27);
            this.txtTCC.TabIndex = 6;
            // 
            // txtMontoInicialUSD
            // 
            this.txtMontoInicialUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoInicialUSD.Location = new System.Drawing.Point(168, 93);
            this.txtMontoInicialUSD.Name = "txtMontoInicialUSD";
            this.txtMontoInicialUSD.Size = new System.Drawing.Size(125, 27);
            this.txtMontoInicialUSD.TabIndex = 5;
            // 
            // txtMontoInicialBs
            // 
            this.txtMontoInicialBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoInicialBs.Location = new System.Drawing.Point(168, 40);
            this.txtMontoInicialBs.Name = "txtMontoInicialBs";
            this.txtMontoInicialBs.Size = new System.Drawing.Size(125, 27);
            this.txtMontoInicialBs.TabIndex = 4;
            this.txtMontoInicialBs.TextChanged += new System.EventHandler(this.txtMontoInicialBs_TextChanged);
            // 
            // lblTCV
            // 
            this.lblTCV.AutoSize = true;
            this.lblTCV.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTCV.Location = new System.Drawing.Point(343, 98);
            this.lblTCV.Name = "lblTCV";
            this.lblTCV.Size = new System.Drawing.Size(57, 18);
            this.lblTCV.TabIndex = 3;
            this.lblTCV.Text = "T.C.V :";
            // 
            // lblTCC
            // 
            this.lblTCC.AutoSize = true;
            this.lblTCC.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTCC.Location = new System.Drawing.Point(337, 41);
            this.lblTCC.Name = "lblTCC";
            this.lblTCC.Size = new System.Drawing.Size(58, 18);
            this.lblTCC.TabIndex = 2;
            this.lblTCC.Text = "T.C.C :";
            // 
            // lblMontoInicialUSD
            // 
            this.lblMontoInicialUSD.AutoSize = true;
            this.lblMontoInicialUSD.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMontoInicialUSD.Location = new System.Drawing.Point(9, 97);
            this.lblMontoInicialUSD.Name = "lblMontoInicialUSD";
            this.lblMontoInicialUSD.Size = new System.Drawing.Size(161, 21);
            this.lblMontoInicialUSD.TabIndex = 1;
            this.lblMontoInicialUSD.Text = "Monto Inicial $us. :";
            // 
            // lblMontoInicialBs
            // 
            this.lblMontoInicialBs.AutoSize = true;
            this.lblMontoInicialBs.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMontoInicialBs.Location = new System.Drawing.Point(11, 40);
            this.lblMontoInicialBs.Name = "lblMontoInicialBs";
            this.lblMontoInicialBs.Size = new System.Drawing.Size(151, 21);
            this.lblMontoInicialBs.TabIndex = 0;
            this.lblMontoInicialBs.Text = "Monto Inicial Bs. :";
            // 
            // gbProcesoCompraVenta
            // 
            this.gbProcesoCompraVenta.BackColor = System.Drawing.Color.LightGreen;
            this.gbProcesoCompraVenta.Controls.Add(this.btnEjecutar);
            this.gbProcesoCompraVenta.Controls.Add(this.txtVentaBs);
            this.gbProcesoCompraVenta.Controls.Add(this.txtVentaUSD);
            this.gbProcesoCompraVenta.Controls.Add(this.txtCompraBs);
            this.gbProcesoCompraVenta.Controls.Add(this.txtCompraUSD);
            this.gbProcesoCompraVenta.Controls.Add(this.lblBs);
            this.gbProcesoCompraVenta.Controls.Add(this.lblUSD);
            this.gbProcesoCompraVenta.Controls.Add(this.lblVenta);
            this.gbProcesoCompraVenta.Controls.Add(this.lblCompra);
            this.gbProcesoCompraVenta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbProcesoCompraVenta.Location = new System.Drawing.Point(24, 198);
            this.gbProcesoCompraVenta.Name = "gbProcesoCompraVenta";
            this.gbProcesoCompraVenta.Size = new System.Drawing.Size(715, 153);
            this.gbProcesoCompraVenta.TabIndex = 1;
            this.gbProcesoCompraVenta.TabStop = false;
            this.gbProcesoCompraVenta.Text = "Proceso de Compra/Venta de Dólares";
            this.gbProcesoCompraVenta.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEjecutar.Location = new System.Drawing.Point(558, 57);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(140, 29);
            this.btnEjecutar.TabIndex = 12;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtVentaBs
            // 
            this.txtVentaBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVentaBs.Location = new System.Drawing.Point(407, 109);
            this.txtVentaBs.Name = "txtVentaBs";
            this.txtVentaBs.Size = new System.Drawing.Size(125, 27);
            this.txtVentaBs.TabIndex = 11;
            // 
            // txtVentaUSD
            // 
            this.txtVentaUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVentaUSD.Location = new System.Drawing.Point(168, 108);
            this.txtVentaUSD.Name = "txtVentaUSD";
            this.txtVentaUSD.Size = new System.Drawing.Size(125, 27);
            this.txtVentaUSD.TabIndex = 10;
            // 
            // txtCompraBs
            // 
            this.txtCompraBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompraBs.Location = new System.Drawing.Point(407, 60);
            this.txtCompraBs.Name = "txtCompraBs";
            this.txtCompraBs.Size = new System.Drawing.Size(125, 27);
            this.txtCompraBs.TabIndex = 9;
            // 
            // txtCompraUSD
            // 
            this.txtCompraUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompraUSD.Location = new System.Drawing.Point(168, 57);
            this.txtCompraUSD.Name = "txtCompraUSD";
            this.txtCompraUSD.Size = new System.Drawing.Size(125, 27);
            this.txtCompraUSD.TabIndex = 8;
            // 
            // lblBs
            // 
            this.lblBs.AutoSize = true;
            this.lblBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBs.Location = new System.Drawing.Point(455, 34);
            this.lblBs.Name = "lblBs";
            this.lblBs.Size = new System.Drawing.Size(31, 21);
            this.lblBs.TabIndex = 7;
            this.lblBs.Text = "Bs";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblUSD.Location = new System.Drawing.Point(206, 33);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(43, 21);
            this.lblUSD.TabIndex = 6;
            this.lblUSD.Text = "$us";
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblVenta.Location = new System.Drawing.Point(68, 109);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(63, 21);
            this.lblVenta.TabIndex = 5;
            this.lblVenta.Text = "Venta:";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCompra.Location = new System.Drawing.Point(68, 60);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(78, 21);
            this.lblCompra.TabIndex = 4;
            this.lblCompra.Text = "Compra:";
            // 
            // gbTotales
            // 
            this.gbTotales.BackColor = System.Drawing.Color.GhostWhite;
            this.gbTotales.Controls.Add(this.txtMontoTotalUSD);
            this.gbTotales.Controls.Add(this.txtMontoTotalBs);
            this.gbTotales.Controls.Add(this.lblMontoTotalUSD);
            this.gbTotales.Controls.Add(this.lblMontoTotalBs);
            this.gbTotales.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbTotales.Location = new System.Drawing.Point(24, 374);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(715, 103);
            this.gbTotales.TabIndex = 2;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Totales del Día";
            // 
            // txtMontoTotalUSD
            // 
            this.txtMontoTotalUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoTotalUSD.Location = new System.Drawing.Point(489, 42);
            this.txtMontoTotalUSD.Name = "txtMontoTotalUSD";
            this.txtMontoTotalUSD.Size = new System.Drawing.Size(125, 27);
            this.txtMontoTotalUSD.TabIndex = 9;
            this.txtMontoTotalUSD.TextChanged += new System.EventHandler(this.txtMontoTotalUSD_TextChanged);
            // 
            // txtMontoTotalBs
            // 
            this.txtMontoTotalBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoTotalBs.Location = new System.Drawing.Point(168, 44);
            this.txtMontoTotalBs.Name = "txtMontoTotalBs";
            this.txtMontoTotalBs.Size = new System.Drawing.Size(125, 27);
            this.txtMontoTotalBs.TabIndex = 8;
            // 
            // lblMontoTotalUSD
            // 
            this.lblMontoTotalUSD.AutoSize = true;
            this.lblMontoTotalUSD.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMontoTotalUSD.Location = new System.Drawing.Point(337, 46);
            this.lblMontoTotalUSD.Name = "lblMontoTotalUSD";
            this.lblMontoTotalUSD.Size = new System.Drawing.Size(144, 21);
            this.lblMontoTotalUSD.TabIndex = 5;
            this.lblMontoTotalUSD.Text = "Monto Total $us:";
            // 
            // lblMontoTotalBs
            // 
            this.lblMontoTotalBs.AutoSize = true;
            this.lblMontoTotalBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMontoTotalBs.Location = new System.Drawing.Point(28, 48);
            this.lblMontoTotalBs.Name = "lblMontoTotalBs";
            this.lblMontoTotalBs.Size = new System.Drawing.Size(134, 21);
            this.lblMontoTotalBs.TabIndex = 4;
            this.lblMontoTotalBs.Text = "Monto Total Bs:";
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 20;
            this.lstOperaciones.Location = new System.Drawing.Point(745, 43);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(349, 384);
            this.lstOperaciones.TabIndex = 3;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // lblOperacionesDia
            // 
            this.lblOperacionesDia.AutoSize = true;
            this.lblOperacionesDia.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOperacionesDia.Location = new System.Drawing.Point(745, 20);
            this.lblOperacionesDia.Name = "lblOperacionesDia";
            this.lblOperacionesDia.Size = new System.Drawing.Size(186, 20);
            this.lblOperacionesDia.TabIndex = 4;
            this.lblOperacionesDia.Text = "Operaciones del Día";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(1005, 448);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 30);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CompraVentaDolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 489);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblOperacionesDia);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.gbProcesoCompraVenta);
            this.Controls.Add(this.gbDatosInicio);
            this.Name = "CompraVentaDolares";
            this.Text = "Compra/Venta de Dólares";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatosInicio.ResumeLayout(false);
            this.gbDatosInicio.PerformLayout();
            this.gbProcesoCompraVenta.ResumeLayout(false);
            this.gbProcesoCompraVenta.PerformLayout();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTCV;
        private System.Windows.Forms.Label lblTCC;
        private System.Windows.Forms.Label lblMontoInicialUSD;
        private System.Windows.Forms.Label lblBs;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblMontoTotalBs;
        private System.Windows.Forms.Label lblMontoInicialBs;
        private System.Windows.Forms.Label lblMontoTotalUSD;
        private System.Windows.Forms.Label lblOperacionesDia;
        private System.Windows.Forms.Button btnInicioDia;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMontoTotalBs;
        private System.Windows.Forms.TextBox txtTCV;
        private System.Windows.Forms.TextBox txtTCC;
        private System.Windows.Forms.TextBox txtMontoInicialUSD;
        private System.Windows.Forms.TextBox txtMontoInicialBs;
        private System.Windows.Forms.TextBox txtVentaBs;
        private System.Windows.Forms.TextBox txtVentaUSD;
        private System.Windows.Forms.TextBox txtCompraBs;
        private System.Windows.Forms.TextBox txtCompraUSD;
        private System.Windows.Forms.TextBox txtMontoTotalUSD;
        private System.Windows.Forms.ListBox lstOperaciones;
        private System.Windows.Forms.GroupBox gbDatosInicio;
        private System.Windows.Forms.GroupBox gbProcesoCompraVenta;
        private System.Windows.Forms.GroupBox gbTotales;
    }
}

