using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Notifications
{
    public class Notify
    {
        public Notify()
        {
            Notification = new List<Notify>();
        }

        //Propriedades===============================================

        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notify> Notification;

        //Métodos ===================================================

        // Validações
        public bool StringPropertyValidations(string value, string propertiesName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertiesName))
            {
                Notification.Add(new Notify
                {
                    Message = "Este campo é obrigatório",
                    PropertyName = propertiesName
                });
                return false;
            }
            return true;
        }

        public bool IntPropertyValidations(int value, string propertiesName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertiesName))
            {
                Notification.Add(new Notify
                {
                    Message = "O valor tem que ser maior que 0!",
                    PropertyName = propertiesName
                });
                return false;
            }
            return true;
        }

        public bool DecimalPropertyValidations(decimal value, string propertiesName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertiesName))
            {
                Notification.Add(new Notify
                {
                    Message = "O valor tem que ser maior que 0!",
                    PropertyName = propertiesName
                });
                return false;
            }
            return true;
        }

    }
}
