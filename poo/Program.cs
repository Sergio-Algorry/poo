using poo;

//Ejemplo1 ej1 = new Ejemplo1();
//Ejemplo2 ej2 = new Ejemplo2();
//Ejemplo3 ej3 = new Ejemplo3();
//Ejemplo4 ej4 = new Ejemplo4();
Ejemplo5 ej5 = new Ejemplo5();

//ej5.EjecutarBuscarPersona(new PersonaBD());
//ej5.EjecutarBuscarPersona(new PersonaLista());

var Buscador = ej5.EjecutarBuscarPersona(TipoBusqueda.Lista);
Buscador.ObtenerPersona(); // desde la clase PersonaLista

Buscador = ej5.EjecutarBuscarPersona(TipoBusqueda.BaseDatos);
Buscador.ObtenerPersona(); // desde la clase PersonaBD


