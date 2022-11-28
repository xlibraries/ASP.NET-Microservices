using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAync<T>(new APIRequest()
            {
                APIType = SD.APIType.POST,
                Data = productDTO,
                URL = SD.ProductAPIBase + "/api/products",
                AccessToken=""
            });
             
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAync<T>(new APIRequest()
            {
                APIType = SD.APIType.DELETE,
                URL = SD.ProductAPIBase + "/api/products" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAync<T>(new APIRequest()
            {
                APIType = SD.APIType.GET,
                URL = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductByIDAsync<T>(int id)
        {
            return await this.SendAync<T>(new APIRequest()
            {
                APIType = SD.APIType.GET,
                URL = SD.ProductAPIBase + "/api/products" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDTO productDTO)
        {
            return await this.SendAync<T>(new APIRequest()
            {
                APIType = SD.APIType.PUT,
                Data = productDTO,
                URL = SD.ProductAPIBase + "/api/products",
                AccessToken = ""
            });
        }
    }
}
