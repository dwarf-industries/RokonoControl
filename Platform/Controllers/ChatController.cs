using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Platform.Models;
using Rokono_Control.DatabaseHandlers;
using Rokono_Control.Models;

namespace Platform.Controllers
{
    public class ChatController : Controller
    {
        RokonoControlContext Context;
        IConfiguration Configuration;

        public ChatController(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }


        [HttpPost]
        public List<OutgoingChatItem> GetChatChannels([FromBody] IncomingIdRequest request)
        {
            var result = new List<OutgoingChatItem>();
            using(var context = new DatabaseController(Context, Configuration))
            {
                result = context.GetChatChannels(request.Id);
            }
            return result;
        }

        [HttpPost]
        public List<OutgoingChatItem> AddNewCategory([FromBody] IncomingIdRequest request)
        {
            var result = new  List<OutgoingChatItem>();
            using(var context = new DatabaseController(Context, Configuration))
            {
                context.AddNewChatChannel(request);
                result = context.GetChatChannels(request.Id);
            }
            return result;
        }

        [HttpPost]
        public List<OutgoingChatItem> AddNewChatRoom([FromBody] IncomingIdRequest request)
        {
            var result = new  List<OutgoingChatItem>();
            using(var context = new DatabaseController(Context, Configuration))
            {
                context.AddNewChatRoom(request);
                result = context.GetChatChannels(request.WorkItemType);
            }
            return result;
        }
        [HttpPost]
        public List<AssociatedUserChatNotifications> GetChannelNotifications([FromBody] IncomingIdRequest request)
        {
            var result = new  List<AssociatedUserChatNotifications>();
            var user =  Request.HttpContext.User.Claims.ElementAt(1);
            var id = int.Parse(user.Value);
            using(var context = new DatabaseController(Context, Configuration))
            {
                result = context.GetChatNotifications(request.Id, id);
            }
            return result;
        }

        [HttpGet]
        public IActionResult GetChatRoom(int id, int projectId) 
        {
            return ViewComponent("ChatWIndow", new IncomingIdRequest{
                Id = id,
                ProjectId = projectId
            });
        }

        [HttpGet]
        public IActionResult GetUserDirectMessageControl(int projectId,int id) 
        {
            return ViewComponent("ChatUserPersonaBox", new IncomingIdRequest{
                Id = id,
                ProjectId = projectId
            });
        }
    }
}