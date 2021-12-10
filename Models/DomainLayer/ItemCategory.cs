using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JoshuaAllison_TermProject.Models
{
    public class ItemCategory
    {
        [Required(ErrorMessage = "Please enter the Id of the Category.")]
        public string ItemCategoryId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the Category.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Description of the Category.")]
        public string Description { get; set; }
    }
}
