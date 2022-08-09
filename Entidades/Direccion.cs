using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Direccion
    {
        private string provincia;
        private string localidad;
        private string calle;
        private int numero;
        private int piso;
        private string departamento;
        private string codigoPostal;
        private string observacion;

        public string Provincia { get => provincia; set => provincia = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Piso { get => piso; set => piso = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }

}
