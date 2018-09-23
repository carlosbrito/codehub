using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;

        public ValuesController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            Model.UserDomainViewModel objToMap = new Model.UserDomainViewModel();
            //Do some work here. 
            //And when we want to map do something like the following. 
            var result = _mapper.Map<Model.UserDomain>(objToMap);

            return new string[] { "value1", "value2" };
        }
    }
}
