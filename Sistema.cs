public class Sistema
{
    public List<Producto> Productos { get; private set; }
    public List<Mesa> Mesas { get; private set; }
    public List<Factura> Facturas { get; private set; }

    public Sistema()
    {
        Productos = new List<Producto>();
        Mesas = new List<Mesa>();
        Facturas = new List<Factura>();
    }
