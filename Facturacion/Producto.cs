namespace Facturacion; // Define el espacio de nombres "Facturacion".

public class Producto
{
    // Atributos privados de la clase.
    private int Id { get; set; } // ID único del producto, que solo se puede modificar dentro de la clase.
    private string Nombre; // Nombre del producto.
    private decimal Precio; // Precio del producto.

    // Constructor que inicializa los valores de los atributos cuando se crea una instancia de Producto.
    public Producto(int id, string nombre, decimal precio)
    {
        Id = id; // Asigna el ID al atributo privado.
        Nombre = nombre; // Asigna el nombre al atributo privado.
        Precio = precio; // Asigna el precio al atributo privado.
    }

    // Método que retorna el valor del atributo privado 'Id'.
    public int GetId()
    {
        return Id; // Devuelve el ID del producto.
    }

    // Método que retorna el valor del atributo privado 'Nombre'.
    public string GetNombre()
    {
        return Nombre; // Devuelve el nombre del producto.
    }

    // Método que retorna el valor del atributo privado 'Precio'.
    public decimal GetPrecio()
    {
        return Precio; // Devuelve el precio del producto.
    }

    // Sobreescribe el método ToString() para devolver una representación del producto como texto.
    public override string ToString()
    {
        // Retorna una cadena con el formato: ID. Nombre - Precio
        return $"{Id}. {GetNombre()} - ${GetPrecio()}";
    }
}
