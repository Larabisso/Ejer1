using System.Collections.Generic;

namespace MiProyecto
{
    public class Coleccion
    {
        public string NombreColeccion { get; set; }
        private List<Figura> listaFiguras;

        public Coleccion(string nombre)
        {
            NombreColeccion = nombre;
            listaFiguras = new List<Figura>();
        }

        public void AñadirFigura(Figura fig)
        {
            listaFiguras.Add(fig);
        }

        public void SubirPrecio(double cantidad, string id)
        {
            foreach (Figura f in listaFiguras)
            {
                if (f.Codigo == id)
                {
                    f.SubirPrecio(cantidad);
                }
            }
        }

        public string ConCapa()
        {
            string resultado = "Figuras con capa:\n";
            foreach (Figura f in listaFiguras)
            {
                if (f.Heroe.Capa)
                {
                    resultado += f.ToString() + "\n";
                }
            }
            return resultado;
        }

        public Figura MasValioso()
        {
            Figura max = null;
            foreach (Figura f in listaFiguras)
            {
                if (max == null || f.Precio > max.Precio)
                {
                    max = f;
                }
            }
            return max;
        }

        public double GetValorColeccion()
        {
            double total = 0;
            foreach (Figura f in listaFiguras)
            {
                total += f.Precio;
            }
            return total;
        }

        public double GetVolumenColeccion()
        {
            double total = 0;
            foreach (Figura f in listaFiguras)
            {
                total += f.Dimensiones.GetVolumen();
            }
            return total + 200;
        }

        public override string ToString()
        {
            string resultado = "Colección: " + NombreColeccion + "\n";
            foreach (Figura f in listaFiguras)
            {
                resultado += f.ToString() + "\n";
            }
            return resultado;
        }
    }
}