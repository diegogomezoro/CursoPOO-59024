using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id;
        private string apellido;
        private string nombre;
        private string cuil;
        private DNI dni;
        private List<Direccion> direcciones;
        private CajaDeAhorro cuenta;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Cuil
        {
            get { return String.Format("Cuil: {0} {1}", cuil, "otro"); }
            set { cuil = String.Format("Cuil: {0}", value); }
        }

        //public int verSaldo()
        //{
        //    return cuenta.informarSaldo();
        //}

        public Cliente()
        { }

        public Cliente(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public Cliente(int id)
            { this.id = id; }

    }
}
