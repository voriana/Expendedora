using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpendedoraLibreriaClases.Entidades;

namespace ExpendedoraLibreriaClases.Utilidades
{
    public static class LatasHelpers
    {
        private static List<Lata> _latas = new List<Lata>();
        public static void AgregarALista()
        {
            Lata l1 = new Lata("F1", "Fanta", "Naranja", 100, 250, 100);
            Lata l2 = new Lata("C1", "Coca-Cola", "Cola", 150, 100, 100);
            Lata l3 = new Lata("C3", "Pepsi", "Cola", 150, 100, 100);
            Lata l4 = new Lata("C1", "Manaos", "Guarana", 95, 100, 100);

            _latas.Add(l1);
            _latas.Add(l2);
            _latas.Add(l3);
            _latas.Add(l4);
        }
        public static List<Lata> DevolverLista()
        {
            
            return _latas;
        }
    }
}
