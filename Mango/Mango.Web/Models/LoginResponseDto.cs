using Mango.Web.Models;

namespace Mango.Services.Web.Models.Dtos
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
