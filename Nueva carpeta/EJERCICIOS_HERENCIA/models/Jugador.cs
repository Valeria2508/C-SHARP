using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_HERENCIA.models;
public class Jugador : PersonalTecnico{
    public string Posicion {get;set;}
    public double Estatura {get;set;}
    public double Peso {get;set;}
    public string ClubActual {get;set;}
    public string PielHabil {get;set;}

    public Jugador(){
        Console.WriteLine("este es el constructor de un jugador");
    }
    
    public double CalcularIMC(){
        return Peso / (Estatura*Estatura);
    }
}