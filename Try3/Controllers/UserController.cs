using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Try3.DTO_s.UserDTO_s;
using Try3.Repository_s.UserRepository;

namespace Try3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        [HttpPost]
        public IActionResult AddAllUsers(AddAllDTO dto)
        {
            _userRepo.AddAllUsers(dto);
            return Ok(dto);
        }
        [HttpPut]
        public IActionResult UpdateAll(int id ,AddAllDTO dto) 
        { 
          _userRepo.UpdateAll(id,dto);
            return Ok();
        }
    }
}
