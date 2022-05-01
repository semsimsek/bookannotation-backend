namespace bookannotation_api.Services.Book
{
    using bookannotation_api.Models;
    using bookannotation_api.Repositories.Book;
    using System.Collections.Generic;

    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;   
        }   
       
        public List<Book> GetAllBooks(int usr)
        {
            try {

                var list = _bookRepository.GetAll(x => x.UserId == usr).ToList();

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't create note: {ex.Message}");
            }

        }
    }
}
