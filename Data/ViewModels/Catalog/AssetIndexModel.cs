using System.Collections.Generic;

namespace LMSystem.Data.ViewModels.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}