using System.Web.Http;

namespace AwesomeCrossPlatformCalculatorAPI.Controllers
{
    [Authorize(Roles = "Admin,Multipliers")]
    public class MultiplicationController : ApiController
    {
        public int Post(int a, int b)
        {
            return a * b;
        }
    }
}