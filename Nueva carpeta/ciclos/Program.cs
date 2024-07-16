// // ciclos
// for (int i = 0; i<10; i++)
// {
//     Console.WriteLine("hola mundo");
// }

// //ciclos foreach

// bool bandera = true;
// while (bandera)
// {
//     Console.WriteLine("sigue adelante");
//     Console.WriteLine("quieres repetir las repeticiones=>");
//     string? respuesta = Console.ReadLine();
//     if (respuesta?.ToLower() == "no")
//     {
//         bandera = false;
//     }  
// }




// 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.
// for (int i = 1; i < 100; i++)
// {
//     Console.WriteLine(i);
// }



// 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números pares desde 1 hasta ese número usando un ciclo for.
// Console.WriteLine("ingrese un numero");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= numero; i++){
//     if (i %2 ==0)
//     {
//         Console.WriteLine(i);
//     }
// }


// 3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
// multiplicar de ese número del 1 al 10 usando un ciclo for.
// Console.WriteLine("ingrese un numero");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < 11; i++){
//     Console.WriteLine(numero + " x " + i + " = " +numero*i);
// }


// 4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
// adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
// alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
// adivine correctamente usando un ciclo do-while.





// 5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
// números impares desde ese número hasta 1 usando un ciclo while.

// Console.WriteLine("ingrese un numero");
// int numero = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= numero; i++){
//     if (i %3 ==0)
//     {
//         Console.WriteLine(i);
//     }
// }


// 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
// es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
// usando un ciclo while.




// 7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
// secuencia de Fibonacci hasta ese número usando un ciclo for.



// 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
// número es primo o no usando un ciclo for.

Console.WriteLine("ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < numero; i++){
    if (numero % i == 0)
    {
        Console.WriteLine("el numero no es primo");
    }
    else{
        Console.WriteLine("el numero es primo");
    }
}




Console.WriteLine("Ingrese un numero:");
int numero = Convert.ToInt32(Console.ReadLine());

bool esPrimo = true;

if (numero <= 1)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
}

if (esPrimo)
{
    Console.WriteLine("El numero es primo");
}
else
{
    Console.WriteLine("El numero no es primo");
}

// 9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
// palabra en una línea separada usando un ciclo foreach.


// 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
// de todos los números desde 1 hasta ese número usando un ciclo for
