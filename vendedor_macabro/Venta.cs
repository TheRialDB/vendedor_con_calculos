using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendedor_macabro
{
    public class Venta
    {
        //atributos
        string codigo;
        string nombre;
        double precio;
        int unidades;

        //constructor vacio
        public Venta()
        {

        }

        //constructor con parametros
        public Venta(string code, string name, double price, int unity)
        {
            codigo = code;
            nombre = name;
            precio = price;
            unidades = unity;
        }

        //metodo para calcular monto
        public double calcularMonto()
        {
            return precio * unidades;
        }

        //getters y setters
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
    }


}
