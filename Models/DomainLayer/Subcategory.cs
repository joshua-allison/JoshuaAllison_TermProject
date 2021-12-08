using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JoshuaAllison_TermProject.Models
{
    public class Subcategory
    {
        //EF Core will configure the database to gerenate this value.
        public int SubcategoryId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Subcategory.")]
        public string SubcategoryName { get; set; }
        [Required(ErrorMessage = "Please enter the Description of the Subcategory.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the Category of the Subcategory.")]
        public Categories Category { get; set; }
        public enum Categories
        {
            Weapon,
            Shield, 
            Armor,
            Focus, 
            Item
        }
    }
}
