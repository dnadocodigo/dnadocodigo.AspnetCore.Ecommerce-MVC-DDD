using Entity.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Entities.Products
{
    [Table("Produto")]
    public class Product : Notify
    {
        [Column("CODIGO")]
        [Display(Name="Código")]
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
