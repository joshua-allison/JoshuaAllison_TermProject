using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JoshuaAllison_TermProject.Models
{
    public class DS3ItemContext : DbContext
    {
        public DS3ItemContext(DbContextOptions<DS3ItemContext> options) : base(options) { }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<WeaponArt> WeaponArts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Subcategory Seed Data
            modelBuilder.Entity<Subcategory>().HasData(
                new Subcategory
                {
                    SubcategoryId = 1,
                    SubcategoryName = "Katanas",
                    Description = "Katanas are a type of Weapon in Dark Souls 3. These Weapons usually do moderate to good damage and deal Bleed. These weapons have particularly strong running attacks. Like curved swords, they're utilized primarily for slashing attacks. While useful in many scenarios, their main downfall is their low durability (an issue that is easily solved in this game, due how durability works), and really low STR scaling (gaining almost no damage benefit from using them two handed).",
                    Category = Subcategory.Categories.Weapon
                },
                new Subcategory
                {
                    SubcategoryId = 2,
                    SubcategoryName = "Fist & Claws",
                    Description = "Fist & Claws are a type of Weapon in Dark Souls 3. These Weapons usually have similar movesets albeit with different skills and properties. Fists and Claws are often used as parrying tools, due to their fast parry frames."
                    + "\nFists:\tFist weapons have a faster light attack than Claws and a different rolling R1, but have shorter range and lack the innate Bleed Auxiliary effect that Claws have.Fist weapons are mostly used for Quality / Strength builds and due to their higher damage and considerably better Weapon Arts, they are usually favored over Claws."
                    + "\nClaws:\tClaws have a slightly slower light attack than Fist weapons but have considerably different movesets when two handed(the Crow Talons especially).Claws have greater range than the Fists and have innate Bleed.Claws are usually used on Dexterity / Luck builds.",
                    Category = Subcategory.Categories.Weapon
                },
                new Subcategory
                {
                    SubcategoryId = 3,
                    SubcategoryName = "Halberds",
                    Description = "Halberds are a type of Weapon in Dark Souls 3. These Weapons usually do moderate damage and have long reach. Halberds are generally either a fusion between a spear and another weapon, thus combining straight thrusting attacks and wide swinging strikes, or are simply a cutting or chopping weapon on a long shaft, which is swung across and overhead at a distance. These weapons often have trouble performing in close range or tight quarters."
                    + "\nJust like Reapers, they have a \"sweet spot\" mechanic that awards players extra damage. Even though the sour spots return as well, the damage difference between the sweet spot hit and the sour spot hit isn't as harsh.",
                    Category = Subcategory.Categories.Weapon
                },
                new Subcategory
                {
                    SubcategoryId = 4,
                    SubcategoryName = "Whips",
                    Description = "Whips are a type of Weapon in Dark Souls 3. These Weapons usually do little to moderate damage, and perform poorly against well-armored foes, but have long reach and can have Auxiliary effects such as Bleeding or Poison. Unlike other melee weapons, whips cannot be parried but cannot backstab or riposte.",
                    Category = Subcategory.Categories.Weapon
                },
                new Subcategory
                {
                    SubcategoryId = 5,
                    SubcategoryName = "Greatswords",
                    Description = "Greatswords are a high damage, long reach weapon class. Plan to put a decent amount of points into Strength if you plan to use these weapons. They have various weapon Skills ranging from Stomp to Stance to unique Skills."
                    + "\nIn terms of damage output per stamina expended, Greatswords are easily the best value weapon category, and they are a good choice for PvE builds as a result.Things to keep in mind when using these in PvP:"
                        + "\n\t 1. They have less range compared to Spears / Halberds, Greataxes, and Ultra Greatswords."
                        + "\n\t 2. The startup to their attacks is markedly slower compared to Straight Swords, Axes, and other smaller weapons."
                        + "\n\t 3. Despite the visual being a thrusting attack, the weapon art heavy deals standard damage(slash for the Flamberge) unless the Greatsword has a thrusting neutral heavy.",
                    Category = Subcategory.Categories.Weapon
                },
                new Subcategory
                {
                    SubcategoryId = 6,
                    SubcategoryName = "Small Shields",
                    Description = "Small Shields  in Dark Souls 3 are a type of Shield that usually weigh very little and have the least form of protection from attacks. They are often used by players who prefer Parrying rather than Blocking.",
                    Category = Subcategory.Categories.Shield
                },
                new Subcategory
                {
                    SubcategoryId = 7,
                    SubcategoryName = "Standard Shields",
                    Description = "Shields in Dark Souls III are an integral part of survival as you begin to understand enemy mechanics. As they are more than just a barrier used to distance yourself from imminent attacks, shields are widely avaiable in various sizes which allow a player to mesh their main-hand weapons into a personalized playstyle. With offensive applications in addition to their apparent defensive application, strategic use of the shield allows for more than simple damage reduction.",
                    Category = Subcategory.Categories.Shield
                },
                new Subcategory
                {
                    SubcategoryId = 8,
                    SubcategoryName = "Greatshields",
                    Description = "Great Shields are a class of Shields in Dark Souls 3. These types of Shields usually weigh a decent amount and provide the best protection in the game. They are often used by players who have high Strength, as they require a good amount to use.",
                    Category = Subcategory.Categories.Shield
                }
            );
            #endregion Subcategory.HasData
            #region WeaponArt Seed Data
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
            #endregion WeaponArt Seed Data
        }
    }
}