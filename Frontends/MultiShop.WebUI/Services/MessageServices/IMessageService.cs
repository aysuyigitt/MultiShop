using MultiShop.DtoLayer.MessageDtos;

namespace MultiShop.WebUI.Services.MessageServices
{
    public interface IMessageService
    {
        Task<List<ResultInboxMessageDto>> GetInboxMessageAsync(string id);

        Task<List<ResultSendboxMessageDto>> GetSendBoxMessageAsync(string id);

        //Task<int> GetTotalMessageCountByReceiverId(string id);


    }
}
