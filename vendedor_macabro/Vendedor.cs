using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendedor_macabro
{
    public partial class Vendedor : Form
    {
        //inicializaciones
        int ctdVentas = 0;
        int cantArticulos = 0;
        int articulosMayores = 0;
        double montoTotal = 0;
        double menorMonto = 0;
        double monto = 0;
        double porcentaje = 0;
        bool bandera = false;
        public Vendedor()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //int nroVenta = Convert.ToInt32(txtVent.Text);
            //double precio = Convert.ToDouble(txtPrice.Text);
            //int cantidad = Convert.ToInt32(txtCant.Text);

            Venta venta = new Venta();

            venta.Codigo = txtVent.Text;
            venta.Nombre = txtArt.Text;
            venta.Precio = Convert.ToDouble(txtPrice.Text);
            venta.Unidades = Convert.ToInt32(txtCant.Text);


            ctdVentas = ctdVentas + 1;

            //monto = precio * cantidad;

            monto = venta.calcularMonto();

            montoTotal = montoTotal + monto;

            lblMon.Text = monto.ToString();
            lblResVen.Text = ctdVentas.ToString();
            lblResMonto.Text = montoTotal.ToString();

            double promedio = montoTotal / ctdVentas;
            lblResProm.Text = promedio.ToString();


            cantArticulos = cantArticulos + venta.Unidades;


            //calculo y muestreo de porcentaje
            for (int i = 0; i < venta.Unidades; i++)
            {
                if (venta.Precio > 100)
                {
                    articulosMayores++;
                }
            }
            porcentaje = Convert.ToDouble(articulosMayores) * 100 / Convert.ToDouble(cantArticulos);

            lblResPor.Text = porcentaje.ToString();



            //calculo y muestreo del menor monto
            if (bandera)
            {
                if (monto < menorMonto)
                {
                    menorMonto = monto;
                }
            }
            else
            {
                menorMonto = monto;
                bandera = true;
            }

            lblResMenor.Text = menorMonto.ToString();





        }
    }
}
