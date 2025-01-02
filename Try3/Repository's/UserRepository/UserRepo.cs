using Try3.DTO_s.UserDTO_s;
using Try3.Models;

namespace Try3.Repository_s.UserRepository
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContextt _context;

        public UserRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddAllUsers(AddAllDTO dto)
        {
            var res = new User()
            {
                UserEmail = dto.UserEmail,
                UserPhone = dto.UserPhone,
                Role = new Role()
                {
                    Rolee= dto.Roledto.Rolee,
                },
                Reactions = dto.Reactions.Select(r => new Reaction
                {
                    ReactionType = r.ReactionType,
                }).ToList(),
                Blogs = dto.Blogs.Select(x => new Blogs
                {
                    Title = x.Title,
                    date_Time = x.date_Time
                }).ToList(),
            };
            _context.users.Add(res);
            _context.SaveChanges();
        }

        public void UpdateAll(int id, AddAllDTO dto)
        {
            var res = _context.users.FirstOrDefault(x =>x.UserId == id);

            res.UserEmail = dto.UserEmail;
            res.UserPhone = dto.UserPhone;
            res.Reactions = dto.Reactions.Select(a => new Reaction
            {
                ReactionType = a.ReactionType,
            }).ToList();
            res.Blogs = dto.Blogs.Select(q => new Blogs
            {
                date_Time = q.date_Time,
               Title = q.Title,
            }).ToList();
            _context.users.Update(res);
            _context.SaveChanges();
        }
    }
}
