using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notification
    {
        public Notification()
        {
            Notifications = new List<Notification>();
        }

        [NotMapped]
        public string PropertyName { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notification> Notifications;

        public bool ValidateString(string valor, string property)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(property))
            {
                Notifications.Add(new Notification { Message = "Campo obrigatório", PropertyName = property });
                return false;
            }
            return true;
        }

        public bool ValidateInt(int valor, string property)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(property))
            {
                Notifications.Add(new Notification { Message = "Campo obrigatório", PropertyName = property });
                return false;
            }
            return true;
        }

        public bool ValidateValidade(DateTime dateFabricacao, DateTime dateValidade, string property)
        {
            if (dateFabricacao > dateValidade || string.IsNullOrWhiteSpace(property))
            {
                Notifications.Add(new Notification { Message = "Data de fabricação maior que a data de validade", PropertyName = property });
                return false;
            }
            return true;
        }
    }
}
