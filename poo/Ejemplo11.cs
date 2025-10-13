using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo11
    {
        //int[] numeros = [1, 2, 3, 4, 5]; // Array de enteros
        int[] numeros = Enumerable.Range(1, 5).ToArray(); // Array de enteros

        //List<Provincia> provincias = new List<Provincia>();
        Provincia[] provincias = new Provincia[]
        {
            new Provincia() { Cod = "x", Nombre = "Córdoba", ClaveTel = "351", Habitantes= 2514},
            new Provincia() { Cod = "c", Nombre = "CABA", ClaveTel = "11", Habitantes= 50000 },
            new Provincia() { Cod = "b", Nombre = "Buenos Aires", ClaveTel = "221", Habitantes= 2358785 },
            new Provincia() { Cod = "s", Nombre = "Santa Fe", ClaveTel = "342", Habitantes= 2500000 },
            new Provincia() { Cod = "m", Nombre = "Mendoza", ClaveTel = "261", Habitantes=150000 }
        };

        public Ejemplo11()
        {

            ////sintaxis de métodos
            //var numMayorA_3 = numeros.Where(r => r > 3).ToArray();
            ////sintaxis de queries
            //var numerosPares = (from n in numeros
            //                    where n % 2 == 0
            //                    select n).ToList();

            //var provinciasMenosDe_2000000 = provincias.Where(p => p.Habitantes< 2000000).ToList();

            //Ejecución diferida
            //var numerosPares = numeros.Where(n =>
            //{
            //    Console.WriteLine($"Evaluando si es par: {n}");
            //    return n % 2 == 0;
            //});       //.ToList();

            //Console.WriteLine();
            //foreach (var item in numerosPares)
            //{
            //    Console.WriteLine($"Número par: {item}");
            //}
            //Console.WriteLine();

            //consulta compleja
            //var provinciasConsulta = provincias
            //    .Where(p => p.Habitantes < 2000000
            //                && p.Nombre.Substring(0, 1) == "C").ToList();

            //var provinciaPrimera = provincias.First();
            //var provinciaPrimeraO = provincias.FirstOrDefault();

            //int[] numeros = { }; // Array de enteros
            //var numero = numeros.FirstOrDefault(); 

            //string[] caracteres = { };
            //var letra = caracteres.FirstOrDefault(); 

            //var provincia = provincias
            //    .Where(p => p.Habitantes < 2000000
            //                && p.Nombre.Substring(0, 1) == "C")
            //    .FirstOrDefault();

            //var provincia = provincias
            //    .FirstOrDefault(p => p.Habitantes < 2000000
            //                && p.Nombre.Substring(0, 1) == "C");

            var provinciasCons = (provincias
                .Where(p => p.Habitantes < 2000000
                            && p.Nombre.Substring(0, 1) == "C")
                .OrderByDescending(p=>p.Nombre)
                .ToList())
                .FirstOrDefault();
        }
    }
}
