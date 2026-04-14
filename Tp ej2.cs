//Ejercicio 2
string Ejercicio2(int Q)
{
    string resultado;
    if (Q >= 18)
    {
        resultado = "¡Bienvenido a la fiesta!.";
        return resultado;
    }
    else
    {
        resultado = "Lo siento, eres muy joven";
        return resultado;
    }
}
Console.WriteLine("Ingrese su edad");
Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
