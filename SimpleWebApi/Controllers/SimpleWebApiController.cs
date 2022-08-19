using Sitecore.Services.Infrastructure.Web.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SimpleWebApi.Controllers
{
    // TODO 本番環境ではCORSの設定を必ず絞ってください。これは全許可となっています。
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SimpleWebApiController : ServicesApiController
    {
        public SimpleWebApiController()
        {
        }

        [HttpGet]
        public string Stats()
        {
            return "ok SimpleWebApi";
        }
    }
}
