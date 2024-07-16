using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase CuentaBancaria con propiedades Titular y Saldo.
public class CuentaBancaria{
    public string Titular {get;set;}
    public double Saldo {get;set;}


    //Añade un método Depositar(double cantidad) que incremente el saldo.
    public void Depositar(double cantidad){
        this.Saldo+=cantidad;//aqui se incrementa
    }
//Añade un método Retirar(double cantidad) a la clase CuentaBancaria que disminuya el saldo si hay fondos suficientes.

    public void Retirar(double cantidad){
        if(Saldo>0){
            this.Saldo-=cantidad;
        }
    }
    
}
