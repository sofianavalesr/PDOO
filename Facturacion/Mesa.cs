namespace Facturacion;
public class Mesa
{
    private int id;
    private List<Producto> productos;
    public Mesa(){
        productos = new List<Producto>();
    }

    public void AgregarProducto(Producto producto)
    {
        
    }

    public int Id { get => id; set => id = value; }
}