//condicional simple
// Console.WriteLine("ingrese su edad: "); //Console.WriteLine solo recibe string
// byte edad = Convert.ToByte(Console.ReadLine());
// if (edad >= 18)
// {
//     Console.WriteLine("eres legal");
// }


// condicional normal
// if (edad >= 18) //true
// {
//     Console.WriteLine("eres menor de edad");
// }
// else
// {
//     Console.WriteLine("eres menos de edad");
// }

//condicional compuesta
// if (edad >= 18)
// {
//     Console.WriteLine("eres legal");
// }
// else if(edad >= 12 && edad < 18)
// {
//     Console.WriteLine("eres un adolescente");
// }
// else
// {
//     Console.WriteLine("eres menor de edad ");
// }


// Console.WriteLine("ingresa tu numero del 1al 7");//pedimos al usuario un dato
// byte numero = Convert.ToByte(Console.ReadLine()); //lo tipeamos y lo guardamos en variable

// como hacer un switch para dias de la semana 
// switch (numero)
// {
//     case 1:
//         Console.WriteLine("elegiste el dia lunes");
//         break;
//      case 2:
//         Console.WriteLine("elegiste el dia martes");
//         break;
//     case 3:
//         Console.WriteLine("elegiste el dia miercoles");
//         break;
//     case 4:
//         Console.WriteLine("elegiste el dia jueves");
//         break;
//     case 5:
//         Console.WriteLine("elegiste el dia viernes");
//         break;
//     case 6:
//         Console.WriteLine("elegiste el dia sabado");
//         break;
//     default:
//         Console.WriteLine("elegiste el dia domingo");
//         break;
// }



// 1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando
// una condición if.
// Console.WriteLine("ingrese un numero entero");
// byte numero_Entero = Convert.ToByte(Console.ReadLine());

// if (numero_Entero % 2 ==0)
// {
//     Console.WriteLine("el numero es par");
// }
// else
// {
//     Console.WriteLine("el numero es impar");
// }



// 2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
// nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
// bienvenida; de lo contrario, muestra un mensaje de error.

// Console.WriteLine("ingrese su nombre");
// string name = Console.ReadLine();

// if ( string.IsNullOrWhiteSpace(name)) // validar que un campo no este vacio o nulo
// {
//     Console.WriteLine("ingresa un nombre valido");
    
// }
// else
// {
//     Console.WriteLine("bienvenido "+ name);
// }



// 3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
// usando if-else.
// Console.WriteLine("ingresa tu edad: ");
// byte edadUsuario = Convert.ToByte(Console.ReadLine());
// if (edadUsuario >= 18)
// {
//     Console.WriteLine("eres mayor de edad ");
// }
// else
// {
//     Console.WriteLine("eres menor de edad ");
// }



// 4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
// muestre el nombre del día correspondiente usando switch.
// Console.WriteLine("ingresa tu numero del 1al 7");//pedimos al usuario un dato
// byte numero = Convert.ToByte(Console.ReadLine()); //lo tipeamos y lo guardamos en variable
// switch (numero)
// {
//     case 1:
//         Console.WriteLine("elegiste el dia lunes");
//         break;
//      case 2:
//         Console.WriteLine("elegiste el dia martes");
//         break;
//     case 3:
//         Console.WriteLine("elegiste el dia miercoles");
//         break;
//     case 4:
//         Console.WriteLine("elegiste el dia jueves");
//         break;
//     case 5:
//         Console.WriteLine("elegiste el dia viernes");
//         break;
//     case 6:
//         Console.WriteLine("elegiste el dia sabado");
//         break;
//     default:
//         Console.WriteLine("elegiste el dia domingo");
//         break;
// }




// 5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
// decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con
// operador ternario)
// Console.WriteLine("ingresa tu pais de nacionalidad");
// string pais = Console.ReadLine();
// pais= (pais == "Colombia") ? "eres colombiano" :"eres extranjero";
// Console.WriteLine(pais);



// 6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando
// if-else.
// Console.WriteLine("digite un numero");
// byte num1 = Convert.ToByte(Console.ReadLine());

// Console.WriteLine("digite un numero");
// byte num2 = Convert.ToByte(Console.ReadLine());

// Console.WriteLine("digite un numero");
// byte num3 = Convert.ToByte(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//   Console.WriteLine("el numero  " + num1+  " es mayor");  
// }
// else if (num2 > num1 && num2 > num3)
// {
//     Console.WriteLine("el numero  " + num2+  " es mayor"); 
// }
// else
// {
//     Console.WriteLine("el numero " + num3+  " es mayor"); 
// }




