using System;
using System.Collections.Generic;
using System.Text;

namespace SCModelo
{
    public class Filmes
    {
        public int Id { get; set; }
        public string Sinopse { get; set; }
        public string Genero { get; set; }
        public string Tipo { get; set; }
        public List<SalaFilme> SalasFilmes { get; set; }
    }
}
