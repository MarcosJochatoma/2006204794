using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794
{
    public class Teclado
    {

        private decimal _MontoTeclado;

        public decimal MontoTeclado
        {
            get
            {
                return _MontoTeclado;
            }
            set
            {
                if (value > 0)
                    _MontoTeclado = value;
            }
        }

        public Teclado(decimal montoTeclado)
        {
            MontoTeclado = montoTeclado;
        }





    }
}
