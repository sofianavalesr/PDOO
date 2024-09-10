namespace Facturacion;

using System;
using System.Collections.Generic;
class Programa
{
    static void Main(string[] args)
    {
        List<Producto> menu = new List<Producto>
        {
            new Producto(1, "Hamburguesa", 5.99m),
            new Producto(2, "Pizza", 8.99m),
            new Producto(3, "Ensalada", 4.99m),
            new Producto(4, "Refresco", 1.99m)
        };

        List<Mesa> mesas = new List<Mesa>();
        for (int i = 1; i <= 10; i++)
        {
            mesas.Add(new Mesa { Numero = i });
        }

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1. Imprimir menú del restaurante");
            Console.WriteLine("2. Agregar productos a una mesa");
            Console.WriteLine("3. Editar productos de una mesa");
            Console.WriteLine("4. Editar el menú del restaurante");
            Console.WriteLine("5. Imprimir la cuenta de la mesa");
            Console.WriteLine("6. Buscar productos por ID");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Menú del restaurante:");
                    foreach (var producto in menu)
                    {
                        Console.WriteLine(producto.ToString());
                    }
                    break;

                case 2:
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
                    break;

                case 3:
                    Console.Write("Ingrese el número de la mesa: ");
                    numeroMesa = int.Parse(Console.ReadLine());
                    mesa = mesas.Find(m => m.Numero == numeroMesa);
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
                    break;

                case 4:
                    Console.WriteLine("1. Agregar nuevo producto");
                    Console.WriteLine("2. Editar producto existente");
                    int opcionEditar = int.Parse(Console.ReadLine());

                    if (opcionEditar == 1)
                    {
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
                    }
                    else if (opcionEditar == 2)
                    {
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
                    }
                    break;

                case 5:
                    Console.Write("Ingrese el número de la mesa: ");
                    numeroMesa = int.Parse(Console.ReadLine());
                    mesa = mesas.Find(m => m.Numero == numeroMesa);
                    if (mesa != null)
                    {
                        mesa.ImprimirCuenta();
                    }
                    else
                    {
                        Console.WriteLine("Mesa no encontrada.");
                    }
                    break;

                case 6:
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
                    break;

                case 7:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
