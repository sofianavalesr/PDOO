Console.Write("Ingrese el ID del nuevo producto: ");
int idNuevoProducto = int.Parse(Console.ReadLine());
if (menu.Exists(p => p.Id == idNuevoProducto))
{
    Console.WriteLine("El ID ya está en uso, elija otro.");
}
else
{
    Console.Write("Ingrese el nombre del nuevo producto: ");
    string nombreNuevoProducto = Console.ReadLine();
    Console.Write("Ingrese el precio del nuevo producto: ");
    decimal precioNuevoProducto = decimal.Parse(Console.ReadLine());
    menu.Add(new Producto(idNuevoProducto, nombreNuevoProducto, precioNuevoProducto));
    Console.WriteLine("Producto agregado al menú.");
}
//editar producto existente
Console.Write("Ingrese el ID del producto a editar: ");
int idEditarProducto = int.Parse(Console.ReadLine());
Producto producto = menu.Find(p => p.Id == idEditarProducto);
if (producto != null)
{
    Console.Write("Ingrese el nuevo nombre del producto: ");
    string nuevoNombre = Console.ReadLine();
    Console.Write("Ingrese el nuevo precio del producto: ");
    decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
    producto.Nombre = nuevoNombre;
    producto.Precio = nuevoPrecio;
    Console.WriteLine("Producto editado en el menú.");
}
else
{
    Console.WriteLine("Producto no encontrado.");
}
