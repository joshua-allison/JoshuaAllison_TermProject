using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoshuaAllison_TermProject.Models
{
    public class Subcategory
    {
        //EF Core will configure the database to gerenate this value.
        public int SubcategoryId { get; set; }
        public string SubcategoryName { get; set; }
        public string Description { get; set; }
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
