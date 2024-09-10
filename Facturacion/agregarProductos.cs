Console.Write("Ingrese el número de la mesa: ");
int numeroMesa = int.Parse(Console.ReadLine());
Mesa mesa = mesas.Find(m => m.Numero == numeroMesa);
if (mesa != null)
{
    Console.Write("Ingrese el ID del producto que desea agregar: ");
    int idProducto = int.Parse(Console.ReadLine());
    Producto producto = menu.Find(p => p.Id == idProducto);
    if (producto != null)
    {
        mesa.AgregarProducto(producto);
        Console.WriteLine("Producto agregado a la mesa.");
    }
    else
    {
        Console.WriteLine("Producto no encontrado.");
    }
}
else
{
    Console.WriteLine("Mesa no encontrada.");
}
