using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_19
{
    public class Tarea
    {
        public enum PrioridadTarea
        {
            Baja,
            Media,
            Alta
        }

        public string Id { get; }
        public string Titulo { get; }
        public PrioridadTarea Prioridad { get; }
        public int EstimacionMinutos { get; }

        public Tarea(string id, string titulo, PrioridadTarea prioridad, int estimacionMinutos)
        {
            Id = id;
            Titulo = titulo;
            Prioridad = prioridad;
            EstimacionMinutos = estimacionMinutos;
        }
    }
}