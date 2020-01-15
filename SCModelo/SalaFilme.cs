using System;
using System.Collections.Generic;
using System.Text;

namespace SCModelo
{
    public class SalaFilme
    {
        public int SalaId { get; set; }
        public SalaCinema Sala { get; set; }
        public int FilmeId { get; set; }
        public Filmes Filmes { get; set; }
    }
}
