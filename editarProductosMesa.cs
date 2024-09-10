Console.Write("Ingrese el número de la mesa: ");
int numeroMesa = int.Parse(Console.ReadLine());
Mesa mesa = mesas.Find(m => m.Numero == numeroMesa);
if (mesa != null)
{
    Console.WriteLine("1. Agregar producto a la mesa");
    Console.WriteLine("2. Eliminar producto de la mesa");
    int opcionEditarMesa = int.Parse(Console.ReadLine());

    if (opcionEditarMesa == 1)
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
    else if (opcionEditarMesa == 2)
    {
        Console.Write("Ingrese el ID del producto que desea eliminar: ");
        int idProducto = int.Parse(Console.ReadLine());
        mesa.EliminarProducto(idProducto);
    }
}
else
{
    Console.WriteLine("Mesa no encontrada.");
}
