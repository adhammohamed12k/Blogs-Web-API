using Try3.DTO_s.ReactionDTO_s;
using Try3.Models;

namespace Try3.Repository_s.ReactionRepository
{
    public class ReactionRepo : IReactionRepo
    {
        private readonly AppDbContextt _context;

        public ReactionRepo(AppDbContextt context)
        {
            _context = context;
        }
        public void AddAll(ReactionAddAll dto)
        {
            var reactoin = new Reaction()
            {
                ReactionType = dto.ReactionType,
                users = dto.userDTOs.Select(x => new User
                {
                    UserEmail = x.UserEmail,
                    UserPhone = x.UserPhone,
                    Role = new Role
                    {
                        Rolee = x.Roledto.Rolee,
                    },
                    Blogs = x.Blogs.Select(e => new Blogs
                    {
                        Title = e.Title,
                        date_Time = e.date_Time,
                    }).ToList(),
                }).ToList(),
            };
            _context.reactions.Add(reactoin);
            _context.SaveChanges();
        }
    }
}
