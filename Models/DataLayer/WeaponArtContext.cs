using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JoshuaAllison_TermProject.Models
{
    public class WeaponArtContext : DbContext
    {
        public WeaponArtContext(DbContextOptions<WeaponArtContext> options) : base(options) { }
        public DbSet<WeaponArt> WeaponArts { get; set; }
    }
}
