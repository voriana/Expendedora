using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraLibreriaClases.Entidades;
using ExpendedoraLibreriaClases.Utilidades;

namespace ExpendedoraConsola
{
    class Program
    {
        static Expendedora _maquina;
        static bool _consolaActiva;
        static Program()
        {
            _consolaActiva = true;
            _maquina = new Expendedora();
            _maquina.Capacidad = _maquina.Capacidad;                        


        }
        
        static void Main(string[] args)
        {
            
            while (_consolaActiva)
            {

                Console.WriteLine($"Expendedora 3.0");
                DesplegarMenu();
                int opcion = Helpers.PedirInt("opcion");
                switch (opcion)
                {
                    case 1:
                        Encender();
                        Console.WriteLine("MAQUINA ENCENDIDA");
                        break;

                    case 2:
                        ListarLatas(_maquina);
                        break;

                    case 3:
                        IngresarLata(_maquina);
                        break;

                    case 4:
                        ExtraerLata(_maquina);
                        break;

                    case 5:
                        ObtenerBalance(_maquina);
                        break;
                    case 6:
                        MostrarStock(_maquina);
                        break;
                    case 0:
                        _consolaActiva = false;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;

                }
            }
           
        }
        static bool Encender()
        {
            return _maquina.EncenderMaquina();
            
        }

        static void IngresarLata(Expendedora expendedora)
        {
            string codigo;
            string nombre;
            string sabor;
            double precio;
            double volumen;
            int cantidad;
            codigo = Helpers.PedirTexto("codigo de la bebida");
            nombre = Helpers.PedirTexto("nombre de la bebida");
            sabor = Helpers.PedirTexto("sabor de la bebida");
            volumen = Helpers.PedirDouble("volumen de la bebida");
            cantidad = Helpers.PedirInt("cantidad que desea agregar");

            Lata lata = new Lata(codigo, nombre, sabor, volumen, cantidad);
            precio = lata.Precio;
            Encender();

            if (!(_maquina.Encendida))
            {
                Console.WriteLine("La maquina no esta encendida");
               
            }
            else if (expendedora.AgregarLata(lata))
            //Agregar la a la lista
            {

                Console.WriteLine(_maquina.Capacidad);
                Console.WriteLine("Lata agregada");
                _maquina.Capacidad = (_maquina.Capacidad - lata.Cantidad);
                Console.WriteLine(_maquina.Capacidad);

            }
            else
            {
                Console.WriteLine("No se ha podido agregar la lata");
            }
        }
        static void ExtraerLata(Expendedora expendedora)
        {
            Console.WriteLine("***BEBIDAS***");
            LatasHelpers.AgregarALista();
            Console.WriteLine(); 
            

            ListarLatas(_maquina);

            string codigo = Helpers.PedirTexto(" codigo de bebida a retirar");
            Console.WriteLine(_maquina.TraerLatas(_maquina.Latas));
           // Console.WriteLine($" por favor el dinero {}");

        }
        static void ObtenerBalance (Expendedora expendedora)
        {

        }

        static void ListarLatas(Expendedora expendedora)
        {
            Console.WriteLine("LATAS DE ESTA MAQUINA EXPENDEDORA");
            
            if (_maquina.GetCapacidadRestante()!=0)
            {
                Console.WriteLine(_maquina.TraerLatas(_maquina.Latas));
            }
            else
            {
                Console.WriteLine("No hay Stock en esta expendedora");
            }
            
        }
        static void MostrarStock (Expendedora expendedora)
        {
            int stock = expendedora.GetCapacidadRestante();
            Console.WriteLine($"Stock restante de la maquina {stock}");
        }

        static void DesplegarMenu()
        {
            Console.WriteLine("***MENU DE OPCIONES***");
            Console.WriteLine("1- ENCENDER MAQUINA");
            Console.WriteLine("2- LISTAR BEDIDAS ");
            Console.WriteLine("3- AGREGAR BEBIDA");
            Console.WriteLine("4- ELEGIR BEBIDA");
            Console.WriteLine("5- OBTENER BALANCE");
            Console.WriteLine("6- OBTENER STOCK Y LISTA BEBIDAS");
            Console.WriteLine("0- SALIR  DEL PROGRAMA");


        }
    }
}
