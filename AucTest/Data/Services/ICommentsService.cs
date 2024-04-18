using AucTest.Models;

namespace AucTest.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
