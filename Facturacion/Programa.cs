namespace Facturacion; // Define el espacio de nombres "Facturacion" que agrupa las clases relacionadas.

using System; // Importa el espacio de nombres que contiene las clases básicas, como Console.

class Programa
{
    // Método principal que es el punto de entrada del programa.
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante(); // Crea una instancia de la clase Restaurante.
        bool continuar = true; // Bandera para controlar el bucle que mantiene el menú activo.

        // Bucle que mantiene el menú interactivo hasta que el usuario decida salir.
        while (continuar)
        {
            // Imprime las opciones del menú para que el usuario elija.
            Console.WriteLine("1. Imprimir menú del restaurante");
            Console.WriteLine("2. Agregar producto a una mesa");
            Console.WriteLine("3. Editar productos de una mesa (agregar/eliminar)");
            Console.WriteLine("4. Editar menú del restaurante");
            Console.WriteLine("5. Imprimir cuenta de una mesa");
            Console.WriteLine("6. Buscar producto por ID");
            Console.WriteLine("7. Salir");
            Console.Write("Elija una opción: ");
            
            // Lee la opción elegida por el usuario y la convierte a entero.
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Estructura switch para ejecutar la acción correspondiente según la opción seleccionada.
            switch (opcion)
            {
                case 1: // Opción para imprimir el menú del restaurante.
                    restaurante.ImprimirMenu();
                    break;

                case 2: // Opción para agregar un producto a una mesa.
                    Console.Write("Número de mesa: "); // Solicita el número de mesa.
                    int numeroMesa = Convert.ToInt32(Console.ReadLine());
                    Console.Write("ID del producto: "); // Solicita el ID del producto.
                    int idProducto = Convert.ToInt32(Console.ReadLine());
                    restaurante.AgregarProductoAMesa(numeroMesa, idProducto); // Llama al método para agregar el producto.
                    break;

                case 3: // Opción para editar los productos de una mesa (agregar o eliminar).
                    Console.Write("Número de mesa: ");
                    numeroMesa = Convert.ToInt32(Console.ReadLine());
                    Console.Write("¿Desea agregar o eliminar un producto? (1: Agregar, 2: Eliminar): ");
                    int opcionEditar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("ID del producto: ");
                    idProducto = Convert.ToInt32(Console.ReadLine());
                    restaurante.EditarProductosMesa(numeroMesa, opcionEditar, idProducto); // Llama al método para editar los productos de la mesa.
                    break;

                case 4: // Opción para editar el menú del restaurante (agregar o editar productos).
                    Console.Write("ID del producto en el menú: "); // Solicita el ID del producto.
                    int idMenu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre del producto: "); // Solicita el nuevo nombre del producto.
                    string? nombre = Console.ReadLine();
                    Console.Write("Precio del producto: "); // Solicita el nuevo precio del producto.
                    decimal precio = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("¿Desea agregar un nuevo producto o editar uno existente? (1: Agregar, 2: Editar): ");
                    int opcionEditarMenu = Convert.ToInt32(Console.ReadLine());

                    // Si el nombre no es nulo ni vacío, se procede a agregar o editar el producto en el menú.
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        restaurante.EditarMenu(idMenu, nombre, precio, opcionEditarMenu == 1); // Determina si se está agregando o editando.
                    }
                    else
                    {
                        Console.WriteLine("El nombre no puede ser nulo o vacío."); // Valida que el nombre no sea vacío.
                    }
                    break;

                case 5: // Opción para imprimir la cuenta de una mesa.
                    Console.Write("Número de mesa: ");
                    numeroMesa = Convert.ToInt32(Console.ReadLine());
                    restaurante.ImprimirCuentaMesa(numeroMesa); // Llama al método para imprimir la cuenta de la mesa.
                    break;

                case 6: // Opción para buscar un producto por su ID.
                    Console.Write("ID del producto a buscar: ");
                    int idBuscar = Convert.ToInt32(Console.ReadLine());
                    Producto? producto = restaurante.BuscarProductoPorId(idBuscar); // Llama al método para buscar el producto por su ID.

                    // Si se encuentra el producto, lo imprime, si no, muestra un mensaje de error.
                    if (producto != null)
                    {
                        Console.WriteLine(producto.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    break;

                case 7: // Opción para salir del programa.
                    continuar = false; // Cambia la bandera para salir del bucle.
                    break;

                default: // Opción predeterminada si el usuario ingresa una opción no válida.
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
