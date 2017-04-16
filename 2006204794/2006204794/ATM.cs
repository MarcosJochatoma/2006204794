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
        private List<Teclado> _Teclado;
        private List<DispensadorEfectivo> _DispensadorEfectivo;
        private List<Pantalla> _Pantalla;
       
     
       
        public ATM()
        {
            _RanuraDeposito = new List<RanuraDeposito>();
            _Teclado = new List<Teclado>();
            _DispensadorEfectivo = new List<DispensadorEfectivo>();
            _Pantalla = new List<Pantalla>();
        }

        
        public BaseDatos BaseDatos
        {
            get; set;
        }

        public Retiro Retiro
        {
            get;set;
        }



        public void Autenticar()
        {
            bool date = BaseDatos.AutenticarUsuario(1000, 123);
            if (date.Equals(true))
                Console.WriteLine("Número de Cuenta no registrada [{0}]", 1000);
        }







    }
}
