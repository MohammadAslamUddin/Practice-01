using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practice_01.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter a Course Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter a Course Code")]
        [StringLength(7, MinimumLength = 5, ErrorMessage = "Code must be between 5 to 7")]
        [Index(IsUnique = true)]
        public string Code { get; set; }

    }
}