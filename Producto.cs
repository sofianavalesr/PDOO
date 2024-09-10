public class Producto
{
    private int Id { get; set; }
    private string Nombre { get; set; }
    private decimal Precio { get; set; }
    private string Descripcion{get;set;}

    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }
    
    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Precio: {Precio:C}";
    }
}