using AutoMapper;
using Domain.Dtos;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StudentsController(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var students = await _context.students.ToListAsync();
              
          
            return Ok(_mapper.Map<List<StudentDto>>(students));
        }
    }
}
