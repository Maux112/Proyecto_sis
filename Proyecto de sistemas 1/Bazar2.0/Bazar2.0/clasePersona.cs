using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazar2._0
{
    class clasePersona
    {
        
        private string _codPer;
        public string CodPer //no lleva punto y coma
        {
            get { return _codPer; }
            set { _codPer = value; }
        }
         private string _nombre;
        public string Nombre //no lleva punto y coma
        {
            get { return _nombre; }
            set{_nombre=value;}
        }

        private string _paterno;
        public string Paterno //no lleva punto y coma
        {
            get { return _paterno; }
            set { _paterno = value; }
        }

        private string _materno;
        public string Materno //no lleva punto y coma
        {
            get { return _materno; }
            set { _materno = value; }
        }

        private string _direccion;
        public string Direccion //no lleva punto y coma
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        private string _telefono;
        public string Telefono //no lleva punto y coma
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        //constructor
        public clasePersona(){}
        public clasePersona(string _codPer, string _nombre, string _paterno, string _materno, string _direccion, string _telefono)
        {
            this.CodPer = _codPer;
            this.Nombre = _nombre;
            this.Paterno = _paterno;
            this.Materno = _materno;
            this.Direccion = _direccion;
            this.Telefono = _telefono;
        }
    }
}
