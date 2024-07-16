using EJERCICIOS_POO.models;

//Crea una instancia de Persona y asigna valores a sus propiedades.
// var persona = new Persona(); 
// persona.Nombre="valeria P";
// persona.Edad=21;

//Muestra los valores en la consola
// Console.WriteLine($" Hola, me llamo {persona.Nombre} y mi edad es {persona.Edad}");


// Crea una instancia de Persona, asigna valores y llama al método Saludar().
// var persona1 = new Persona();//intancia
// persona1.Nombre="val"; //asignar valores
// persona1.Edad=20;
// persona1.Saludar();//llamar metodo



//Crea una instancia de Coche, asigna valores y muestra los valores en la consola.
var persona2 = new Persona("Valeria",21); //intancia
Console.WriteLine($"me llamo {persona2.Nombre} y tengo {persona2.Edad} años de edad");

var coche = new Coche();
coche.Marca = "marca1";
coche.Modelo=2020;
coche.Anio=2022;
Console.WriteLine($"el coche es de la marca {coche.Marca} del modelo {coche.Modelo} y del año {coche.Anio}");



//Crea una instancia de Coche, asigna valores y llama al método MostrarDetalles().
var coche1 = new Coche();
coche1.Marca="Coc";
coche1.Modelo=2015;
coche1.Anio=2023;
coche1.MostrarDetalles(); //llamar metodo

//Llama a este método y muestra los detalles actualizados.
coche1.ActualizarAño();


//Crea una instancia de Libro, asigna valores y muestra los valores en la consola.
var libro1 = new Libro();
libro1.Titulo="hola".ToUpper();
libro1.Autor="mundo";
Console.WriteLine($"el libro se llama {libro1.Titulo} y su autor es {libro1.Autor}");

//Crea una instancia de Calculadora y muestra el resultado de la suma.
var calcular = new Calculadora();
calcular.Suma();

//Llama a este método y muestra el resultado. resta
calcular.Resta();
Console.WriteLine(calcular.Resta());

//● Asegúrate de que el nombre siempre se almacene en minúsculas.
//Crea una instancia de Producto, asigna valores y muestra los valores en la consola
var producto1 = new Producto();
producto1.Nombre="Anillo".ToLower();
producto1.Precio=1000;
Console.WriteLine($"el producto es {producto1.Nombre} y su precio es {producto1.Precio}");

//Usa estos métodos para cambiar el nombre y mostrar el valor actualizado.
producto1.SetNombre("Collar");
Console.WriteLine("el nuevo nombre del producto es "+ producto1.GetNombre());

//Crea una instancia de CuentaBancaria, deposita una cantidad y muestra el saldo.
var cuenta = new CuentaBancaria();
cuenta.Depositar(3000);
Console.WriteLine(cuenta.Saldo);

//Llama a este método y muestra el saldo actualizado.
cuenta.Retirar(2000);
Console.WriteLine(cuenta.Saldo);

//Asegúrate de que el nombre siempre se almacene en minúsculas.
//Crea una instancia de Estudiante, asigna valores y muestra los valores en la consola.
var estu = new Estudiante();
estu.Nombre="valeria".ToLower();
estu.Edad=21;
estu.Grado=11;
Console.WriteLine($"el estudiante se llama {estu.Nombre} tiene {estu.Edad} años y esta en {estu.Grado} grado");

