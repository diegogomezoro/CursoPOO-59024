using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banco
    {
        //Atributos
        private int numero;
        private string lugar;
        private List<Sucursal> sucursales;
        private List<Cliente> clientes;
        private List<Producto> productos;

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }

        //Metodos u Operaciones
        public Banco()
        {
            this.clientes = new List<Cliente>();
        }

    }
}
