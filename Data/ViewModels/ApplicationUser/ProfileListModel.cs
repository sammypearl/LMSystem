using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSystem.Data.ViewModels.ApplicationUser
{
    public class ProfileListModel
    {
        public IEnumerable<ProfileModel> Profiles { get; set; }
    }
}
