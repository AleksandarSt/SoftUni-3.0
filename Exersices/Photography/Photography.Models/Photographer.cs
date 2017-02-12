using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Photographer
    {
        public Photographer()
        {
            this.Lenses = new HashSet<Lens>();
            this.Accessories = new HashSet<Accessory>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required,Range(2,50)]
        public string LastName { get; set; }

        [RegularExpression(@"\+[0-9]{1,3}\/[0-9]{8,10}",ErrorMessage ="Invalid phone number")]
        public string Phone { get; set; }

        [Required]
        public Camera PrimaryCamera { get; set; }

        [Required]
        public Camera SecondaryCamera { get; set; }

        public ICollection<Lens> Lenses { get; set; }

        public ICollection<Accessory> Accessories { get; set; }

        public ICollection<Workshop> AttendedWorkshops { get; set; }

        public ICollection<Workshop> TrainedWorkshops { get; set; }

    }
}
