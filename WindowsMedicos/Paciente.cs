using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMedicos
{
    class Paciente : Persona
    {
        private int edad;
        private DateTime fechaBaja;
        private string nombre;
        public Paciente(int _edad, DateTime _fechaBaja, string _nombre) : base(_edad, _nombre)
        {
            nombre = _nombre;
            edad = _edad;
            fechaBaja = _fechaBaja;

        }
        public string getNombre() { return nombre; }

        public int getEdad() { return edad; }
        public override string ToString()
        {
            return base.ToString() + $" es un paciente";
        }

    }
}
