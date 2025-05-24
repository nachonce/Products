using BusinessLogic;
using Entidades;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Bienvenidos al gestor de productos Dummy");
        Console.WriteLine("Digite la opcion deseada");
        Console.WriteLine("1.Agregar Producto");
        Console.WriteLine("2.Consultar listado de productos");
        Console.WriteLine("3.Salir");
        var gestor = new ProductManager();
        var option = Int32.Parse(Console.ReadLine());
        bool salir = false;

        while (!salir)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite la informacion del producto a continuacion");
                    Console.WriteLine("Id:");
                    int Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nombre:");
                    String Name = Console.ReadLine();

                    Console.WriteLine("Precio:");
                    double Precio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Stock:");
                    int Stock = int.Parse(Console.ReadLine());

                    var producto = new Product
                    {
                        Name = Name,
                        Precio = Precio,
                        Stock = Stock,
                        Id = Id
                    };
                    try
                    {
                        gestor.AddProduct(producto);
                    }
                    catch (Exception ex) { 
                    Console.WriteLine($"{ex.Message}");
                    }
                    
                    
                    
                    
                    break;
                case 2:
                    Console.WriteLine("Listado de productos existentes");
                    var lista = gestor.GetProducts();

                    Console.WriteLine("Lista de productos");
                    foreach (var p in lista)
                    {
                        Console.WriteLine($"{p.Name}");
                    }



                    break;
                case 3:
                    salir = true;
                    Console.WriteLine("Saliendo...");
                    break;
                case 4:
                    Console.WriteLine("Opcion Invalida");
                    break;


            }
        }
    }
}



