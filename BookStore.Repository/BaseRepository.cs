using BookStore.Models.ViewModels;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly BookStore1Context _context = new BookStore1Context();
    }
}
