using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models.Domain
{
    [Table("BlogPostTbl")]
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public string? Heading { get; set; }
        public string? PageTitle { get; set; }
        public string? Content { get; set; }
        public string? ShortDescription { get; set; }   
        public string? FeaturedImageUrl { get; set; } 
        public string UrlHandle { get; set; }
        public DateTime PublishedData { get; set; }
        public string? Author { get; set; }
        public bool Visible { get; set; }
       
        public ICollection<Tag>  Tags{ get; set; }
    }
}
