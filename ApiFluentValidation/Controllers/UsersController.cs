using ApiFluentValidation.Context;
using ApiFluentValidation.Entities;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFluentValidation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IValidator<User> _validator;
        private readonly AppDbContext _context;

        public UsersController(IValidator<User> validator, AppDbContext context)
        {
            _validator = validator;
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            ValidationResult result = await _validator.ValidateAsync(user);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors);
            }

            // Adiciona o usuário ao banco de dados
            user.Id = Guid.NewGuid(); // Gera um novo GUID para o usuário
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpGet("by-id/{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("by-name/{firstName}")]
        public async Task<IActionResult> GetUserByFirstName(string firstName)
        {
            var user = await _context.Users.Where(u => u.FirstName == firstName).FirstOrDefaultAsync();

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
