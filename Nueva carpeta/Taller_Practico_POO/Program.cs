//1. Crear una clase básica y un objeto de esa clase.
using Taller_Practico_POO.models;

//2. Utilizar un constructor para inicializar un objeto.
var persona1 = new Personas("valeria", "perez", 21);
persona1.Saludar();

// 3.Utilizar propiedades para acceder a los campos de una clase
Console.WriteLine($@"
    Nombre: {persona1.Nombre} 
    Apellido: {persona1.Apellido}
    Edad: {persona1.Edad} años
    ");

//4. Crear y utilizar métodos dentro de una clase.
persona1.Saludar();

//5. Crear una clase Estudiante con propiedades para nombre, edad y matrícula. Crear una lista 
// de estudiantes y agregar varios estudiantes a la lista. Mostrar los detalles de cada 
// estudiante.


Estudiante PedirDatos()
{

    Console.WriteLine("Ingrese el nombre del estudiante");
    var nombreEstudiante = Console.ReadLine();
    Console.WriteLine("Ingrese la edad del estudiante");
    var edadEstudiante = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la matricula del estudiante");
    var matriculaEstudiante = Console.ReadLine();

    return new Estudiante(nombreEstudiante, edadEstudiante, matriculaEstudiante);
}

Estudiante.AgregarEstudiantes(PedirDatos());
Estudiante.AgregarEstudiantes(PedirDatos());
Estudiante.MostrarEstudiantes();

//6. Crear una clase Habitacion y una clase Reserva. La clase Habitacion debe tener propiedades 
// como número de habitación y tipo. La clase Reserva debe tener propiedades como fecha 
// de inicio, fecha de fin y la habitación reservada


//7. Crear una clase Prenda con propiedades para nombre, talla y precio. Crear una clase Tienda 
// que gestione una colección de prendas y permita agregar y buscar prendas. 
