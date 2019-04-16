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
    public class SchoolController : Controller
    {
        private readonly SchoolService _schoolService;

        public SchoolController(SchoolService schoolService)
        {
            this._schoolService = schoolService;
        }

        [HttpGet("{id}")]
        [GraphQLMetadata("school")]
        public School Get(string id)
        {
            return _schoolService.Get(id);
        }
    }
}