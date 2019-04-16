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
    public class StudentsController : Controller
    {
        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            this._studentService = studentService;
        }

        [GraphQLMetadata("students")]
        [HttpGet]
        public IList<Student> Get()
        {
            return _studentService.GetLists();
        }
    }
}