using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class CuentaBancariaLogica
    {
        public static void depositar(CuentaBancaria cuenta, float monto, float impuesto)
        {
            monto = monto * 2;
            cuenta.depositar(monto, impuesto);
        }
    }
}
