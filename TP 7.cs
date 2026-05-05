// Ejercicio 1
int N;
Console.WriteLine("Ingrese un numero");
string numero = Console.ReadLine();
N = Convert.ToInt32(numero);
bool EsPrimo = N > 1;
for (int i = 2; i * i <= N && EsPrimo; i++)
{
    if (N % i == 0)
    {
        EsPrimo = false;
        Console.WriteLine("El numero " + N + ", no es primo");
    }
    else
    {
        EsPrimo = true;
        Console.WriteLine("El numero " + N + ", es primo");
    }
}
// Ejercicio 2

Console.WriteLine("Ingrese un numero no negativo");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0)
{
    Console.WriteLine("El numero que a puesto es negativo");
}
int factorial = 1;
for (int i = 1; i <= x; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);

// Ejercicio 3
int j = 0;
int k = 1;
int l;
Console.WriteLine("Ingrese un numero");
int numero1 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < numero1; i++)
{
    Console.WriteLine(j);
    l = j;
    j = k;
    k = l + j;

}

// Ejercicio 4

Console.WriteLine("Ingrese una accion");
Console.WriteLine("1. Saludar | 2. Despedirse | 3. Finalizar");
string e = Console.ReadLine();
switch (e)
{
    case "Saludar":
        Console.WriteLine("hola");
        break;
    case "Despedirse":
        Console.WriteLine("chau");
        break;
    case "Finalizar":
        Console.WriteLine("Tarea Finalizada");
        break;
}