//Ejercicio 3

int secreto = 7;

Console.WriteLine("Adivina el número secreto entre 1 y 10");
while (secreto != 7) ;
{
    Console.WriteLine("Escriba el numero secreto!.");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (secreto == 7) ;
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
    }
    else
    {
        Console.WriteLine("¡Inténtalo de nuevo!");
    }
}
