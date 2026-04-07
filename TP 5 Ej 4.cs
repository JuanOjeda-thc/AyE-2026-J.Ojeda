// Ejercicio 4
int suma = 0;
int numero;

Console.WriteLine("Ingrese un número");
Console.WriteLine("Ingrese el número 0 para finalizar");
numero = Convert.ToInt32(Console.ReadLine());
suma = suma + numero;
while (numero != 0)
{
    Console.WriteLine(numero);
    numero = Convert.ToInt32(Console.ReadLine());
    suma = suma + numero;
}
Console.WriteLine("La suma total es: ");
Console.Write(suma);