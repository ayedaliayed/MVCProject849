using MVCProject849.ValidationAttributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject849.Model_Views
{
    public class createupadteemployee
    {

        public int Id { get; set; }
        //[StringLength(15, MinimumLength = 3)]
        [Required]
        [MaxLength(15)]
        [MinLength(3)]
        [unqeName]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^.*\.(jpg|png|jpeg)$", ErrorMessage = " Image must be in jpg, png, or jpeg format.")]
        public string Image { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string Address { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(7)]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone must contain numbers only.")]
        public string Phone { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
    }
}
