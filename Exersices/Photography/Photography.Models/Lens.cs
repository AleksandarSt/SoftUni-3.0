using System.Collections.Generic;

namespace Photography.Models
{
    public class Lens
    {
        public Lens()
        {
            this.CompatibleCameras = new HashSet<Camera> ();
        }


        public int Id { get; set; }

        public string Make { get; set; }

        public int? FocalLength { get; set; }

        public double? MaxAperture { get; set; }

        public ICollection<Camera> CompatibleCameras { get; set; }

        public Photographer Owner { get; set; }
    }
}
