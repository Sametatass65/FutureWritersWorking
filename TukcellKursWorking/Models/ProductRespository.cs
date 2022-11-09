using MessagePack;
using TukcellKursWorking.Models;

namespace TukcellKursWorking.Models
{
    public class ProductRespository
    {
        private static List<Product> _products = new List<Product>()
        {          
            new() { Id = 1, ProductName = "Televizyon", UnitPrice = 2, UnitsInStock = 2 },        
            new () { Id = 2, ProductName = "Televizyon1", UnitPrice = 2, UnitsInStock = 2 },           
            new () { Id = 3, ProductName = "Televizyon2", UnitPrice = 2, UnitsInStock = 2 },       
            new() { Id = 4, ProductName = "Televizyon3", UnitPrice = 2, UnitsInStock = 2 }
        };
       
        public List<Product> GetAll()=>_products;
      
        public void Add(Product product)=> _products.Add(product);
       
        public void Remove(int id)
        { 
            var result = _products.FirstOrDefault(p=> p.Id == id);
            if (result == null)
            {
                throw new Exception($"DataBasede Böyle bir {id} bulunmamaktadır");
            }
            _products.Remove(result);
        }
        public void Update(Product product)
        {
            var result = _products.FirstOrDefault(p=>p.Id == product.Id);
            if (result == null)
            {
                throw new Exception("Databasede eböyle bir ürün bulunmamaktadır");
            }
            result.ProductName = product.ProductName;
            result.UnitPrice = product.UnitPrice;
            result.UnitsInStock = result.UnitsInStock;

            var index = _products.FindIndex(x=>x.Id == product.Id);
            _products[index] = result;
            

        }
    }
}
