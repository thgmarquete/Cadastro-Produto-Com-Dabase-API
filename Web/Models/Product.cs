using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Descriçao { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Category Categoria { get; set; }

    }
}
