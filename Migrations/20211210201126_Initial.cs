using Microsoft.EntityFrameworkCore.Migrations;

namespace JoshuaAllison_TermProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuxillaryEffects",
                columns: table => new
                {
                    AuxillaryEffectId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IconURL = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxillaryEffects", x => x.AuxillaryEffectId);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    ItemCategoryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.ItemCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "WeaponArts",
                columns: table => new
                {
                    WeaponArtId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponArts", x => x.WeaponArtId);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubcategories",
                columns: table => new
                {
                    ItemSubcategoryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    ItemCategoryId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubcategories", x => x.ItemSubcategoryId);
                    table.ForeignKey(
                        name: "FK_ItemSubcategories_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    IconURL = table.Column<string>(nullable: false),
                    FlavorText = table.Column<string>(nullable: false),
                    ItemSubcategoryId = table.Column<string>(nullable: false),
                    WeaponArtId = table.Column<int>(nullable: false),
                    FPConsumption = table.Column<int>(nullable: false),
                    AttackType = table.Column<string>(nullable: false),
                    AuxillaryEffectId = table.Column<string>(nullable: true),
                    AuxEffectValue = table.Column<int>(nullable: false),
                    PhysicalAR = table.Column<int>(nullable: false),
                    MagicAR = table.Column<int>(nullable: false),
                    FireAR = table.Column<int>(nullable: false),
                    LightningAR = table.Column<int>(nullable: false),
                    DarkAR = table.Column<int>(nullable: false),
                    PhysicalDR = table.Column<int>(nullable: false),
                    MagicDR = table.Column<int>(nullable: false),
                    FireDR = table.Column<int>(nullable: false),
                    LightningDR = table.Column<int>(nullable: false),
                    DarkDR = table.Column<int>(nullable: false),
                    StrengthScaling = table.Column<string>(nullable: false),
                    DexterityScaling = table.Column<string>(nullable: false),
                    IntellectScaling = table.Column<string>(nullable: false),
                    FaithScaling = table.Column<string>(nullable: false),
                    StrengthRequirement = table.Column<int>(nullable: false),
                    DexterityRequirement = table.Column<int>(nullable: false),
                    IntellectRequirement = table.Column<int>(nullable: false),
                    FaithRequirement = table.Column<int>(nullable: false),
                    Critical = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Stability = table.Column<int>(nullable: false),
                    Durability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipments_AuxillaryEffects_AuxillaryEffectId",
                        column: x => x.AuxillaryEffectId,
                        principalTable: "AuxillaryEffects",
                        principalColumn: "AuxillaryEffectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_ItemSubcategories_ItemSubcategoryId",
                        column: x => x.ItemSubcategoryId,
                        principalTable: "ItemSubcategories",
                        principalColumn: "ItemSubcategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_WeaponArts_WeaponArtId",
                        column: x => x.WeaponArtId,
                        principalTable: "WeaponArts",
                        principalColumn: "WeaponArtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuxillaryEffects",
                columns: new[] { "AuxillaryEffectId", "Description", "IconURL", "Name" },
                values: new object[,]
                {
                    { "N", "This item does not have an auxillary status effect.", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon_weight.png", "None" },
                    { "B", "15% HP damage plus an additional 50-200 flat damage, varies by source", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-bleedres.png", "Bleed" },
                    { "F", "Inflicts damage, lower absorption, and slows stamina regeneration. Deals 11% of a player's max HP plus an additional 85 flat damage. When affected, the target has - 15 Stamina Regen and takes + 7 % increased damage.", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-wp_frost.png", "Frostbite" },
                    { "P", "Slowly inflicts HP damage on the player. Lasts for 90 Seconds, or until cured. ", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/icon-poisonres.png", "Poison" }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "ItemCategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { "W", "Weapons are a type of equipment in Dark Souls 3. Players may equip up to 3 in the slots for each hand. When developing a build, the player should try to find the weapon that mixes the right amount of damage, bonuses and moveset, alongside stamina consumption and Skills. Weapon classes do not necessarily share the same skills so check each individual weapon page to see its specific skill. If you would like to learn more about each weapon, visit their page, or check out the Combat page for specific explanations on how to master the game. You can use this Equipment & Spell Checklist to keep track of what you have", "Weapons" },
                    { "S", "Shields in Dark Souls 3 are an integral part of your survival as you learn the game, since even a single blow past your guard can lead to your untimely demise. More than just a wall between you and the enemy, the player is presented with a wide variety of shield styles to choose from, allowing them the freedom to integrate their shield into their own personal playstyle. With offensive applications in addition to the obvious defensive applications, shield strategy can easily become far deeper than simply blocking damage. If you'd like to see comparisons of the different shield types, please click the the link above each list.", "Shields" },
                    { "A", "Armor in Dark Souls 3 provides the player with protection against damage, resistance to Status Effects, and adds Poise. Armor pieces may also be mixed and matched for cosmetic purposes. Unlike past installments in the series, armor cannot be upgraded.", "Armor" },
                    { "R", @"Rings are an important category of equipment in Dark Souls 3. Players may equip up to 4 rings at once and they each grant specific benefits. This page has a list of all of the rings available in the game, separated by default and DLC rings. Click on each ring to find specific written location information. The list is by order that they will display in your inventory in game. This is to facilitate their acquisition by making it easy to see which you are missing with your inventory screen open.
                A returning feature from Dark Souls 2, rings are available in more powerful iterations that appear with the + 1, +2 or + 3 suffixes.These enhanced rings are only found in NG + and beyond.Their locations and which Journey(New Game) they can be found in will be noted here and on the individual ring pages.To obtain the Trophy / Achievement fo rcollecting every ring, you must collect all of the different + X variations available, making a total of 107 rings.Do NOT sell any of the rings you've obtained.
                Rings of any variation can be obtained upon each playthrough.If you miss a ring on your first playthrough, or even your second or third, you can still obtain on any following playthrough.Weather it's NG+2 or NG+20 all the rings stay where they originally are placed, they do not go away simply because you've continued playing.Meaning you can obtain the achievement on any playthrough.In addition to this information, you DO NOT need to have all the rings on you at once.Provided you have picked up the ring it counts.HOWEVER, you should always put your rings into your Item Box via the bonfire.This will allow you to keep track and KNOW for a fact what you have, I do not recommend sharing your rings amongst friends until you've gotten your achievement. 
                Ring of Sacrifice DOES count towards achievement.(Got the achievement after picking up the first roS in NG++, after getting every other ring.)
                116 Total Rings -9 DLC Rings(8 of which are + 3 & other is Chillbite Ring) -1(+3) Ring - 16(+2) Rings - 20(+1) Rings - 70(+0 / Regular) Rings - 107 Rings for Achievement
                The Trophy / Achievement may be glitched and despite having all 107 rings in your inventory it may not register.In this case drop 15 rings, then pick them up again, then drop a different 15 and pick them up.* Do this until it registers.DO NOT drop any more than 15 to be safe.The game only allows about 30 rings to be on the ground at any time and will delete any number more than that.It's recommended that you make a backup of your save before doing this. If you chose the Life Ring as your gift at the beginning of your playthrough, you will possibly need to drop it and then pick it back up or buy another from the Handmaiden after she receives the Dreamchaser's Ashes to fix the glitched achievement.
                An additional way to get around the glitch is to move a large amount of rings into your storage box and then back.This way is much safer than dropping them on the ground. ", "Rings" },
                    { "I", "Items in Dark Souls 3 will be much the same as previous Souls games. Categories for the wiki are separated for player convenience into: Key Items, Multiplayer Items, Consumables, Tools, Projectiles, Ammunition, Souls, Boss Souls & Upgrade Materials.", "Items" }
                });

            migrationBuilder.InsertData(
                table: "WeaponArts",
                columns: new[] { "WeaponArtId", "Description", "Name" },
                values: new object[,]
                {
                    { 8, "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.", "Parry" },
                    { 7, "Equipping this shield in the left hand allows one to perform the Skill of the right hand weapon.", "Weapon Skill" },
                    { 6, "Without lowering your guard, strike the enemy with the shield to knock them back or stagger them. Works while equipped in either hand.", "Shield Bash" },
                    { 5, "Assume a holding stance to rapidly execute a lunging slash with normal attack, or a deflective parry with strong attack.", "Hold" },
                    { 1, "While in stance, use normal attack to break a foe's guard from below, and strong attack to slash upwards with a forward lunge.", "Stance" },
                    { 3, "Spin weapon vigorously above head and sweep foes, and transition with normal or strong attack for continued spin attacks, which whip up wind and gain momentum, strengthening subsequent attacks.", "Wind Wheel" },
                    { 2, "Cross arms in front of body to temporarily boost poise. Damage reduced while activated.", "Perseverance" },
                    { 9, "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.  Also deflects spells.", "Spell Parry" },
                    { 4, "Strike from the left to evade shields and deal a stinging blow that temporarily slows stamina recovery. The shackles of bondage lie deep in the hearts of all humankind.", "Impact" },
                    { 11, "Repel an attack at the right time to follow up with a critical hit.  Works while equipped in either hand.  Also deflects spells.", "Spell Parry" }
                });

            migrationBuilder.InsertData(
                table: "ItemSubcategories",
                columns: new[] { "ItemSubcategoryId", "Description", "ItemCategoryId", "Name" },
                values: new object[,]
                {
                    { "Ka", "Katanas are a type of Weapon in Dark Souls 3. These Weapons usually do moderate to good damage and deal Bleed. These weapons have particularly strong running attacks. Like curved swords, they're utilized primarily for slashing attacks. While useful in many scenarios, their main downfall is their low durability (an issue that is easily solved in this game, due how durability works), and really low STR scaling (gaining almost no damage benefit from using them two handed).", "W", "Katanas" },
                    { "FC", @"Fist & Claws are a type of Weapon in Dark Souls 3. These Weapons usually have similar movesets albeit with different skills and properties. Fists and Claws are often used as parrying tools, due to their fast parry frames.
                Fists:	Fist weapons have a faster light attack than Claws and a different rolling R1, but have shorter range and lack the innate Bleed Auxiliary effect that Claws have.Fist weapons are mostly used for Quality / Strength builds and due to their higher damage and considerably better Weapon Arts, they are usually favored over Claws.
                Claws:	Claws have a slightly slower light attack than Fist weapons but have considerably different movesets when two handed(the Crow Talons especially).Claws have greater range than the Fists and have innate Bleed.Claws are usually used on Dexterity / Luck builds.", "W", "Fist & Claws" },
                    { "Ha", @"Halberds are a type of Weapon in Dark Souls 3. These Weapons usually do moderate damage and have long reach. Halberds are generally either a fusion between a spear and another weapon, thus combining straight thrusting attacks and wide swinging strikes, or are simply a cutting or chopping weapon on a long shaft, which is swung across and overhead at a distance. These weapons often have trouble performing in close range or tight quarters.
                Just like Reapers, they have a ""sweet spot"" mechanic that awards players extra damage. Even though the sour spots return as well, the damage difference between the sweet spot hit and the sour spot hit isn't as harsh.", "W", "Halberds" },
                    { "Wh", "Whips are a type of Weapon in Dark Souls 3. These Weapons usually do little to moderate damage, and perform poorly against well-armored foes, but have long reach and can have Auxiliary effects such as Bleeding or Poison. Unlike other melee weapons, whips cannot be parried but cannot backstab or riposte.", "W", "Whips" },
                    { "GS", @"Greatswords are a high damage, long reach weapon class. Plan to put a decent amount of points into Strength if you plan to use these weapons. They have various weapon Skills ranging from Stomp to Stance to unique Skills.
                In terms of damage output per stamina expended, Greatswords are easily the best value weapon category, and they are a good choice for PvE builds as a result.Things to keep in mind when using these in PvP:
                	 1. They have less range compared to Spears / Halberds, Greataxes, and Ultra Greatswords.
                	 2. The startup to their attacks is markedly slower compared to Straight Swords, Axes, and other smaller weapons.
                	 3. Despite the visual being a thrusting attack, the weapon art heavy deals standard damage(slash for the Flamberge) unless the Greatsword has a thrusting neutral heavy.", "W", "Greatswords" },
                    { "SSh", "Small Shields  in Dark Souls 3 are a type of Shield that usually weigh very little and have the least form of protection from attacks. They are often used by players who prefer Parrying rather than Blocking.", "S", "Small Shields" },
                    { "MSh", "Shields in Dark Souls III are an integral part of survival as you begin to understand enemy mechanics. As they are more than just a barrier used to distance yourself from imminent attacks, shields are widely avaiable in various sizes which allow a player to mesh their main-hand weapons into a personalized playstyle. With offensive applications in addition to their apparent defensive application, strategic use of the shield allows for more than simple damage reduction.", "S", "Standard Shields" },
                    { "LSh", "Great Shields are a class of Shields in Dark Souls 3. These types of Shields usually weigh a decent amount and provide the best protection in the game. They are often used by players who have high Strength, as they require a good amount to use.", "S", "Greatshields" }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "EquipmentId", "AttackType", "AuxEffectValue", "AuxillaryEffectId", "Critical", "DarkAR", "DarkDR", "DexterityRequirement", "DexterityScaling", "Durability", "FPConsumption", "FaithRequirement", "FaithScaling", "FireAR", "FireDR", "FlavorText", "IconURL", "IntellectRequirement", "IntellectScaling", "ItemSubcategoryId", "LightningAR", "LightningDR", "MagicAR", "MagicDR", "Name", "PhysicalAR", "PhysicalDR", "Stability", "StrengthRequirement", "StrengthScaling", "WeaponArtId", "Weight" },
                values: new object[] { 1, "Slash", 36, "B", 100, 0, 35, 14, "D", 70, 18, 0, "-", 0, 30, "Greatsword with an undulating blade. The blade, resembling flame, was crafted to mutilate flesh and induce bleeding.", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/flameberge.png", 0, "-", "GS", 0, 30, 0, 35, "Flamberge", 158, 50, 35, 15, "D", 1, 8.5 });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "EquipmentId", "AttackType", "AuxEffectValue", "AuxillaryEffectId", "Critical", "DarkAR", "DarkDR", "DexterityRequirement", "DexterityScaling", "Durability", "FPConsumption", "FaithRequirement", "FaithScaling", "FireAR", "FireDR", "FlavorText", "IconURL", "IntellectRequirement", "IntellectScaling", "ItemSubcategoryId", "LightningAR", "LightningDR", "MagicAR", "MagicDR", "Name", "PhysicalAR", "PhysicalDR", "Stability", "StrengthRequirement", "StrengthScaling", "WeaponArtId", "Weight" },
                values: new object[] { 2, "Strike", 0, "N", 100, 0, 63, 0, "-", 190, 16, 0, "-", 0, 65, "A greatshield adorned with flowing patterns, a celebration of an ancient glory. Boasts the highest stability of such shields, but with reduced stamina regeneration speed. Perhaps it is glory that begets such indolence.", "https://darksouls3.wiki.fextralife.com/file/Dark-Souls-3/greatshield_of_glory.png", 0, "-", "LSh", 0, 52, 0, 70, "Greatshield of Glory", 134, 100, 80, 40, "D", 6, 18.5 });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_AuxillaryEffectId",
                table: "Equipments",
                column: "AuxillaryEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_ItemSubcategoryId",
                table: "Equipments",
                column: "ItemSubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_WeaponArtId",
                table: "Equipments",
                column: "WeaponArtId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubcategories_ItemCategoryId",
                table: "ItemSubcategories",
                column: "ItemCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "AuxillaryEffects");

            migrationBuilder.DropTable(
                name: "ItemSubcategories");

            migrationBuilder.DropTable(
                name: "WeaponArts");

            migrationBuilder.DropTable(
                name: "ItemCategories");
        }
    }
}
