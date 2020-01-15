using System;
using System.Collections.Generic;
using System.Text;

namespace SCModelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public char Sexo { get; set; }

        public List<Filmes> FilmesComprados { get; set; }

    }
}
