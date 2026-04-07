//Ejercicio 1
int codigo = 1948;

while (codigo != 1948)
{
    Console.WriteLine("Ingrese el código de acceso:");
    codigo = int.Parse(Console.ReadLine());

    if (codigo != 1948)
    {
        Console.WriteLine("Código incorrecto. Intente nuevamente.");
    }
    else {
        Console.WriteLine("Código correcto. Acceso concedido.");
    }
}