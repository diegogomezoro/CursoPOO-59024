using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaBancaria
    {
        private int numero;
        private string alias;
        private string cbu;
        private string tipo;
        private float saldo;
        private Cliente titular;

        private static int descubierto = 5000;

        public static void modificarDescubierto(int monto)
        {
            descubierto = monto;
        }

        public static int leerDescubierto()
        {
            return descubierto;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Alias { get => alias; set => alias = value; }
        public string Cbu { get => cbu; set => cbu = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public Cliente Titular { get => titular; set => titular = value; }

        public void depositar(float monto, float impuesto)
        {
            saldo =  (saldo + monto)-impuesto;
        }
    }
}
