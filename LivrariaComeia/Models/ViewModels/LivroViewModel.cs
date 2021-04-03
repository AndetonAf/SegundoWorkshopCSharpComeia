using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaComeia.Models.ViewModels
{
    public class LivroViewModel
    {
        public Livro Livro { get; set; }
        public List<SelectListItem> CatetoriasSelect { get; set; }
    }
}
