namespace bookannotation_api.Services.User
{
    using bookannotation_api.Helpers;
    using bookannotation_api.Models;
    using bookannotation_api.Repositories.User;

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(UserRegisterDto user)
        {
            var passwordhelper = new PasswordHelper();

            passwordhelper.CreatePasswordHash(user.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var newUser = new User {
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = user.Email,
                Birthday = user.Birthday,
                Name = user.Name,
                LastName = user.LastName,
                Country = user.Country,
                Role = "User"
            };

            return await _userRepository.AddAsync(newUser);
        }
    }
}
