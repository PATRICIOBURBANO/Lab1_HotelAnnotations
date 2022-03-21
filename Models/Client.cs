using System.ComponentModel.DataAnnotations;

namespace Lab1_HotelAnnotations.Models
{
    public class Client
    {

        [Key]
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Minimum length is 3 and Maximum 25 chars")]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 3, ErrorMessage = "Minimum length is 3 and Maximum 25 chars")]
        [Required(ErrorMessage = "Required LastName")]
        public string LastName { get; set; }

        [Phone(ErrorMessage = "Please enter valid phone number")]
        public string PhoneNumber { get; set; }

    }
}
