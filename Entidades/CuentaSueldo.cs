using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaSueldo : CuentaBancaria
    {
        public new void depositar(float monto, float impuesto)
        {
            Saldo = Saldo + monto;
        }
    }
}
