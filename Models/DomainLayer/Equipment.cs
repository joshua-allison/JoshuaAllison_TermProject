using System.ComponentModel.DataAnnotations;

namespace JoshuaAllison_TermProject.Models
{
    public class Equipment
    {
        #region Identifiers
        //EF Core will configure the database to gerenate this value.
        public int EquipmentId { get; set; }
        [Required(ErrorMessage = "Please enter the Name of the equipment.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "String length for {0} must be between {2} and {1}." )]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the Icon URL of the equipment.")]
        public string IconURL { get; set; }
        [Required(ErrorMessage = "Please enter the Flavor Text of the equipment.")]
        [StringLength(1000, MinimumLength = 15, ErrorMessage = "String length for {0} must be between {2} and {1}.")]
        public string FlavorText { get; set; }
        [Required(ErrorMessage = "Please enter the Subcategory of the equipment.")]
        public string ItemSubcategoryId { get; set; }
        public ItemSubcategory ItemSubcategory { get; set; }
        [Required(ErrorMessage = "Please enter the Weapon Art of the equipment.")]
        public int WeaponArtId { get; set; }
        public WeaponArt weaponArt { get; set; }
        [Required(ErrorMessage = "Please enter the FP consumption of the equipment weapon art.")]
        [Range(0, 100, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int FPConsumption { get; set; }
        [Required(ErrorMessage = "Please enter the Attack Type of the equipment.")]
        public string AttackType { get; set; }
        public string AuxillaryEffectId { get; set; }
        public AuxillaryEffect AuxEffect { get; set; }
        public int AuxEffectValue { get; set; }
        public string Slug => Name?.Replace(' ', '-').ToLower();
        #endregion Identifiers
        #region Attack Ratings
        [Required(ErrorMessage = "Please enter the Physical attack rating of the equipment.")]
        [Range(0, 500, ErrorMessage = "Value for Physical Attack must be between {1} and {2}.")]
        public int PhysicalAR { get; set; }
        [Required(ErrorMessage = "Please enter the Magic attack rating of the equipment.")]
        [Range(0, 500, ErrorMessage = "Value for Magic Attack must be between {1} and {2}.")]
        public int MagicAR { get; set; }
        [Required(ErrorMessage = "Please enter the Fire attack rating of the equipment.")]
        [Range(0, 500, ErrorMessage = "Value for Fire Attack must be between {1} and {2}.")]
        public int FireAR { get; set; }
        [Required(ErrorMessage = "Please enter the Lightning attack rating of the equipment.")]
        [Range(0, 500, ErrorMessage = "Value for Lightning Attack must be between {1} and {2}.")]
        public int LightningAR { get; set; }
        [Required(ErrorMessage = "Please enter the Dark attack rating of the equipment.")]
        [Range(0, 500, ErrorMessage = "Value for Dark Attack must be between {1} and {2}.")]
        public int DarkAR { get; set; }
        #endregion Attack Ratings
        #region Defense Ratings
        [Required(ErrorMessage = "Please enter the Physical defense rating of the equipment.")]
        [Range(0, 100, ErrorMessage = "Value for Physical Defense must be between {1} and {2}.")]
        public int PhysicalDR { get; set; }
        [Required(ErrorMessage = "Please enter the Magic defense rating of the equipment.")]
        [Range(0, 100, ErrorMessage = "Value for Magic Defense must be between {1} and {2}.")]
        public int MagicDR { get; set; }
        [Required(ErrorMessage = "Please enter the Fire attack defense of the equipment.")]
        [Range(0, 100, ErrorMessage = "Value for Fire Defense must be between {1} and {2}.")]
        public int FireDR { get; set; }
        [Required(ErrorMessage = "Please enter the Lightning defense rating of the equipment.")]
        [Range(0, 100, ErrorMessage = "Value for Lightning Defense must be between {1} and {2}.")]
        public int LightningDR { get; set; }
        [Required(ErrorMessage = "Please enter the Dark attack defense of the equipment.")]
        [Range(0, 100, ErrorMessage = "Value for Dark Defense must be between {1} and {2}.")]
        public int DarkDR { get; set; }
        #endregion Defense Ratings
        #region Stat Scaling
        [Required(ErrorMessage = "Please enter the Strength scaling of the equipment.")]
        [RegularExpression(@"[SABCDE-]", ErrorMessage = "Strength Scaling must be expressed as \'S\', \'A\', \'B\', \'C\', \'D\', \'E\',  or \'-\', ")]
        public char StrengthScaling { get; set; }
        [Required(ErrorMessage = "Please enter the Dexterity scaling of the equipment.")]
        [RegularExpression(@"[SABCDE-]", ErrorMessage = "Dexterity Scaling must be expressed as \'S\', \'A\', \'B\', \'C\', \'D\', \'E\',  or \'-\', ")]
        public char DexterityScaling { get; set; }
        [Required(ErrorMessage = "Please enter the Intellect scaling of the equipment.")]
        [RegularExpression(@"[SABCDE-]", ErrorMessage = "Intellect Scaling must be expressed as \'S\', \'A\', \'B\', \'C\', \'D\', \'E\',  or \'-\', ")]
        public char IntellectScaling { get; set; }
        [Required(ErrorMessage = "Please enter the Faith scaling of the equipment.")]
        [RegularExpression(@"[SABCDE-]", ErrorMessage = "Faith Scaling must be expressed as \'S\', \'A\', \'B\', \'C\', \'D\', \'E\',  or \'-\', ")]
        public char FaithScaling { get; set; }
        #endregion Stat Scaling
        #region Stat Requirements
        [Required(ErrorMessage = "Please enter the Strength requirement of the equipment.")]
        [Range(0, 99, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int StrengthRequirement { get; set; }
        [Required(ErrorMessage = "Please enter the Dexterity requirement of the equipment.")]
        [Range(0, 99, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int DexterityRequirement { get; set; }
        [Required(ErrorMessage = "Please enter the Intellect requirement of the equipment.")]
        [Range(0, 99, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int IntellectRequirement { get; set; }
        [Required(ErrorMessage = "Please enter the Faith requirement of the equipment.")]
        [Range(0, 99, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int FaithRequirement { get; set; }
        #endregion Scaling
        #region Other Stats
        [Required(ErrorMessage = "Please enter the Critcal rating of the equipment.")]
        public int Critical { get; set; }
        [Required(ErrorMessage = "Please enter the Weight of the equipment.")]
        public double Weight { get; set; }
        [Required(ErrorMessage = "Please enter the Stability of the equipment.")]
        public int Stability { get; set; }
        [Required(ErrorMessage = "Please enter the Durability of the equipment.")]
        public int Durability { get; set; }
        #endregion Other Stats
    }
}
