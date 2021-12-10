using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JoshuaAllison_TermProject.Models
{
    public class ItemSubcategory
    {
        [Required(ErrorMessage = "Please enter the Id of the Subcategory.")]
        public string ItemSubcategoryId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Subcategory.")]
        public string Name{ get; set; }
        [Required(ErrorMessage = "Please enter the Description of the Subcategory.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the parent Category of this Subcategory.")]
        public string ItemCategoryId { get; set; }
        public ItemCategory itemCategory { get; set; }
    }
}
