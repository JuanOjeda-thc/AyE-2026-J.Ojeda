// Ejercicio 1 trabajo numero 4

void MostrarNumeros(int numero)
{
    if (numero <= 10)
    {
        Console.WriteLine(numero);
        MostrarNumeros(numero + 1);
    }
}
MostrarNumeros(0);

// Ejercicio 2 trabajo numero 4

void MostrarHola(int veces)
{
    if (veces < 5)
    {
        Console.WriteLine("Hola Mundo");
        MostrarHola(veces + 1);
    }
}
MostrarHola(0);

// Ejercicio 3 trabajo numero 4

void MostrarPares(int numeroPar)
{
    if (numeroPar <= 20)
    {
        Console.WriteLine(numeroPar);
        MostrarPares(numeroPar + 2);
    }
}
MostrarPares(2);

// Ejercicio 4 trabajo numero 4

void MostrarMultiplos7(int multiplo)
{
    if (multiplo <= 70)
    {
        Console.WriteLine(multiplo);
        MostrarMultiplos7(multiplo + 7);
    }
}
MostrarMultiplos7(7);

// Ejercicio 5 trabajo numero 4

void MostrarSuma(int numero, int suma)
{
    if (numero <= 5)
    {
        suma = suma + numero;
        Console.WriteLine(suma);
        MostrarSuma(numero + 1, suma);
    }
}

MostrarSuma(1, 0);

// Ejercicio 1 trabajo numero 5

Console.WriteLine("Ejercicio 1");

void Contraseña()
{
    string contraseña = Console.ReadLine();

    if (contraseña == "777")
    {
        Console.WriteLine("Contraseña correcta");
    }
    else
    {
        Console.WriteLine("Intente otra vez");
        Contraseña();
    }
}
Contraseña();

// Ejercicio 2 trabajo numero 5

Console.WriteLine("Ejercicio 2");

void Cuenta(int numero)
{
    if (numero >= 1)
    {
        Console.WriteLine(numero);
        Cuenta(numero - 1);
    }
    else
    {
        Console.WriteLine("¡Despegue!");
    }
}
Cuenta(5);

// Ejercicio 3 trabajo numero 5

Console.WriteLine("Ejercicio 3");

void Adivinar()
{
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 7)
    {
        Console.WriteLine("¡Correcto!");
    }
    else
    {
        Console.WriteLine("Pruebe otra vez");
        Adivinar();
    }
}
Adivinar();


// Ejercicio 4 trabajo numero 5

Console.WriteLine("Ejercicio 4");

void Suma(int suma)
{
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        Console.WriteLine(suma);
    }
    else
    {
        Suma(suma + numero);
    }
}
Suma(0);