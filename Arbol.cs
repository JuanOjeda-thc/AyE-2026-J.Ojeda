using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static evaluacion_base_de_datos.Agentes;

public class Nodo
{
    public Agente agente;
    public Nodo izquierda, derecha;

    public Nodo(Agente agente)
    {
        this.agente = agente;
    }
}

public class Arbol
{
    public Nodo raiz;

    public void Agregar(Agente agente)
    {
        raiz = Insertar(raiz, agente);
    }

    Nodo Insertar(Nodo nodo, Agente agente)
    {
        if (nodo == null)
            return new Nodo(agente);

        if (agente.id < nodo.agente.id)
            nodo.izquierda = Insertar(nodo.izquierda, agente);
        else if (agente.id > nodo.agente.id)
            nodo.derecha = Insertar(nodo.derecha, agente);

        return nodo;
    }

    public Agente Buscar(int id)
    {
        Nodo actual = raiz;

        while (actual != null)
        {
            if (actual.agente.id == id)
                return actual.agente;

            if (id < actual.agente.id)
                actual = actual.izquierda;
            else
                actual = actual.derecha;
        }

        return null;
    }
}

