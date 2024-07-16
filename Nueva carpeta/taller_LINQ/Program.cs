List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// ● Filtrar y mostrar solo los números pares de la lista numbers.
Console.WriteLine(" mostrar solo los números pares de la lista numbers.");
var numPares = numbers.Where(num => num%2==0);

foreach (var num in numPares)
{
    Console.WriteLine(num);
}

// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
Console.WriteLine("calcular la suma de todos los números impares en la lista numbers.");
var sumaNumImpares = numbers.Where(num => num %2 != 0);
Console.WriteLine(sumaNumImpares.Sum());

// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
Console.WriteLine("Ordenar de manera descendente los números mayores que 5 en la lista numbers.");
var ordenNumDesc = numbers.Where(num => num > 5).OrderByDescending(num => num).ToList();
foreach (var num in ordenNumDesc)
{
    Console.WriteLine(num);
}
// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
Console.WriteLine("Contar cuántos números son menores o iguales a 3 en la lista numbers.");
var calcularNumeros = numbers.Count(num => num <= 3);
Console.WriteLine(calcularNumeros);
// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
Console.WriteLine("Seleccionar cada número en la lista numbers y multiplicarlo por 2.");
var multiPorDos = numbers.Select(num => num * 2);
foreach (var num in multiPorDos)
{
    Console.WriteLine(num);
}


//////////////////////////////////////////////////////////////////////////////////////////////////////////

List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David","Eve" };

// ● Ordenar los nombres en la lista names alfabéticamente.
Console.WriteLine("Ordenar los nombres en la lista names alfabéticamente.");
var ordenAlfa = names.OrderBy(nom=>nom);
foreach (var nom in ordenAlfa)
{
    Console.WriteLine(nom);
}
// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
Console.WriteLine("Seleccionar los nombres en la lista names que empiezan con la letra 'A'.");
var nombreA = names.Where(nom => nom.StartsWith("A"));
foreach (var nom in nombreA)
{
    Console.WriteLine(nom);
}

// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
Console.WriteLine("Contar cuántos nombres en la lista names tienen más de 5 caracteres.");
var nombresCaracter = names.Where(nom => nom.Length>5);
foreach (var nom in nombresCaracter)
{
    Console.WriteLine(nom);
}
// ● Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.
Console.WriteLine("Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.");
var concatenar = string.Join(" ",names);
Console.WriteLine(concatenar);
// ● Encontrar y mostrar el nombre más largo en la lista names.
Console.WriteLine("Encontrar y mostrar el nombre más largo en la lista names.");
var nombreLargo = names.OrderByDescending(nom => nom.Length).FirstOrDefault();
Console.WriteLine(nombreLargo);

//////////////////////////////////////////////////////////////////////////////////////////////////////////

List<string> words = new List<string> { "apple", "banana", "cherry", "date","elderberry" };
// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
Console.WriteLine("Verificar si todas las palabras en la lista words tienen más de 3 caracteres.");
bool palabrasTresCaracteres = words.All(w => w.Length>3);
Console.WriteLine(palabrasTresCaracteres);
// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
Console.WriteLine("Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.");
var primeraPalabra = words.Where(w => w.StartsWith("b"));
foreach (var w in primeraPalabra)
{
    Console.WriteLine(w);
}

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
Console.WriteLine("Contar cuántas palabras en la lista words contienen la letra 'e'.");
var palabrasWord = words.Count(w => w.Contains("e"));
Console.WriteLine(palabrasWord + " palabras");
// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
Console.WriteLine("Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.");
var mayusculas = words.Select(w => w.ToUpper());
foreach (var w in mayusculas)
{
    Console.WriteLine(w);
}
// ● Verificar si alguna palabra en la lista words termina con la letra 'y'.
Console.WriteLine("Verificar si alguna palabra en la lista words termina con la letra 'y'.");
bool terminaY = words.Any(w => w.EndsWith("y"));
Console.WriteLine(terminaY);

//////////////////////////////////////////////////////////////////////////////////////////////////////////

List<int> data = new List<int> { 2, 5, 1, 6, 3, 8, 4, 7, 9 };
List<int> moreData = new List<int> { 10, 12, 15, 11, 14, 13 };

// ● Combinar y ordenar las listas data y moreData de forma ascendente.}
Console.WriteLine("Combinar y ordenar las listas data y moreData de forma ascendente.");
var dosListas = data.Concat(moreData).OrderBy(n => n);
foreach (var n in dosListas)
{
    Console.WriteLine(n);
}

// ● Calcular la suma de todos los números pares en la lista data.
Console.WriteLine("Calcular la suma de todos los números pares en la lista data.");
var suma = data.Where(n => n % 2 == 0).Sum();
Console.WriteLine("Suma de números pares en data: " + suma);

// ● Encontrar el número más grande en la lista data.
Console.WriteLine("Encontrar el número más grande en la lista data.");
var numeroGrande = data.OrderByDescending(n => n).FirstOrDefault();
Console.WriteLine("Número más grande en data: " + numeroGrande);
//, ● Unir las listas data y moreData, eliminando los elementos duplicados.
Console.WriteLine("Unir las listas data y moreData, eliminando los elementos duplicados.");
var unidos = data.Union(moreData).Distinct();
Console.WriteLine("Unidos sin duplicados: ");
foreach (var item in unidos)
{
    Console.WriteLine(item);
}
// ● Calcular el promedio de la lista moreData y seleccionar los números en data que son
// mayores que ese promedio.
Console.WriteLine("Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.");
var promedioMoreData = moreData.Average();
var mayoresPromedio = moreData.Where(n => n > promedioMoreData);
Console.WriteLine("Números en data mayores que el promedio de moreData: ");
foreach (var numero in mayoresPromedio)
{
    Console.WriteLine(numero);
}
// ● Contar cuántos números en la lista moreData son números primos(te recomiendo crear
// una función independiente que valide si el número es primo o no lo es, luego esa funciona
// pasala al método LINQ adecuado).
Console.WriteLine(@"Contar cuántos números en la lista moreData son números primos(te recomiendo crear 
 una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al
  método LINQ adecuado).");
static bool EsPrimo(int num)
{
    if (num <= 1) return false;
    if (num <= 3) return true;
    if (num % 2 == 0 || num % 3 == 0) return false;
    int i = 5;
    while (i * i <= num)
    {
        if (num % i == 0 || num % (i + 2) == 0) return false;
        i += 6;
    }
    return true;
}
var primosMoreData = moreData.Count(n=>EsPrimo(n));
Console.WriteLine("Números en moreData que son primos: " + primosMoreData);
