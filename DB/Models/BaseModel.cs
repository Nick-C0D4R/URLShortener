using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
