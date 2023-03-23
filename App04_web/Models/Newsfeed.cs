using System.ComponentModel.DataAnnotations;
namespace App04_web.Models

{
    public class Newsfeed
    {
        [Key]
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Message { get; set; }

    }
}
