using Mango.Services.Web;
using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;
        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateProductAsync(ProductDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            { 
                ApiType= SD.ApiType.POST,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/product"
            });

        }

        public async Task<ResponseDto?> DeleteProductAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/product" + id
            });

        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto()
            { 
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/product/"
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/product" + id
            });
        }

        public async Task<ResponseDto?> UpdateProductAsync(ProductDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            { 
                ApiType = SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/product"
            });

        }
    }
}
