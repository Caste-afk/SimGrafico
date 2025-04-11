using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGrafico
{
    public class Ctelefonata
    {
        public int numero { get; set; }
        public TimeSpan durata { get; set; }
        public int volte { get; set; }

        public Ctelefonata(int numero, TimeSpan durata)
        {
            this.numero = numero;
            this.durata = durata;
        }

    }
}
