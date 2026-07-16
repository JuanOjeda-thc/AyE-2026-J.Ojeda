//evaluacion
string[] heroes = ["Arthur", "Merlin", "Robin", "Conan", "Leonidas", "Gandalf", "Lara", "Zelda", "Aloy", "Geralt", "Ciri", "Kratos", "Ellie", "Joel", "Tifa", "Cloud", "Sephiroth", "Aerith", "Barret", "Ryu", "Ken", "Chun-Li", "Guile", "Zangief"];
string[] clases = ["Caballero", "Mago", "Arquero", "Bárbaro", "Espadachín", "Mago", "Exploradora", "Princesa", "Cazadora", "Brujo", "Guerrera", "Dios", "Superviviente", "Contrabandista", "Luchadora", "Soldado", "Villano", "Curandera", "Artillero", "Karateka", "Karateka", "Artista Marcial", "Militar", "Luchador"];
Random random = new Random();
bool[] usados = new bool[heroes.Length];

string[,] equipodragon = new string[6, 3];
string[,] equipolobo = new string[6, 3];
string[,] equipoleon = new string[6, 3];
string[,] equipoagila = new string[6, 3];

LlenarEquipo(equipodragon);
LlenarEquipo(equipolobo);
LlenarEquipo(equipoleon);
LlenarEquipo(equipoagila);

Console.WriteLine("El equipo de los dragones");
MostrarEquipo(equipodragon);
Console.WriteLine("El equipo de los lobos");
MostrarEquipo(equipolobo);
Console.WriteLine("El equipo de los leones");
MostrarEquipo(equipoleon);
Console.WriteLine("El equipo de los agilas");
MostrarEquipo(equipoagila);

int poderdedragon = SumarPoder(equipodragon);
int poderdelobo = SumarPoder(equipolobo);
int poderdeleon = SumarPoder(equipoleon);
int poderdeagilas = SumarPoder(equipoagila);

Console.WriteLine("Semifinal : leones contra agilas");
string[,] ganadorsemifinal1;
string nombredelganadorsemi1;
if (poderdeagilas > poderdeleon)
{
    ganadorsemifinal1 = equipoagila;
    nombredelganadorsemi1 = "agilas";
    Console.WriteLine("el ganador es " + nombredelganadorsemi1);
}
else
{
    ganadorsemifinal1 = equipoleon;
    nombredelganadorsemi1 = "leones";
    Console.WriteLine("el ganador es " + nombredelganadorsemi1);
} 

Console.WriteLine("Semifinal : dragones contra lobos");
string[,] ganadorsemifinal2;
string nombredelganadorsemi2;
if (poderdelobo > poderdedragon)
{
    ganadorsemifinal2 = equipolobo;
    nombredelganadorsemi2 = "lobos";
    Console.WriteLine("el ganador es " + nombredelganadorsemi2);
}
else
{
    ganadorsemifinal2 = equipodragon;
    nombredelganadorsemi2 = "dragon";
    Console.WriteLine("el ganador es " + nombredelganadorsemi2);
}

int Poderfinalistas1 = SumarPoder(ganadorsemifinal1);
int poderfinalistas2 = SumarPoder(ganadorsemifinal2);

Console.WriteLine("la final, el clan " + nombredelganadorsemi1, "contra el clan " + nombredelganadorsemi2);

string[,] equipoganador;
string nombredelganador;

if (Poderfinalistas1 > poderfinalistas2) 
{
    equipoganador = ganadorsemifinal1;
    nombredelganador = nombredelganadorsemi1;
}
else
{
    equipoganador = ganadorsemifinal2;
    nombredelganador = nombredelganadorsemi2;
}

Console.WriteLine("el equipo ganador es " + equipoganador);
Console.WriteLine("los heroes del equipo ganador :");
MostrarEquipo(equipoganador);

void LlenarEquipo(string[,] equipo)
{
    for (int i = 0; i < equipo.GetLength(0); i++) 
    {
        int indice;
        do
        {
            indice = random.Next(0, heroes.Length);
        }
        while (usados[indice]);
        
            usados[indice] = true;
            equipo[i, 0] = heroes[indice];
            equipo[i, 1] = clases[indice];
            equipo[i, 2] = random.Next(100, 500).ToString();
        
    }
}

int SumarPoder(string[,] equipo)
{
    int suma = 0;
        for (int i = 0; i < equipo.GetLength(0); i++)
    {
        suma += Convert.ToInt32( equipo[i, 2]);
    }
    return suma;

}

void MostrarEquipo(string[,] equipo)
{
    for (int i = 0; i < equipo.GetLength(0); i++)
    {
        Console.WriteLine($"nombre:{equipo[i, 0]}, clases: {equipo[i, 1]} poder: {equipo[i, 2]}");
    }

    
}