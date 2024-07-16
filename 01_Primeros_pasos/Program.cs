
 // See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string nombre= "valeria";
//string apellido = "piedrahita";
//byte edad= 20;
//string clan = "berners lee";
/* Console.WriteLine(nombre);
Console.WriteLine(apellido);
Console.WriteLine(edad);
Console.WriteLine(clan); */
/* 
string nombre="valeria",apellido="piedrahita",documento_num;
byte edad=21;
documento_num = "123";
var clan = "berners lee";

Console.WriteLine("hola soy "+ nombre + " con apellido \n"  + apellido + " mi cedula es "+ documento_num + " tengo" + edad
 + " años y soy de " + clan);






 *///  Escribe un programa que imprima “¡Hola, mundo!" en la consola.
Console.WriteLine("hola mundo");
// ● Declara un int y un string, asignarles valores e imprímelos.
int edad1 = 21;
string nombre1 = "val";
Console.WriteLine(edad1);
 Console.WriteLine(nombre1);
// ● Convierte un string a mayúsculas y a minúsculas.
string texto_Mauscula = "hola vale";
Console.WriteLine(texto_Mauscula.ToUpper());
string texto_Minuscula ="val HOLA";
Console.WriteLine(texto_Minuscula.ToLower());
// ● Declara dos int, realizar suma, resta, multiplicación y división, y muestra los resultados.
int numero1 = 10;
int numero2 = 20;
int suma = numero1+numero2;
int resta = numero1 - numero2;
int multiplicacion = numero1 * numero2;


Console.WriteLine("las operaciones a realizar con ambos sumeros son: ");
Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + (double)numero1/numero2);
// ● Declara dos int, realiza comparaciones de igualdad, desigualdad, mayor que y menor que,
// y muestra los resultados.
int a = 5;
int b = 6;
Console.WriteLine(a==b); //igualdad
Console.WriteLine(a!=b); //desigualdad
Console.WriteLine(a>b); //mayor que
Console.WriteLine(a<b); //menor que
// ● Busca una palabra específica en un string y reemplazarla por otra.
string palabra_Especifica = "hola como estas";
string reemplazo = palabra_Especifica.Replace("hola","vale");
Console.WriteLine(reemplazo);
// ● Pide al usuario su nombre y edad, luego imprime un mensaje con esta información.
Console.Write("Ingrese su nombre: ");
string nombreUsuario = Console.ReadLine(); //para pedir un dato al usuario e imprimir en pantalla
Console.WriteLine("Hola, " + nombreUsuario + "!");


Console.WriteLine("Ingrese su edad: ");
int edadUsuario =int.Parse(Console.ReadLine());
Console.WriteLine(edadUsuario + "!"); 

// ● Declara un int y escribe un programa que indique si es mayor, menor o igual a 10.
int numeroUno = 10;
Console.WriteLine("Ingrese un numero entero positivo: ");
int numeroUsuario =int.Parse(Console.ReadLine());
if (numeroUsuario> numeroUno)
{
    Console.WriteLine("El numero es mayor que 10");
}
else if (numeroUsuario<numeroUno)
{
    Console.WriteLine("El numero es menor que 10");
}
else
{
    Console.WriteLine("El numero es igual que 10");
}
// ● Declara dos variables double, realiza suma, resta, multiplicación y división, y muestra los
// resultados.
double num1 = 12.5;
double num2 = 10.26;
double sum = num1 + num2;
double rest = num1 - num2;
double multi = num1 * num2;
double div = num1 / num2;
Console.WriteLine("las operaciones entre ambos numeros double son: ");
Console.WriteLine("suma: "+sum);
Console.WriteLine("resta: "+rest);
Console.WriteLine("multiplicacion: "+multi);
Console.WriteLine("division: "+div);
// ● Declarar dos variables string, concatenarlas y mostrar el resultado.
string palabra1 = "hola lider ";
string palabra2 = "como se encuentra hoy";
Console.WriteLine(palabra1+palabra2);
// ● Declara una variable int, conviértela a double y muestra ambos valores.
int variableEntera = 500;
double variableDouble =(double)variableEntera;
Console.WriteLine("la variable entera es: "+variableEntera+" y la variable double es: "+variableDouble);
// ● Escribe un programa que pida al usuario un número y muestre si es positivo, negativo o
// cero.
Console.WriteLine("ingrese un numero entero: ");
int numeroEs =int.Parse(Console.ReadLine()); 
if (numeroEs >0)
{
    Console.WriteLine("el numero es positivo: ");
}   
else
{
    Console.WriteLine("el numero es negativo: ");
}
// ● Usa un bucle for para imprimir los números del 1 al 10.
for (int numeros = 1; numeros < 11; numeros++)
{
    Console.WriteLine(numeros);
}
// ● Elimina los espacios en blanco al inicio y al final de un string, y formatea el string para que
// empiece con mayúscula y el resto en minúsculas.
string mensaje = "   hola querida ";
string mensaje_sin_espacios = mensaje.Trim();
string mensaje_con_inicial_mayuscula = char.ToUpper(mensaje_sin_espacios[0]) + mensaje_sin_espacios.Substring(1);
Console.WriteLine(mensaje_con_inicial_mayuscula);

// ● Escribe un programa que pida al usuario un número y muestre su tabla de multiplicar del 1
// al 10.
Console.WriteLine("ingrese un numero entero positivo: ");
int numero_Multi= int.Parse(Console.ReadLine());
for (int i = 0; i < 11; i++)
{
    Console.WriteLine(numero_Multi + "X" + i + "=" + i*numero_Multi);
}
// ● Concatena dos strings y muestra la longitud de cada uno.
string texto1 = "hola mundo";
string texto2 = "como estas";
Console.WriteLine("el texto uno tiene "+texto1.Length + " palabras");
Console.WriteLine("el texto dos tiene " + texto2.Length+ " palabras");
// ● Extrae una subcadena de un string y muestra la subcadena y su longitud.
string cadena = "hello word, whats up";
string subcadena = cadena.Substring(3,5);
Console.WriteLine("la subcadena es: "+subcadena+ " con longitud de: "+ subcadena.Length);

