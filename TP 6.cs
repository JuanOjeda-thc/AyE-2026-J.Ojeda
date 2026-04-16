string ejercicio1() {
    Console.WriteLine("Escriba un numero para saber si es positivo o negativo");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero > 0) {
        return "El numero es positivo";
    } else if (numero < 0) {
        return "El numero es negativo";
    } else {
        return "El numero es cero";
    }
}
string ejercicio2()
{
    Console.WriteLine("Escriba su edad para saber si es mayor de edad");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad >= 18)
    {
        return "Eres mayor de edad";
    }
    else
    {
        return "Eres menor de edad";
    }
}
string ejercicio3()
{
    Console.WriteLine("Escriba un numero para saber si es par o impar");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 == 0)
    {
        return "El numero es par";
    }
    else
    {
        return "El numero es impar";
    }
}
string ejercicio4()
{
    Console.WriteLine("Escriba un numero para saber si es divisible por 3");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 3 == 0)
    {
        return "El numero es divisible por 3";
    }
    else
    {
        return "El numero no es divisible por 3";
    }
}
string ejercicio5()
{
    Console.WriteLine("Escriba un numero para saber si es divisible por 5");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 5 == 0)
    {
        return "El numero es divisible por 5";
    }
    else
    {
        return "El numero no es divisible por 5";
    }
}

Console.WriteLine("Escriba un numero");
Console.WriteLine("1. Ejercicio 1");
Console.WriteLine("2. Ejercicio 2");
Console.WriteLine("3. Ejercicio 3");
Console.WriteLine("4. Ejercicio 4");
Console.WriteLine("5. Ejercicio 5");
Console.WriteLine("0. Salir");
int ejercicio = Convert.ToInt32(Console.ReadLine());

switch (ejercicio) {
    case 1:
        Console.WriteLine(ejercicio1());
        break;
    case 2:
        Console.WriteLine(ejercicio2());
        break;
    case 3:
        Console.WriteLine(ejercicio3());
        break;
    case 4:
        Console.WriteLine(ejercicio4());
        break;
    case 5:
        Console.WriteLine(ejercicio5());
        break;
    case 0:
        Console.WriteLine("Saliendo del programa");
        break;
    default:
        Console.WriteLine("Numero no valido");
        break;
}