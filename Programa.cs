class Program
{
    static void Main(string[] args)
    {
        var sistema = new Sistema();

        // Inicializar algunos productos
        sistema.Productos.Add(new Producto(1, "Pizza", 10.99m));
        sistema.Productos.Add(new Producto(2, "Coca Cola", 1.99m));
        sistema.Productos.Add(new Producto(3, "Ensalada", 5.99m));

        // Agregar mesas
        sistema.Mesas.Add(new Mesa(1));
        sistema.Mesas.Add(new Mesa(2));

        while (true)
        {
            Console.WriteLine("1. Imprimir Menú");
            Console.WriteLine("2. Agregar Producto a Mesa");
            Console.WriteLine("3. Imprimir Cuenta de Mesa");
            Console.WriteLine("4. Cargar Datos");
            Console.WriteLine("5. Guardar Datos");
            Console.WriteLine("6. Salir");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    sistema.ImprimirMenu();
                    break;
                case "2":
                    Console.WriteLine("Ingrese número de mesa:");
                    int mesaNumero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese ID del producto:");
                    int productoId = int.Parse(Console.ReadLine());
                    var producto = sistema.Productos.FirstOrDefault(p => p.Id == productoId);
                    if (producto != null)
                    {
                        sistema.AgregarProductoAMesa(mesaNumero, producto);
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Ingrese número de mesa:");
                    mesaNumero = int.Parse(Console.ReadLine());
                    sistema.ImprimirCuenta(mesaNumero);
                    break;
                case "4":
                    Console.WriteLine("Ingrese ruta del archivo para cargar:");
                    string cargaRuta = Console.ReadLine();
                    sistema.CargarDatos(cargaRuta);
                    break;
                case "5":
                    Console.WriteLine("Ingrese ruta del archivo para guardar:");
                    string guardarRuta = Console.ReadLine();
                    sistema.GuardarDatos(guardarRuta);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}

