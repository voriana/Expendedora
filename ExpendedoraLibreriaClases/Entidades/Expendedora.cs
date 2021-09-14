using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpendedoraLibreriaClases.Entidades
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        public Expendedora()
        {

        }
        public Expendedora(string proveedor)
        {
            _proveedor = proveedor;
        }
        public Expendedora(List<Lata>latas, string proveedor, int capacidad, double dinero)
        {
            _latas = latas;
            _proveedor = proveedor;
            _capacidad = capacidad;
            _dinero = dinero;

        }
        public List<Lata> Latas { get => _latas; }
        public string Proveedor { get => _proveedor; }
       

        public int Capacidad
        {
            get
            {
                return _capacidad;
            }
            set
            {
                _capacidad = 100;
            }
        }
        
      
        public double Dinero { get => _dinero; }
        public bool Encendida { get => _encendida; }

        public bool AgregarLata(Lata lata)
        {
            bool flag = true;
            if(lata== null)
            {
                flag = false;
            }
            else
            {
                if (Encendida)
                {
                    foreach(Lata l in _latas)
                    {
                        // FA 1: El código ya existe
                        if (l.Codigo == lata.Codigo)
                        {
                            flag= false;
                           
                        }
                        
                    }
                    //FA 2: La máquina está llena (capacidad insuficiente)
                    if (_latas.Count()==Capacidad)
                    {
                        flag= false;
                        

                    }
                    else
                    {
                        flag = true;
                        _latas.Add(lata);
                    }

                }else
                {
                    flag = false;
                    //LA MAQUINA NO ESTA ENCENDIDA
                }
         
            }
            return flag;
        }
        public Lata ExtraerLata(string nombre,double precio)
        {
            Lata LataAExtraer = new Lata();
           foreach (Lata l in _latas)
           {
                if (l.Nombre== nombre && l.Precio==precio)
                {
                    LataAExtraer = l;
                }
                
           }
            return LataAExtraer;
        }
        public string GetBalance()
        {
            string resultado = "";
            return resultado;
        }
        public int GetCapacidadRestante()
        {
            int Restante = (Capacidad - _latas.Count());
            return Restante;

        }
        public bool EncenderMaquina()
        {
            return _encendida = true;
        }
        public bool EstaVacia()
        {
            if (_capacidad == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Lata> TraerLatas()
        {

            return _latas;
        }
    }
}
