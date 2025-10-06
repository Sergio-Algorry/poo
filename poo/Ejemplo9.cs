using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public  class Ejemplo9
    {
        //public List<int> lista { get; set; } = new List<int>() { 56, 8, 25, 10 };
        public List<string> lista { get; set; } = new List<string>() 
        {
            "Ana", "Pedro", "Maria", "Juan", "Zoe", "Luis", "Carlos"
        };

        public Ejemplo9()
        {
            //Console.WriteLine($"Elemento posicion 0: {lista[10]}");

            //lista.Add(28);
            //lista.Remove(52);
            //lista.RemoveAt(3);

            //lista.Clear();

            //lista.Sort(4,3,default);
            //lista.Reverse();


            Console.WriteLine($"Cantidad de elementos: {lista.Count.ToString()} \r\n");
            foreach (var item in lista)
            {
                Console.WriteLine($"Elemento: {item}");
            }
        }
    }
}
