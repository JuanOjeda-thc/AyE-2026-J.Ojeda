Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("ingrese su promedio actual: ");
float promedio = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese la distancia en kilometros de su casa a la universidad: ");
int distancia = int.Parse(Console.ReadLine());

bool DeterminarBeca(float promedio, int distancia)
{
    if (promedio >= 8.5 || distancia > 50)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool resultado = DeterminarBeca(promedio, distancia);
if (resultado == true)
{
    Console.WriteLine("Felicidades,");
    Console.WriteLine(nombre);
    Console.WriteLine("ha sido seleccionado para recibir la beca.");
}
else
{
    Console.WriteLine("Lo sentimos,");
    Console.WriteLine(nombre);
    Console.WriteLine("no ha sido seleccionado para recibir la beca.");
}