using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Photography.Models
{
    public class Camera
    {
        public Camera()
        {
            this.CompatibleLenses = new HashSet<Lens>();
        }

        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public bool IsFullFrame { get; set; }

        [Required, Range(100, int.MaxValue)]
        public int MinISO { get; set; }

        public int MaxISO { get; set; }

        public ICollection<Lens> CompatibleLenses { get; set; }

        public Photographer Owner { get; set; }
    }
}
