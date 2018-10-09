using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class claseProducto
    {
      

        private string _codprod;
        public string CodProd //no lleva punto y coma
        {
            get { return _codprod; }
            set { _codprod = value; }
        }

        private string _nombre;
        public string Nombre //no lleva punto y coma
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private decimal _precio;
        public decimal Precio //no lleva punto y coma
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _cantidadEx;
        public int CantidadEx //no lleva punto y coma
        {
            get { return _cantidadEx; }
            set { _cantidadEx = value; }
        }

        private int _cantidadMin;
        public int CantidadMin //no lleva punto y coma
        {
            get { return _cantidadMin; }
            set { _cantidadMin = value; }
        }

        private string _caracteristicas;
        public string Caracteristicas //no lleva punto y coma
        {
            get { return _caracteristicas; }
            set { _caracteristicas = value; }
        }
       
        //constructor
        public claseProducto() { }
        public claseProducto(string _codprod, string _nombre, decimal _precio, int _cantidadEx, int _cantidadMin, string _caracteristicas)
        {
            this.CodProd = _codprod;
            this.Nombre = _nombre;
            this.Precio = _precio;
            this.CantidadEx = _cantidadEx;
            this.CantidadMin = _cantidadMin;
            this.Caracteristicas = _caracteristicas;
        }
    }
}
