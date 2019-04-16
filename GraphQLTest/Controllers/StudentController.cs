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
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            this._studentService = studentService;
        }

        [HttpGet("{id}")]
        [GraphQLMetadata("student")]
        public Student Get(int id)
        {
            return _studentService.Get(id);
        }
    }
}