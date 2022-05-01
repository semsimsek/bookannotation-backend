namespace bookannotation_api.Models
{
    public class Note : BaseModel
    {
        public int NoteId { get; set; }
        [Required]
        public string? NoteHeader { get; set; }
        public string? NoteBody { get; set; }
        [ForeignKey("UserId")]
        public User? User;
    }
}