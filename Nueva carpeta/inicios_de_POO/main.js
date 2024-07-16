let persona={
    nombre: "Juan",
    apellido: "Pérez",
    edad: 25,
    saludar: function(){
        console.log(`Hola, mi nombre es ${this.nombre} ${this.apellido} y tengo ${this.edad} años.`);
    }
}