
namespace Platform.ViewComponents
{
    using System.Linq;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Platform.DataHandlers;
    using Platform.DataHandlers.Interfaces;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    public class ChatWIndowViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;

        public ChatWIndowViewComponent(RokonoControlContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }

        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            
            ViewData["TransferId"] = request.Id;
            ViewData["ProjectId"] = request.ProjectId;
            ViewData["IsPersonal"] = request.UserId;
            using(var context = new DatabaseController(Context,Configuration))
            {
                ViewData["ChatMessages"] = context.GetCannelMessages(request.Id, request.UserId, UserId);
            }
            return View();
        }
    }
}