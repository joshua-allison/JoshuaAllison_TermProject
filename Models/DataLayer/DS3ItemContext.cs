using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JoshuaAllison_TermProject.Models
{
    public class DS3ItemContext : DbContext
    {
        public DS3ItemContext()
        {
        }

        public DS3ItemContext(DbContextOptions<DS3ItemContext> options) : base(options) { }
        public DbSet<ItemCategory> ItemCategories { get; set; }
        public DbSet<ItemSubcategory> ItemSubcategories { get; set; }
        public DbSet<WeaponArt> WeaponArts { get; set; }
        public DbSet<AuxillaryEffect> AuxillaryEffects { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        #region Seed Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Category
            modelBuilder.Entity<ItemCategory>().HasData(
                new ItemCategory
                {
                    ItemCategoryId = "W",
                    Name = "Weapons",
                    Description = "Weapons are a type of equipment in Dark Souls 3. Players may equip up to 3 in the slots for each hand. When developing a build, the player should try to find the weapon that mixes the right amount of damage, bonuses and moveset, alongside stamina consumption and Skills. Weapon classes do not necessarily share the same skills so check each individual weapon page to see its specific skill. If you would like to learn more about each weapon, visit their page, or check out the Combat page for specific explanations on how to master the game. You can use this Equipment & Spell Checklist to keep track of what you have"
                },
                new ItemCategory
                {
                    ItemCategoryId = "S",
                    Name = "Shields",
                    Description = "Shields in Dark Souls 3 are an integral part of your survival as you learn the game, since even a single blow past your guard can lead to your untimely demise. More than just a wall between you and the enemy, the player is presented with a wide variety of shield styles to choose from, allowing them the freedom to integrate their shield into their own personal playstyle. With offensive applications in addition to the obvious defensive applications, shield strategy can easily become far deeper than simply blocking damage. If you'd like to see comparisons of the different shield types, please click the the link above each list."
                },
                new ItemCategory
                {
                    ItemCategoryId = "A",
                    Name = "Armor",
                    Description = "Armor in Dark Souls 3 provides the player with protection against damage, resistance to Status Effects, and adds Poise. Armor pieces may also be mixed and matched for cosmetic purposes. Unlike past installments in the series, armor cannot be upgraded."
                },
                new ItemCategory
                {
                    ItemCategoryId = "R",
                    Name = "Rings",
                    Description = "Rings are an important category of equipment in Dark Souls 3. Players may equip up to 4 rings at once and they each grant specific benefits. This page has a list of all of the rings available in the game, separated by default and DLC rings. Click on each ring to find specific written location information. The list is by order that they will display in your inventory in game. This is to facilitate their acquisition by making it easy to see which you are missing with your inventory screen open."
                    +"\nA returning feature from Dark Souls 2, rings are available in more powerful iterations that appear with the + 1, +2 or + 3 suffixes.These enhanced rings are only found in NG + and beyond.Their locations and which Journey(New Game) they can be found in will be noted here and on the individual ring pages.To obtain the Trophy / Achievement fo rcollecting every ring, you must collect all of the different + X variations available, making a total of 107 rings.Do NOT sell any of the rings you've obtained."
                    +"\nRings of any variation can be obtained upon each playthrough.If you miss a ring on your first playthrough, or even your second or third, you can still obtain on any following playthrough.Weather it's NG+2 or NG+20 all the rings stay where they originally are placed, they do not go away simply because you've continued playing.Meaning you can obtain the achievement on any playthrough.In addition to this information, you DO NOT need to have all the rings on you at once.Provided you have picked up the ring it counts.HOWEVER, you should always put your rings into your Item Box via the bonfire.This will allow you to keep track and KNOW for a fact what you have, I do not recommend sharing your rings amongst friends until you've gotten your achievement. "
                    +"\nRing of Sacrifice DOES count towards achievement.(Got the achievement after picking up the first roS in NG++, after getting every other ring.)"
                    +"\n116 Total Rings -9 DLC Rings(8 of which are + 3 & other is Chillbite Ring) -1(+3) Ring - 16(+2) Rings - 20(+1) Rings - 70(+0 / Regular) Rings - 107 Rings for Achievement"
                    +"\nThe Trophy / Achievement may be glitched and despite having all 107 rings in your inventory it may not register.In this case drop 15 rings, then pick them up again, then drop a different 15 and pick them up.* Do this until it registers.DO NOT drop any more than 15 to be safe.The game only allows about 30 rings to be on the ground at any time and will delete any number more than that.It's recommended that you make a backup of your save before doing this. If you chose the Life Ring as your gift at the beginning of your playthrough, you will possibly need to drop it and then pick it back up or buy another from the Handmaiden after she receives the Dreamchaser's Ashes to fix the glitched achievement."
                    +"\nAn additional way to get around the glitch is to move a large amount of rings into your storage box and then back.This way is much safer than dropping them on the ground. "
                },
                new ItemCategory
                {
                    ItemCategoryId = "I",
                    Name = "Items",
                    Description = "Items in Dark Souls 3 will be much the same as previous Souls games. Categories for the wiki are separated for player convenience into: Key Items, Multiplayer Items, Consumables, Tools, Projectiles, Ammunition, Souls, Boss Souls & Upgrade Materials."
                }
            );
            #endregion Category
            #region Subcategory
            modelBuilder.Entity<ItemSubcategory>().HasData(
                new ItemSubcategory
                {
                    ItemSubcategoryId = "Ka",
                    Name = "Katanas",
                    Description = "Katanas are a type of Weapon in Dark Souls 3. These Weapons usually do moderate to good damage and deal Bleed. These weapons have particularly strong running attacks. Like curved swords, they're utilized primarily for slashing attacks. While useful in many scenarios, their main downfall is their low durability (an issue that is easily solved in this game, due how durability works), and really low STR scaling (gaining almost no damage benefit from using them two handed).",
                    ItemCategoryId = "W"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "FC",
                    Name = "Fist & Claws",
                    Description = "Fist & Claws are a type of Weapon in Dark Souls 3. These Weapons usually have similar movesets albeit with different skills and properties. Fists and Claws are often used as parrying tools, due to their fast parry frames."
                    + "\nFists:\tFist weapons have a faster light attack than Claws and a different rolling R1, but have shorter range and lack the innate Bleed Auxiliary effect that Claws have.Fist weapons are mostly used for Quality / Strength builds and due to their higher damage and considerably better Weapon Arts, they are usually favored over Claws."
                    + "\nClaws:\tClaws have a slightly slower light attack than Fist weapons but have considerably different movesets when two handed(the Crow Talons especially).Claws have greater range than the Fists and have innate Bleed.Claws are usually used on Dexterity / Luck builds.",
                    ItemCategoryId = "W"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "Ha",
                    Name = "Halberds",
                    Description = "Halberds are a type of Weapon in Dark Souls 3. These Weapons usually do moderate damage and have long reach. Halberds are generally either a fusion between a spear and another weapon, thus combining straight thrusting attacks and wide swinging strikes, or are simply a cutting or chopping weapon on a long shaft, which is swung across and overhead at a distance. These weapons often have trouble performing in close range or tight quarters."
                    + "\nJust like Reapers, they have a \"sweet spot\" mechanic that awards players extra damage. Even though the sour spots return as well, the damage difference between the sweet spot hit and the sour spot hit isn't as harsh.",
                    ItemCategoryId = "W"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "Wh",
                    Name = "Whips",
                    Description = "Whips are a type of Weapon in Dark Souls 3. These Weapons usually do little to moderate damage, and perform poorly against well-armored foes, but have long reach and can have Auxiliary effects such as Bleeding or Poison. Unlike other melee weapons, whips cannot be parried but cannot backstab or riposte.",
                    ItemCategoryId = "W"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "GS",
                    Name = "Greatswords",
                    Description = "Greatswords are a high damage, long reach weapon class. Plan to put a decent amount of points into Strength if you plan to use these weapons. They have various weapon Skills ranging from Stomp to Stance to unique Skills."
                    + "\nIn terms of damage output per stamina expended, Greatswords are easily the best value weapon category, and they are a good choice for PvE builds as a result.Things to keep in mind when using these in PvP:"
                        + "\n\t 1. They have less range compared to Spears / Halberds, Greataxes, and Ultra Greatswords."
                        + "\n\t 2. The startup to their attacks is markedly slower compared to Straight Swords, Axes, and other smaller weapons."
                        + "\n\t 3. Despite the visual being a thrusting attack, the weapon art heavy deals standard damage(slash for the Flamberge) unless the Greatsword has a thrusting neutral heavy.",
                    ItemCategoryId = "W"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "SSh",
                    Name = "Small Shields",
                    Description = "Small Shields  in Dark Souls 3 are a type of Shield that usually weigh very little and have the least form of protection from attacks. They are often used by players who prefer Parrying rather than Blocking.",
                    ItemCategoryId = "S"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "MSh",
                    Name = "Standard Shields",
                    Description = "Shields in Dark Souls III are an integral part of survival as you begin to understand enemy mechanics. As they are more than just a barrier used to distance yourself from imminent attacks, shields are widely avaiable in various sizes which allow a player to mesh their main-hand weapons into a personalized playstyle. With offensive applications in addition to their apparent defensive application, strategic use of the shield allows for more than simple damage reduction.",
                    ItemCategoryId = "S"
                },
                new ItemSubcategory
                {
                    ItemSubcategoryId = "LSh",
                    Name = "Greatshields",
                    Description = "Great Shields are a class of Shields in Dark Souls 3. These types of Shields usually weigh a decent amount and provide the best protection in the game. They are often used by players who have high Strength, as they require a good amount to use.",
                    ItemCategoryId = "S"
                }
            );
            #endregion Subcategory
            #region WeaponArt
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
                    WeaponArtId = 11,
                    Name = "Spell Parry",
                    Description = "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.  Also deflects spells."
                }
            );
            #endregion WeaponArt
            #region Auxillary Effects
            modelBuilder.Entity<AuxillaryEffect>().HasData(
                new AuxillaryEffect
                {
                    AuxillaryEffectId = "N",
                    Name = "None",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon_weight.png",
                    Description = "This item does not have an auxillary status effect."
                },
                new AuxillaryEffect
                {
                    AuxillaryEffectId = "B",
                    Name = "Bleed",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-bleedres.png",
                    Description = "15% HP damage plus an additional 50-200 flat damage, varies by source"
                },
                new AuxillaryEffect
                {
                    AuxillaryEffectId = "F",
                    Name = "Frostbite",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_frost.png",
                    Description = "Inflicts damage, lower absorption, and slows stamina regeneration. Deals 11% of a player's max HP plus an additional 85 flat damage. When affected, the target has - 15 Stamina Regen and takes + 7 % increased damage."
                },
                new AuxillaryEffect
                {
                    AuxillaryEffectId = "P",
                    Name = "Poison",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-poisonres.png",
                    Description = "Slowly inflicts HP damage on the player. Lasts for 90 Seconds, or until cured. "
                }
            );
            #endregion Auxillary Effects
            #region Equipment
            modelBuilder.Entity<Equipment>().HasData(
                new Equipment
                {
                    EquipmentId = 1,
                    Name = "Flamberge",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/flameberge.png",
                    FlavorText = "Greatsword with an undulating blade. The blade, resembling flame, was crafted to mutilate flesh and induce bleeding.",
                    ItemSubcategoryId = "GS",
                    WeaponArtId = 1,
                    FPConsumption = 18,
                    AttackType = "Slash",
                    AuxillaryEffectId = "B",
                    AuxEffectValue = 36,

                    PhysicalAR = 158,
                    MagicAR = 0,
                    FireAR = 0,
                    LightningAR = 0,
                    DarkAR = 0,

                    PhysicalDR = 50,
                    MagicDR = 35,
                    FireDR = 30,
                    LightningDR = 30,
                    DarkDR = 35,

                    StrengthScaling = 'D',
                    DexterityScaling = 'D',
                    IntellectScaling = '-',
                    FaithScaling = '-',

                    StrengthRequirement = 15,
                    DexterityRequirement = 14,
                    IntellectRequirement = 0,
                    FaithRequirement = 0,

                    Critical = 100,
                    Weight = 8.5,
                    Stability = 35,
                    Durability = 70
                },
                new Equipment
                {
                    EquipmentId = 2,
                    Name = "Greatshield of Glory",
                    IconURL = "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/greatshield_of_glory.png",
                    FlavorText = "A greatshield adorned with flowing patterns, a celebration of an ancient glory. Boasts the highest stability of such shields, but with reduced stamina regeneration speed. Perhaps it is glory that begets such indolence.",
                    ItemSubcategoryId = "LSh",
                    WeaponArtId = 6,
                    FPConsumption = 16,
                    AttackType = "Strike",
                    AuxillaryEffectId = "N",
                    AuxEffectValue = 0,

                    PhysicalAR = 134,
                    MagicAR = 0,
                    FireAR = 0,
                    LightningAR = 0,
                    DarkAR = 0,

                    PhysicalDR = 100,
                    MagicDR = 70,
                    FireDR = 65,
                    LightningDR = 52,
                    DarkDR = 63,
                    
                    StrengthScaling = 'D',
                    DexterityScaling = '-',
                    IntellectScaling = '-',
                    FaithScaling = '-',
                    
                    StrengthRequirement = 40,
                    DexterityRequirement = 0,
                    IntellectRequirement = 0,
                    FaithRequirement = 0,
                    
                    Critical = 100,
                    Weight = 18.5,
                    Stability = 80,
                    Durability = 190
                }
            );

            #endregion Equipment
        }
        #endregion Seed Data
    }
}