using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794
{
    public class Cuenta
    {
        private int _NumeroCuenta;
        private int _Pin;
        private decimal _Monto;

        public int NumeroCuenta
        {
            get
            {
                return _NumeroCuenta;                
            }
           
        }

        public int Pin
        {
            get
            {
                return _Pin;
            }
            set
            {
                if (value > 0)
                    _Pin = value;
            }
        }


        public decimal Monto
        {
            get
            {
                return _Monto;
            }
            set
            {
                if (value > 0)
                    _Monto = value;
            }
        }

     
        public Cuenta()
        {
        }
    }
}
