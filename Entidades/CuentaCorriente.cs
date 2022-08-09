using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente : CuentaBancaria
    {
        //private int numero;
        //private string alias;
        //private string cbu;
        //private string tipo;
        //private int saldo;
        //private Cliente titular;

        //public int informarSaldo()
        //{
        //    return saldo;
        //}

        //public void depositarDinero(int monto)
        //{
        //    saldo = (saldo + monto) - 10 ;
        //}

        //public void depositarDinero(int monto, int impuesto)
        //{
        //    saldo = saldo + monto - impuesto;
        //}

        private float saldo;
        private float saldoDescubierto;

        public float Saldo1 { get => saldo; set => saldo = value; }
        public float SaldoDescubierto { get => saldoDescubierto; set => saldoDescubierto = value; }

        public CuentaCorriente(float saldo)
        {
            this.Saldo1 = saldo;
        }

        public string extraer(float monto)
        {
            if (Saldo1 >= monto)
            {
                Saldo1 = Saldo1 - monto;
                return  "Extraccion ok";
            }
            else
            {
                float montoExcedente = monto - Saldo1;
                if (montoExcedente <= SaldoDescubierto)
                {
                    Saldo1 = 0;
                    SaldoDescubierto = SaldoDescubierto - montoExcedente;
                    return "Extraccion ok";
                }
                else
                {
                    return "No hay fondos suficientes";
                }
            }
        }

    }
}
