using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraConsola
{
    public static class Helpers
    {
        public static int PedirInt(string mensaje)
        {
            int resultado=0;
            string entrada;
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine($"Ingrese {mensaje}");
                entrada = Console.ReadLine();
                flag = int.TryParse(entrada, out resultado);
                if (!flag)
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                }
                else if (resultado < 0)
                {
                    Console.WriteLine("Opcion Invalida");
                }
            }
            return resultado;
        }

        //soliticar Double
        public static double PedirDouble(string mensaje)
        {
            string entrada;
            bool flag = false;
            double resultado=0;
            while (!flag)
            {
                Console.WriteLine($"Ingrese {mensaje}");
                entrada = Console.ReadLine();
                flag = double.TryParse(entrada, out resultado);
                if (!flag)
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                }else if (resultado <= 0)
                {
                    Console.WriteLine("Debe ingresar un numero positivo");
                    flag = false;
                }
            }
            return resultado;
        }

        //solicitar String
        public static string PedirTexto(string mensaje)
        {
            string entrada="";
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine($"Ingrese {mensaje}");
                entrada = Console.ReadLine();
                flag = !string.IsNullOrEmpty(entrada);
                if (!flag)
                {
                    Console.WriteLine("Dato Invalido.Intente nuevamente");
                }
            }
            return entrada;
        }
        
    }
}
