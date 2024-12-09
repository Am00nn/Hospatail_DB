using System.ComponentModel.DataAnnotations;

namespace Hospital_project.Models
{
    public class Patient
    {
        [Key]
        public int P_Id { get; set; }

        [Required]
        public string P_Name { get; set; }

        [Required]
        public string P_Age { get; set; }

        [Required]
        public string P_Gender { get; set; }
    }
}
