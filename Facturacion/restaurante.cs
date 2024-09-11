using System;
using System.Collections.Generic;

namespace Facturacion
{
    public class Restaurante
    {
        private Menu menu;
        private List<Mesa> mesas;

        public Restaurante()
        {
            menu = new Menu();
            mesas = new List<Mesa>();

            menu.AgregarProducto(new Producto(1, "Hamburguesa", 8.99m), false);
            menu.AgregarProducto(new Producto(2, "Pizza", 12.99m), false);
            menu.AgregarProducto(new Producto(3, "Ensalada", 6.50m), false);
            menu.AgregarProducto(new Producto(4, "Soda", 2.00m), false);

            for (int i = 1; i <= 10; i++)
            {
                Mesa mesa = new Mesa();
                mesa.SetNumero(i);
                mesas.Add(mesa);
            }
        }

        public void ImprimirMenu() => menu.ImprimirMenu();

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
                if (opcion == 1)
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
                else if (opcion == 2)
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

        public Producto? BuscarProductoPorId(int id) => menu.BuscarProductoPorId(id);
    }
}