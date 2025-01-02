using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Try3.DTO_s.ReactionDTO_s;
using Try3.Repository_s.ReactionRepository;
using Try3.Repository_s.UserRepository;

namespace Try3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {
        private readonly IReactionRepo _repo;

        public ReactionController(IReactionRepo repo)
        {
            this._repo = repo;
        }
        [HttpPost]
        public IActionResult AddAll(ReactionAddAll dto)
        {
            _repo.AddAll(dto);
            return Ok(dto);
        }
    }
}
