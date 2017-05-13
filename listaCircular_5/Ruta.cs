using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaCircular_5
{
    class Ruta
    {
        private Base inicio;

        private int _contadorBase;
       
        public Ruta()
        {
            _contadorBase = 0;
        }

        public override string ToString()
        {
            return "Total: " + _contadorBase;
        }

        public void agregarBase(Base nuevaBase)
        {
            if (inicio == null)
            {
                inicio = nuevaBase;
                nuevaBase.siguiente = inicio;
                _contadorBase++;
            }
            else
            {
                Base temporal = inicio;

                while (temporal.siguiente != inicio)
                {
                    temporal = temporal.siguiente;
                }

                temporal.siguiente = nuevaBase;
                nuevaBase.siguiente = inicio;
                _contadorBase++;
            }
        }

        public string reporte()
        {
            string mostrar = ToString() + Environment.NewLine;

            if (inicio != null)
            {
                mostrar += "--------------------------" + Environment.NewLine;
                mostrar += inicio.ToString() + Environment.NewLine;

                Base temporal = inicio.siguiente;

                while (temporal != inicio)
                {
                    mostrar += "--------------------------" + Environment.NewLine;
                    mostrar += temporal.ToString() + Environment.NewLine;
                    temporal = temporal.siguiente;
                }
            }

            return mostrar;
        }

        public Base buscar(string nombre)
        {
            Base temporal = inicio;

            while (true)
            {
                if (temporal.nombre == nombre)
                {
                    return temporal;
                }
                else
                {
                    temporal = temporal.siguiente;
                    if (temporal == inicio)
                    {
                        return null;
                    }
                }
            }
        }

        public void eliminarInicio()
        {
            if(inicio != null)
            {
                if(inicio.siguiente == inicio)
                {
                    inicio = null;
                    _contadorBase--;
                }
                else
                {
                    Base temporal = inicio.siguiente;
                    
                    while (temporal.siguiente != inicio)
                    {
                        temporal = temporal.siguiente;
                    }

                    temporal.siguiente = temporal.siguiente.siguiente;
                    inicio = temporal.siguiente;
                    _contadorBase--;
                }

            }
        }

        public void eliminar(string nombre)
        {
            Base temporal = buscar(nombre);
            Base temporal2 = inicio;

            if (inicio.nombre == nombre)
            {
                eliminarInicio();
            }
            else
            {
                while (true)
                {
                    temporal2 = temporal2.siguiente;

                    if (temporal2.siguiente == temporal)
                    {
                        temporal2.siguiente = temporal.siguiente;
                        _contadorBase--;
                        break;
                    }
                }
            }
        }

        public void agregarInicio(Base nuevaBase)
        {
            if (inicio == null)
            {
                inicio = nuevaBase;
                inicio.siguiente = inicio;
                _contadorBase++;
            }
            else if (inicio.siguiente == inicio)
            {
                nuevaBase.siguiente = inicio;
                inicio.siguiente = nuevaBase;
                inicio = nuevaBase;
                _contadorBase++;
            }
            else
            {
                Base temporal = inicio;

                while (temporal.siguiente != inicio)
                {
                    temporal = temporal.siguiente;
                }

                nuevaBase.siguiente = inicio;
                temporal.siguiente = nuevaBase;
                inicio = nuevaBase;
                _contadorBase++;
            }
        }

        public void insertarDespuesDe(string nombre, Base nuevaBase)
        {
            if (inicio != null)
            {
                Base temporal = inicio;

                while (temporal.siguiente != inicio)
                {
                    if (temporal.nombre == nombre)
                        break;

                    temporal = temporal.siguiente;
                }

                if (temporal.nombre == nombre)
                {
                    nuevaBase.siguiente = temporal.siguiente;
                    temporal.siguiente = nuevaBase;
                    _contadorBase++;
                }
            }
        }

        public string recorrido(string nombre, DateTime horaInicio, DateTime horaFin)
        {
            Base temporal = buscar(nombre);

            string mostrar = "";

            while (horaInicio <= horaFin)
            {
                mostrar += "Base: " + temporal.nombre.ToString() + Environment.NewLine;
                mostrar += "Hora: " + horaInicio.Hour + ":" + horaInicio.Minute + Environment.NewLine;
                temporal = temporal.siguiente;
                horaInicio = horaInicio.AddMinutes(temporal.hora);
            }

            return mostrar;
        }
    }
}
