using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo4
    {
        public Ejemplo4()
        {
            var persona = new Persona();
            persona.FechaNacimiento = new DateTime(1957, 5, 1);
            Console.WriteLine($"La edad es {persona.Edad()}");

            var fecha = new DateTime(2032, 4, 1);
            Console.WriteLine($"La edad en {fecha.ToString("dd/MM/yyyy")} es {persona.Edad(fecha)}");

            fecha = new DateTime(2032, 5, 1);
            Console.WriteLine($"La edad en {fecha.ToString("dd/MM/yyyy")} es {persona.Edad(fecha)}");
        }
    }

    public class Persona
    {
        public DateTime FechaNacimiento { get; set; }

        public int Edad()
        {
                int edad = DateTime.Now.Year - FechaNacimiento.Year;
                if (DateTime.Now < FechaNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad;
        }

        public int Edad(DateTime fecha)
        {
                int edad = fecha.Year - FechaNacimiento.Year;
                if (fecha < FechaNacimiento.AddYears(edad))
                {
                    edad--;
                }
                return edad;
        }
    }


}