// 7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
// contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
// indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
// que la contraseña no puede estar en blanco.
//  Console.WriteLine("ingrese una contraseña");
// string pass = Console.ReadLine();

// if ( string.IsNullOrWhiteSpace(pass)) // validar que un campo no este vacio o nulo
// {
//     Console.WriteLine("la contraseña no puede estar en blanco");
    
// }
// else
// {
//     Console.WriteLine("la contraseña es aceptada ");
// }




// 8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del
// mes correspondiente usando switch.
// Console.WriteLine("ingresa tu numero del 1al 12");//pedimos al usuario un dato
// byte numero_mes = Convert.ToByte(Console.ReadLine()); //lo tipeamos y lo guardamos en variable
// switch (numero_mes)
// {
//     case 1:
//         Console.WriteLine("enero");
//         break;
//      case 2:
//         Console.WriteLine("febrero");
//         break;
//     case 3:
//         Console.WriteLine("marzo");
//         break;
//     case 4:
//         Console.WriteLine("abril");
//         break;
//     case 5:
//         Console.WriteLine("mayo");
//         break;
//     case 6:
//         Console.WriteLine("junio");
//         break;
//     case 7:
//         Console.WriteLine("julio");
//         break;
//     case 8:
//         Console.WriteLine("agosto");
//         break;
//     case 9:
//         Console.WriteLine("septiembre");
//         break;
//     case 10:
//         Console.WriteLine("octubre");
//         break;
//     case 11:
//         Console.WriteLine("noviembre");
//         break;
//     default:
//         Console.WriteLine("diciembre");
//         break;
// }



// 9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra
// correspondiente (A, B, C, D, F) usando if-else.
// Console.WriteLine("ingresa su calificacion tipo numerica entero del 1 al 5");
// byte nota = Convert.ToByte(Console.ReadLine());

// switch (nota)
// {
    
//     case 1:
//         Console.WriteLine("su nota es A");
//         break;
//     case 2:
//         Console.WriteLine("su nota es B");
//         break;
//     case 3:
//         Console.WriteLine("su nota es C");
//         break;
//     case 4:
//         Console.WriteLine("su nota es D");
//         break;
//     case 5:
//         Console.WriteLine("su nota es F");
//         break;
// }




// 10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
// consonante usando switch.
// Console.WriteLine("ingresa una letra");
// string letra = Console.ReadLine().ToLower();

// switch (letra)
// {
//     case "a":
//         Console.WriteLine("es vocal");
//         break;
//     case "e":
//         Console.WriteLine("es vocal");
//         break;   
//     case "i":
//         Console.WriteLine("es vocal");
//         break;
//     case "o":
//         Console.WriteLine("es vocal");
//         break;
//     case "u":
//         Console.WriteLine("es vocal");
//         break;
//     default:
//         Console.WriteLine("es consonante");
//         break;

// }



// 11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
// usando if-else.
// Console.WriteLine("ingresa un numero");
// byte n1 = Convert.ToByte(Console.ReadLine());

// Console.WriteLine("ingresa un numero");
// byte n2 = Convert.ToByte(Console.ReadLine());

// if (n1 != n2)
// {
//     Console.WriteLine("los numeros son diferentes");
// }
// else
// {
//     Console.WriteLine("los numeros son iguales");
// }

// 12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
// no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida,
// muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.

//  Console.WriteLine("ingrese su direccion");
// string direccion = Console.ReadLine();

// if ( string.IsNullOrWhiteSpace(direccion)) // validar que un campo no este vacio o nulo
// {
//     Console.WriteLine("la direccion no puede estar en blanco");
    
// }
// else
// {
//     Console.WriteLine("la direccion es aceptada ");
// }




// 13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
// cero usando if-else.
// Console.WriteLine("ingrese un numero entero");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero > 0)
// {
//     Console.WriteLine("el numero es positivo");
// }
// else if (numero < 0)
// {
//     Console.WriteLine("el numero es negativo");
// }
// else
// {
//     Console.WriteLine("el numero es cero");
// }




// 14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando
// if-else.

// Console.WriteLine("ingresa una letra");
// char letra = Convert.ToChar(Console.ReadLine().ToLower());

// if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
// {
//     Console.WriteLine("es una vocal");
// }
// else if (char.IsLetter(letra))
// {
//     Console.WriteLine("es una consonante");
// }
// else{
//     Console.WriteLine("dato no valido");
// }




// 15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
// es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.




// 16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
// if-else.
// 17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
// no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
// muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.
// 18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
// laborable o de fin de semana usando switch.