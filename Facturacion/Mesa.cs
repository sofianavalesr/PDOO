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
        if(producto!=null)
        {
            productos.Add(producto);
        }
        else{
            Console.WriteLine("Error, el producto no existe");
        }
    }

    public int Id { get => id; set => id = value; }
}