namespace Biblio.Core;
//TODO pasar a objetos complejos Titulo y Editorial

public class Ejemplar
{
    public ulong ISBN {get; set;}
    public ushort idEditorial {get; set;}
    public byte cantCopias {get; set;}
    public ushort cantPrestamos {get; set;}
    public ushort idTitulo {get; set;}

    public Editorial Editorial {get;set;}
    public Titulo Titulo {get;set;}

    public Ejemplar(Editorial editorial, Titulo titulo)
    {
        Editorial=editorial;
        Titulo=titulo;
    }
    

}