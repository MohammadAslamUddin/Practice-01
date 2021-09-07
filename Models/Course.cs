using System.ComponentModel.DataAnnotations;

namespace Practice_01.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter a Course Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter a Course Code")]
        [StringLength(7,MinimumLength = 5, ErrorMessage = "Code must be between 5 to 7")]
        public string Code { get; set; }
    }
}