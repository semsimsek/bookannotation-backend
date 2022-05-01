namespace bookannotation_api.Repositories.User
{
    using bookannotation_api.Models;
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }
    }
}
