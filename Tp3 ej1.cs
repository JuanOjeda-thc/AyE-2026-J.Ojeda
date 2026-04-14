//Ejercicio 1
string Ejercicio1(int N)
{
    string resultado;
    if (N > 0)
    {
        resultado = "El número es positivo.";
        return resultado;
    }
    else if (N < 0)
    {
        resultado = "El número es negativo";
        return resultado;
    }
    else
    {
        resultado = "El número es cero";
        return resultado;
    }
}

Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
