//ejercicio 1
Console.WriteLine("tabla de jugadores");
string[] nombres = {"Juan","Pepe","dross","milan","Jorge","nuria","maria","lopez","virginia","leontina","gillermo","javier","pablo","joaquin","nicolas","cesar","jazmin","florencia","laura","lileana","julio","marcelo","ignacio" };
string[] posiciones = {"delantero","defensor","mediocampista","arquero" };
string[,] matriz = new string[23, 3];
Random random = new Random();

for (int i = 0; i < 23; i++)
{
    string nombre = nombres[random.Next(nombres.Length)];
    string rendimiento = random.Next(50, 101).ToString();
    string posicion = posiciones[random.Next(posiciones.Length)];

    matriz [i, 0] = nombre;
    matriz [i, 1] = rendimiento;
    matriz [i, 2] = posicion;
}

Console.WriteLine("Nombre Rendimiento Posición");
for (int i = 0; i < 23; i++)
{
    Console.WriteLine($"{matriz [i, 0]} {matriz [i, 1]} {matriz[i, 2]}");
}


//ejercicio 2

Console.WriteLine("Ingrese el número base:");
int baseNum = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el exponente:");
int exponente = int.Parse(Console.ReadLine());
int resultado = Potencia(baseNum, exponente);
Console.WriteLine($"El resultado es: {resultado}");

    int Potencia(int baseNum, int exponente)
    {
        if (exponente == 0) return 1; 
        return baseNum * Potencia(baseNum, exponente - 1); 
    }
