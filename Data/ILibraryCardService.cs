using System.Collections.Generic;
using LMSystem.Data.Models;

namespace LMSystem.Data
{
    public interface ILibraryCardService
    {
        IEnumerable<LibraryCard> GetAll();
        LibraryCard Get(int id);
        void Add(LibraryCard newCard);
    }
}