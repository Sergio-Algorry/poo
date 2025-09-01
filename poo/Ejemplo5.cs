using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    internal class Ejemplo5
    {
        //public Ejemplo5()
        //{
        //    PersonaBD pBD = new PersonaBD();
        //    pBD.ObtenerPersona();

        //    PersonaLista pLista = new PersonaLista();
        //    pLista.ObtenerPersona();
        //}

        public void EjecutarBuscarPersona(IBuscarPersona buscarPersona)
        {
            buscarPersona.ObtenerPersona();
        }


        public IBuscarPersona EjecutarBuscarPersona(TipoBusqueda tipoBusqueda)
        {
            switch(tipoBusqueda)
            {
                case TipoBusqueda.Lista:
                    return new PersonaLista();
                case TipoBusqueda.BaseDatos:
                    return new PersonaBD();
                default:
                    Console.WriteLine("ERROR...");
                    return null;
            }
        }

    }

    public class PersonaBD : IBuscarPersona, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //    public void ObtenerPersona()
        //    { 
        //        Console.WriteLine("Obteniendo persona de la base de datos");
        //    }
        public void ObtenerPersona()
        {
            Console.WriteLine("Obteniendo persona de la base de datos");
        }

        public void OtroMetodo()
        {
            Console.WriteLine("Otro metodo");
        }
    }

    public class PersonaLista : IBuscarPersona
    {
        public void ObtenerPersona()
        {
            Console.WriteLine("Obteniendo persona de la Lista");
        }
    }

    public interface IBuscarPersona
    {
        void ObtenerPersona();
    }

    public enum TipoBusqueda
    {
        Lista = 1,
        BaseDatos = 2
    }
}

