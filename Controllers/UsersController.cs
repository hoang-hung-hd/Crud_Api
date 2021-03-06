using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Simple_Crud_Api.Models.Users;
using Simple_Crud_Api.Services;

namespace Simple_Crud_Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {

        private IUserService _userService;
        private IMapper _mapper;

        public UsersController(
            IUserService userService,
            IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var user = _userService.GetById(id);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(CreateRequest model)
        {
            _userService.Create(model);
            return Ok(new { message = "User created" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateRequest model)
        {
            _userService.Update(id, model);
            return Ok(new { message = "User updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok(new { message = "User deleted" });
        }
    }
}
