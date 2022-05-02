namespace bookannotation_api.Models.Dtos
{
    public class UserRegisterDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
    }
}
