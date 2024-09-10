Console.Write("Ingrese el número de la mesa: ");
int numeroMesa = int.Parse(Console.ReadLine());
Mesa mesa = mesas.Find(m => m.Numero == numeroMesa);
if (mesa != null)
{
    mesa.ImprimirCuenta();
}
else
{
    Console.WriteLine("Mesa no encontrada.");
}
