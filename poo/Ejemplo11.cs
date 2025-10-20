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

        ProvinciaCiudad[] provinciasCiudad = new ProvinciaCiudad[]
        {
            new ProvinciaCiudad()
            {
                Cod = "x", Nombre = "Córdoba", ClaveTel = "351", Habitantes= 2514,
                Ciudades = ["Códoba", "Cruz del Eje"]
            },
            new ProvinciaCiudad() { Cod = "c", Nombre = "CABA", ClaveTel = "11", Habitantes= 50000 },
            new ProvinciaCiudad() 
            { 
                Cod = "b", Nombre = "Buenos Aires", ClaveTel = "221", Habitantes= 2358785,
                Ciudades = ["La Plata", "Mar del Plata", "Bahía Blanca"]
            },
            new ProvinciaCiudad() { Cod = "s", Nombre = "Santa Fe", ClaveTel = "342", Habitantes= 2500000 },
            new ProvinciaCiudad() { Cod = "m", Nombre = "Mendoza", ClaveTel = "261", Habitantes=150000 }
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

            //var provinciasCons = (provincias
            //    .Where(p => p.Habitantes < 2000000
            //                && p.Nombre.Substring(0, 1) == "C")
            //    .OrderByDescending(p=>p.Nombre)
            //    .ToList())
            //    .FirstOrDefault();

            //var numerosOrdenados = numeros.OrderByDescending(n => n).ToList();

            //select
            //var nombreProvincias = provincias.Select(p => p.Nombre).ToList();
            //var nombreCodProvincias = provincias.Select(p => new
            //{
            //    Codigo = p.Cod,
            //    Nombre = p.Nombre,
            //    pepe = "pepe"
            //}).ToList();

            //var numerosAlCuadrado = numeros.Select(n => n * n).ToList();

            //var provIndice = provincias
            //    .Select((provincia, indice) => new
            //    {
            //        Indice = indice,
            //        Nombre = provincia.Nombre
            //    });

            //var provOrdenDesc =
            //    (
            //        provincias
            //            .Select((provincia, indice) => new
            //            {
            //                Orden = indice + 1,
            //                Nombre = provincia.Nombre
            //            })
            //    )
            //    .OrderByDescending(o => o.Orden)
            //    .ToList();

            //var ciudades = provinciasCiudad
            //    .Select(p => p.Ciudades)
            //    .ToList();

            //var ciudadesMany = provinciasCiudad
            //    .SelectMany(p => p.Ciudades)
            //    .ToList();

            //int[] arreglo = { 1, 2 };

            //var productoCartesiano = provincias
            //                        .SelectMany(p => arreglo, (provincia, numero) =>
            //                        new
            //                        {
            //                            Provincia = provincia,
            //                            Numero = numero
            //                        });

            //foreach (var item in productoCartesiano)
            //{
            //    Console.WriteLine($"{item.Numero} ---- {item.Provincia.Habitantes}");

            //}

            // int = 2.000.000.0000
            // long = 9.000.000.0000.0000
            Console.WriteLine($"Cantida de números {numeros.Count()}");
            Console.WriteLine($"Cantida de números {numeros.LongCount()}");
            Console.WriteLine($"Cantida de provincias {provincias.Count()}");
            Console.WriteLine($"Cantida de provincias con C {provincias
                                                   .Count(p => p.Nombre.Substring(0,1) == "C")}");

            Console.WriteLine($"Suma de números {numeros.Sum()}");
            Console.WriteLine($"suma de habitantes {provincias
                                                   .Sum(p => p.Habitantes)}");


            Console.WriteLine($"Min de números {numeros.Min()}");
            Console.WriteLine($"Min de habitantes {provincias
                                                   .Min(p => p.Habitantes)}");
            Console.WriteLine($"Min de habitantes {provincias
                                                   .MinBy(p => p.Habitantes)!
                                                   .Nombre}");

            Console.WriteLine($"Max de números {numeros.Max()}");
            Console.WriteLine($"Max de habitantes {provincias
                                                   .Max(p => p.Habitantes)}");
            Console.WriteLine($"Max de habitantes {provincias
                                                   .MaxBy(p => p.Habitantes)!
                                                   .Nombre}");

            Console.WriteLine($"Prom de números {numeros.Average()}");
            Console.WriteLine($"Prom de habitantes {provincias
                                                   .Average(p => p.Habitantes)}");

        }
    }


    public class ProvinciaCiudad : Provincia
    {
        public string[] Ciudades { get; set; } = [];
    }
}
