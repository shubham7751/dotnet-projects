using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models.Domain
{
    [Table("TagTBL")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set;}
        public string? DisplayName { get; set;}
        public ICollection<BlogPost>?  BlogPosts { get; set; }
      
    }
}
