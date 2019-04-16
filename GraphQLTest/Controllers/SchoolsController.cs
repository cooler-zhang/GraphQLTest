using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : Controller
    {
        private readonly SchoolService _schoolService;

        public SchoolsController(SchoolService schoolService)
        {
            this._schoolService = schoolService;
        }

        [GraphQLMetadata("schools")]
        [HttpGet]
        public IList<School> Get()
        {
            return _schoolService.GetLists();
        }
    }
}