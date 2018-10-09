using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class claseCompra
    {
        private string _codCompra;
         public string CodCompra //no lleva punto y coma
        {
            get { return _codCompra; }
            set { _codCompra = value; }
        }

         private string _fechaCompra;
         public string FechaCompra //no lleva punto y coma
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        private decimal _precio;
        public decimal Precio //no lleva punto y coma
        {
            get { return _precio; }
            set{_precio=value;}
        }

        private int _numeroUnidades;
        public int NumeroUnidades //no lleva punto y coma
        {
            get { return _numeroUnidades; }
            set { _numeroUnidades = value; }
        }

        private decimal _total;
        public decimal Total //no lleva punto y coma
        {
            get { return _total; }
            set { _total = value; }
        }
        private string _codProd;
        public string CodProd //no lleva punto y coma
        {
            get { return _codProd; }
            set { _codProd = value; }
        }

        private string _codProveedores;
        public string CodProveedores //no lleva punto y coma
        {
            get { return _codProveedores; }
            set { _codProveedores = value; }
        }

        //constructor
        public claseCompra(){}
        public claseCompra(string _codCompra, string _fechaCompra, decimal _precio, int _numeroUnidades, decimal _total, string _codProd, string _codProveedores)
        {
            this.CodCompra = _codCompra;
            this.FechaCompra = _fechaCompra;
            this.Precio = _precio;
            this.NumeroUnidades = _numeroUnidades;
            this.Total = _total;
            this.CodProd = _codProd;
            this.CodProveedores = _codProveedores;
        }
    }
}
