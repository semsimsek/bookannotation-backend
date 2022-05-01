namespace bookannotation_api.Models
{
    public class Book : BaseModel
    {
        public int BookId { get; set; }
        [Required]
        public string? BookName { get; set; }
        public string? BookCoverImageUrl { get; set; }
        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        [ForeignKey("BookId")]
        public ICollection<Note>? Notes { get; set; }
    }
}