using evaluacion_base_de_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using static evaluacion_base_de_datos.Agentes;

namespace Prueba_Base_de_Datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            List<Agente> agentes = db.Agentes.ToList();

            Arbol arbol = new Arbol();

            foreach (Agente agente in agentes)
                arbol.Agregar(agente);

            foreach (Agente agente in agentes)
                Console.WriteLine(agente.id + " - " + agente.nombre_agente);

            Console.Write("Ingrese el ID: ");
            int id = int.Parse(Console.ReadLine());

            Agente encontrado = arbol.Buscar(id);

            if (encontrado != null)
                Console.WriteLine(encontrado.nombre_agente);
            else
                Console.WriteLine("Agente no encontrado");

            for (int i = 0; i < agentes.Count - 1; i++)
            {
                for (int j = 0; j < agentes.Count - i - 1; j++)
                {
                    if (string.Compare(
                        agentes[j].nombre_agente,
                        agentes[j + 1].nombre_agente,
                        StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Agente aux = agentes[j];
                        agentes[j] = agentes[j + 1];
                        agentes[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("\nAgentes ordenados:");

            foreach (Agente agente in agentes)
                Console.WriteLine(agente.nombre_agente);
        }

        static void Agregar(AppDbContext db, Agente agente)
        {
            db.Agentes.Add(agente);
            db.SaveChanges();
        }

        static Agente Consultar(AppDbContext db, int id)
        {
            return db.Agentes.Find(id);
        }

        static void Actualizar(AppDbContext db, int id, string nombre)
        {
            Agente agente = db.Agentes.Find(id);

            if (agente != null)
            {
                agente.nombre_agente = nombre;
                db.SaveChanges();
            }
        }

        static void Eliminar(AppDbContext db, int id)
        {
            Agente agente = db.Agentes.Find(id);

            if (agente != null)
            {
                db.Agentes.Remove(agente);
                db.SaveChanges();
            }
        }
    }
}
