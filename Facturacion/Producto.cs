namespace Facturacion;
public class Producto
{

    private int Id { get; set; }


    private string Nombre;
    private decimal Precio;


    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
    public int GetId(){return Id;}
    public string GetNombre()
    {
        return Nombre;
    }
     public decimal GetPrecio()
    {
        return Precio;
    }
    public override string ToString()
    {
        return $"{Id}. {GetNombre()} - ${GetPrecio()}";
    }
}
