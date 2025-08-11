using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo1
    {
        public Ejemplo1()
        {
            CamposYPropiedades ej = new CamposYPropiedades();

            ej.Nombre = "";
            Console.WriteLine(ej.Nombre);
        }
    }

    public class  CamposYPropiedades
    {
        //public string Nombre;

        //private string nombre;
        //public string Nombre
        //{
        //    get 
        //    { 
        //        if(nombre == "")
        //        {
        //            return "Nombre no establecido";
        //        }
        //        return nombre; 
        //    }
        //    set 
        //    { 
        //        if(value == null)
        //        {
        //            throw new ArgumentNullException(nameof(value), "El nombre no puede ser nulo");
        //        }

        //        nombre = value.ToUpper(); 
        //    }
        //}

        public string Nombre { get; set; }
    }
}
