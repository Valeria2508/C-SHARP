using POO_abract1.models;
// //estamos usando la clase padre
// var primerAnimal = new Animal(1,"bruno", 14, "golden" );
// Console.WriteLine(primerAnimal);

// //estamos usando la clase hijo
// var segundoAnimal = new Perro(2,"mia",7,"gata", true);

var empleado1 = new Empleado("vale", 21, "coder", 1200);
empleado1.MostrarInformacion();

Console.WriteLine(Conversor.ConvertirFahrenheitACelsius());