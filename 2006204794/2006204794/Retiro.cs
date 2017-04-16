using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794
{
    public class Retiro
    {
        public ATM ATM
        {
            get;set;
        }

        public BaseDatos BaseDatos
        {
            get;set;
        }

        public decimal MontoDisponible
        {
            get; private set;
        }

        public Retiro()
        {

        }
        public Retiro(ATM atm)
        {
            ATM = atm;
        }

      







    }
}
