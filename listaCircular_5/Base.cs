using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaCircular_5
{
    class Base
    {
        private string _nombre;
        private int _hora;
        private Base _siguiente;

        public string nombre
        {
            get
            {
                return _nombre;
            }
        }

        public int hora
        {
            get
            {
                return _hora;
            }
        }

        public Base siguiente
        {
            get
            {
                return _siguiente;
            }

            set
            {
                _siguiente = value;
            }
        }

        public Base(string nombre, int hora)
        {
            _nombre = nombre;
            _hora = hora;
        }

        public override string ToString()
        {
            string mostrar = "";

            mostrar += "El nombre de la base es: " + _nombre + Environment.NewLine;
            mostrar += "Tiempo de llegada es: " + _hora + Environment.NewLine;

            return mostrar;
        }
       
    }
}
