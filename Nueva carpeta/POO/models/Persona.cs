using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models;
public class Persona{
    public int Id{get;set;}
    public string? Nombre{get;set;}
    public string? FechaNacimiento{get;set;}//dateonly solo es para que muestre el dia 
    public string? Genero {get;set;}
    public string? Nacionalidad {get;set;}
    public int? Telefono{get;set;}
    public string? Correo{get;set;}

    public Persona(string nombre,string fechaNacimiento, string genero, string nacionalidad, int telefono, string correo)
    {
        this.Nombre=nombre;
        this.FechaNacimiento= fechaNacimiento;
        this.Genero=genero;
        this.Nacionalidad=nacionalidad;
        this.Telefono=telefono;
        this.Correo=correo;
    }

    public void Saludar(){ //funcion void es que no retorna nada
        Console.WriteLine("hola, mi nombre es "+Nombre);
    
    }


    public void Despedirse(){
        Console.WriteLine("adios, mi nombre fue "+Nombre);
    }

    // public int Suma(){ //funcion con tipo de dato que reemplaza void, retorna algo
    //     int n1=20;
    //     int n2=10;
    //     int suma=n1+n2;
    //     return suma;
    // }
}

