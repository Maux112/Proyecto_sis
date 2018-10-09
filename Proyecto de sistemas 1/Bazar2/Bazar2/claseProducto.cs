using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2
{
    class claseProducto
    {
         private string _nombre;
        public string Nombre //no lleva punto y coma
        {
            get { return _nombre; }
            set{_nombre=value;}
        }

        private string _codprod;
        public string CodProd //no lleva punto y coma
        {
            get { return _codprod; }
            set { _codprod = value; }
        }

        private decimal _precio;
        public decimal Precio //no lleva punto y coma
        {
            get { return _precio; }
            set{_precio=value;}
        }

        private int _cantidad;
        public int Cantidad //no lleva punto y coma
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string _descripcion;
        public string Descripcion //no lleva punto y coma
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private string _marca;
        public string Marca //no lleva punto y coma
        {
            get { return _marca; }
            set { _marca = value; }
        }
        //constructor
        public claseProducto(){}
        public claseProducto(string _nombre, string _codprod, decimal _precio, int _cantidad, string _descripcion, string _marca)
        {
            this.Nombre=_nombre;
            this.CodProd = _codprod;
            this.Precio = _precio;
            this.Cantidad = _cantidad;
            this.Descripcion = _descripcion;
            this.Marca = _marca;
        }
    }
}
