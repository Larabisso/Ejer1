namespace MiProyecto
{
    public class Figura
    {
        public string Codigo { get; set; }
        public double Precio { get; set; }
        public Dimension Dimensiones { get; set; }
        public Superheroe Heroe { get; set; }

        public Figura(string codigo, double precio, Dimension dimensiones, Superheroe heroe)
        {
            Codigo = codigo;
            Precio = precio;
            Dimensiones = dimensiones;
            Heroe = heroe;
        }

        public void SubirPrecio(double cantidad)
        {
            Precio += cantidad;
        }

        public override string ToString()
        {
            return "Código: " + Codigo +
                   ", Precio: " + Precio +
                   ", Dimensiones: [" + Dimensiones.ToString() + "]" +
                   ", Héroe: [" + Heroe.ToString() + "]";
        }
    }
}