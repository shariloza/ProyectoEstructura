using System;

namespace Biblioteca;

public class NodoDoble
{
    object dato;
    NodoDoble siguiente, anterior;

    public object Dato { get => dato; set => dato = value; }
    public NodoDoble Siguiente { get => siguiente; set => siguiente = value; }
    public NodoDoble Anterior { get => anterior; set => anterior = value; }

    public NodoDoble(object _dato){
        dato = _dato;
        siguiente = null;
        anterior = null;
    }

    public NodoDoble(object _dato, NodoDoble _siguiente, NodoDoble _anterior){
        dato = _dato;
        siguiente = _siguiente;
        anterior = _anterior;
    }
    public NodoDoble(){}
}
