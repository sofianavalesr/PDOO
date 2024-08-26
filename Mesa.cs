public class Mesa
{
    public int Numero { get; set; }
    public List<Producto> Productos { get; set; }

    public Mesa(int numero)
    {
        Numero = numero;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void EliminarProducto(int id)
    {
        Productos.RemoveAll(p => p.Id == id);
    }

    public decimal CalcularTotal()
    {
        return Productos.Sum(p => p.Precio);
    }
}