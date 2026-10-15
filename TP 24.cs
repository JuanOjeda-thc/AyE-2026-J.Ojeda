using System;
using System.IO;

string rutaSalida = "trabajo.txt";

using (StreamWriter writer = new StreamWriter(rutaSalida, append: false))
{
    // Ejercicio 1
    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("Ingrese un número de dos cifras:");
    int num1 = int.Parse(Console.ReadLine());

    if (num1 >= 10 && num1 <= 99)
    {
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 2
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("Indicar un número de tres cifras:");
    int num2 = int.Parse(Console.ReadLine());

    if (num2 >= 100 && num2 <= 999)
    {
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 3
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("Indicar precio de lista:");
    int precio = int.Parse(Console.ReadLine());

    if (precio > 0)
    {
        int descuento = precio * 18 / 100;
        int final = precio - descuento;
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 4
    Console.WriteLine("Ejercicio 4");
    Console.WriteLine("Número de dos cifras:");
    int num4 = int.Parse(Console.ReadLine());

    if (num4 >= 10 && num4 <= 99)
    {
        int perm = (num4 % 10) * 10 + (num4 / 10);
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 5
    Console.WriteLine("Ejercicio 5");
    Console.WriteLine("Fecha (6 dígitos):");
    int fecha = int.Parse(Console.ReadLine());

    if (fecha >= 100000 && fecha <= 999999)
    {
        int mes = (fecha / 100) % 100;

        if (mes >= 1 && mes <= 12)
            File.AppendAllText("resultados.txt",
                "Ejercicio 1\n" +
                "Unidades: " + (num1 % 10) + "\n" +
                "Decenas: " + (num1 / 10) + "\n");
        else
            Console.WriteLine("Mes inválido");
    }
    else Console.WriteLine("Error");


    // Ejercicio 6
    Console.WriteLine("Ejercicio 6");
    Console.WriteLine("Lado del cuadrado:");
    int lado = int.Parse(Console.ReadLine());

    if (lado > 0)
    {
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 7
    Console.WriteLine("Ejercicio 7");
    Console.WriteLine("Valor por hora:");
    int valor = int.Parse(Console.ReadLine());

    Console.WriteLine("Horas trabajadas:");
    int horas = int.Parse(Console.ReadLine());

    if (valor > 0 && horas >= 0)
    {
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 8
    Console.WriteLine("Ejercicio 8");
    Console.WriteLine("Temperatura en Fahrenheit:");
    int f = int.Parse(Console.ReadLine());

    int c = (f - 32) * 5 / 9;
    File.AppendAllText("resultados.txt",
        "Ejercicio 1\n" +
        "Unidades: " + (num1 % 10) + "\n" +
        "Decenas: " + (num1 / 10) + "\n");


    // Ejercicio 9
    Console.WriteLine("Ejercicio 9");
    Console.WriteLine("Dados la hora, minutos y los segundos de dos instantes, la computadora muestra cuantos segundos contiene el intervalo que abarcan.:");
    Console.WriteLine("Hora1:");
    int h1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Min1:");
    int m1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Seg1:");
    int s1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Hora2:");
    int h2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Min2:");
    int m2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Seg2:");
    int s2 = int.Parse(Console.ReadLine());

    if (h1 >= 0 && h1 < 24 && m1 >= 0 && m1 < 60 && s1 >= 0 && s1 < 60 &&
        h2 >= 0 && h2 < 24 && m2 >= 0 && m2 < 60 && s2 >= 0 && s2 < 60)
    {
        int t1 = h1 * 3600 + m1 * 60 + s1;
        int t2 = h2 * 3600 + m2 * 60 + s2;

        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");


    // Ejercicio 10
    Console.WriteLine("Ejercicio 10");
    Console.WriteLine("Número de 3 cifras:");
    int num10 = int.Parse(Console.ReadLine());

    if (num10 >= 100 && num10 <= 999)
    {
        File.AppendAllText("resultados.txt",
            "Ejercicio 1\n" +
            "Unidades: " + (num1 % 10) + "\n" +
            "Decenas: " + (num1 / 10) + "\n");
    }
    else Console.WriteLine("Error");

}
    using (StreamReader reader = new StreamReader(rutaSalida))
    {
        string? linea;

        while ((linea = reader.ReadLine()) != null)
        {
            Console.WriteLine(linea);
        }
    }