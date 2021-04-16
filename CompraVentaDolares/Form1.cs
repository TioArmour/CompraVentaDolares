using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVentaDolares
{
    public partial class CompraVentaDolares : Form
    {
        /*
            Declaramos nuestras variables globales
         */
        double montoInicialBs;
        double montoInicialUSD;
        double tipoCambioCompra;
        double tipoCambioVenta;
        double montoTotalBs;
        double montoTotalUSD;

        public CompraVentaDolares()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMontoTotalBs.Enabled = false;
            txtMontoTotalUSD.Enabled = false;
            txtCompraBs.Enabled = false;
            txtCompraUSD.Enabled = false;
            btnEjecutar.Enabled = false;
            txtVentaBs.Enabled = false;
            txtVentaUSD.Enabled = false;
        }

        private void btnInicioDia_Click(object sender, EventArgs e)
        {
            if (txtMontoInicialBs.Text != "" && txtMontoInicialUSD.Text != "" && txtTCC.Text != "" && txtTCV.Text != "")
            {
                try
                {
                    
                    montoInicialBs = double.Parse(txtMontoInicialBs.Text);
                    montoInicialUSD = double.Parse(txtMontoInicialUSD.Text);
                    tipoCambioCompra = double.Parse(txtTCC.Text);
                    tipoCambioVenta = double.Parse(txtTCV.Text);
                    if(montoInicialBs > 0 && montoInicialUSD > 0 && tipoCambioCompra > 0 && tipoCambioVenta > 0)
                    {
                    montoTotalBs = montoInicialBs;
                    montoTotalUSD = montoInicialUSD;
                    txtMontoTotalBs.Text = Convert.ToString(montoInicialBs);
                    txtMontoTotalUSD.Text = Convert.ToString(montoInicialUSD);
                    txtCompraBs.Enabled = true;
                    txtCompraUSD.Enabled = true;
                    btnEjecutar.Enabled = true;
                    txtVentaBs.Enabled = true;
                    txtVentaUSD.Enabled = true;
                    txtMontoInicialBs.Enabled = false;
                    txtMontoInicialUSD.Enabled = false;
                    txtTCC.Enabled = false;
                    txtTCV.Enabled = false;
                    btnInicioDia.Enabled = false;
                    txtCompraBs.Enabled = false;
                    txtVentaBs.Enabled = false;
                    }
                    else
                    {
                        txtMontoInicialBs.Clear();
                        txtMontoInicialUSD.Clear();
                        txtTCC.Clear();
                        txtTCV.Clear();
                        txtMontoInicialBs.Focus();
                        MessageBox.Show("No puedes introducir valores menores 0. Inténtalo nuevamente.");
                    }
                }
                catch (Exception Ex)
                {
                    txtMontoInicialBs.Clear();
                    txtMontoInicialUSD.Clear();
                    txtTCC.Clear();
                    txtTCV.Clear();
                    txtMontoInicialBs.Focus();
                    MessageBox.Show("Ocurrió un error en la introducción de datos. Inténtalo nuevamente");
                }
            }
            else
            {
                txtMontoInicialBs.Clear();
                txtMontoInicialUSD.Clear();
                txtTCC.Clear();
                txtTCV.Clear();
                txtMontoInicialBs.Focus();
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            double montoCompraUSD;
            double montoVentaUSD;
            double montoCompraBs;
            double montoVentaBs;
            try
            {
                if (txtCompraUSD.Text == "")
                {
                    montoVentaUSD = double.Parse(txtVentaUSD.Text);
                    if (montoVentaUSD > 0)
                    {
                        montoVentaBs = montoVentaUSD * tipoCambioVenta;
                        if(montoTotalUSD >= montoVentaUSD)
                        {
                            txtVentaBs.Text = Convert.ToString(montoVentaBs);
                            montoTotalBs += montoVentaBs;
                            montoTotalUSD -= montoVentaUSD;
                            txtMontoTotalBs.Text = Convert.ToString(montoTotalBs);
                            txtMontoTotalUSD.Text = Convert.ToString(montoTotalUSD);
                            txtCompraUSD.Clear();
                            txtVentaUSD.Clear();
                            lstOperaciones.Items.Insert(0,($"Venta {montoVentaUSD} $us --> {montoVentaBs} Bs."));
                        }
                        else
                        {
                            MessageBox.Show($"No se puede realizar la operación. No tienes los dólares suficientes para realizar la venta.");
                            txtVentaUSD.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puedes introducir valores menores a 0. Inténtalo nuevamente.");
                        txtVentaUSD.Clear();
                        txtVentaUSD.Focus();
                    }
                }
                else
                {
                    if (txtVentaUSD.Text == "")
                    {
                        montoCompraUSD = double.Parse(txtCompraUSD.Text);
                        if (montoCompraUSD > 0)
                        {
                            montoCompraBs = montoCompraUSD * tipoCambioCompra;
                            if (montoCompraBs <= montoTotalBs)
                            {
                                montoTotalBs -= montoCompraBs;
                                montoTotalUSD += montoCompraUSD;
                                txtCompraBs.Text = Convert.ToString(montoCompraBs);
                                txtMontoTotalBs.Text = Convert.ToString(montoTotalBs);
                                txtMontoTotalUSD.Text = Convert.ToString(montoTotalUSD);
                                txtCompraUSD.Clear();
                                txtVentaUSD.Clear();
                                lstOperaciones.Items.Insert(0,($"Compra {montoCompraUSD} $us --> {montoCompraBs} Bs."));
                            }
                            else
                            {
                                MessageBox.Show($"No se puede completar la operación. No tienes el equivalente en bolivianos para comprar los dólares.");
                                txtCompraUSD.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puedes introducir valores menores a 0. Inténtalo nuevamente.");
                            txtCompraUSD.Clear();
                            txtCompraUSD.Focus();
                        }
                    }
                    else
                    {
                        montoCompraUSD = double.Parse(txtCompraUSD.Text);
                        montoVentaUSD = double.Parse(txtVentaUSD.Text);
                        if (montoCompraUSD > 0 && montoVentaUSD > 0)
                        {
                            montoCompraBs = montoCompraUSD * tipoCambioCompra;
                            montoVentaBs = montoVentaUSD * tipoCambioVenta;
                            if (montoCompraBs <= montoTotalBs)
                            {
                                montoTotalBs -= montoCompraBs;
                                montoTotalUSD += montoCompraUSD;
                                txtCompraBs.Text = Convert.ToString(montoCompraBs);
                                txtMontoTotalBs.Text = Convert.ToString(montoTotalBs);
                                txtMontoTotalUSD.Text = Convert.ToString(montoTotalUSD);
                                txtCompraUSD.Clear();
                                txtVentaUSD.Clear();
                                lstOperaciones.Items.Insert(0,($"Compra {montoCompraUSD} $us --> {montoCompraBs} Bs."));
                            }
                            else
                            {
                                MessageBox.Show($"No se puede completar la operación. No tienes el equivalente en bolivianos para comprar los dólares.");
                            }
                            if (montoTotalUSD >= montoVentaUSD)
                            {
                                txtVentaBs.Text = Convert.ToString(montoVentaBs);
                                montoTotalBs += montoVentaBs;
                                montoTotalUSD -= montoVentaUSD;
                                txtMontoTotalBs.Text = Convert.ToString(montoTotalBs);
                                txtMontoTotalUSD.Text = Convert.ToString(montoTotalUSD);
                                txtCompraUSD.Clear();
                                txtVentaUSD.Clear();
                                lstOperaciones.Items.Insert(0,($"Venta {montoVentaUSD} $us --> {montoVentaBs}  Bs."));
                            }
                            else
                            {
                                MessageBox.Show($"No se puede realizar la operación. No tienes los dólares suficientes para realizar la venta.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puedes introducir valores menores a 0. Inténtalo nuevamente.");
                            txtCompraUSD.Clear();
                            txtVentaUSD.Clear();
                            txtCompraUSD.Focus();
                        }
                    }
                    
                }
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Ha ocurrido un eror al realizar la operación. Inténtalo nuevamente.");
                txtCompraUSD.Clear();
                txtVentaUSD.Clear();
                txtCompraUSD.Focus();
            }
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMontoTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoInicialBs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
