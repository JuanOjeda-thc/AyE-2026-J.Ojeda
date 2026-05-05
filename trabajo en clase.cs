// EJERCICIO 1
Console.WriteLine("");
Console.WriteLine("Ejercicio 1");
Console.WriteLine("");
Console.WriteLine("Ingrese 0 o 1");
int num = int.Parse(Console.ReadLine());
while (num == 0 && num == 1)
{
    Console.WriteLine("Ya estas adentro del while");
}
Console.WriteLine("Numero incorrecto");

// EJERCICIO 2
Console.WriteLine("");
Console.WriteLine("Ejercicio 2");
Console.WriteLine("");
Console.WriteLine("Ingrese un numero de dos cifras");
int num1 = int.Parse(Console.ReadLine());
while (num1 <= 9)
{
    Console.WriteLine("Numero incorrecto");
    break;
}
if (num1 >= 10)
{
    Console.WriteLine("Bien, Ingresaste un numero de dos cifras");
}
else
{
    Console.WriteLine("Numero Incorrecto");
}