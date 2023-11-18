using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCordobaBack.Entidades
{
    public class Vendedores
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Vendedores()
        {
            VendedorId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        public Vendedores(int vendId, string nombre, string apellido)
        {
            VendedorId = vendId;
            Nombre = nombre;
            Apellido = apellido;

        }
    }
}
