using General;
using Main.Interface;
using Main.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFriend.Controllers
{
    [Authorize]
    public class FriendController : Controller
    {
        private readonly IFriendBusiness friendBusiness;
        public FriendController(IFriendBusiness friendBusiness)
        {
            this.friendBusiness = friendBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult AddFriend(FriendModel model)
        {
            if (ModelState.IsValid)
            {
                model.Name = model.Name.StripHTML();
                model.DateOfBirth = model.DateOfBirth.StripHTML();
                if (friendBusiness.AddFriend(model,User.GetUserId()))
                {
                    return Json(new { success = true, msg = MessageHelper.SaveSuccess });
                }
            }
            CoreLogger.Instance.Error(this.CreateMessageLog(ModelState.GetMessage()));
            return Json(new { success = false, msg = MessageHelper.SaveNotSuccess });
        }
        public JsonResult EditFriend(FriendModel model)
        {
            if (ModelState.IsValid)
            {
                if (friendBusiness.EditFriend(model))
                {
                    return Json(new { success = true, msg = MessageHelper.SaveSuccess });
                }
            }
            CoreLogger.Instance.Error(this.CreateMessageLog(ModelState.GetMessage()));
            return Json(new { success = false, msg = MessageHelper.SaveNotSuccess });
        }
        public JsonResult DelFriend(FriendModel model)
        {
            if (model != null)
            {
                if (friendBusiness.DelFriend(model))
                {
                    return Json(new { success = true, msg = MessageHelper.DelSuccess });
                }
            }
            return Json(new { success = false, msg = MessageHelper.DelNotSuccess });
        }
        public JsonResult GetListFriend()
        {
            var list = friendBusiness.GetListFriend(User.GetUserId());
            return Json(new { data = list });
        }
    }
}
