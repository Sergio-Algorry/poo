using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo7
    {
        Producto producto = new Producto();
        //EntidadBase entidad = new EntidadBase();
        public Ejemplo7()
        {
            producto.Id = 10;
            producto.Nombre = "Manzana";
            Console.WriteLine($"producto = {producto.ToString()}");
            Console.WriteLine($"producto.id = {producto.Id.ToString()}");
            Console.WriteLine($"mostrar pepe = {producto.MostrarPepe()}");


            //entidad.Id = 15;
            //Console.WriteLine($"entidad = {entidad.Id}");

            Pepito pp = new Pepito();

            Console.WriteLine($"pp = {pp.ToString()}");
        }

    }

    abstract public class EntidadBase
    {
        public int Id { get; set; }

        abstract public string MostrarId();

        virtual public string MostrarPepe()
        {
            return $"PePe";
        }
    }
    public class Producto : EntidadBase
    {
        public string Nombre { get; set; }

        public override string MostrarId()
        {
            throw new NotImplementedException();
        }

        override public string ToString()
        {
            base.ToString();
            return $"Clase que hereda Id: {Id}, Nombre: {Nombre}";
        }

        public override string MostrarPepe()
        {
            Console.WriteLine( "llamado desde sobreescritura " + base.MostrarPepe());
            return "No soy Pepe";
        }
    }

    public class Pepito : Producto
    {
        public string domicilio { get; set; }
    }
}
