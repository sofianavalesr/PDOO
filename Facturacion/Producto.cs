namespace Facturacion;
public class Producto
{

    private int Id { get; set; }

    private string nombre;
    private decimal precio;

    private decimal GetPrecio()
    {
        return precio;
    }

    private void SetPrecio(decimal value)
    {
        precio = value;
    }

    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        SetNombre(nombre);
        SetPrecio(precio);
    }
    public int GetId(){return Id;}
    public string GetNombre()
    {
        return nombre;
    }

    public override string ToString()
    {
        return $"{Id}. {GetNombre()} - ${GetPrecio()}";
    }
}
