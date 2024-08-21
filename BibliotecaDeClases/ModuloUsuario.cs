using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClases
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IDModulo;
        private int _IDUsuario;
        private bool _PermiteAlta;
        private bool _PermiteBaja;
        private bool _PermiteConsulta;
        private bool _PermiteModificacion;

        public int IDModulo { get => _IDModulo; set => _IDModulo = value; }
        public int IDUsuario { get => _IDUsuario; set => _IDUsuario = value; }
        public bool PermiteAlta { get => _PermiteAlta; set => _PermiteAlta = value; }
        public bool PermiteBaja { get => _PermiteBaja; set => _PermiteBaja = value; }
        public bool PermiteConsulta { get => _PermiteConsulta; set => _PermiteConsulta = value; }
        public bool PermiteModificacion { get => _PermiteModificacion; set => _PermiteModificacion = value; }
    }
}