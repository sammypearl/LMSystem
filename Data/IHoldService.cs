using System.Collections.Generic;
using LMSystem.Data.Models;

namespace LMSystem.Data
{
    public interface IHoldService
    {
        IEnumerable<AssetType> GetAll();
        AssetType Get(int id);
        void Add(AssetType newType);
    }
}