using System;
using System.ComponentModel.DataAnnotations;

namespace Practice_01.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter a Student's Name")]
        public string Name { get; set; }
        public string RegistrationNo { get; set; }
        [Required(ErrorMessage = "Please Enter a Student's Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email Format Doesn't match")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter a Student's Contact")]
        [RegularExpression(@"(^(\+88|0088)?(01){1}[3456789]{1}(\d){8})$", ErrorMessage = "Mobile Format Doesn't match")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Please Enter a Student's Home Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Select an admission Date")]
        public DateTime Date { get; set; }
    }
}