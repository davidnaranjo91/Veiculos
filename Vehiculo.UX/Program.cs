using Vehiculos.Logic;

var auto1 = new Vehiculo() {
    Marca: "Mazda",
    Modelo: "323",
    Anio = 1991,
};

var auto2 = new Vehiculo() {
    Marca: "Toyota",
    Modelo: "Yaris",
    Anio = 2010,
};

var autos = new Vehiculo[] {auto1, auto2};


foreach( var i in autos)
{
    Console.WriteLine(i);
}

