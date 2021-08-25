using System.ComponentModel.DataAnnotations;

namespace LMSystem.Data.Models
{
    public class Video : LibraryAsset
    {
        [Required] 
        public string Director { get; set; }
    }
}