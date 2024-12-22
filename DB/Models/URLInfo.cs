using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    [Table("URLInfo")]
    public class URLInfo : BaseModel
    {
        [Required]
        public string URL { get; set; }
        [Required]
        public string OriginalUrl { get; set; }
        [Required]
        public DateOnly Created { get; set; }

        
        public int CreatedId { get; set; }
        public UserInfo Creator { get; set; }
    }
}
