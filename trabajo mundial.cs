namespace ConsoleApp1
{
    internal class Program
    {
        public struct Jugador
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Cant_goles { get; set; }
            public int Cant_de_disparos_al_arco { get; set; }
            public int Numero_de_camiseta { get; set; }
            public string Posicion { get; set; }
            public string Equipo { get; set; }

            public Jugador(string n, string a, int goles, int disparos, int camiseta, string posicion, string equipo)
            {
                Nombre = n;
                Apellido = a;
                Cant_goles = goles;
                Cant_de_disparos_al_arco = disparos;
                Numero_de_camiseta = camiseta;
                Posicion = posicion;
                Equipo = equipo;
            }

            public double IndiceAtaque()
            {
                if (Cant_de_disparos_al_arco == 0)
                    return 0;

                return (double)Cant_goles / Cant_de_disparos_al_arco * 100;
            }

            public void Lista()
            {
                Console.WriteLine($"Nombre: {Nombre} {Apellido}");
                Console.WriteLine($"Goles: {Cant_goles}");
                Console.WriteLine($"Disparos al arco: {Cant_de_disparos_al_arco}");
                Console.WriteLine($"Camiseta: {Numero_de_camiseta}");
                Console.WriteLine($"Posición: {Posicion}");
                Console.WriteLine($"Equipo: {Equipo}");
                Console.WriteLine($"Índice de ataque: {IndiceAtaque():F2}%");
            }
        }

        static void Main(string[] args)
        {
            Jugador[] jugadores = new Jugador[3];

            jugadores[0] = new Jugador("Cristiano", "Ronaldo", 2, 5, 7, "Delantero", "Portugal");
            jugadores[1] = new Jugador("Lionel", "Messi", 8, 9, 10, "Delantero", "Argentina");
            jugadores[2] = new Jugador("Julian", "Alvarez", 2, 7, 9, "Delantero", "Argentina");

            Jugador mejor = jugadores[0];

            for (int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i].Lista();

                if (jugadores[i].IndiceAtaque() > mejor.IndiceAtaque())
                {
                    mejor = jugadores[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("[Mejor índice de ataque]");
            Console.WriteLine($"Jugador: {mejor.Nombre} {mejor.Apellido}");
            Console.WriteLine($"Índice: {mejor.IndiceAtaque():F2}%");
        }
    }
}