using DataPersistence;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public  class ProductManager
    {
        
        public void AddProduct(Product producto) {
            if (string.IsNullOrEmpty(producto.Name)) {
                throw new Exception("El nombre esta vacio");

       }

            if (producto.Stock < -1) {
                throw new Exception("El stock no puede ser negativo");
            }

            if (producto.Precio <= 0)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }


            var fm = new FileManager();
            fm.SaveProducts(producto);

           




           


        }

        public List<Product> GetProducts() { 
        var list = new List<Product>();

            
            return list;
        }
    }
}
