using System;
using System.Collections.Generic;
using System.Text;

namespace SCModelo
{
    public class SalaCinema
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public List<SalaFilme> SalasFilmes { get; set; }
    }
}
