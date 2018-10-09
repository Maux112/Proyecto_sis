using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class claseVenta
    {
        private string _codVenta;
        public string CodVenta //no lleva punto y coma
        {
            get { return _codVenta; }
            set { _codVenta = value; }
        }

         private string _fechaVenta;
        public string FechaVenta //no lleva punto y coma
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }
    
        private int _cantidad;
        public int Cantidad //no lleva punto y coma
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

          private decimal _totalVenta;
        public decimal TotalVenta //no lleva punto y coma
        {
            get { return _totalVenta; }
            set{_totalVenta=value;}
        }

        private string _codProd;
        public string CodProd //no lleva punto y coma
        {
            get { return _codProd; }
            set { _codProd = value; }
        }
        private string _CodPer;
        public string CodPer //no lleva punto y coma
        {
            get { return _CodPer; }
            set { _CodPer = value; }
        }
        //constructor
        public claseVenta(){}
        public claseVenta(string _codVenta, string _fechaVenta, int _cantidad, decimal _totalVenta, string _codProd, string _CodPer)
        {
            this.CodVenta = _codVenta;
            this.CodProd = _fechaVenta;
            this.Cantidad = _cantidad;
            this.TotalVenta = _totalVenta;
            this.CodProd = _codProd;
            this.CodPer = _CodPer;
        }
    }
}
