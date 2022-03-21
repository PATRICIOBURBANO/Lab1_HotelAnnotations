using System.ComponentModel.DataAnnotations;

namespace Lab1_HotelAnnotations.Models
{
    public class Room
    {

        public int Id { get; set; } 

        [Key]
        public int RoomNumber { get; set; }

        public int Capacity { get; set; }

       
        public Section Section { get; set; }


    }
    public enum Section
    {
        [Display(Name = "1st")]
        First,

        [Display(Name = "2nd")]
        Second,

        [Display(Name = "3rd")]
        Third
    }
}
