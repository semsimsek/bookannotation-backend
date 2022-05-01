namespace bookannotation_api.Services.Book
{
    using bookannotation_api.Models;
    public interface IBookService
    {
        List<Book> GetAllBooks(int userId);
    };
}
