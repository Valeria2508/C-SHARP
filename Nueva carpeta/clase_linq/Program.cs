// Console.Clear();
// Console.WriteLine("Hello, World!");
// Variables:

// - Cadenas (string, char)
// - Numeros (int, float, double, byte, long, decimal, unit)
// - Booleanos (true, false)

// char nombre = 'J';
// Console.WriteLine(nombre.GetType().Name);
// var frutas = new string[]{
//     "banano",
//     "pera",
//     "sandía"
// };

// frutas[1]= "fresas";

// Console.WriteLine(frutas.GetType().Name); //saber tipo de dato

// Console.WriteLine(frutas[1]); //para saber la posicion


//lista con numeros del 1 al 10 en desorden
// var numerosLista = new List<byte> {9,10,7,8,4,3,4,6,1,5};

//array con numeros del 1 al 10 en desorden
// var numerosArray = new byte[ ] {9,10,7,8,3,4,6,1,5,2};

//recorrer la lista
// foreach(var item in numerosLista)
// {
//     Console.WriteLine(item);
// }

//recorrer el array
// foreach(var item in numerosArray )
// {
//     if (item % 2 == 0)
//     {
//         Console.WriteLine(item);
//     }
// }

//lista vacia donde se guardarán solo los numeros pares
//forma iperativa
// var numerosPares = new List<byte>();
// foreach(var item in numerosArray)
// {
//     if (item % 2 == 0)
//     {
//         numerosPares.Add(item);
//     }
// }


//linq, realiza consultas a colecciones
//forma declarativa
//numeros pares con LINQ
// var numerosParesArray =numerosArray.Where(item=> item % 2==0);

//numeros duplicados con LINQ
// var numerosDuplicadosArray = numerosArray.Select(item => item*2).ToArray();

//ordenar descendentemente
// var numerosDesc = numerosArray.OrderByDescending(item => item).ToList();
// foreach (var item in numerosDesc)
// {
//     Console.WriteLine(item);
// }

//ordenar ascendente
// var numerosAscendente = numerosArray.OrderBy(item=> item).ToArray();
// foreach (var item in numerosAscendente)
// {
//     Console.WriteLine(item);
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////
 //EJEMPLO CREAR UNA LISTA
 // var numbers = new List<int>(){};
// List<string> nombres2 =new() {};

//EJEMPLO WHERE CON NOTAS
// List<double> notas = new (){4.3,5,2.6,4.2};
// double promedio = notas.Average();
// Console.WriteLine(Math.Round(promedio,2)); //para que me tenga en cuenta que tenga dos decimales




//EJEMPLO CONSULTAS EN LINQ
// PRIMERO CREARE UN ARRAY
var nombres =new string[]{
    "caro","zanti","vale","camiB","camiC"
};


//SE RECORRE PARA PODER MOSTRAR SUS ELEMENTOS
foreach (var nombre in nombres)
{
    Console.WriteLine(nombre);
}





//METODOS LINQ
//WHERE
Console.WriteLine("metodo where para buscar el nombre vale");
var result = nombres.Where(nombre=> nombre =="vale").ToList();
foreach (var nombre in result)
{
    Console.WriteLine(nombre);
}

//SELECT
Console.WriteLine("metodo select para seleccionar los nombres y que se muestren en mayuscula");
var result2 = nombres.Select(nombre=> nombre.ToUpper()).ToList();
foreach (var nombre in result2)
{
    Console.WriteLine(nombre);
}

//ORDERBY
Console.WriteLine("metodo orderby para ordenar los nombres de manera ascendente");
var result3 = nombres.OrderBy(nombre=> nombre).ToList();
foreach (var nombre in result3)
{
    Console.WriteLine(nombre);
}


//ORDERBYDescending
Console.WriteLine("metodo orderby para ordenar los nombres de manera descendente");
var result4 = nombres.OrderByDescending(nombre=> nombre).ToList();
foreach (var nombre in result4)
{
    Console.WriteLine(nombre);
}

//FIRTS
Console.WriteLine("metodo first para mostrar el primer elemento de dicha busqueda");
var result5 = nombres.First(nombre=> nombre == "camiB");
 Console.WriteLine(result5);

//GROUPBY
Console.WriteLine("Agrupa elementos que contengan la palabra 'cami'");
var result6 = nombres.GroupBy(nombre => nombre.Contains("cami"));

foreach (var group in result6)
{
    Console.WriteLine(group.Key ? "Contiene 'cami':" : "No contiene 'cami':");
    foreach (var nombre in group)
    {
        Console.WriteLine(nombre);
    }
}

//SUM
Console.WriteLine("suma todos los valores de una lista ");
var numbers = new int[]{1,5,2,4,10,8,6,3,7,9};
var result7 = numbers.Sum(num=>num);
Console.WriteLine(result7);

//AVARAGE
Console.WriteLine("promedia valores de una lista ");
var result8 = numbers.Average(num=>num);
Console.WriteLine(result8);

//COUNT     
Console.WriteLine("cuenta cuantos valores hay en la lista");
var result9 = numbers.Count();
Console.WriteLine(result9);

//FIRST
Console.WriteLine("Devuelve el primer elemento de una colección que cumple con una condición.");
var result10 = numbers.First(num=>num > 5);
Console.WriteLine(result10);

//FirstOrDefault
Console.WriteLine(" Devuelve el primer elemento de una colección que cumple con una condición, o un valor por defecto si no se encuentra ningún elemento.");
var result11 = numbers.FirstOrDefault(num=>num > 7);
Console.WriteLine(result11);

//ANY
Console.WriteLine("Determina si cualquier elemento de una colección cumple con una condición.");
var result12 = numbers.Any(num=>num > 8);
Console.WriteLine(result12);



















/*  // CREATE OTHER LIST
 var numbers = new int[]{1,5,2,4,10,8,6,3,7,9};
 //LINQ
 //WHERE
 Console.WriteLine("imprimir los numeros mayores o iguales a 4");
 var r1 = numbers.Where(num=> num >4).ToList();
 foreach (var num in r1)
 {
    Console.WriteLine(num);
 }
//WHERE
Console.WriteLine("imprimir los numeros menores a 6");
 var r2 = numbers.Where(num=> num >6).ToList();
 foreach (var num in r2)
 {
    Console.WriteLine(num);
 }
 */