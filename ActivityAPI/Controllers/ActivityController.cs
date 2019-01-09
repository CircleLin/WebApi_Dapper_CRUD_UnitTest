using System.Web.Http;
using ActivityAPI.Service;
using System.Web.Http.Cors;

namespace ActivityAPI.Controllers
{
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix("api/Activity")]
    public class ActivityController : ApiController
    {
        IActivityService service;
        public ActivityController(IActivityService _service)
        {
            service = _service;
        }

       
    }
}