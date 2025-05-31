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
        private FileManager fm = new FileManager();
        public void AddProduct(Product producto) {
            if (string.IsNullOrEmpty(producto.Name)) {
                throw new Exception("El nombre esta vacio");

       }

            if (producto.Stock < -1) {
                throw new Exception("El stock no puede ser negativos");
            }

            if (producto.Precio <= 0 ) 
            {
                throw new Exception("Los precios deben ser mayor a 0");
            }


            
            fm.SaveProducts(producto);

           




           


        }

        public List<Product> GetProducts() {
            return fm.ReadProducts();
        }
    }
}
