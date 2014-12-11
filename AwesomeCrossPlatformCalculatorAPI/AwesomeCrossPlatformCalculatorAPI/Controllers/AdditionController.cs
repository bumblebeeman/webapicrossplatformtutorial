using System.Web.Http;

namespace AwesomeCrossPlatformCalculatorAPI.Controllers
{
    public class AdditionController : ApiController
    {
        public int Post(int a, int b)
        {
            return a + b;
        }
    }
}