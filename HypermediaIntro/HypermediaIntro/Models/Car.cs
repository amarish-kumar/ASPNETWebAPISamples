using System.ComponentModel.DataAnnotations;

namespace HypermediaIntro.Models {

    public class Car : Resource {

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        public int Year { get; set; }

        [Range(0, 500000)]
        public float Price { get; set; }
    }
}