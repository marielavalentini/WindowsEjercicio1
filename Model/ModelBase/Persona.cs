using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelBase
{
    public abstract class Persona
    {
        public Persona(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
        public Persona() { }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
