using System;
using System.Collections.Generic;

class Producto {
    public string Nombre { get; set; } //Propiedades de la clase
    public int Codigo { get; set; }
    public double Precio { get; set; }

    public Producto(string nombre, int codigo, double precio) {
        Nombre = nombre;
        Codigo = codigo;
        Precio = precio;
    }

    public override string ToString() {
        return $"Nombre: {Nombre}, Codigo: {Codigo}, Precio: {Precio}";
    }
}

public class Tienda {
    private Producto producto1;
    private Producto producto2;
    private Producto producto3;
    private Producto producto4;

    public Tienda() {
        producto1 = new Producto("Papas", 1, 28);
        producto2 = new Producto("Sodas", 2, 24);
        producto3 = new Producto("Dulces", 3, 5);
        producto4 = new Producto("Galletas", 4, 22);
    }

    public void MostrarProductos() {
        Console.WriteLine(producto1);
        Console.WriteLine(producto2);
        Console.WriteLine(producto3);
        Console.WriteLine(producto4);
    }

    public double CalcularPrecioTotal() {
        return CalcularPrecioTotalRecursivo(producto1, producto2, producto3, producto4);
    }

    private double CalcularPrecioTotalRecursivo(params Producto[] productos) {
        if (productos.Length == 0) return 0;
        return productos[0].Precio + CalcularPrecioTotalRecursivo(productos[1..]);
    }
}

public class Program {
    public static void Main() {
        Tienda tienda = new Tienda();
        tienda.MostrarProductos();
        Console.WriteLine($"Precio total: {tienda.CalcularPrecioTotal()}");
    }
}
