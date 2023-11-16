using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaCineBack.Entidades
{
    public class Idiomas
    {
        public int Id_idioma { get; set; }
        public string Idioma { get; set; }


        public Idiomas(int id_idioma,string idioma)
        {
            Id_idioma=id_idioma;
            Idioma = idioma;
        }

        public Idiomas()
        {
            Id_idioma = 0;
            Idioma = string.Empty;
        }

        public override string ToString()
        {
            return Idioma.ToString();
        }
    }
}
