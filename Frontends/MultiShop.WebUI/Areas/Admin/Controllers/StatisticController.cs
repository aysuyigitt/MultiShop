using Microsoft.AspNetCore.Mvc;
using MultiShop.WebUI.Services.CatalogService.CommentServices;
using MultiShop.WebUI.Services.DiscountServices;
using MultiShop.WebUI.Services.StatisticServices.CatalogStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.DiscountStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.MessageStatisticServices;
using MultiShop.WebUI.Services.StatisticServices.UserStatisticServices;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly ICatalogStatisticService _catalogStatisticService;
        private readonly IUserStatisticService _userStatisticService;
        private readonly ICommentService _commentService;
        private readonly IDiscountStatisticService _discountStatisticService;
        private readonly IMessageStatisticService _messageStatisticService;

        public StatisticController(ICatalogStatisticService catalogStatisticService, IUserStatisticService userStatisticService, ICommentService commentService, IDiscountStatisticService discountStatisticService, IMessageStatisticService messageStatisticService)
        {
            _catalogStatisticService = catalogStatisticService;
            _userStatisticService = userStatisticService;
            _commentService = commentService;
            _discountStatisticService = discountStatisticService;
            _messageStatisticService = messageStatisticService;
        }

        public async Task<ActionResult> Index()
        {
            var getBrandCount = await _catalogStatisticService.GetBrandCount();
            var getProductCount = await _catalogStatisticService.GetProductCount();
            var getCategoryCount = await _catalogStatisticService.GetCategoryCount();
            var getMaxPriceproductName = await _catalogStatisticService.GetMaxPriceproductName();
            var getMinPriceproductName = await _catalogStatisticService.GetMinPriceproductName();
            var getUserCount = await _userStatisticService.GetUserCount();

         
            var getTotalCommentCount = await _commentService.GetTotalCommentCount();
            var getActiveCommentCount = await _commentService.GetActiviteCommentCount();
            var getPassiveCommentCount = await _commentService.GetPassiveCommentCount();

            var getDiscountCouponCount = await _discountStatisticService.GetDiscountCouponCount();

            var getMessageTotalCount = await _messageStatisticService.GetTotalMessageCount();

            ViewBag.getBrandCount = getBrandCount;
            ViewBag.getProductCount = getProductCount;
            ViewBag.getCategoryCount = getCategoryCount;
            ViewBag.getMaxPriceproductName = getMaxPriceproductName;
            ViewBag.getMinPriceproductName = getMinPriceproductName;

            ViewBag.getUserCount = getUserCount;

            ViewBag.getTotalCommentCount = getTotalCommentCount;
            ViewBag.getActiveCommentCount = getActiveCommentCount;
            ViewBag.getPassiveCommentCount = getPassiveCommentCount;

            ViewBag.getDiscountCouponCount = getDiscountCouponCount;

            ViewBag.getMessageTotalCount = getMessageTotalCount;
           
            return View();
        }
    }
}
