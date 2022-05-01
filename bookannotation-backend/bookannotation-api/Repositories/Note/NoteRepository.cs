namespace bookannotation_api.Repositories.Note
{
    using bookannotation_api.Data;
    using bookannotation_api.Models;
    public class NoteRepository : BaseRepository<Note>, INoteRepository
    {
        public NoteRepository(DataContext context) : base(context)
        {
        }
    }
}