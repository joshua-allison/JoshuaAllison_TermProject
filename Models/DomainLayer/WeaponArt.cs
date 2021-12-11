using System.ComponentModel.DataAnnotations;

namespace JoshuaAllison_TermProject.Models
{
    public class WeaponArt
    {
        //EF Core will configure the database to gerenate this value.
        public int WeaponArtId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Weapon Art.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Description of the Weapon Art.")]
        public string Description { get; set; }

    }
}
