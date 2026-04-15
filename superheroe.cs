namespace MiProyecto
{
    public class Superheroe
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Capa { get; set; }

        public Superheroe(string nombre)
        {
            Nombre = nombre;
            Descripcion = "";
            Capa = false;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Descripción: " + Descripcion + ", Capa: " + Capa;
        }
    }
}