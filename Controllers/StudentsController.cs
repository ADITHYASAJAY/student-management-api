using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.DTOs;
using StudentManagement.API.Services;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController:ControllerBase
    {
        private readonly IStudentService _service;
        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetStudentAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateStudentDto dto)
        {
            await _service.CreateStudentAsync(dto);
            return Ok(dto);
        }
    }
}
