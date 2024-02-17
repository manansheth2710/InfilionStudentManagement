using InfilionStudentManagement.DAL.Models;
using InfilionStudentManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InfilionStudentManagement.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolDbContext _context;
        private IHttpClientFactory _clientFactory;
        public HttpClient Http;
        public StudentController(SchoolDbContext context, IHttpClientFactory clientFactory)
        {
            _context = context;
            Http = _clientFactory.CreateClient("SchoolApi");
            _clientFactory = clientFactory;

        }
        // GET: api/<StudentController>
        [HttpGet]
        [Route("/GetStudents")]
        public async Task<List<TblStudents>> Get()
        {
            List<TblStudents> students = new();

            students = await _context.TblStudents.ToListAsync();

            if (students is not null)
            {
                return students;
            }
            return new List<TblStudents>();
        }

        // POST api/<StudentController>
        [HttpPost]
        [Route("/AddStudent")]
        public bool Post([FromBody] TblStudents tblStudents)
        {
            try
            {
                _context.TblStudents.Add(tblStudents);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public bool Put(int id)
        {
            var student = _context.TblStudents.Where(s => s.Id == id).FirstOrDefault();
            if (student is not null)
            {
                _context.TblStudents.Remove(student);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete]
        [Route("/DeleteStudent/{id}")]
        public bool Delete(int id)
        {
            var student = _context.TblStudents.Where(s => s.Id == id).FirstOrDefault();
            if (student is not null)
            {
                _context.TblStudents.Remove(student);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
