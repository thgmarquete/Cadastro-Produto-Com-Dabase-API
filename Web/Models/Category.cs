using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Descri��o")]
        [Required(ErrorMessage ="O campo � descri��o obrigat�rio")]
        public string Descricao { get; set; }

        public List<Product>Produtos { get; set; }

    }
}