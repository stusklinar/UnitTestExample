using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DB;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISimpleCalc _calc;
        private readonly IRepoLayer _repoLayer;

        public ValuesController(ISimpleCalc calc, IRepoLayer repoLayer)
        {
            _calc = calc;
            _repoLayer = repoLayer;
        }
        // GET api/values/5
        [HttpGet("")]
        public IEnumerable<double> Get()
        {
            var numbers = _repoLayer.GetNumbers();

            return numbers.Select(kvp => _calc.Calc(kvp.Key, kvp.Value));


        }

    }
}
