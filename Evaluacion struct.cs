using System.ComponentModel.Design;

namespace Evaluacion_struct_y_pilas
{
    internal class Program
    {
        struct Personaje
        {
            public int VidaTotal;
            public int VidaActual;
            public string UltimaAccion;

            public Personaje(int vidaTotal, int vidaActual, string ultimaAccion)
            {
                VidaTotal = vidaTotal;
                VidaActual = vidaActual;
                UltimaAccion = ultimaAccion;
            }

        }

        struct VolverenElTiempo
        {
            public int VidaTotal;
            public int VidaActual;
            public string UltimaAccion;
            public VolverenElTiempo(int vidaTotal, int vidaActual, string ultimaAccion)
            {
                VidaTotal = vidaTotal;
                VidaActual = vidaActual;
                UltimaAccion = ultimaAccion;
            }
        }

        static void Main(string[] args)
        {
            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Stack<Personaje> VolverEnElTiempo = new Stack<Personaje>();

            Stack<Personaje> VidaActual = new Stack<Personaje>(100);

            Stack<Personaje> VidaTotal = new Stack<Personaje>(100);

            Stack<Personaje> UltimaAccion = new Stack<Personaje>(100);


            VidaTotal.Push(new Personaje { VidaTotal = 100 });
            VidaActual.Push(new Personaje { VidaActual = VidaTotal.Peek().VidaActual });
            UltimaAccion.Push(new Personaje { UltimaAccion = "Ninguna" });
            VolverEnElTiempo.Push(new Personaje { VidaTotal = VidaActual.Peek().VidaActual});

            Console.WriteLine("tu personaje tiene 100 puntos de vida, diga cuanto daño recibio:");
            VidaActual.Push(new Personaje { VidaActual = VidaActual.Peek().VidaActual - int.Parse(Console.ReadLine()) });

            if (VidaActual.Peek().VidaActual > 0)
            {
                Console.WriteLine("tu personaje tiene " + VidaTotal.Peek().VidaActual + " cuanto daño quiere recibir? :");
                UltimaAccion.Push(new Personaje { UltimaAccion = Console.ReadLine() });
            }
            else
            {
                Console.WriteLine("tu personaje ha muerto, vuelves atras");
                VolverEnElTiempo.Pop();
            }
        }
    }
}
