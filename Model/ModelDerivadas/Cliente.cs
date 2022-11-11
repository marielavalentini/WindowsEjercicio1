using Model.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDerivadas
{
    public class Cliente : Persona
    {
        public Cliente(int cuit, string telefono, int id, string nombre, string apellido):base(id, nombre, apellido)
        {
            Cuit = cuit;    
            Telefono = telefono;
        }
        public int Cuit { get; set; }
        public string Telefono { get; set; }
    }
}
