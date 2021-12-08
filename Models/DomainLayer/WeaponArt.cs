using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoshuaAllison_TermProject.Models
{
    public class WeaponArt
    {
        //EF Core will configure the database to gerenate this value.
        public int WeaponArtId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
