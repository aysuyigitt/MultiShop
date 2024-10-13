using MultiShop.DtoLayer.IdentityDtos.UserDtos;
using Newtonsoft.Json;

namespace MultiShop.WebUI.Services.UserIdentityServices
{
    public class UserIdentityService : IUserIdentityService
    {
        private readonly HttpClient _hhttpClient;

        public UserIdentityService(HttpClient hhttpClient)
        {
            _hhttpClient = hhttpClient;
        }
        public async Task<List<ResultUserDto>> GetAllUserListAsync()
        {
            var responseMessage = await _hhttpClient.GetAsync("http://localhost:5001/api/users/GetAllUserList");
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            var values=JsonConvert.DeserializeObject<List<ResultUserDto>>(jsonData);
            return values;
        }
    }
}
