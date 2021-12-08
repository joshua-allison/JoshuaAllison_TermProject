using Microsoft.EntityFrameworkCore.Migrations;

namespace JoshuaAllison_TermProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    SubcategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcategoryName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Category = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryId);
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
                name: "Equipments",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    IconURL = table.Column<string>(nullable: false),
                    SubcategoryId = table.Column<int>(nullable: false),
                    WeaponArtId = table.Column<int>(nullable: false),
                    AttackType = table.Column<int>(nullable: false),
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
                    AuxType = table.Column<int>(nullable: false),
                    AuxValue = table.Column<int>(nullable: false),
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
                    Durability = table.Column<int>(nullable: false),
                    FPConsumption = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.EquipmentId);
                    table.ForeignKey(
                        name: "FK_Equipments_Subcategories_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "Subcategories",
                        principalColumn: "SubcategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_WeaponArts_WeaponArtId",
                        column: x => x.WeaponArtId,
                        principalTable: "WeaponArts",
                        principalColumn: "WeaponArtId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "SubcategoryId", "Category", "Description", "SubcategoryName" },
                values: new object[,]
                {
                    { 1, 0, "Katanas are a type of Weapon in Dark Souls 3. These Weapons usually do moderate to good damage and deal Bleed. These weapons have particularly strong running attacks. Like curved swords, they're utilized primarily for slashing attacks. While useful in many scenarios, their main downfall is their low durability (an issue that is easily solved in this game, due how durability works), and really low STR scaling (gaining almost no damage benefit from using them two handed).", "Katanas" },
                    { 2, 0, @"Fist & Claws are a type of Weapon in Dark Souls 3. These Weapons usually have similar movesets albeit with different skills and properties. Fists and Claws are often used as parrying tools, due to their fast parry frames.
                Fists:	Fist weapons have a faster light attack than Claws and a different rolling R1, but have shorter range and lack the innate Bleed Auxiliary effect that Claws have.Fist weapons are mostly used for Quality / Strength builds and due to their higher damage and considerably better Weapon Arts, they are usually favored over Claws.
                Claws:	Claws have a slightly slower light attack than Fist weapons but have considerably different movesets when two handed(the Crow Talons especially).Claws have greater range than the Fists and have innate Bleed.Claws are usually used on Dexterity / Luck builds.", "Fist & Claws" },
                    { 3, 0, @"Halberds are a type of Weapon in Dark Souls 3. These Weapons usually do moderate damage and have long reach. Halberds are generally either a fusion between a spear and another weapon, thus combining straight thrusting attacks and wide swinging strikes, or are simply a cutting or chopping weapon on a long shaft, which is swung across and overhead at a distance. These weapons often have trouble performing in close range or tight quarters.
                Just like Reapers, they have a ""sweet spot"" mechanic that awards players extra damage. Even though the sour spots return as well, the damage difference between the sweet spot hit and the sour spot hit isn't as harsh.", "Halberds" },
                    { 4, 0, "Whips are a type of Weapon in Dark Souls 3. These Weapons usually do little to moderate damage, and perform poorly against well-armored foes, but have long reach and can have Auxiliary effects such as Bleeding or Poison. Unlike other melee weapons, whips cannot be parried but cannot backstab or riposte.", "Whips" },
                    { 5, 0, @"Greatswords are a high damage, long reach weapon class. Plan to put a decent amount of points into Strength if you plan to use these weapons. They have various weapon Skills ranging from Stomp to Stance to unique Skills.
                In terms of damage output per stamina expended, Greatswords are easily the best value weapon category, and they are a good choice for PvE builds as a result.Things to keep in mind when using these in PvP:
                	 1. They have less range compared to Spears / Halberds, Greataxes, and Ultra Greatswords.
                	 2. The startup to their attacks is markedly slower compared to Straight Swords, Axes, and other smaller weapons.
                	 3. Despite the visual being a thrusting attack, the weapon art heavy deals standard damage(slash for the Flamberge) unless the Greatsword has a thrusting neutral heavy.", "Greatswords" },
                    { 6, 1, "Small Shields  in Dark Souls 3 are a type of Shield that usually weigh very little and have the least form of protection from attacks. They are often used by players who prefer Parrying rather than Blocking.", "Small Shields" },
                    { 7, 1, "Shields in Dark Souls III are an integral part of survival as you begin to understand enemy mechanics. As they are more than just a barrier used to distance yourself from imminent attacks, shields are widely avaiable in various sizes which allow a player to mesh their main-hand weapons into a personalized playstyle. With offensive applications in addition to their apparent defensive application, strategic use of the shield allows for more than simple damage reduction.", "Standard Shields" },
                    { 8, 1, "Great Shields are a class of Shields in Dark Souls 3. These types of Shields usually weigh a decent amount and provide the best protection in the game. They are often used by players who have high Strength, as they require a good amount to use.", "Greatshields" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_SubcategoryId",
                table: "Equipments",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_WeaponArtId",
                table: "Equipments",
                column: "WeaponArtId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "WeaponArts");
        }
    }
}
