using P1A.Clases;

string linea, linea1, linea2, linea3;
//carro miCarrito = new carro("Toyota", 2022, "azul");
carro EmilyCarrito = new carro("BMW", 2022, "Azul", 350);


//if (miCarrito.Modelo > EstefaniCarrito.Modelo)
//{
//    Console.WriteLine("El carro del profe es mas reciente");
//}
//else
//{
//    Console.WriteLine("El carro de Estefani es mas reciente");
//}

Console.WriteLine($"\tMi carrito es Marca {EmilyCarrito.Marca}");
Console.WriteLine($"\tModelo {EmilyCarrito.Modelo}");
Console.WriteLine($"\tDe Color {EmilyCarrito.Color}");
Console.WriteLine($"\tY con una Maxima Velocidad de {EmilyCarrito.Maxvel}");

//Encender motor
Console.WriteLine(EmilyCarrito.GetVelocidadActual());
Console.Write("Desea encender el carro? S/N: ");
linea = Console.ReadLine();

if (linea == "S")
{
    EmilyCarrito.EncenderMotor();
}



for (int i = 0; i < 5; i++)
{
    EmilyCarrito.acelerar();
}

EmilyCarrito.acelerar(3);
EmilyCarrito.acelerar(6);
EmilyCarrito.acelerar(1);

//desaleración
Console.WriteLine("\nCOMIENZA LA DESACELERACIÓN");
EmilyCarrito.desacelerar(10);
EmilyCarrito.desacelerar(5);
EmilyCarrito.desacelerar(3);
EmilyCarrito.desacelerar(1);

//frenado
Console.Write("\nDesea frenar el carro? S/N: ");
linea = Console.ReadLine();

if (linea == "S")
{
    EmilyCarrito.frenar();
}
else if (linea == "N")
{
    Console.WriteLine($"El carro sigue en marcha");
}

//apgar motor

Console.Write("\nDesea apagar el carro? S/N: ");
linea3 = Console.ReadLine();
if (linea3 == "S")
{
    EmilyCarrito.apagar();
}
else if (linea3 == "N")
{
    Console.WriteLine("El carro sigue encendido");
}

//bocinar 
Console.Write("\nDesea bocinar? S/N: ");
linea2 = Console.ReadLine();

if (linea2 == "S")
{
    EmilyCarrito.bocinar();
}
else if (linea2 == "N")
{
    Console.WriteLine("");
}

Console.WriteLine("\n\t\tGRACIAS POR UTILIZAR EL PROGRAMA!");
