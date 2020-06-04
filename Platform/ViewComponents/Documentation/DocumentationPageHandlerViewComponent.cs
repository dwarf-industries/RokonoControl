
namespace Platform.ViewComponents.Documentation
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.DatabaseHandlers;
    using Rokono_Control.Models;

    [ViewComponent(Name = "DocumentationPageHandler")]

    public class DocumentationPageHandlerViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public DocumentationPageHandlerViewComponent(RokonoControlContext context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }
        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            ViewData["CategoryField"] = request.UserId;
            if(request.Id == 0)
            {
                ViewData["Modal"] = 1;
                return View("/Views/Shared/Components/Documentation/DocumentationPageHandler/Default.cshtml");
            }
            using(var context = new DatabaseController(Context, Configuration))
            {
                ViewData["PageData"] = context.GetDocumentationPage(request.Id); 
            }
            ViewData["Modal"] = 0;
            return View("/Views/Shared/Components/Documentation/DocumentationPageHandler/Default.cshtml");
        }
    }
}