using System.Collections.Generic;
using LMSystem.Data.Models;

namespace LMSystem.Data
{
    public interface IVideoService
    {
        IEnumerable<Video> GetAll();
        IEnumerable<Video> GetByDirector(string author);
        Video Get(int id);
        void Add(Video newVideo);
    }
}