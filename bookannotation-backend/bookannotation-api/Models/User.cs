namespace bookannotation_api.Models
{
    public class User : BaseModel
    {
        public int UserId { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Role { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}