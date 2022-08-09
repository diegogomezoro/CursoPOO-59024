using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtiene el cliente de acuerdo a su cuit
            ClienteCorporativo cliente = new ClienteCorporativo("30-12345678-1");
            // Obtiene la cuenta corriente del cliente
            //CuentaCorriente cc = cliente.obtenerCuentaCorriente();
            //cc.depositar(10000);

            // Realiza la extraccion
            //Console.WriteLine(cc.extraer(2000));

            Console.WriteLine(CajaDeAhorro.leerDescubierto().ToString());


            
            Console.ReadLine();
        }
    }
}
