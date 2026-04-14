//Ejercicio 3

string Ejercicio3(string contraseña)
{
    string resultado;
    if (contraseña == "python123")
    {
        resultado = "¡Contraseña correcta! Acceso concedido.";
        return resultado;
    }
    else
    {
        resultado = "¡Contraseña incorrecta, Autodestrucción en 5 minutos!";
        return resultado;
    }
}
Console.WriteLine("Ingrese la contraseña");
Console.WriteLine(Ejercicio3(Console.ReadLine()));
