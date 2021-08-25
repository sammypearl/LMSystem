using System.Collections.Generic;
using LMSystem.Data.Models;

namespace LMSystem.Data
{
    public interface IAssetType
    {
        IEnumerable<AssetType> GetAll();
        AssetType Get(int id);
        void Add(AssetType newType);
    }
}