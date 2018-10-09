using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class claseUsuario
    {

        private string _usuario;
        public string Usuario //no lleva punto y coma
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _clave;
        public string Clave //no lleva punto y coma
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _codPer;
        public string CodPer //no lleva punto y coma
        {
            get { return _codPer; }
            set { _codPer = value; }
        }
        public claseUsuario(){}
        public claseUsuario(string _usuario, string _clave, string _codPer)
        {
            this.Usuario = _usuario;
            this.Clave = _clave;
            this.CodPer = _codPer;
        }
    }
}
