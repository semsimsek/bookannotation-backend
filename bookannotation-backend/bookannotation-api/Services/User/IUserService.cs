namespace bookannotation_api.Services.User
{
    using bookannotation_api.Models;
    public interface IUserService
    {
        Task<User> CreateUser(UserRegisterDto user);
    }
}
