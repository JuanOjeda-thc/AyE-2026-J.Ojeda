//Ejercicio 1
Console.WriteLine("cuantas horas trabajo esta semana?");
int horas = Convert.ToInt32(Console.ReadLine());

if (horas < 40)
{
    int salario = horas * 16;
    Console.WriteLine("El salario semanal es: " + salario);
}
else if (horas == 40)
{
    int salario = horas * 16;
    Console.WriteLine("El salario semanal es: " + salario);
}
else
{
    int salario = (40 * 16) + ((horas - 40) * 20);
    Console.WriteLine("El salario semanal es: " + salario);
}
//ejercicio 2

//no termine de entender el ejercicio

//ejercicio 3

Console.WriteLine("Ingrese una palabra");
string palabra = Console.ReadLine();

    int contadorVocales = 0;
    foreach (char letra in palabra)
    {
        if ("aeiouAEIOU".Contains(letra))
        {
            contadorVocales++;
        }
    }
    Console.WriteLine("La cantidad de vocales en la palabra es: " + contadorVocales);

//ejercicio 4

Console.WriteLine("ingrese una palabra");
string palabra2 = Console.ReadLine();
   
    string palabraReversa = new string(palabra2.Reverse().ToArray());
    if (palabra2.Equals(palabraReversa, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("La palabra es un palíndromo.");
    }
    else
    {
        Console.WriteLine("La palabra no es un palíndromo. intente otra vez");
    }

