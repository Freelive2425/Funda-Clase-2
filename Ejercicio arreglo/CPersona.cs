using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_arreglo
{
    public abstract class CPersona 
    {
        private int codigo;
        public int Codigo { get; set; }
        private string nombre;
        public string Nombre { get; set; }
        public CPersona(int pcodigo, string pnombre)
        {
            Codigo = pcodigo;
            Nombre = pnombre;
        }
        public virtual string Informacion()
        {
            return Codigo + "\t" + Nombre; 
        }
    }
}
