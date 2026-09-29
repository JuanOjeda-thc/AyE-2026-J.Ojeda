using System;
using System.Collections.Generic;

struct Mago
{
    public int VidaTotal;
    public int VidaActual;
    public string UltimoHechizo;

    public Mago(int vidaTotal, int vidaActual, string ultimoHechizo)
    {
        VidaTotal = vidaTotal;
        VidaActual = vidaActual;
        UltimoHechizo = ultimoHechizo;
    }
}

class Program
{
    static Stack<Mago> hechizosquitero = new Stack<Mago>();

    static void volverEnElTiempo()
    {
        if (hechizosquitero.Count > 0)
        {
            Mago eliminado = hechizosquitero.Pop();

            Console.WriteLine("Hechizo borrado:");
            Console.WriteLine("Vida actual: " + eliminado.VidaActual);
            Console.WriteLine("Último hechizo: " + eliminado.UltimoHechizo);
        }
    }

    static void golpear()
    {
        Mago actual = hechizosquitero.Peek();

        actual.VidaActual -= 20;
        actual.UltimoHechizo = "espinas";

        hechizosquitero.Push(actual);

        Console.WriteLine("Golpear");
        Console.WriteLine("Vida actual: " + actual.VidaActual);
        Console.WriteLine("Último hechizo: " + actual.UltimoHechizo);
    }

    static void Main()
    {
        Mago mago1 = new Mago(100, 100, "bola de fuego");
        Mago mago2 = new Mago(100, 80, "rayo");
        Mago mago3 = new Mago(100, 60, "hielo");

        hechizosquitero.Push(mago1);
        hechizosquitero.Push(mago2);
        hechizosquitero.Push(mago3);

        Console.WriteLine("Historial");

        foreach (Mago m in hechizosquitero)
        {
            Console.WriteLine(
                "Vida total: " + m.VidaTotal +
                "Vida actual: " + m.VidaActual +
                "Ultimo hechizo: " + m.UltimoHechizo
            );
        }

        golpear();

        Console.WriteLine("Despues del golpe");

        foreach (Mago m in hechizosquitero)
        {
            Console.WriteLine(
                "Vida total: " + m.VidaTotal +
                "Vida actual: " + m.VidaActual +
                "Ultimo hechizo: " + m.UltimoHechizo
            );
        }

        Console.WriteLine("Volver en el tiempo");
        volverEnElTiempo();
    }
}