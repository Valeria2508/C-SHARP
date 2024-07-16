// 1. Filtra los números mayores a 10 en una lista de enteros.
List<int> numEnteros = new(){-5,-12,5,10,15,20};
Console.WriteLine("punto 1");
var resultado1 = numEnteros.Where(num => num >10);
foreach (var num in resultado1)
{
    Console.WriteLine(num);
}
// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.
Console.WriteLine("punto 2");
var resultado2 = numEnteros.Select(num=> Math.Pow(num,2));
foreach (var num in resultado2)
{
    Console.WriteLine(num);
}


// 3. Ordena alfabéticamente una lista de nombres.
Console.WriteLine("punto 3");
List<string> nombres = new(){"nora","andrea","lorena","berto","carla"};
var resultado3 = nombres.OrderBy(nombre=> nombre);
foreach (var nombre in resultado3)
{
    Console.WriteLine(nombre);
}

// 4. Ordena una lista de precios de mayor a menor.
Console.WriteLine("punto 4");
List<double> price = new(){4500,2000,3200,1000,8600};
var resultado4 = price.OrderBy(precio=>precio);
foreach (var precio in resultado4)
{
    Console.WriteLine(precio);
}
// 5. Encuentra el primer número par en una lista de enteros.
Console.WriteLine("punto 5");
var resultado5 = numEnteros.First(num => num %2==0);
Console.WriteLine(resultado5);
// 6. Encuentra el último nombre en una lista de nombres.
Console.WriteLine("punto 6");
var resultado6 = nombres.Last();
Console.WriteLine(resultado6);
// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay
// ninguno.
Console.WriteLine("punto 7");
var resultado7 = numEnteros.FirstOrDefault(num=>num<0 );
Console.WriteLine(resultado7);
// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si
// no hay ninguno.
Console.WriteLine("punto 8");
var resultado8 = numEnteros.LastOrDefault(num=>num>50 );
Console.WriteLine(resultado8);

// 9. Verifica si algún elemento en una lista de booleanos es verdadero.
Console.WriteLine("punto 9");
List<bool> ListBool = new(){true,false,true,false};
var resultado9 = ListBool.Any(value=>value==true);
Console.WriteLine(resultado9);
// 10. Verifica si todos los elementos en una lista de números son mayores a 0.
Console.WriteLine("punto 10");
var resultado10 = numEnteros.All(num=>num > 0);
Console.WriteLine(resultado10);

// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".
Console.WriteLine("punto 11");
var resultado11= nombres.Contains("LINQ");
Console.WriteLine(resultado11);

// 12. Cuenta cuántos números pares hay en una lista de enteros.
Console.WriteLine("punto 12");
var resultado12 = numEnteros.Count(num=> num%2==0);
Console.WriteLine(resultado12);

// 13. Calcula la suma de los elementos en una lista de precios.
Console.WriteLine("punto 13");
var resultado13 = price.Sum();
Console.WriteLine(resultado13);
// 14. Calcula el promedio de una lista de edades.
Console.WriteLine("punto 14");
List<int> ededes = new(){5,12,5,10,15,20};
var resultado14 = ededes.Average();
Console.WriteLine(Math.Round(resultado14,0));
// 15. Encuentra el número mínimo en una lista de temperaturas.
Console.WriteLine("punto 15");
List<int> temperatura = new(){30,20,10};
var resultado15 = temperatura.Min();
Console.WriteLine(resultado15);
// 16. Encuentra el número máximo en una lista de alturas.
Console.WriteLine("punto 16");
List<int> altura = new(){50,200,10};
var resultado16 = altura.Max();
Console.WriteLine(resultado16);

// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.
Console.WriteLine("punto 17");
List<int> puntuacion = new(){5,4,3,2,1,6,8,10};
var resultado17 = puntuacion.Take(5);
foreach (var puntu in resultado17)
{
    Console.WriteLine(puntu);
    
}

// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
Console.WriteLine("punto 18");
var resultado18 = nombres.Skip(3);
foreach (var nom in resultado18)
{
    Console.WriteLine(nom);
}

// 19. Elimina los elementos duplicados en una lista de números.
Console.WriteLine("punto 19");
List<int> numDuplicados = new(){5,5,2,10,5,5};
var resultado19 = numDuplicados.Distinct();
foreach (var num in resultado19)
{
    Console.WriteLine(num);
}
// 20. Convierte una lista de palabras en una array.


// 21. Convierte una lista de números en un array.
// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// 25. Obtén los nombres más largos en una lista de nombres.
// 26. Encuentra el primer número mayor a 100 en una lista de precios.
// 27. Encuentra el último día del mes en una lista de fechas.
// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por
// defecto si no hay ninguno.
// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay
// ninguno.
// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// 31. Verifica si todas las edades en una lista son mayores de 18.
// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// 34. Calcula la suma de los números positivos en una lista de enteros.
// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.
// 36. Encuentra la temperatura mínima en una lista de temperaturas.
// 37. Encuentra la altura máxima en una lista de alturas.
// 38. Obtén los primeros 10 elementos de una lista de productos.
// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.
