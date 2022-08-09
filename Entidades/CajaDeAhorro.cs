using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajaDeAhorro : CuentaBancaria
    {
        //private int numero;
        //private string alias;
        //private string cbu;
        //private string tipo;
        //private decimal saldo;
        //private Cliente titular;

        public string extraer(float monto)
        {
            if (Saldo >= monto)
            {
                Saldo = Saldo - monto;
                return "Extraccion ok";
            }
            else
            {

                return "No hay fondos suficientes";

            }
        }

        public float informarSaldo()
        {
            return Saldo;
        }

        public float informarSaldo(float valor)
        {
            return (Saldo - valor);
        }

        public new void depositar(float monto, float impuesto)
        {
            Saldo = (Saldo + monto) - impuesto * 2;
        }

    }
}
