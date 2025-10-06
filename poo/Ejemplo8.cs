using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    public class Ejemplo8
    {
        int[] numeros = { 1, 2, 3, 4, 5 };
        string?[] nombres = { null, "Ana", "Juan", "Pedro", "Maria" };
        DateTime[] fechas = { new DateTime(2020, 1, 1), new DateTime(2021, 2, 2), new DateTime(2022, 3, 3) };
        //DateTime[] fechas = { new DateTime(2020, 1, 1), new DateTime(2021, 2, 2), new DateTime(2022, 3, 3) };

        public Ejemplo8()
        {
            #region Metodos genericos
            Util.Imprimir(
                $"Cantidad de elementos en el arreglo numeros: {Utilidades.CantidadDeElementos<int>(numeros)}");
            Util.Imprimir(
                $"Cantidad de elementos en el arreglo nombres: {Utilidades.CantidadDeElementos<string>(nombres)}");
            Util.Imprimir(
                $"Cantidad de elementos en el arreglo fechas: {Utilidades.CantidadDeElementos(fechas)}");

            //UtilidadesArreglos<int,int> utilInt = new UtilidadesArreglos<int,int>();
            //Util.Imprimir(
            //    $"Primer elemento del arreglo numeros: {
            //        utilInt.PrimerElemntoOValorPorDefecto(numeros)}");

            //UtilidadesArreglos<string,string> utilString = 
            //    new UtilidadesArreglos<String,string>();
            //Util.Imprimir(
            //    $"Primer elemento del arreglo string: {
            //        utilString.PrimerElemntoOValorPorDefecto(nombres)}");

            //UtilidadesArreglos<DateTime,DateTime> utilFecha =
            //    new();
            //Util.Imprimir(
            //    $"Primer elemento del arreglo fecha: {utilFecha.PrimerElemntoOValorPorDefecto(fechas)}");
            #endregion

            #region Control de restricciones
            //UtilidadesArreglos<int> utilInt = new UtilidadesArreglos<int>();
            //Util.Imprimir(
            //    $"Primer elemento del arreglo numeros: {utilInt.PrimerElemntoOValorPorDefecto(numeros)}");

            //UtilidadesArreglos<string> utilString = new UtilidadesArreglos<String>();
            //if (utilString.PrimerElemntoOValorPorDefecto(nombres) == null)
            //{ 
            //    Util.Imprimir("El primer elemento del arreglo string es null"); 
            //}
            //else
            //{
                //Util.Imprimir(
                //$"Primer elemento del arreglo string: {utilString.PrimerElemntoOValorPorDefecto(nombres)}");
            //}
            //UtilidadesArreglos<DateTime> utilFecha = new();
            //Util.Imprimir(
            //    $"Primer elemento del arreglo fecha: {utilFecha.PrimerElemntoOValorPorDefecto(fechas)}");

            UtilidadesArreglos<vehiculo> utilVehiculo = new UtilidadesArreglos<vehiculo>();
            UtilidadesArreglos<auto> utilAuto = new UtilidadesArreglos<auto>();
            #endregion
        }
    }

    public static class Utilidades
    {
        public static int CantidadDeElementos<T>(T[] arreglo)
        {
            return arreglo.Length;
        }
    }

    //public class UtilidadesArreglos<T,E, F>
    //public class UtilidadesArreglos<T> where T : class
    //public class UtilidadesArreglos<T> where T : vehiculo
    public class UtilidadesArreglos<T> where T : vehiculo, new()
    {
        public T PrimerElemntoOValorPorDefecto(T[] arreglo)
        {
            if (arreglo.Length == 0)
            {
                return default;
            }
            else
            {
                return arreglo[0];
            }
        }

        //public E PrimerElemntoOValorPorDefecto(T[] arreglo, F valorf)
        //{
        //    if (arreglo.Length == 0)
        //    {
        //        return default;
        //    }
        //    else
        //    {
        //        E valor = (E)Convert.ChangeType(arreglo[0], typeof(E));
        //        return valor;
        //    }
        //}
    }


    public class  vehiculo
    {
        
    }

    public class  auto : vehiculo
    {
        private readonly string marca;

        public auto(string marca)
        {
            this.marca = marca;
        }

        public auto()
        {
            
        }

    }
}