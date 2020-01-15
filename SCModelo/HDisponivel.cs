using System;
using System.Collections.Generic;
using System.Text;

namespace SCModelo
{
    public class HDisponivel
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }
        public SalaCinema Sala { get; set; }
        public int SalaId { get; set; }
    }
}
