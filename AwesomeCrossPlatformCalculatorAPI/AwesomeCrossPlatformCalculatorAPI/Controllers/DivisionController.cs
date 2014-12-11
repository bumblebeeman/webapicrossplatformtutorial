using System.Web.Http;

namespace AwesomeCrossPlatformCalculatorAPI.Controllers
{
    [Authorize(Roles = "Admin,Dividers")]
    public class DivisionController : ApiController
    {
        public int Post(int a, int b)
        {
            return a / b;
        }
    }
}