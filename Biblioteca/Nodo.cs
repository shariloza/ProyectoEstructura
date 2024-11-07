namespace Biblioteca;

public class Nodo
{
    object dato;
    Nodo enlace;

    public object Dato { get => dato; set => dato = value; }
    public Nodo Enlace { get => enlace; set => enlace = value; }

    public Nodo(){}
    public Nodo(object _dato){
        dato = _dato;
        enlace = null;
    }
    public Nodo(object _dato, Nodo _enlace){
        dato = _dato;
        enlace = _enlace;
    }
}
