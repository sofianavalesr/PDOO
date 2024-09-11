namespace Facturacion;
// Menu.cs
using System;
using System.Collections.Generic;

public class Menu
{
    public List<Producto> Productos { get; set; } = new List<Producto>();

    public void ImprimirMenu()
    {
        Console.WriteLine("Menú del restaurante:");
        foreach (var producto in Productos)
        {
            Console.WriteLine(producto.ToString());
        }
    }

    public void AgregarProducto(Producto producto)
    {
        if (Productos.Exists(p => p.Id == producto.Id))
        {
            Console.WriteLine("El ID ya está en uso, elija otro.");
        }
        else
        {
            Productos.Add(producto);
            Console.WriteLine("Producto agregado al menú.");
        }
    }

    public void EditarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
    {
        Producto? producto = Productos.Find(p => p.Id == id);
        if (producto != null)
        {
            producto.Nombre = nuevoNombre;
            producto.Precio = nuevoPrecio;
            Console.WriteLine("Producto editado en el menú.");
        }
        else
        {
            Console.WriteLine("Producto no encontrado.");
        }
    }

    public Producto? BuscarProductoPorId(int id)
    {
        return Productos.Find(p => p.Id == id);
    }
}