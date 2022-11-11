using Model.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDerivadas
{
    public class Empleado:Persona
    {
        public Empleado(int legajo, int id, string nombre, string apellido) : base(id, nombre, apellido)
        {
            Legajo = legajo;
        }

        public Empleado() { }

        public int Legajo { get; set; }
        public int DepartamentoId { get; set; }

        #region Propiedades de Navegacion
        public Departamento Departamento { get; set; }
        #endregion
    }
}
