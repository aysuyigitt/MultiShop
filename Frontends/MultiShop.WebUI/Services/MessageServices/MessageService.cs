using MultiShop.DtoLayer.DiscountDtos;
using MultiShop.DtoLayer.MessageDtos;
using System.Net.Http;
using static System.Net.WebRequestMethods;

namespace MultiShop.WebUI.Services.MessageServices
{
    public class MessageService : IMessageService
    {
        private readonly HttpClient _hhttpClient;

        public MessageService(HttpClient hhttpClient)
        {
            _hhttpClient = hhttpClient;
        }
        public async Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id)
        {
            var responseMessage = await _hhttpClient.GetAsync("http://localhost:5000/services/Message/UserMessages/GetMessageInbox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultInboxMessageDto>>();
            return values;
        }

        public async Task<List<ResultSendboxMessageDto>> GetSendBoxMessageAsync(string id)
        {
            var responseMessage = await _hhttpClient.GetAsync("http://localhost:5000/services/Message/UserMessages/GetMessageSendBox?id=" + id);
            var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultSendboxMessageDto>>();
            return values;
        }
    }
}

    //    public async Task<int> GetTotalMessageCountByReceiverId(string id)
    //    {
    //        var responseMessage = await _hhttpClient.GetAsync($"UserMessages/GetTotalMessageCountByReceiverId/{id}");
    //        var values = await responseMessage.Content.ReadFromJsonAsync<int>();
    //        return values;
    //    }
    //}


//$"orderings/GetOrderingByUserId/{id}"
//http://localhost:5000/services/Message/UserMessages/GetMessageSendBox?id=" + id)