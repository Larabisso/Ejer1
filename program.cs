using System;
using MiProyecto;
class Program
{
    public static void Main(string[] args)
    {
        Superheroe batman = new Superheroe("Batman");
        batman.Descripcion = "Traje negro";
        batman.Capa = true;

        Superheroe spiderman = new Superheroe("Spiderman");
        spiderman.Descripcion = "Rojo y azul";

        Dimension dim1 = new Dimension(10, 5, 3);
        Dimension dim2 = new Dimension(8, 4, 2);

        Figura f1 = new Figura("F001", 1000, dim1, batman);
        Figura f2 = new Figura("F002", 800, dim2, spiderman);

        Coleccion col = new Coleccion("Superhéroes");

        col.AñadirFigura(f1);
        col.AñadirFigura(f2);

        Console.WriteLine(col);

        Console.WriteLine(col.ConCapa());

        Console.WriteLine("Más valioso:");
        Console.WriteLine(col.MasValioso());

        Console.WriteLine("Total: " + col.GetValorColeccion());
        Console.WriteLine("Volumen: " + col.GetVolumenColeccion());

        Console.ReadKey();
    }
}