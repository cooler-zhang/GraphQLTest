using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLTest.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Test()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public string Test1()
        {
            var schema = Schema.For(@"
type School {
    id: String
    name: String
}

type SchoolService {
    first: School
}", _ =>
{
    _.Types.Include<SchoolService>();
});

            return schema.Execute(_ =>
            {
                _.Query = "{ first { name } }";
                //_.Query = "{{ get(id: \"No.1\") {{ id name }} }}";
            });
        }

        [HttpGet]
        public string Test2()
        {
            var schema = Schema.For(@"
              type Student {
                id: Int
                name: String
              }

              type Query {
                student(id: ID): Student
              }
            ", _ =>
            {
                _.Types.Include<Student>();
            });

            return schema.Execute(_ =>
            {
                _.Query = $"{{ school(id: 1) {{ id name }} }}";
            });
        }
    }
}
