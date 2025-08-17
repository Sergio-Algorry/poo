using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo3
    {
        PracticaConstructor objeto = new PracticaConstructor("sergio Algorry");
        public Ejemplo3()
        {
            Console.WriteLine($"Los valores de la propiedades son: \r\n Nombre {objeto.Nombre}\r\n Edad {objeto.Edad}");
        }
    }

    public class PracticaConstructor
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public PracticaConstructor()
        {
            Edad = 999999;
        }
        public PracticaConstructor(string aNombre) : this()
        {
            Nombre = aNombre;
        }
        public PracticaConstructor(string aNombre, int aEdad)
        {
            Nombre = aNombre;
            Edad = aEdad;
        }
    }
}
