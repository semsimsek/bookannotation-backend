namespace bookannotation_api.Repositories.Book
{
    using bookannotation_api.Models;

    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
