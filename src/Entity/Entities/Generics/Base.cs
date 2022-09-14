using Entity.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Entities.Generics
{
    public class Base : Notify
    {
        [Display(Name="Código")]
        public int Code { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
