using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MvcRegression.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpPost]
        public void Test(List<TestClass> filters = null)
        {
        }
    }

    public class TestClass
    {
        public string Test { get; set; }
    }
}