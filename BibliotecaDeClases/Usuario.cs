using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClases
{
    public class Usuario : BusinessEntity
    {
        private string _Apellido;
        private string _Clave;
        private string _Email;
        private bool _Habilitado;
        private string _Nombre;
        private string _NombreUsuario;

        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Clave { get => _Clave; set => _Clave = value; }
        public string Email { get => _Email; set => _Email = value; }
        public bool Habilitado { get => _Habilitado; set => _Habilitado = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
    }
}