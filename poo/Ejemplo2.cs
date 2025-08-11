namespace poo
{
    public class Ejemplo2
    {
        public Ejemplo2()
        {
            //Console.WriteLine("PASANDO COMO ARGUMENTO UNA VARIABLE POR VALOR\r\n");

            //int numero = 10;
            Tipos ej = new Tipos();
            //Console.WriteLine($"Antes de llamar al método: {numero}");
            //ej.Valor(ref numero);
            //Console.WriteLine($"Después de llamar al método: {numero}\r\n");

            Console.WriteLine("PASANDO COMO ARGUMENTO UNA VARIABLE POR REFERENCIA\r\n");
            Pepe p = new Pepe();
            p.Nombre = "Sergio";
            Console.WriteLine($"Antes de llamar al método: {p.Nombre}");
            ej.Referencia(p);
            Console.WriteLine($"Después de llamar al método: {p.Nombre}");
        }
    }

    public class Tipos
    {
        public void Valor(ref int numero)
        {
            Console.WriteLine($"Dentro del método: {numero}");
            numero = numero * 1000;
            Console.WriteLine($"Dentro del método después de modificar: {numero}");
        }

        public void Referencia(Pepe dummy)
        {
            Console.WriteLine($"Dentro del método: {dummy.Nombre}");
            dummy.Nombre = "José";
            Console.WriteLine($"Dentro del método después de modificar: {dummy.Nombre}");
        }
    }

    public class Pepe
    {
        public string Nombre { get; set; }
    }
}
