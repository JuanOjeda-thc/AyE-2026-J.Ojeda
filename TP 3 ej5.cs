//Ejercicio 5

string Ejercicio5(int edad, string compro)
{
    string resultado;
    if (edad >= 65 && compro == "si")
    {
        resultado = "¡Felicidades! Tienes entrada gratuita al cine.";
        return resultado;
    }
    else
    {
        resultado = "Compra la entrada o fuera del cine";
        return resultado;
    }
}
Console.WriteLine("Ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ha comprado palomitas de maíz?");
string compro = Console.ReadLine();
Console.WriteLine(Ejercicio5(edad, compro));