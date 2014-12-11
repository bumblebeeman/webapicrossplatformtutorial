using System.Web.Http;

namespace AwesomeCrossPlatformCalculatorAPI.Controllers
{
    [Authorize(Roles = "Admin,Subtractors")]
    public class SubtractionController : ApiController
    {
        public int Post(int a, int b)
        {
            return a - b;
        }
    }
}
