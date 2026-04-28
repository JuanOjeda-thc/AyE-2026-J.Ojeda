Console.WriteLine("Ingrese un número entero no negativo:");
int x = Convert.ToInt32(Console.ReadLine());
int intentos = 0;
const int maxIntentos = 3;

while (intentos < maxIntentos)
{
    intentos++;
    if (intentos < maxIntentos)
    {
        Console.WriteLine($"Entrada inválida. Le quedan {maxIntentos - intentos} intento(s). Por favor, ingrese un número entero no negativo:");
        x = Convert.ToInt32(Console.ReadLine());
       
        if (x >= 0)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Ha excedido el número máximo de intentos. El programa se cerrará.");
        return; 
    }
}

int factorial = 1;
for (int i = 1; i <= x ; i++)
{
    factorial *= i;
}
Console.WriteLine($"{factorial}");