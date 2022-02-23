using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TE19DWEBAPIKURS.Models;
using TE19DWEBAPIKURS.Services.StudentService;

namespace TE19DWEBAPIKURS.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) 
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetStudent() 
        {
            return Ok(_studentService.GetStudentList());
        }
    }
}