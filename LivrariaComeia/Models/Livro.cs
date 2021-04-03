using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaComeia.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeLancamento { get; set; } = DateTime.Now;
        public decimal Valor { get; set; }

        public Categoria Categoria { get; set; }
    }
}
