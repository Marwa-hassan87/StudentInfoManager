using System.ComponentModel.DataAnnotations;

namespace studentManage.Models
{
    public class Student
    {
        [Key]
        public int studetn_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Course { get; set; }
    }
}
