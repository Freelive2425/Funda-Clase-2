using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_arreglo
{
   public class CAlumno:CPersona
    {
        private int nrocursos;
        public int NroCursos { get; set; }
        private string carreraprofesional; 
        public string CarreraProfesional { get; set; }
        public CAlumno(int pnrocursos, string carprof, int codigo, string nombre) : base(codigo, nombre)
        {
            NroCursos = pnrocursos;
            CarreraProfesional = carprof; 
        }
        public override string Informacion()
        {
            string info =base.Informacion();
            info = info + "\t" + CarreraProfesional + "\t" + NroCursos;
            return info; 
        }

    }
}
