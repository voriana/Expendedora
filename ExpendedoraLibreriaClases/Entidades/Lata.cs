using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraLibreriaClases.Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        public Lata()
        {

        }

        public Lata(string codigo, string nombre , string sabor, double precio, double volumen, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;
        }
        public Lata(string codigo, string nombre, string sabor, double volumen, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _sabor = sabor;
            _volumen = volumen;
            _cantidad = cantidad;
        }

        public string Codigo {get=> _codigo;}
        public string Nombre { get => _nombre; }
        public string Sabor { get => _sabor; }
        public double Volumen { get => _volumen; }
        public int Cantidad { get => _cantidad; }
        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }



        private double GetPrecioPorLitro()
        {
            //double precio=0;
            if (Volumen == 250)
            {
                Precio   = 80.50;
            }else if (Volumen == 600)
            {
                Precio = 100;
            }else if (Volumen == 1000)
            {
                Precio = 120.45;
            }else if (Volumen == 2000)
            {
                Precio = 200;
            }
            return Precio;
        }

        public override string ToString()
        {
            return string.Format(
                $"Codigo= {Codigo} - Nombre= {Nombre} - Sabor={Sabor}" +
                $" - Volumen {Volumen} - Cantidad {Cantidad}");
        }

        public string Listar()
        {
            return $"Codigo {Codigo}) {Nombre} {Volumen} ml [{Cantidad}]";
        }

    }
}
