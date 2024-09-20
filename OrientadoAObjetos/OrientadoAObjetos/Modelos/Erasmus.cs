using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientadoAObjetos.Modelos
{
    public class Erasmus:Alumno
    {
        private string pais;

        public Erasmus(string dni, string nombre, string telefono, string pais) : base(dni, nombre, telefono)
        {
            this.Pais = pais;
        }

        public string Pais { get => pais; set => pais = value; }
    }
}
