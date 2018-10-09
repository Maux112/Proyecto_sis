using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class claseProveedor
    {
        private string _codProveedor;
        public string CodProveedor //no lleva punto y coma
        {
            get { return _codProveedor; }
            set { _codProveedor = value; }
        }

        private string _nombre;
        public string Nombre //no lleva punto y coma
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _telefono;
        public string Telefono //no lleva punto y coma
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public claseProveedor(){}
        public claseProveedor(string _codProveedor, string _nombre, string _telefono)
        {
            this.CodProveedor = _codProveedor;
            this.Nombre = _nombre;
            this.Telefono = _telefono;
        }
    }
}
