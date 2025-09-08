using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo6
    {
        public Ejemplo6()
        {
            var fechaNacimiento = new DateTime(1995, 5, 15);
            Console.WriteLine($"Edad a hoy: {Util.CalcularEdad(fechaNacimiento)}");
            var fecha = new DateTime(2028, 4, 15);
            Console.WriteLine($"Edad a {fecha.ToString("dd/MM/yyyy")}: {Util.CalcularEdad(fechaNacimiento, fecha)}\r\n");


            Console.WriteLine("\r\n\r\nUsando métodos de extensión");
            Console.WriteLine($"Edad a hoy (con extensión): {fechaNacimiento.CalcularEdad()}");
            Console.WriteLine($"Edad a {fecha.ToString("dd/MM/yyyy")} (con Ext,): {fechaNacimiento.CalcularEdad(fecha)}\r\n");


        }
    }

    public static class Util
    {
        public static void Imprimir(string texto)
        {
            Console.WriteLine(texto);
        }

        public static string MensajeError(string error,
                                          Exception? e = null,
                                          bool conInner = false,
                                          bool conTrace = false)
        {
            var msg = error;
            if (e != null)
            {
                if (string.IsNullOrEmpty(msg)) msg = e.Message;
                else if (!msg.EndsWith("\r\n")) msg = msg + "\r\n" + e.Message;
                else msg = msg + e.Message;

                if (e.InnerException != null & conInner)
                {
                    msg = msg + "\r\nInnerException: " + e.InnerException!.Message;
                }

                if (e.StackTrace != null & conTrace)
                {
                    msg = msg + "\r\nTrace: " + e.StackTrace;
                }
            }

            return msg;
        }

        public static int CalcularEdad(this DateTime fechaNacimiento,
                                       DateTime? fecha = null)
        {
            var fechaCalculo = (fecha ?? DateTime.UtcNow).Date;
            var nacimiento = fechaNacimiento.ToUniversalTime().Date;    
            var edad = fechaCalculo.Year - fechaNacimiento.Year;
            if (fechaNacimiento > fechaCalculo.AddYears(-edad)) edad--;
            return edad;
        }
    }
}
