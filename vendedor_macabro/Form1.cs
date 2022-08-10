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
    public partial class Form1 : Form
    {
        int ctdVentas = 0;
        int cantArticulos = 0;
        int articulosMayores = 0;
        double montoTotal = 0;
        double menorMonto = 0;
        double monto = 0;
        double porcentaje = 0;
        bool bandera = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int nroVenta = Convert.ToInt32(txtVent.Text);
            double precio = Convert.ToDouble(txtPrice.Text);
            int cantidad = Convert.ToInt32(txtCant.Text);


            ctdVentas = ctdVentas + 1;

            monto = precio * cantidad;

            montoTotal = montoTotal + monto;

            lblMon.Text = monto.ToString();
            lblResVen.Text = ctdVentas.ToString();
            lblResMonto.Text = montoTotal.ToString();

            double promedio = montoTotal / ctdVentas;
            lblResProm.Text = promedio.ToString();


            cantArticulos = cantArticulos + cantidad;



            for (int i = 0; i < cantidad; i++)
            {
                if (precio > 100)
                {
                    articulosMayores++;
                }
            }
            porcentaje = Convert.ToDouble(articulosMayores) * 100 / Convert.ToDouble(cantArticulos);

            lblResPor.Text = porcentaje.ToString();




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
