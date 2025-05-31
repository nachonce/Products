using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    public class FileManager
    {
        private static string ruta = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "Productos.txt"
);
         



        //leer la lista de prodcutos de un txt y cragrlo en una listas

        public List<Product> ReadProducts()
        {
           
            var products = new List<Product>();

            if (!File.Exists(ruta))
                return products;

            foreach (var linea in File.ReadAllLines(ruta))
            {
               

                var partes = linea.Split(',');

                if (partes.Length == 4 &&
                    int.TryParse(partes[0], out int id) &&
                    double.TryParse(partes[2], out double precio) &&
                    int.TryParse(partes[3], out int stock))
                {
                    products.Add(new Product
                    {
                        Id = id,
                        Name = partes[1],
                        Precio = precio,
                        Stock = stock
                    });
                }
                else
                {
                    Console.WriteLine($"❌ Línea inválida: {linea}");
                }
            }

            return products;
        }





        public void SaveProducts(Product product)
        {

            String linea = $"{product.Id},{product.Name},{product.Precio},{product.Stock}";

            using (StreamWriter sw = new StreamWriter(ruta, append: true)) { 
            
            sw.WriteLine(linea);
            }
        }
    }
}
