using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClases
{
    public class Modulo : BusinessEntity
    {
        private string _Descripcion;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}