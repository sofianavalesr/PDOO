namespace Facturacion;
// Restaurante.cs
using System;
using System.Collections.Generic;

public class Restaurante
{
    private Menu menu;
    private List<Mesa> mesas;

    public Restaurante()
    {
        menu = new Menu();
        mesas = new List<Mesa>();

        // Agregamos productos al menú por defecto
        menu.AgregarProducto(new Producto(1, "Hamburguesa", 8.99m));
        menu.AgregarProducto(new Producto(2, "Pizza", 12.99m));
        menu.AgregarProducto(new Producto(3, "Ensalada", 6.50m));
        menu.AgregarProducto(new Producto(4, "Soda", 2.00m));

        // Inicializamos las mesas
        for (int i = 1; i <= 10; i++)
        {
            Mesa mesa = new Mesa();
            mesa.SetNumero(i);

            mesas.Add(mesa); 
        }
    }

    public void ImprimirMenu()
    {
        menu.ImprimirMenu();
    }

    public void AgregarProductoAMesa(int numeroMesa, int idProducto)
    {
        Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
        Producto? producto = menu.BuscarProductoPorId(idProducto);

        if (mesa != null && producto != null)
        {
            mesa.AgregarProducto(producto);
            Console.WriteLine("Producto agregado a la mesa.");
        }
        else
        {
            Console.WriteLine(mesa == null ? "Mesa no encontrada." : "Producto no encontrado.");
        }
    }

    public void EditarProductosMesa(int numeroMesa, int opcion, int idProducto)
    {
        Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);

        if (mesa != null)
        {
            if (opcion == 1) // Agregar producto
            {
                Producto? producto = menu.BuscarProductoPorId(idProducto);
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
            else if (opcion == 2) // Eliminar producto
            {
                mesa.EliminarProducto(idProducto);
            }
        }
        else
        {
            Console.WriteLine("Mesa no encontrada.");
        }
    }

    public void EditarMenu(int id, string nombre, decimal precio, bool esNuevoProducto)
    {
        if (esNuevoProducto)
        {
            menu.AgregarProducto(new Producto(id, nombre, precio));
        }
        else
        {
            menu.EditarProducto(id, nombre, precio);
        }
    }

    public void ImprimirCuentaMesa(int numeroMesa)
    {
        Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
        if (mesa != null)
        {
            mesa.ImprimirCuenta();
        }
        else
        {
            Console.WriteLine("Mesa no encontrada.");
        }
    }

    public Producto? BuscarProductoPorId(int id)
    {
        return menu.BuscarProductoPorId(id);
    }
}
