using Mango.Services.ProductAPI.Models.DTO;
using Mango.Services.ProductAPI.Models.DTOs;
using Mango.Services.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.ProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
        protected ResponseDTO _response;
        private IProductRepository _productRepository;

        public ProductAPIController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            this._response = new ResponseDTO();
        }
        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<ProductDTO> productDTOs = await _productRepository.GetProducts();
                _response.Result = productDTOs;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErorrMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

        [HttpGet]
        //Route helps to differentiate when an API request is made where should it be redirected to.
        //Also as in the defination we haven't defined that it expects an id so by using Route we need to define it.
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                ProductDTO productDTOs = await _productRepository.GetProductById(id);
                _response.Result = productDTOs;

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErorrMessages = new List<string>() { ex.ToString() };
            }

            return _response;
        }

    }
}
