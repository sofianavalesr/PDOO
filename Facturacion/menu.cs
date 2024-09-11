namespace Facturacion; // Define el espacio de nombres "Facturacion", que contiene clases relacionadas con la facturación.

// Menu.cs
using System; // Importa el espacio de nombres System, que incluye clases básicas como Console.
using System.Collections.Generic; // Importa la librería para trabajar con colecciones genéricas como List.

public class Menu
{
    // Lista de productos que contiene el menú del restaurante.
    public List<Producto> Productos { get; set; } = new List<Producto>();

    // Método que imprime el menú del restaurante.
    public void ImprimirMenu()
    {
        Console.WriteLine("Menú del restaurante:"); // Muestra un mensaje inicial.
        
        // Itera sobre la lista de productos y los imprime.
        foreach (var producto in Productos)
        {
            Console.WriteLine(producto.ToString()); // Llama al método ToString() de cada producto.
        }
    }

    // Método para agregar un producto al menú.
    public void AgregarProducto(Producto producto)
    {
        // Verifica si ya existe un producto con el mismo ID en la lista.
        if (Productos.Exists(p => p.GetId() == producto.GetId()))
        {
            // Si el ID ya existe, imprime un mensaje de advertencia.
            Console.WriteLine("El ID ya está en uso, elija otro.");
        }
        else
        {
            // Si el ID es único, agrega el producto a la lista.
            Productos.Add(producto);
            Console.WriteLine("Producto agregado al menú.");
        }
    }

    // Método para editar un producto existente en el menú.
    public void EditarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
    {
        // Busca el producto por su ID.
        Producto? producto = Productos.Find(p => p.GetId() == id);
        
        // Si se encuentra el producto, actualiza su nombre y precio (debería tener lógica para esto).
        if (producto != null)
        {
            // Aquí iría la lógica para actualizar las propiedades del producto.
            // Ej: producto.SetNombre(nuevoNombre); producto.SetPrecio(nuevoPrecio);
            Console.WriteLine("Producto editado en el menú.");
        }
        else
        {
            // Si no se encuentra, informa que no se encontró el producto.
            Console.WriteLine("Producto no encontrado.");
        }
    }

    // Método para buscar un producto por su ID.
    public Producto? BuscarProductoPorId(int id)
    {
        // Devuelve el producto que coincida con el ID proporcionado o null si no lo encuentra.
        return Productos.Find(p => p.GetId() == id);
    }
}
