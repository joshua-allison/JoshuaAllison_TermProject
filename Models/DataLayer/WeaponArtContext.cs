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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeaponArt>().HasData(
                new WeaponArt
                {
                    WeaponArtId = 1,
                    Name = "Stance",
                    Description = "While in stance, use normal attack to break a foe's guard from below, and strong attack to slash upwards with a forward lunge."
                },
                new WeaponArt
                {
                    WeaponArtId = 2,
                    Name = "Perseverance",
                    Description = "Cross arms in front of body to temporarily boost poise. Damage reduced while activated."
                },
                new WeaponArt
                {
                    WeaponArtId = 3,
                    Name = "Wind Wheel",
                    Description = "Spin weapon vigorously above head and sweep foes, and transition with normal or strong attack for continued spin attacks, which whip up wind and gain momentum, strengthening subsequent attacks."
                },
                new WeaponArt
                {
                    WeaponArtId = 4,
                    Name = "Impact",
                    Description = "Strike from the left to evade shields and deal a stinging blow that temporarily slows stamina recovery. The shackles of bondage lie deep in the hearts of all humankind."
                },
                new WeaponArt
                {
                    WeaponArtId = 5,
                    Name = "Hold",
                    Description = "Assume a holding stance to rapidly execute a lunging slash with normal attack, or a deflective parry with strong attack."
                },
                new WeaponArt
                {
                    WeaponArtId = 6,
                    Name = "Shield Bash",
                    Description = "Without lowering your guard, strike the enemy with the shield to knock them back or stagger them. Works while equipped in either hand."
                },
                new WeaponArt
                {
                    WeaponArtId = 7,
                    Name = "Weapon Skill",
                    Description = "Equipping this shield in the left hand allows one to perform the Skill of the right hand weapon."
                },
                new WeaponArt
                {
                    WeaponArtId = 8,
                    Name = "Parry",
                    Description = "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand."
                },
                new WeaponArt
                {
                    WeaponArtId = 9,
                    Name = "Spell Parry",
                    Description = "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.  Also deflects spells."
                },
                new WeaponArt
                {
                    WeaponArtId = 9,
                    Name = "Spell Parry",
                    Description = "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.  Also deflects spells."
                }
            );
        }
    }
}
