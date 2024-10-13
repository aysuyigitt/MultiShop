using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.Interfaces;
using MultiShop.WebUI.Services.MessageServices;

namespace MultiShop.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IUserService _userSevice;

        public MessageController(IMessageService messageService, IUserService userService)
        {
            _messageService = messageService;
            _userSevice = userService;
        }

        public async Task< IActionResult> Inbox()
        {
            var user=await _userSevice.GetUserInfo();   
            var values =await _messageService.GetInboxMessageAsync(user.Id);
            return View(values);
        }
        public async Task<IActionResult> SendBox()
        {
            var user = await _userSevice.GetUserInfo();
            var values = await _messageService.GetSendBoxMessageAsync(user.Id);
            return View(values);
        }
    }
}
