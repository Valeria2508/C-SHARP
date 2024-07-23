using EJERCICIO_STATIC.MODELS;
//Ejercicio 1 
/* Crea una clase llamada Contador que tenga una propiedad estática llamada TotalContadores y un 
método estático llamado Incrementar. Cada vez que se llame a Incrementar, TotalContadores debe 
aumentar en 1
 */
// Console.WriteLine("Punto 1");
// Contador.Incrementar();
// Contador.Incrementar();

// // Ejercicio 2 
// // Crea una clase llamada Convertidor con un método estático llamado CelsiusAFahrenheit que tome 
// // un valor en grados Celsius y devuelva el valor en grados Fahrenheit.
// Console.WriteLine("Punto 2");
// Console.WriteLine("Ingresa los grados en celsius");
// var celsius = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"{celsius} celsius en fahrenheit son: {Convertidor.CelsiusAFahrenheit(celsius)}"); 

// //Ejercicio 3 
// // Crea  una  clase  llamada  Configuracion  con  una  propiedad  estática  llamada  ModoOscuro  de  tipo 
// // booleano.  Inicializa  ModoOscuro  en  false.  Crea  un  método  estático  llamado  CambiarModo  que 
// // invierta el valor de ModoOscuro
// Console.WriteLine("Punto 3");
// Configuracion.CambiarModo();

// // Ejercicio 4 
// // Crea una clase llamada MatematicaUtil con métodos para realizar operaciones básicas (suma, resta, 
// // multiplicación y división) que tomen dos parámetros y devuelvan el resultado.

// Console.WriteLine("Punto 4");
// //solicita al usuario los dos numeros
// Console.WriteLine("Ingresa un numero: ");
// var num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa un numero: ");
// var num2 = Convert.ToDouble(Console.ReadLine());

// //instancia ya que nada es statico
// var calcular = new MatematicaUtil();

// //imprime en consola el resultado
// Console.WriteLine($"Suma {num1} + {num2}= {calcular.Sumar(num1, num2)}");
// Console.WriteLine($"Resta {num1} - {num2}= {calcular.Restar(num1, num2)}");
// Console.WriteLine($"Multiplicacion {num1} * {num2}= {calcular.multiplicar(num1, num2)}");
// Console.WriteLine($"Division {num1} / {num2}= {calcular.Dividir(num1, num2)}");


// // Ejercicio 5 
// // Crea una clase llamada CalculadoraAritmetica con métodos estáticos para las operaciones básicas: 
// // Sumar,  Restar,  Multiplicar  y  Dividir.  Cada  método  debe  tomar  dos  parámetros  y  devolver  el 
// // resultado de la operación.

// Console.WriteLine("Punto 5");
// //solicita al usuario los dos numeros
// Console.WriteLine("Ingresa un numero: ");
// var numUno = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Ingresa un numero: ");
// var numDos = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"suma: {numUno} + {numDos} = {CalculadoraAritmetica.Sumar(numUno, numDos)};");
// Console.WriteLine($"resta: {numUno} - {numDos} = {CalculadoraAritmetica.Restar(numUno, numDos)};");
// Console.WriteLine($"multiplicacion: {numUno} * {numDos} = {CalculadoraAritmetica.multiplicar(numUno, numDos)};");
// Console.WriteLine($"division: {numUno} / {numDos} = {CalculadoraAritmetica.Dividir(numUno, numDos)};");

// Ejercicio 6 
// Crea  una  clase  llamada  AlmacenamientoMensajes  con  una  lista  estática  de  cadenas  llamada 
// Mensajes. Implementa un método estático llamado AgregarMensaje que agregue un mensaje a la 
// lista y otro método estático llamado MostrarMensajes que imprima todos los mensajes 
// almacenados.

// Console.WriteLine("Punto 6");

// AlmacenamientoMensajes.AgregarMensaje("Hola mundo!");
// Console.WriteLine("mensaje agg");
// AlmacenamientoMensajes.MostrarMensaje();    

//Ejercicio 7
// Crea una clase llamada BaseDatos que tenga un campo estático Conexion que simule una conexión 
// a una base de datos. Usa un constructor estático para inicializar Conexion con un valor 
// predeterminado  y  crea  un  método  estático  llamado  MostrarConexion  que  imprima  el  valor  de 
// Conexion

// Console.WriteLine("Punto 7");
// BaseDatos.MostrarConexion();

// Ejercicio 8 
// Crea  una  clase  llamada  UtilidadCadena  con  un  método  estático  llamado  Reverso  que  tome  una 
// cadena y devuelva su reverso.
// Console.WriteLine("Punto 8");
// UtilidadCadena.Reverso();


// Ejercicio 9 
// Crea una clase llamada Usuario con un campo estático TotalUsuarios que cuente cuántos usuarios 
// han sido creados. Incluye un método estático llamado MostrarTotalUsuarios que imprima el total 
// de usuarios creados. 
// Console.WriteLine("Punto 9");
// Usuario.MostrarTotalUsuarios();
// Usuario.MostrarTotalUsuarios();

// Ejercicio 10 
// Crea una clase llamada UtilidadFecha con un método estático llamado DiasEntreFechas que tome 
// dos objetos DateTime y devuelva el número de días entre ellos
Console.WriteLine("Punto 10");
UtilidadFecha.DiasEntreFechas();

