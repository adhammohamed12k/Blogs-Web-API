using Try3.DTO_s.UserDTO_s;

namespace Try3.Repository_s.UserRepository
{
    public interface IUserRepo
    {
        public void AddAllUsers(AddAllDTO dto);
        public void UpdateAll( int id ,AddAllDTO dto);
    }
}
