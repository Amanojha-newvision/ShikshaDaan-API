using AutoMapper;
using Database;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShiskhaDaanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public EmployeeController(ApplicationContext context, IMapper mapper)
        {
             _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeDto>>> GetEmployees()
        {
            return await _context.Employees.Select(x => _mapper.Map<EmployeeDto>(x)).ToListAsync();
        }

    }
}
