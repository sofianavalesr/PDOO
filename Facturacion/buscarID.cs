Console.Write("Ingrese el ID del producto que desea buscar: ");
int idBuscarProducto = int.Parse(Console.ReadLine());
Producto productoBuscado = menu.Find(p => p.Id == idBuscarProducto);
if (productoBuscado != null)
{
    Console.WriteLine(productoBuscado.ToString());
}
else
{
    Console.WriteLine("Producto no encontrado.");
}
