//Ejercicio 4
string Ejercicio4(int numero)
{
    string resultado;
    if (numero % 2 == 0)
    {
        resultado = "El número es par.";
        return resultado;
    }
    else
    {
        resultado = "El número es impar.";
        return resultado;
    }
}
Console.WriteLine("Ingrese un número");
Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
