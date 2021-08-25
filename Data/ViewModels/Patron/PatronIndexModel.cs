using System.Collections.Generic;

namespace LMSystem.Data.ViewModels.Patron
{
    public class PatronIndexModel
    {
        public IEnumerable<PatronDetailModel> Patrons { get; set; }
    }
}