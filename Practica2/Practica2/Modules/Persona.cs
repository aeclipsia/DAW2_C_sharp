using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Modules
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _dni;

        public Persona(string nombre, string apellido, int edad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Dni { get => _dni; set => _dni = value; }
    }
}
