using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;
//Crea una clase Producto con propiedades Nombre y Precio.

public class Producto{
    public string Nombre {get; set;}
    public int Precio {get;set;}
    
//Añade métodos GetNombre() y SetNombre(string nombre) a la clase Producto para acceder y modificar el nombre.
    public string GetNombre(){
        return Nombre;
    }

    public void SetNombre(string nombre){
        this.Nombre=nombre;
    }
}