namespace Facturacion
{
    public class Producto
    {
        private int Id { get; set; }
        private string Nombre;
        private decimal Precio;

        public Producto(int id, string nombre, decimal precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
        }

        public int GetId() => Id;
        public string GetNombre() => Nombre;
        public decimal GetPrecio() => Precio;

        public override string ToString() => $"{Id}. {Nombre} - ${Precio}";
    }
}