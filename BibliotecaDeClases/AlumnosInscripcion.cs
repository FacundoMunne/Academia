using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClases
{
    public class AlumnosInscripcion : BusinessEntity
    {
        private string _Condicion;
        private int _IDAlumno;
        private int _IDCuso;
        private int _Nota;

        public string Condicion { get => _Condicion; set => _Condicion = value; }
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDCuso { get => _IDCuso; set => _IDCuso = value; }
        public int Nota { get => _Nota; set => _Nota = value; }
    }
}