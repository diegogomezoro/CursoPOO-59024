using Entidades;

namespace AplicacionEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banco b1 = new Banco();

            Cliente c1 = new Cliente();
            c1.Apellido = "Lopez";
            c1.Nombre = "Juan";

            b1.Clientes.Add(c1);

            Cliente c2 = new Cliente("Gonzalez", "Carlos");
            b1.Clientes.Add(c2);



        }
    }
}