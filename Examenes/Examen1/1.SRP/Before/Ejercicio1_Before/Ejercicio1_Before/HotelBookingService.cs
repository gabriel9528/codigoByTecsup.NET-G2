using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before
{
    public class HotelBookingService
    {

        public string Create(string name, string email, DateTime checkIn, DateTime checkOut)
        {
            StringBuilder message = new StringBuilder();

            bool isValid = true;
            
            message.Append($"Iniciando reserva {DateTime.Now.ToLongTimeString()}....");

            if (string.IsNullOrEmpty(name))
                message.Append("La reserva no puede ser agendada, debido a que debe proporcionar un nombre.");
            isValid = false;

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                message.Append("La reserva no puede ser agendada, debido a que debe proporcionar un email valido.");
            isValid = false;

            if (checkIn.Equals(DateTime.MinValue))
                message.Append("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");
            isValid = false;

            if (checkOut.Equals(DateTime.MinValue))
                message.Append("La reserva no puede ser agendada, debido a que debe proporcionar la hora de la reserva.");
            isValid = false;

            if(checkIn > checkOut)
                message.Append("La reserva no puede ser agendada, debido a que la fecha de salida no puede ser menor a la fecha de entrada.");

            if (isValid)
                message.Append($"La cita quedo agendada para el paciente {name}.");

            return message.ToString().Replace(".", Environment.NewLine);

        }
    }
}
