using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794
{
    public class ATM
    {
        private List<RanuraDeposito> _RanuraDeposito;

        public ATM(int numDeposito)
        {
            _RanuraDeposito = new List<RanuraDeposito>(numDeposito);
        }
    }
}
