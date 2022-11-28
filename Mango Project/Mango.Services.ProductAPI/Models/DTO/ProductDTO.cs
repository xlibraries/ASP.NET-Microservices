using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public string ProductImgURL { get; set; }
    }
}
