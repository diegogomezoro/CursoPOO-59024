using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteCorporativo
    {
        // Atributos aquí
        private String cuit;
        private CuentaCorriente cuenta;

        // Constructores
        public ClienteCorporativo(String c)
        {
            cuit = c;
            cuenta = new CuentaCorriente(5000);
            // busca en la Base de Datos los datos
            // de este cliente según el cuit y
            // completa los atributos
        }

        // Métodos aquí
        public CuentaCorriente obtenerCuentaCorriente()
        {
            return cuenta;
        }
    }
}
