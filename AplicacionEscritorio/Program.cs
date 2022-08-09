using Entidades;

namespace AplicacionEscritorio
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Cliente cliente = new Cliente();
            //int saldo = cliente.verSaldo();
            //if (saldo > 0)
            //    MessageBox.Show("El cliente tiene saldo");

            //Cliente cliente2 = new Cliente();

            //CuentaCorriente cuentaCorriente = new CuentaCorriente();
            //cuentaCorriente.depositarDinero(10);
            //cuentaCorriente.depositarDinero(20, 10);

            //Cliente c1 = new Cliente("Lopez", "Juan");
            //c1.Apellido = "Gonzalez";

            //Cliente c2 = new Cliente();
            //c2.Apellido = "apellido";

            //Direccion.cambiarCP(10);

        }
    }
}