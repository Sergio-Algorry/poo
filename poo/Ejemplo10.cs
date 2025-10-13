using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo10
    {
        //public Dictionary<string, int> DIC { get; set; } = new Dictionary<string, int>();
        public Dictionary<string, Provincia> DIC { get; set; } = 
                                    new Dictionary<string, Provincia>();

        public Ejemplo10()
        {
            //Provincia p1 = new Provincia() 
            //             { Cod = "x", Nombre = "Córdoba", ClaveTel = "351" };

            Provincia p1 = new Provincia();
            p1.Cod = "x";
            p1.Nombre = "Córdoba";
            p1.ClaveTel = "351";

            Provincia p2 = new Provincia();
            p2.Cod = "C";
            p2.Nombre = "CABA";
            p2.ClaveTel = "11";
            
            string clave1 = Guid.NewGuid().ToString();
            string clave2 = Guid.NewGuid().ToString();

            DIC.Add(clave1, p1);
            DIC[clave2] = p2;

            Console.WriteLine($"Cantidad de elementos: {DIC.Count.ToString()} \r\n");
            Console.WriteLine($"Elemento 1 tel: {DIC[clave1].ClaveTel}\r\n");
            
            if(DIC.ContainsKey("pepe"))
            {
                Console.WriteLine($"Elemento 2 tel: {DIC[clave2].Nombre}\r\n");
            }
            else
            {
                Console.WriteLine($"No existe la clave <pepe> \r\n");
            }

            //foreach (var item in DIC)
            //{
            //    Console.WriteLine($"Elemento: {item}");
            //    Console.WriteLine($"Elemento: {item.Key}");
            //    Console.WriteLine($"Elemento: {item.Value.Cod}");
            //    Console.WriteLine($"Elemento: {item.Value.Nombre}");
            //    Console.WriteLine($"Elemento: {item.Value.ClaveTel} \r\n");
            //}

            //foreach (var item in DIC.Keys)
            //{
            //    Console.WriteLine($"key: {item}");
            //}

            //foreach (var item in DIC.Values)
            //{
            //    Console.WriteLine($"Codigo: {item.Cod}");
            //}

            //foreach (var llave in PR)
            //{
            //    Console.Writeline(llave.Key);

            //    foreach (var valor in llave.Value)
            //    {
            //        Console.Writeline(“ - ” +valor.Nombre);
            //    }
            //}


        }
    }

    public class Provincia
    {
        public string Cod { get; set; }
        public string Nombre { get; set; }
        public string ClaveTel { get; set; }
        public int Habitantes { get; set; }

        public override string ToString()
        {
            return $"{Cod} - {Nombre} - {ClaveTel}";
        }
    }
}
