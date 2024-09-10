public class Factura
{
    public int Numero { get; set; }
    public DateTime Fecha { get; set; }
    public List<Producto> Productos { get; set; }

    public Factura(int numero)
    {
        Numero = numero;
        Fecha = DateTime.Now;
        Productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        Productos.Add(producto);
    }

    public void Imprimir()
    {
        Console.WriteLine($"Factura N°: {Numero}");
        Console.WriteLine($"Fecha: {Fecha}");
        foreach (var producto in Productos)
        {
            Console.WriteLine($"{producto.Nombre} = {producto.Precio:C}");
        }
        Console.WriteLine($"Total: {CalcularTotal():C}");
    }

    public decimal CalcularTotal()
    {
        return Productos.Sum(p => p.Precio);
    }
}
