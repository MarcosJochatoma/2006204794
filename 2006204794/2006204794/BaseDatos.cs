using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2006204794
{
    public class BaseDatos
    {
        private Cuenta _Cuenta;

        public BaseDatos()
        {
            _Cuenta = new Cuenta();
        }

        public bool AutenticarUsuario(int numeroCuenta, int pin)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta && _Cuenta.Pin==pin)
            {
                return true;
            }
            return false;
            
        }


        public decimal ObtenerSaldoDisponible(int numeroCuenta)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
            {
                return _Cuenta.Monto;
            }else
            {
                return 0;
            }
        }

        public decimal ObtenerSaldoTotal(int numeroCuenta)
        {
            if (_Cuenta.NumeroCuenta == numeroCuenta)
            {
                return _Cuenta.Monto;
            }
            else
            {
                return 0;
            }
        }







    }
}
