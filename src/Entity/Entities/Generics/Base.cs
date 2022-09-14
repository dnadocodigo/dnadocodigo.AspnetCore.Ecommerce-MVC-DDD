using Entity.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entity.Entities.Generics
{
    public class Base : Notify
    {
        [Display(Name = "Código")]
        public int Code { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
