using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="O campo é descrição obrigatório")]
        public string Descricao { get; set; }

        public List<Product>Produtos { get; set; }

    }
}