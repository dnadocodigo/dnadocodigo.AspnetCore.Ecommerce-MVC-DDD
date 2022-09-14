using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Products
{
    public class Product
    {
        [Column("CODIGO")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("VALOR")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("ESTADO")]
        [Display(Name = "Estado")]
        public bool Status { get; set; }
    }
}
