using System.Web.Http;
using ActivityAPI.Service;
using System.Web.Http.Cors;
using System.Net.Http;
using System.Web.Http.Description;
using System.Collections.Generic;

namespace ActivityAPI.Controllers
{
    /// <summary>
    /// 活動controller
    /// </summary>       
    public class ActivityController : BaseApiController
    {
        IActivityService service;
        public ActivityController(IActivityService _service)
        {
            service = _service;
        }

        /// <summary>
        /// 活動清單
        /// </summary>
        /// <returns></returns>         
        public IEnumerable<Models.Activity> GetActivitys()
        {
            return service.GetAll();
        }

        /// <summary>
        /// 取得單項活動
        /// </summary>
        /// <param name="Id">活動ID</param>
        /// <returns></returns>
        [ResponseType(typeof(Models.Activity))]           
        public IHttpActionResult GetActivity(int Id)
        {            
            var act = service.Get(Id);
            if(act != null)
            {
                return Ok(act);
            }
            else
            {
                return NotFound();
            }
        }

        /// <summary>
        /// 新增活動
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        [HttpPost]
        [ResponseType(typeof(void))]  
        public IHttpActionResult PostActivity([FromBody] Models.Activity activity)
        {    
            service.Add(activity);
            return Ok();
        }

        /// <summary>
        /// 報名活動
        /// </summary>
        /// <param name="Id">活動ID</param>
        /// <returns></returns>
        [Route("Register/{Id:int}")]
        [HttpPost]
        [ResponseType(typeof(HttpResponseMessage))]
        public HttpResponseMessage RegActivity(int Id)
        {
            HttpResponseMessage response;
           
            bool isfullbooked = service.IsFullyBooked(Id);

            if (isfullbooked)
            {
                response = Request.CreateResponse();
                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
                response.Content = new StringContent("活動人數已額滿");
                return response;
            }
            else
            {
                service.RegActivity(Id);
                response = Request.CreateResponse();
                response.StatusCode = System.Net.HttpStatusCode.OK;
                response.Content = new StringContent("報名活動成功");
                return response;
            }
        }       
    }
}