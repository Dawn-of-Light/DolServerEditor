/*
* DAWN OF LIGHT - The first free open source DAoC server emulator
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*
*/

using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Input;

namespace Origins_Editor
{
    partial class LoadSpell
    {
        private System.Windows.Forms.BindingSource SpellbindingSource;
        DataTable SpellDatatable = new DataTable();
        DataTable linexspell = new DataTable();
        DataTable languagespell = new DataTable();

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void dataGrid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MainWindow form1 = new  MainWindow();
            //form1.ShowDialog();
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadSpell));
            this.LineNameSpellSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpellHandlerSearchcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchSpellIDtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBySpellNametextBox = new System.Windows.Forms.TextBox();
            this.ControlMenu = new System.Windows.Forms.GroupBox();
            this.SpellbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.SpellbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.SaveNewbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.LanguageSpellMessage4richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.LanguageSpellMessage3richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LanguageSpellMessage2richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.LanguageSpellMessage1richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.LanguageSpellNametextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.LanguageSpellDescriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridViewLanguageSpell = new System.Windows.Forms.DataGridView();
            this.LanguageSpellbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpellLanguagebindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.label53 = new System.Windows.Forms.Label();
            this.LanguageSpellLAnguageChoicecomboBox = new System.Windows.Forms.ComboBox();
            this.LanguageSpellTagtextBox = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.PackageIDAddLineXSpellcomboBox = new System.Windows.Forms.ComboBox();
            this.LineNameAddLineXSpellcomboBox = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.LinexSpellAddLeveltextBox = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.LineXSpellbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.LineXSpellbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewLineXSpell = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.IsFocuscomboBox = new System.Windows.Forms.ComboBox();
            this.AllowBoltcomboBox = new System.Windows.Forms.ComboBox();
            this.IsSecondarycomboBox = new System.Windows.Forms.ComboBox();
            this.IsPrimarycomboBox = new System.Windows.Forms.ComboBox();
            this.UninterruptiblecomboBox = new System.Windows.Forms.ComboBox();
            this.MoveCastcomboBox = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.SharedTimerGrouptextBox = new System.Windows.Forms.TextBox();
            this.AmnesiaChancetextBox = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.SpellGrouptextBox = new System.Windows.Forms.TextBox();
            this.InstrumentRequirementtextBox = new System.Windows.Forms.TextBox();
            this.EffectGrouptextBox = new System.Windows.Forms.TextBox();
            this.SubSpellIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PackageIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TranslationIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Message4richTextBox = new System.Windows.Forms.RichTextBox();
            this.Message3richTextBox = new System.Windows.Forms.RichTextBox();
            this.Message2richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Message1richTextBox = new System.Windows.Forms.RichTextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TargetcomboBox = new System.Windows.Forms.ComboBox();
            this.SpellTypecomboBox = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ResurrectManatextBox = new System.Windows.Forms.TextBox();
            this.ResurrectHealthtextBox = new System.Windows.Forms.TextBox();
            this.ValuetextBox = new System.Windows.Forms.TextBox();
            this.LifeDrainReturntextBox = new System.Windows.Forms.TextBox();
            this.ConcentrationtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RecastDelaytextBox = new System.Windows.Forms.TextBox();
            this.PulsetextBox = new System.Windows.Forms.TextBox();
            this.PulsePowertextBox = new System.Windows.Forms.TextBox();
            this.RadiustextBox = new System.Windows.Forms.TextBox();
            this.FrequencytextBox = new System.Windows.Forms.TextBox();
            this.DurationtextBox = new System.Windows.Forms.TextBox();
            this.DamageTypetextBox = new System.Windows.Forms.TextBox();
            this.RangetextBox = new System.Windows.Forms.TextBox();
            this.PowertextBox = new System.Windows.Forms.TextBox();
            this.DamagetextBox = new System.Windows.Forms.TextBox();
            this.CastTimetextBox = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.spellIDtextBox = new System.Windows.Forms.TextBox();
            this.ClientEffecttextBox = new System.Windows.Forms.TextBox();
            this.IcontextBox = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.dataGridSpell = new System.Windows.Forms.DataGridView();
            this.SpelldataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.commandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewSpellButton = new System.Windows.Forms.Button();
            this.SpellListingButton = new System.Windows.Forms.Button();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellbindingNavigator)).BeginInit();
            this.SpellbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellbindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguageSpell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageSpellbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLanguagebindingNavigator)).BeginInit();
            this.SpellLanguagebindingNavigator.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineXSpellbindingNavigator)).BeginInit();
            this.LineXSpellbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineXSpellbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineXSpell)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LineNameSpellSearchcomboBox
            // 
            this.LineNameSpellSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineNameSpellSearchcomboBox.FormattingEnabled = true;
            this.LineNameSpellSearchcomboBox.Items.AddRange(new object[] {
            " All",
            "Abrasion",
            "Arboreal Mastery",
            "Arboreal Path",
            "Augmentation",
            "Aura Manipulation",
            "Bard Music",
            "Bard Music Spec",
            "Battlesongs",
            "Beastcraft",
            "Bedazzling",
            "Body Destruction",
            "Bone Army",
            "Bone Guardians",
            "Bone Mystics",
            "Bone Warriors",
            "BoneBufferHaste",
            "BoneBufferShield",
            "BoneDebufferDisease",
            "BoneDebufferHaste",
            "BoneHealerHeal",
            "BoneMage",
            "Calefaction",
            "Champion Abilities",
            "Chants",
            "Character Abilities",
            "Combat Style Effects",
            "Creeping Path",
            "Creeping Path Spec",
            "Cursing",
            "Cursing Spec",
            "Darkness",
            "Death Servant",
            "Death Servant Spec",
            "Deathsight",
            "Deathsight Spec",
            "Dementia",
            "Disorientation",
            "Domination",
            "Dragon Magic",
            "Druid Nature Magic",
            "Druid Nature Spec",
            "Druid Nurture Spec",
            "Empowering",
            "Enchantment",
            "Enchantment Mastery",
            "Enhancement",
            "Essence Manipulation",
            "Ethereal Shriek",
            "Friar Enhancement Spec",
            "Guardian Angel",
            "Healer Augmentation Spec",
            "Healer Mending Spec",
            "Heretic Enhancement Spec",
            "Heretic Rejuvenation Spec",
            "Hexing",
            "Holism",
            "Illusions",
            "Instruments",
            "Item Effects",
            "Liquifaction",
            "Magnetism",
            "Matter",
            "Matter Manipulation",
            "Mending",
            "Mentalism",
            "Mind Mastery",
            "Mind Twisting",
            "Mob Spells",
            "Mundane Poisons",
            "Necro Pet Insta Spells",
            "Nightshade",
            "Nurture",
            "Nurture Warden Spec",
            "Odin\'s Will",
            "Pacification",
            "Pacification Spec",
            "Painworking",
            "Painworking Spec",
            "Path of Air",
            "Path of Earth",
            "Path of Fire",
            "Path of Ice",
            "Pathfinding",
            "PetBuff",
            "Phantasmal Wail",
            "Potions",
            "Power Strikes",
            "Pyromancy",
            "Rebirth",
            "Rebirth (Cleric)",
            "Refrigeration",
            "Regrowth",
            "Regrowth Bard Spec",
            "Regrowth Druid Spec",
            "Regrowth Warden Spec",
            "Rejuvenation",
            "Reserved Spells",
            "Runecarving",
            "Runes of Darkness",
            "Runes of Destruction",
            "Runes of Suppression",
            "Savagery",
            "Shadow Control",
            "Shadow Mastery",
            "Shaman Augmentation Spec",
            "Shaman Mend Spec",
            "Smiting",
            "Soulrending",
            "Spectral Force",
            "Spectral Guard",
            "Spirit Animation",
            "Spirit Dimming",
            "Spirit Enhancement",
            "Spirit Suppression",
            "Stormcalling",
            "Subterranean Incantations",
            "Subterranean Spec",
            "Summon Monster",
            "Summoning",
            "Suppression",
            "Telekinesis",
            "Terrible Hammer",
            "Vacuumancy",
            "Valewalker Arb Path Spec",
            "Valewalker Arboreal Path Base",
            "Valkyrie Mending Spec",
            "Valor",
            "Vampiiric Embrace",
            "Vapormancy",
            "Verdant Path",
            "Verdant Path Spec",
            "Vivification",
            "Void Mastery",
            "Way of the Eclipse",
            "Way of the Moon",
            "Way of the Sun",
            "Witchcraft"});
            this.LineNameSpellSearchcomboBox.Location = new System.Drawing.Point(67, 13);
            this.LineNameSpellSearchcomboBox.MaxDropDownItems = 15;
            this.LineNameSpellSearchcomboBox.Name = "LineNameSpellSearchcomboBox";
            this.LineNameSpellSearchcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LineNameSpellSearchcomboBox.Sorted = true;
            this.LineNameSpellSearchcomboBox.TabIndex = 3;
            this.LineNameSpellSearchcomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LineName";
            // 
            // SpellHandlerSearchcomboBox
            // 
            this.SpellHandlerSearchcomboBox.DisplayMember = "All";
            this.SpellHandlerSearchcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpellHandlerSearchcomboBox.FormattingEnabled = true;
            this.SpellHandlerSearchcomboBox.Items.AddRange(new object[] {
            " All",
            "AblativeArmor",
            "AcuityBuff",
            "AcuityShear",
            "AfHitsBuff",
            "Amnesia",
            "Archery",
            "ArmorAbsorptionBuff",
            "ArmorAbsorptionDebuff",
            "ArmorFactorBuff",
            "ArmorFactorDebuff",
            "Arrogance",
            "ArrowDamageTypes",
            "BainsheePulseDmg",
            "Banespike",
            "Battlewarder",
            "BeFriend",
            "Bladeturn",
            "BlanketOfCamouflage",
            "BlockMissile",
            "BodyguardHandler",
            "BodyResistBuff",
            "BodyResistDebuff",
            "BodySpiritEnergyBuff",
            "BolsteringRoar",
            "Bolt",
            "Bomber",
            "Call",
            "CalmingNotes",
            "Campfire",
            "CastingSpeedDebuff",
            "CCResist",
            "Chamber",
            "Charm",
            "ChokingVapors",
            "CleansingAura",
            "ColdResistBuff",
            "ColdResistDebuff",
            "CombatHeal",
            "CombatSpeedBuff",
            "CombatSpeedDebuff",
            "CombineScrolls",
            "Confusion",
            "ConstitutionBuff",
            "ConstitutionDebuff",
            "ConstitutionShear",
            "Costume",
            "Critical",
            "CrushSlashThrustBuff",
            "CrushSlashThrustDebuff",
            "CureAll",
            "CureDisease",
            "CureMezz",
            "CureNearsight",
            "CurePoison",
            "DamageAdd",
            "DamageOverTime",
            "DamageShield",
            "DamageSpeedDecrease",
            "DefensiveProc",
            "DexterityBuff",
            "DexterityDebuff",
            "DexterityQuicknessBuff",
            "DexterityQuicknessDebuff",
            "DexterityQuicknessShear",
            "DexterityShear",
            "DirectDamage",
            "DirectDamageWithDebuff",
            "Disarm",
            "Disease",
            "DissonanceTrap",
            "DoomHammer",
            "DreamMorph",
            "EffectivenessBuff",
            "EffectivenessDebuff",
            "EnduranceDrain",
            "EnduranceHeal",
            "EnduranceRegenBuff",
            "EnergyResistBuff",
            "EnergyResistDebuff",
            "EvadeBuff",
            "FacilitatePainworking",
            "FatigueConsumptionBuff",
            "FatigueConsumptionDebuff",
            "Fear",
            "Firecamp",
            "FrontalPulseConeDD",
            "FumbleChanceDebuff",
            "Fury",
            "GatewayPersonalBind",
            "Grapple",
            "GroupRecall",
            "Heal",
            "HealOverTime",
            "HealthRegenBuff",
            "HealthToEndurance",
            "HeatColdMatterBuff",
            "HeatResistBuff",
            "HeatResistDebuff",
            "HereticDamageSpeedDecreaseLOP",
            "HereticDoTLostOnPulse",
            "HereticPiercingMagic",
            "Illusion Spell",
            "KeepDamageBuff",
            "Lifedrain",
            "LifeTransfer",
            "Loockout",
            "MagicalStrike",
            "MagicResistsBuff",
            "MatterResistBuff",
            "MatterResistDebuff",
            "MeleeDamageBuff",
            "MeleeDamageDebuff",
            "Mesmerize",
            "MesmerizeDurationBuf",
            "MetalGuard",
            "MissHit",
            "MobHeal",
            "MonsterDoT",
            "Nearsight",
            "NearsightReduction",
            "OffensiveProc",
            "OmniLifedrain",
            "Oppression",
            "ParryBuff",
            "PBAEDamage",
            "PBAEHeal",
            "PetConversion",
            "PetLifedrain",
            "PetSpell",
            "Phaseshift",
            "PoisonSpike",
            "Port",
            "PowerDrain",
            "PowerDrainPet",
            "PowerHeal",
            "PowerHealthEnduranceRegenBuff",
            "Powerless",
            "PowerRegenBuff",
            "PowerRend",
            "PowerTransferPet",
            "PowerTrap",
            "PrescienceNode",
            "PvERessurectionIllnessSpellType",
            "Rampage",
            "RandomBuffShear",
            "Range",
            "RangeShield",
            "ReanimateCorpse",
            "Recall",
            "RemovePet",
            "Resurrect",
            "RvrResurrectionIllnessSpellType",
            "Sabotage",
            "SavageCombatSpeedBuff",
            "SavageCrushResistanceBuff",
            "SavageDPSBuff",
            "SavageEnduranceHeal",
            "SavageEvadeBuff",
            "SavageParryBuff",
            "SavageSlashResistanceBuff",
            "SavageThrustResistanceBuff",
            "Silence",
            "SlashResistDebuff",
            "SpeedDecrease",
            "SpeedEnhancement",
            "SpeedOfTheRealm",
            "SpeedWrapWard",
            "SpiritResistBuff",
            "SpiritResistDebuff",
            "SpreadHeal",
            "StrengthBuff",
            "StrengthConstitutionBuff",
            "StrengthConstitutionDebuff",
            "StrengthConstitutionShear",
            "StrengthDebuff",
            "StrengthShear",
            "Stun",
            "StyleAbsDecrease",
            "StyleArmorFactorDebuff",
            "StyleBleeding",
            "StyleCombatSpeedDebuff",
            "StyleHandler",
            "StylePowerDrain",
            "StyleSpeedDecrease",
            "StyleStun",
            "StyleTaunt",
            "SummonAnimistFnF",
            "SummonAnimistPet",
            "SummonCommander",
            "SummonDruidPet",
            "SummonHunterPet",
            "SummonMastery",
            "SummonMinion",
            "SummonMonster",
            "SummonNecroPet",
            "SummonNoveltyPet",
            "SummonSiegeWeapon",
            "SummonSimulacrum",
            "SummonSpiritFighter",
            "SummonTheurgistPet",
            "SummonTitan",
            "SummonUnderhill",
            "SummonWarcrystal",
            "SummonWood",
            "TargetModifier",
            "Taunt",
            "ThrustResistDebuff",
            "ToHitBuff",
            "TurretPBAoE",
            "TurretsRelease",
            "UnbreakableSpeedDecrease",
            "Uninterruptable",
            "UniPortal",
            "UniPortalKeep",
            "ValkyrieOffensiveProc",
            "VampiirArmorDebuff",
            "VampiirBolt",
            "VampiirEffectivenessDeBuff",
            "VampiirMagicResistance",
            "VampiirMeleeResistance",
            "VampiirSkillBonusDeBuff",
            "VampiirStealthDetection",
            "VampSpeedDecrease",
            "WarlockSpeedDecrease",
            "WaterBreathing",
            "WeaponSkillBuff"});
            this.SpellHandlerSearchcomboBox.Location = new System.Drawing.Point(267, 13);
            this.SpellHandlerSearchcomboBox.MaxDropDownItems = 15;
            this.SpellHandlerSearchcomboBox.Name = "SpellHandlerSearchcomboBox";
            this.SpellHandlerSearchcomboBox.Size = new System.Drawing.Size(112, 21);
            this.SpellHandlerSearchcomboBox.Sorted = true;
            this.SpellHandlerSearchcomboBox.TabIndex = 8;
            this.SpellHandlerSearchcomboBox.SelectedIndexChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SpellHandler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "SpellID";
            // 
            // SearchSpellIDtextBox
            // 
            this.SearchSpellIDtextBox.Location = new System.Drawing.Point(438, 14);
            this.SearchSpellIDtextBox.Name = "SearchSpellIDtextBox";
            this.SearchSpellIDtextBox.Size = new System.Drawing.Size(44, 20);
            this.SearchSpellIDtextBox.TabIndex = 12;
            this.SearchSpellIDtextBox.TextChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Spell Name";
            // 
            // SearchBySpellNametextBox
            // 
            this.SearchBySpellNametextBox.Location = new System.Drawing.Point(554, 14);
            this.SearchBySpellNametextBox.Name = "SearchBySpellNametextBox";
            this.SearchBySpellNametextBox.Size = new System.Drawing.Size(143, 20);
            this.SearchBySpellNametextBox.TabIndex = 14;
            this.SearchBySpellNametextBox.TextChanged += new System.EventHandler(this.SearchFilters_SelectedChanged);
            // 
            // ControlMenu
            // 
            this.ControlMenu.Controls.Add(this.label3);
            this.ControlMenu.Controls.Add(this.label2);
            this.ControlMenu.Controls.Add(this.SpellbindingNavigator);
            this.ControlMenu.Controls.Add(this.LineNameSpellSearchcomboBox);
            this.ControlMenu.Controls.Add(this.label4);
            this.ControlMenu.Controls.Add(this.SearchBySpellNametextBox);
            this.ControlMenu.Controls.Add(this.SpellHandlerSearchcomboBox);
            this.ControlMenu.Controls.Add(this.label5);
            this.ControlMenu.Controls.Add(this.SearchSpellIDtextBox);
            this.ControlMenu.Location = new System.Drawing.Point(7, 1);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(713, 67);
            this.ControlMenu.TabIndex = 17;
            this.ControlMenu.TabStop = false;
            // 
            // SpellbindingNavigator
            // 
            this.SpellbindingNavigator.AddNewItem = null;
            this.SpellbindingNavigator.BindingSource = this.SpellbindingSource;
            this.SpellbindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.SpellbindingNavigator.DeleteItem = null;
            this.SpellbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.SpellbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.SpellbindingNavigator.Location = new System.Drawing.Point(4, 39);
            this.SpellbindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.SpellbindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.SpellbindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.SpellbindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.SpellbindingNavigator.Name = "SpellbindingNavigator";
            this.SpellbindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.SpellbindingNavigator.Size = new System.Drawing.Size(232, 25);
            this.SpellbindingNavigator.TabIndex = 1;
            this.SpellbindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.SpellNavigatorDeleteItem_Click);
            // 
            // SaveNewbutton
            // 
            this.SaveNewbutton.Location = new System.Drawing.Point(43, 42);
            this.SaveNewbutton.Name = "SaveNewbutton";
            this.SaveNewbutton.Size = new System.Drawing.Size(111, 23);
            this.SaveNewbutton.TabIndex = 21;
            this.SaveNewbutton.Text = "Save New Spell";
            this.SaveNewbutton.UseVisualStyleBackColor = true;
            this.SaveNewbutton.Click += new System.EventHandler(this.SaveNewSpell_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(43, 42);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(111, 23);
            this.Savebutton.TabIndex = 20;
            this.Savebutton.Text = "Save Loaded Spell";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.SaveLoadedSpell_Click);
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(83, 62);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(43, 20);
            this.textBox36.TabIndex = 2;
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 39);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(61, 13);
            this.label47.TabIndex = 18;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(8, 13);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(41, 13);
            this.label46.TabIndex = 19;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(8, 65);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(28, 13);
            this.label45.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(7, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 695);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox12);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.textBox51);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spell Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.LanguageSpellMessage4richTextBox);
            this.groupBox12.Controls.Add(this.textBox9);
            this.groupBox12.Controls.Add(this.LanguageSpellMessage3richTextBox);
            this.groupBox12.Controls.Add(this.textBox10);
            this.groupBox12.Controls.Add(this.button1);
            this.groupBox12.Controls.Add(this.LanguageSpellMessage2richTextBox);
            this.groupBox12.Controls.Add(this.textBox8);
            this.groupBox12.Controls.Add(this.LanguageSpellMessage1richTextBox);
            this.groupBox12.Controls.Add(this.textBox4);
            this.groupBox12.Controls.Add(this.label51);
            this.groupBox12.Controls.Add(this.LanguageSpellNametextBox);
            this.groupBox12.Controls.Add(this.label31);
            this.groupBox12.Controls.Add(this.LanguageSpellDescriptionrichTextBox);
            this.groupBox12.Controls.Add(this.dataGridViewLanguageSpell);
            this.groupBox12.Controls.Add(this.SpellLanguagebindingNavigator);
            this.groupBox12.Controls.Add(this.label53);
            this.groupBox12.Controls.Add(this.LanguageSpellLAnguageChoicecomboBox);
            this.groupBox12.Controls.Add(this.LanguageSpellTagtextBox);
            this.groupBox12.Controls.Add(this.label52);
            this.groupBox12.Enabled = false;
            this.groupBox12.Location = new System.Drawing.Point(8, 450);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(950, 218);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "LanguageSpell Add";
            // 
            // LanguageSpellMessage4richTextBox
            // 
            this.LanguageSpellMessage4richTextBox.Location = new System.Drawing.Point(506, 70);
            this.LanguageSpellMessage4richTextBox.Name = "LanguageSpellMessage4richTextBox";
            this.LanguageSpellMessage4richTextBox.Size = new System.Drawing.Size(195, 30);
            this.LanguageSpellMessage4richTextBox.TabIndex = 48;
            this.LanguageSpellMessage4richTextBox.Text = "";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(578, 54);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(57, 20);
            this.textBox9.TabIndex = 47;
            this.textBox9.Text = "Message4";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LanguageSpellMessage3richTextBox
            // 
            this.LanguageSpellMessage3richTextBox.Location = new System.Drawing.Point(506, 22);
            this.LanguageSpellMessage3richTextBox.Name = "LanguageSpellMessage3richTextBox";
            this.LanguageSpellMessage3richTextBox.Size = new System.Drawing.Size(195, 28);
            this.LanguageSpellMessage3richTextBox.TabIndex = 46;
            this.LanguageSpellMessage3richTextBox.Text = "";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(577, 6);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(56, 20);
            this.textBox10.TabIndex = 45;
            this.textBox10.Text = "Message3";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(881, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 81);
            this.button1.TabIndex = 44;
            this.button1.Text = "Add Language Spell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddLanguageSpell_Click);
            // 
            // LanguageSpellMessage2richTextBox
            // 
            this.LanguageSpellMessage2richTextBox.Location = new System.Drawing.Point(302, 70);
            this.LanguageSpellMessage2richTextBox.Name = "LanguageSpellMessage2richTextBox";
            this.LanguageSpellMessage2richTextBox.Size = new System.Drawing.Size(198, 30);
            this.LanguageSpellMessage2richTextBox.TabIndex = 39;
            this.LanguageSpellMessage2richTextBox.Text = "";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(382, 54);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(58, 20);
            this.textBox8.TabIndex = 38;
            this.textBox8.Text = "Message2";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LanguageSpellMessage1richTextBox
            // 
            this.LanguageSpellMessage1richTextBox.Location = new System.Drawing.Point(302, 22);
            this.LanguageSpellMessage1richTextBox.Name = "LanguageSpellMessage1richTextBox";
            this.LanguageSpellMessage1richTextBox.Size = new System.Drawing.Size(198, 28);
            this.LanguageSpellMessage1richTextBox.TabIndex = 37;
            this.LanguageSpellMessage1richTextBox.Text = "";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(381, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 36;
            this.textBox4.Text = "Message1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(119, 29);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 13);
            this.label51.TabIndex = 33;
            this.label51.Text = "Name";
            // 
            // LanguageSpellNametextBox
            // 
            this.LanguageSpellNametextBox.Location = new System.Drawing.Point(160, 29);
            this.LanguageSpellNametextBox.Name = "LanguageSpellNametextBox";
            this.LanguageSpellNametextBox.Size = new System.Drawing.Size(136, 20);
            this.LanguageSpellNametextBox.TabIndex = 32;
            this.LanguageSpellNametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(763, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(60, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Description";
            // 
            // LanguageSpellDescriptionrichTextBox
            // 
            this.LanguageSpellDescriptionrichTextBox.Location = new System.Drawing.Point(707, 22);
            this.LanguageSpellDescriptionrichTextBox.Name = "LanguageSpellDescriptionrichTextBox";
            this.LanguageSpellDescriptionrichTextBox.Size = new System.Drawing.Size(171, 78);
            this.LanguageSpellDescriptionrichTextBox.TabIndex = 34;
            this.LanguageSpellDescriptionrichTextBox.Text = "";
            // 
            // dataGridViewLanguageSpell
            // 
            this.dataGridViewLanguageSpell.AllowUserToAddRows = false;
            this.dataGridViewLanguageSpell.AllowUserToOrderColumns = true;
            this.dataGridViewLanguageSpell.AutoGenerateColumns = false;
            this.dataGridViewLanguageSpell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLanguageSpell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLanguageSpell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanguageSpell.DataSource = this.LanguageSpellbindingSource;
            this.dataGridViewLanguageSpell.Location = new System.Drawing.Point(6, 106);
            this.dataGridViewLanguageSpell.MultiSelect = false;
            this.dataGridViewLanguageSpell.Name = "dataGridViewLanguageSpell";
            this.dataGridViewLanguageSpell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLanguageSpell.Size = new System.Drawing.Size(938, 106);
            this.dataGridViewLanguageSpell.TabIndex = 20;
            this.dataGridViewLanguageSpell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.LanguageSpelldataGridView_CellValueChanged);
            // 
            // SpellLanguagebindingNavigator
            // 
            this.SpellLanguagebindingNavigator.AddNewItem = null;
            this.SpellLanguagebindingNavigator.BindingSource = this.LanguageSpellbindingSource;
            this.SpellLanguagebindingNavigator.CountItem = null;
            this.SpellLanguagebindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.SpellLanguagebindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.SpellLanguagebindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem2});
            this.SpellLanguagebindingNavigator.Location = new System.Drawing.Point(6, 78);
            this.SpellLanguagebindingNavigator.MoveFirstItem = null;
            this.SpellLanguagebindingNavigator.MoveLastItem = null;
            this.SpellLanguagebindingNavigator.MoveNextItem = null;
            this.SpellLanguagebindingNavigator.MovePreviousItem = null;
            this.SpellLanguagebindingNavigator.Name = "SpellLanguagebindingNavigator";
            this.SpellLanguagebindingNavigator.PositionItem = null;
            this.SpellLanguagebindingNavigator.Size = new System.Drawing.Size(35, 25);
            this.SpellLanguagebindingNavigator.TabIndex = 20;
            this.SpellLanguagebindingNavigator.Text = "bindingNavigator3";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            this.bindingNavigatorDeleteItem2.Click += new System.EventHandler(this.LanguageSpellbindingNavigatorDeleteItem_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 38);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 13);
            this.label53.TabIndex = 26;
            this.label53.Text = "Language";
            // 
            // LanguageSpellLAnguageChoicecomboBox
            // 
            this.LanguageSpellLAnguageChoicecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageSpellLAnguageChoicecomboBox.FormattingEnabled = true;
            this.LanguageSpellLAnguageChoicecomboBox.Items.AddRange(new object[] {
            "FR",
            "DE"});
            this.LanguageSpellLAnguageChoicecomboBox.Location = new System.Drawing.Point(61, 35);
            this.LanguageSpellLAnguageChoicecomboBox.Name = "LanguageSpellLAnguageChoicecomboBox";
            this.LanguageSpellLAnguageChoicecomboBox.Size = new System.Drawing.Size(44, 21);
            this.LanguageSpellLAnguageChoicecomboBox.TabIndex = 31;
            // 
            // LanguageSpellTagtextBox
            // 
            this.LanguageSpellTagtextBox.Location = new System.Drawing.Point(160, 58);
            this.LanguageSpellTagtextBox.Name = "LanguageSpellTagtextBox";
            this.LanguageSpellTagtextBox.Size = new System.Drawing.Size(136, 20);
            this.LanguageSpellTagtextBox.TabIndex = 29;
            this.LanguageSpellTagtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(118, 61);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(26, 13);
            this.label52.TabIndex = 30;
            this.label52.Text = "Tag";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PackageIDAddLineXSpellcomboBox);
            this.groupBox4.Controls.Add(this.LineNameAddLineXSpellcomboBox);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.LinexSpellAddLeveltextBox);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.LineXSpellbindingNavigator);
            this.groupBox4.Controls.Add(this.dataGridViewLineXSpell);
            this.groupBox4.Location = new System.Drawing.Point(385, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(573, 162);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LineXSpell of this Spell";
            // 
            // PackageIDAddLineXSpellcomboBox
            // 
            this.PackageIDAddLineXSpellcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackageIDAddLineXSpellcomboBox.FormattingEnabled = true;
            this.PackageIDAddLineXSpellcomboBox.Location = new System.Drawing.Point(65, 78);
            this.PackageIDAddLineXSpellcomboBox.Name = "PackageIDAddLineXSpellcomboBox";
            this.PackageIDAddLineXSpellcomboBox.Size = new System.Drawing.Size(106, 21);
            this.PackageIDAddLineXSpellcomboBox.TabIndex = 33;
            // 
            // LineNameAddLineXSpellcomboBox
            // 
            this.LineNameAddLineXSpellcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LineNameAddLineXSpellcomboBox.FormattingEnabled = true;
            this.LineNameAddLineXSpellcomboBox.Items.AddRange(new object[] {
            "Abrasion",
            "Arboreal Mastery",
            "Arboreal Path",
            "Augmentation",
            "Aura Manipulation",
            "Bard Music",
            "Bard Music Spec",
            "Battlesongs",
            "Beastcraft",
            "Bedazzling",
            "Body Destruction",
            "Bone Army",
            "Bone Guardians",
            "Bone Mystics",
            "Bone Warriors",
            "BoneBufferHaste",
            "BoneBufferShield",
            "BoneDebufferDisease",
            "BoneDebufferHaste",
            "BoneHealerHeal",
            "BoneMage",
            "Calefaction",
            "Champion Abilities",
            "Chants",
            "Character Abilities",
            "Combat Style Effects",
            "Creeping Path",
            "Creeping Path Spec",
            "Cursing",
            "Cursing Spec",
            "Darkness",
            "Death Servant",
            "Death Servant Spec",
            "Deathsight",
            "Deathsight Spec",
            "Dementia",
            "Disorientation",
            "Domination",
            "Dragon Magic",
            "Druid Nature Magic",
            "Druid Nature Spec",
            "Druid Nurture Spec",
            "Empowering",
            "Enchantment",
            "Enchantment Mastery",
            "Enhancement",
            "Essence Manipulation",
            "Ethereal Shriek",
            "Friar Enhancement Spec",
            "Guardian Angel",
            "Healer Augmentation Spec",
            "Healer Mending Spec",
            "Heretic Enhancement Spec",
            "Heretic Rejuvenation Spec",
            "Hexing",
            "Holism",
            "Illusions",
            "Instruments",
            "Item Effects",
            "Liquifaction",
            "Magnetism",
            "Matter",
            "Matter Manipulation",
            "Mending",
            "Mentalism",
            "Mind Mastery",
            "Mind Twisting",
            "Mob Spells",
            "Mundane Poisons",
            "Necro Pet Insta Spells",
            "Nightshade",
            "Nurture",
            "Nurture Warden Spec",
            "Odin\'s Will",
            "Pacification",
            "Pacification Spec",
            "Painworking",
            "Painworking Spec",
            "Path of Air",
            "Path of Earth",
            "Path of Fire",
            "Path of Ice",
            "Pathfinding",
            "PetBuff",
            "Phantasmal Wail",
            "Potions",
            "Power Strikes",
            "Pyromancy",
            "Rebirth",
            "Rebirth (Cleric)",
            "Refrigeration",
            "Regrowth",
            "Regrowth Bard Spec",
            "Regrowth Druid Spec",
            "Regrowth Warden Spec",
            "Rejuvenation",
            "Reserved Spells",
            "Runecarving",
            "Runes of Darkness",
            "Runes of Destruction",
            "Runes of Suppression",
            "Savagery",
            "Shadow Control",
            "Shadow Mastery",
            "Shaman Augmentation Spec",
            "Shaman Mend Spec",
            "Smiting",
            "Soulrending",
            "Spectral Force",
            "Spectral Guard",
            "Spirit Animation",
            "Spirit Dimming",
            "Spirit Enhancement",
            "Spirit Suppression",
            "Stormcalling",
            "Subterranean Incantations",
            "Subterranean Spec",
            "Summon Monster",
            "Summoning",
            "Suppression",
            "Telekinesis",
            "Terrible Hammer",
            "Vacuumancy",
            "Valewalker Arb Path Spec",
            "Valewalker Arboreal Path Base",
            "Valkyrie Mending Spec",
            "Valor",
            "Vampiiric Embrace",
            "Vapormancy",
            "Verdant Path",
            "Verdant Path Spec",
            "Vivification",
            "Void Mastery",
            "Way of the Eclipse",
            "Way of the Moon",
            "Way of the Sun",
            "Witchcraft"});
            this.LineNameAddLineXSpellcomboBox.Location = new System.Drawing.Point(65, 26);
            this.LineNameAddLineXSpellcomboBox.Name = "LineNameAddLineXSpellcomboBox";
            this.LineNameAddLineXSpellcomboBox.Size = new System.Drawing.Size(136, 21);
            this.LineNameAddLineXSpellcomboBox.Sorted = true;
            this.LineNameAddLineXSpellcomboBox.TabIndex = 32;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "PackageID";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Add LineXSpell";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddLineXSpell_Click);
            // 
            // LinexSpellAddLeveltextBox
            // 
            this.LinexSpellAddLeveltextBox.Location = new System.Drawing.Point(65, 53);
            this.LinexSpellAddLeveltextBox.Name = "LinexSpellAddLeveltextBox";
            this.LinexSpellAddLeveltextBox.Size = new System.Drawing.Size(54, 20);
            this.LinexSpellAddLeveltextBox.TabIndex = 27;
            this.LinexSpellAddLeveltextBox.Text = "50";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(7, 55);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(33, 13);
            this.label54.TabIndex = 37;
            this.label54.Text = "Level";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 30);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(55, 13);
            this.label55.TabIndex = 35;
            this.label55.Text = "LineName";
            // 
            // LineXSpellbindingNavigator
            // 
            this.LineXSpellbindingNavigator.AddNewItem = null;
            this.LineXSpellbindingNavigator.BindingSource = this.LineXSpellbindingSource;
            this.LineXSpellbindingNavigator.CountItem = null;
            this.LineXSpellbindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.LineXSpellbindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.LineXSpellbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem1});
            this.LineXSpellbindingNavigator.Location = new System.Drawing.Point(214, 5);
            this.LineXSpellbindingNavigator.MoveFirstItem = null;
            this.LineXSpellbindingNavigator.MoveLastItem = null;
            this.LineXSpellbindingNavigator.MoveNextItem = null;
            this.LineXSpellbindingNavigator.MovePreviousItem = null;
            this.LineXSpellbindingNavigator.Name = "LineXSpellbindingNavigator";
            this.LineXSpellbindingNavigator.PositionItem = null;
            this.LineXSpellbindingNavigator.Size = new System.Drawing.Size(35, 25);
            this.LineXSpellbindingNavigator.TabIndex = 23;
            this.LineXSpellbindingNavigator.Text = "bindingNavigator2";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.LineXSpellbindingNavigatorDeleteItem_Click);
            // 
            // dataGridViewLineXSpell
            // 
            this.dataGridViewLineXSpell.AllowUserToAddRows = false;
            this.dataGridViewLineXSpell.AllowUserToOrderColumns = true;
            this.dataGridViewLineXSpell.AutoGenerateColumns = false;
            this.dataGridViewLineXSpell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLineXSpell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLineXSpell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLineXSpell.DataSource = this.LineXSpellbindingSource;
            this.dataGridViewLineXSpell.Location = new System.Drawing.Point(211, 30);
            this.dataGridViewLineXSpell.MultiSelect = false;
            this.dataGridViewLineXSpell.Name = "dataGridViewLineXSpell";
            this.dataGridViewLineXSpell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLineXSpell.Size = new System.Drawing.Size(356, 118);
            this.dataGridViewLineXSpell.TabIndex = 20;
            this.dataGridViewLineXSpell.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.LineXSpelldataGridView_CellValueChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.IsFocuscomboBox);
            this.groupBox7.Controls.Add(this.AllowBoltcomboBox);
            this.groupBox7.Controls.Add(this.IsSecondarycomboBox);
            this.groupBox7.Controls.Add(this.IsPrimarycomboBox);
            this.groupBox7.Controls.Add(this.UninterruptiblecomboBox);
            this.groupBox7.Controls.Add(this.MoveCastcomboBox);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label40);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.SharedTimerGrouptextBox);
            this.groupBox7.Controls.Add(this.AmnesiaChancetextBox);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Controls.Add(this.label36);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.SpellGrouptextBox);
            this.groupBox7.Controls.Add(this.InstrumentRequirementtextBox);
            this.groupBox7.Controls.Add(this.EffectGrouptextBox);
            this.groupBox7.Controls.Add(this.SubSpellIDtextBox);
            this.groupBox7.Location = new System.Drawing.Point(592, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(366, 179);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            // 
            // IsFocuscomboBox
            // 
            this.IsFocuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsFocuscomboBox.FormattingEnabled = true;
            this.IsFocuscomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsFocuscomboBox.Location = new System.Drawing.Point(300, 149);
            this.IsFocuscomboBox.Name = "IsFocuscomboBox";
            this.IsFocuscomboBox.Size = new System.Drawing.Size(60, 21);
            this.IsFocuscomboBox.TabIndex = 49;
            // 
            // AllowBoltcomboBox
            // 
            this.AllowBoltcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllowBoltcomboBox.FormattingEnabled = true;
            this.AllowBoltcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.AllowBoltcomboBox.Location = new System.Drawing.Point(300, 98);
            this.AllowBoltcomboBox.Name = "AllowBoltcomboBox";
            this.AllowBoltcomboBox.Size = new System.Drawing.Size(60, 21);
            this.AllowBoltcomboBox.TabIndex = 48;
            // 
            // IsSecondarycomboBox
            // 
            this.IsSecondarycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsSecondarycomboBox.FormattingEnabled = true;
            this.IsSecondarycomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsSecondarycomboBox.Location = new System.Drawing.Point(300, 71);
            this.IsSecondarycomboBox.Name = "IsSecondarycomboBox";
            this.IsSecondarycomboBox.Size = new System.Drawing.Size(60, 21);
            this.IsSecondarycomboBox.TabIndex = 47;
            // 
            // IsPrimarycomboBox
            // 
            this.IsPrimarycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsPrimarycomboBox.FormattingEnabled = true;
            this.IsPrimarycomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.IsPrimarycomboBox.Location = new System.Drawing.Point(300, 46);
            this.IsPrimarycomboBox.Name = "IsPrimarycomboBox";
            this.IsPrimarycomboBox.Size = new System.Drawing.Size(60, 21);
            this.IsPrimarycomboBox.TabIndex = 46;
            // 
            // UninterruptiblecomboBox
            // 
            this.UninterruptiblecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UninterruptiblecomboBox.FormattingEnabled = true;
            this.UninterruptiblecomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.UninterruptiblecomboBox.Location = new System.Drawing.Point(300, 19);
            this.UninterruptiblecomboBox.Name = "UninterruptiblecomboBox";
            this.UninterruptiblecomboBox.Size = new System.Drawing.Size(60, 21);
            this.UninterruptiblecomboBox.TabIndex = 45;
            // 
            // MoveCastcomboBox
            // 
            this.MoveCastcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoveCastcomboBox.FormattingEnabled = true;
            this.MoveCastcomboBox.Items.AddRange(new object[] {
            "False",
            "True"});
            this.MoveCastcomboBox.Location = new System.Drawing.Point(300, 124);
            this.MoveCastcomboBox.Name = "MoveCastcomboBox";
            this.MoveCastcomboBox.Size = new System.Drawing.Size(60, 21);
            this.MoveCastcomboBox.TabIndex = 44;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(5, 152);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(96, 13);
            this.label42.TabIndex = 28;
            this.label42.Text = "SharedTimerGroup";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(205, 152);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 13);
            this.label41.TabIndex = 27;
            this.label41.Text = "IsFocus";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(84, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "AmnesiaChance";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(205, 49);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 13);
            this.label40.TabIndex = 26;
            this.label40.Text = "IsPrimary";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(205, 74);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(66, 13);
            this.label39.TabIndex = 25;
            this.label39.Text = "IsSecondary";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(205, 101);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "AllowBolt";
            // 
            // SharedTimerGrouptextBox
            // 
            this.SharedTimerGrouptextBox.Location = new System.Drawing.Point(127, 149);
            this.SharedTimerGrouptextBox.Name = "SharedTimerGrouptextBox";
            this.SharedTimerGrouptextBox.Size = new System.Drawing.Size(59, 20);
            this.SharedTimerGrouptextBox.TabIndex = 14;
            this.SharedTimerGrouptextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmnesiaChancetextBox
            // 
            this.AmnesiaChancetextBox.Location = new System.Drawing.Point(127, 19);
            this.AmnesiaChancetextBox.Name = "AmnesiaChancetextBox";
            this.AmnesiaChancetextBox.Size = new System.Drawing.Size(59, 20);
            this.AmnesiaChancetextBox.TabIndex = 34;
            this.AmnesiaChancetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(5, 126);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 13);
            this.label37.TabIndex = 23;
            this.label37.Text = "SubSpellId";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(205, 129);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 22;
            this.label36.Text = "MoveCast";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(205, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(75, 13);
            this.label35.TabIndex = 21;
            this.label35.Text = "Uninterruptible";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 48);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(116, 13);
            this.label34.TabIndex = 20;
            this.label34.Text = "InstrumentRequirement";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 100);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 13);
            this.label33.TabIndex = 19;
            this.label33.Text = "EffectGroup";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 18;
            this.label32.Text = "SpellGroup";
            // 
            // SpellGrouptextBox
            // 
            this.SpellGrouptextBox.Location = new System.Drawing.Point(127, 71);
            this.SpellGrouptextBox.Name = "SpellGrouptextBox";
            this.SpellGrouptextBox.Size = new System.Drawing.Size(59, 20);
            this.SpellGrouptextBox.TabIndex = 4;
            this.SpellGrouptextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InstrumentRequirementtextBox
            // 
            this.InstrumentRequirementtextBox.Location = new System.Drawing.Point(127, 45);
            this.InstrumentRequirementtextBox.Name = "InstrumentRequirementtextBox";
            this.InstrumentRequirementtextBox.Size = new System.Drawing.Size(59, 20);
            this.InstrumentRequirementtextBox.TabIndex = 3;
            this.InstrumentRequirementtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EffectGrouptextBox
            // 
            this.EffectGrouptextBox.Location = new System.Drawing.Point(127, 97);
            this.EffectGrouptextBox.Name = "EffectGrouptextBox";
            this.EffectGrouptextBox.Size = new System.Drawing.Size(59, 20);
            this.EffectGrouptextBox.TabIndex = 8;
            this.EffectGrouptextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubSpellIDtextBox
            // 
            this.SubSpellIDtextBox.Location = new System.Drawing.Point(127, 123);
            this.SubSpellIDtextBox.Name = "SubSpellIDtextBox";
            this.SubSpellIDtextBox.Size = new System.Drawing.Size(59, 20);
            this.SubSpellIDtextBox.TabIndex = 7;
            this.SubSpellIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PackageIDcomboBox);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.TranslationIDtextBox);
            this.groupBox6.Location = new System.Drawing.Point(592, 188);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(366, 97);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // PackageIDcomboBox
            // 
            this.PackageIDcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PackageIDcomboBox.FormattingEnabled = true;
            this.PackageIDcomboBox.Location = new System.Drawing.Point(9, 41);
            this.PackageIDcomboBox.Name = "PackageIDcomboBox";
            this.PackageIDcomboBox.Size = new System.Drawing.Size(108, 21);
            this.PackageIDcomboBox.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(32, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "PackageId";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(221, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "TranslationID";
            // 
            // TranslationIDtextBox
            // 
            this.TranslationIDtextBox.Enabled = false;
            this.TranslationIDtextBox.Location = new System.Drawing.Point(198, 42);
            this.TranslationIDtextBox.Name = "TranslationIDtextBox";
            this.TranslationIDtextBox.Size = new System.Drawing.Size(110, 20);
            this.TranslationIDtextBox.TabIndex = 5;
            this.TranslationIDtextBox.TextChanged += new System.EventHandler(this.TranslationID_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Message4richTextBox);
            this.groupBox5.Controls.Add(this.Message3richTextBox);
            this.groupBox5.Controls.Add(this.Message2richTextBox);
            this.groupBox5.Controls.Add(this.textBox34);
            this.groupBox5.Controls.Add(this.textBox33);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.Message1richTextBox);
            this.groupBox5.Controls.Add(this.textBox39);
            this.groupBox5.Location = new System.Drawing.Point(8, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(370, 162);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            // 
            // Message4richTextBox
            // 
            this.Message4richTextBox.Location = new System.Drawing.Point(182, 101);
            this.Message4richTextBox.Name = "Message4richTextBox";
            this.Message4richTextBox.Size = new System.Drawing.Size(185, 55);
            this.Message4richTextBox.TabIndex = 29;
            this.Message4richTextBox.Text = "";
            // 
            // Message3richTextBox
            // 
            this.Message3richTextBox.Location = new System.Drawing.Point(7, 101);
            this.Message3richTextBox.Name = "Message3richTextBox";
            this.Message3richTextBox.Size = new System.Drawing.Size(170, 55);
            this.Message3richTextBox.TabIndex = 28;
            this.Message3richTextBox.Text = "";
            // 
            // Message2richTextBox
            // 
            this.Message2richTextBox.Location = new System.Drawing.Point(182, 24);
            this.Message2richTextBox.Name = "Message2richTextBox";
            this.Message2richTextBox.Size = new System.Drawing.Size(185, 57);
            this.Message2richTextBox.TabIndex = 27;
            this.Message2richTextBox.Text = "";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(185, 81);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(57, 20);
            this.textBox34.TabIndex = 26;
            this.textBox34.Text = "Message4";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(7, 81);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(57, 20);
            this.textBox33.TabIndex = 25;
            this.textBox33.Text = "Message3";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 7);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(57, 20);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "Message2";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Message1richTextBox
            // 
            this.Message1richTextBox.Location = new System.Drawing.Point(7, 24);
            this.Message1richTextBox.Name = "Message1richTextBox";
            this.Message1richTextBox.Size = new System.Drawing.Size(170, 57);
            this.Message1richTextBox.TabIndex = 23;
            this.Message1richTextBox.Text = "";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(6, 7);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(57, 20);
            this.textBox39.TabIndex = 3;
            this.textBox39.Text = "Message1";
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TargetcomboBox);
            this.groupBox8.Controls.Add(this.SpellTypecomboBox);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label25);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.ResurrectManatextBox);
            this.groupBox8.Controls.Add(this.ResurrectHealthtextBox);
            this.groupBox8.Controls.Add(this.ValuetextBox);
            this.groupBox8.Controls.Add(this.LifeDrainReturntextBox);
            this.groupBox8.Controls.Add(this.ConcentrationtextBox);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.RecastDelaytextBox);
            this.groupBox8.Controls.Add(this.PulsetextBox);
            this.groupBox8.Controls.Add(this.PulsePowertextBox);
            this.groupBox8.Controls.Add(this.RadiustextBox);
            this.groupBox8.Controls.Add(this.FrequencytextBox);
            this.groupBox8.Controls.Add(this.DurationtextBox);
            this.groupBox8.Controls.Add(this.DamageTypetextBox);
            this.groupBox8.Controls.Add(this.RangetextBox);
            this.groupBox8.Controls.Add(this.PowertextBox);
            this.groupBox8.Controls.Add(this.DamagetextBox);
            this.groupBox8.Controls.Add(this.CastTimetextBox);
            this.groupBox8.Location = new System.Drawing.Point(8, 106);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(578, 179);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            // 
            // TargetcomboBox
            // 
            this.TargetcomboBox.DisplayMember = "Target";
            this.TargetcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetcomboBox.FormattingEnabled = true;
            this.TargetcomboBox.Items.AddRange(new object[] {
            "",
            "Area",
            "cone",
            "corpse",
            "Enemy",
            "Group",
            "Pet",
            "Realm",
            "Self",
            "Target"});
            this.TargetcomboBox.Location = new System.Drawing.Point(80, 18);
            this.TargetcomboBox.Name = "TargetcomboBox";
            this.TargetcomboBox.Size = new System.Drawing.Size(59, 21);
            this.TargetcomboBox.Sorted = true;
            this.TargetcomboBox.TabIndex = 44;
            this.TargetcomboBox.ValueMember = "Target";
            // 
            // SpellTypecomboBox
            // 
            this.SpellTypecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpellTypecomboBox.FormattingEnabled = true;
            this.SpellTypecomboBox.Items.AddRange(new object[] {
            "AblativeArmor",
            "AcuityBuff",
            "AcuityShear",
            "AfHitsBuff",
            "Amnesia",
            "Archery",
            "ArmorAbsorptionBuff",
            "ArmorAbsorptionDebuff",
            "ArmorFactorBuff",
            "ArmorFactorDebuff",
            "Arrogance",
            "ArrowDamageTypes",
            "BainsheePulseDmg",
            "Banespike",
            "Battlewarder",
            "BeFriend",
            "Bladeturn",
            "BlanketOfCamouflage",
            "BlockMissile",
            "BodyguardHandler",
            "BodyResistBuff",
            "BodyResistDebuff",
            "BodySpiritEnergyBuff",
            "BolsteringRoar",
            "Bolt",
            "Bomber",
            "Call",
            "CalmingNotes",
            "Campfire",
            "CastingSpeedDebuff",
            "CCResist",
            "Chamber",
            "Charm",
            "ChokingVapors",
            "CleansingAura",
            "ColdResistBuff",
            "ColdResistDebuff",
            "CombatHeal",
            "CombatSpeedBuff",
            "CombatSpeedDebuff",
            "CombineScrolls",
            "Confusion",
            "ConstitutionBuff",
            "ConstitutionDebuff",
            "ConstitutionShear",
            "Costume",
            "Critical",
            "CrushSlashThrustBuff",
            "CrushSlashThrustDebuff",
            "CureAll",
            "CureDisease",
            "CureMezz",
            "CureNearsight",
            "CurePoison",
            "DamageAdd",
            "DamageOverTime",
            "DamageShield",
            "DamageSpeedDecrease",
            "DefensiveProc",
            "DexterityBuff",
            "DexterityDebuff",
            "DexterityQuicknessBuff",
            "DexterityQuicknessDebuff",
            "DexterityQuicknessShear",
            "DexterityShear",
            "DirectDamage",
            "DirectDamageWithDebuff",
            "Disarm",
            "Disease",
            "DissonanceTrap",
            "DoomHammer",
            "DreamMorph",
            "EffectivenessBuff",
            "EffectivenessDebuff",
            "EnduranceDrain",
            "EnduranceHeal",
            "EnduranceRegenBuff",
            "EnergyResistBuff",
            "EnergyResistDebuff",
            "EvadeBuff",
            "FacilitatePainworking",
            "FatigueConsumptionBuff",
            "FatigueConsumptionDebuff",
            "Fear",
            "Firecamp",
            "FrontalPulseConeDD",
            "FumbleChanceDebuff",
            "Fury",
            "GatewayPersonalBind",
            "Grapple",
            "GroupRecall",
            "Heal",
            "HealOverTime",
            "HealthRegenBuff",
            "HealthToEndurance",
            "HeatColdMatterBuff",
            "HeatResistBuff",
            "HeatResistDebuff",
            "HereticDamageSpeedDecreaseLOP",
            "HereticDoTLostOnPulse",
            "HereticPiercingMagic",
            "Illusion Spell",
            "KeepDamageBuff",
            "Lifedrain",
            "LifeTransfer",
            "Loockout",
            "MagicalStrike",
            "MagicResistsBuff",
            "MatterResistBuff",
            "MatterResistDebuff",
            "MeleeDamageBuff",
            "MeleeDamageDebuff",
            "Mesmerize",
            "MesmerizeDurationBuf",
            "MetalGuard",
            "MissHit",
            "MobHeal",
            "MonsterDoT",
            "Nearsight",
            "NearsightReduction",
            "OffensiveProc",
            "OmniLifedrain",
            "Oppression",
            "ParryBuff",
            "PBAEDamage",
            "PBAEHeal",
            "PetConversion",
            "PetLifedrain",
            "PetSpell",
            "Phaseshift",
            "PoisonSpike",
            "Port",
            "PowerDrain",
            "PowerDrainPet",
            "PowerHeal",
            "PowerHealthEnduranceRegenBuff",
            "Powerless",
            "PowerRegenBuff",
            "PowerRend",
            "PowerTransferPet",
            "PowerTrap",
            "PrescienceNode",
            "PvERessurectionIllnessSpellType",
            "Rampage",
            "RandomBuffShear",
            "Range",
            "RangeShield",
            "ReanimateCorpse",
            "Recall",
            "RemovePet",
            "Resurrect",
            "RvrResurrectionIllnessSpellType",
            "Sabotage",
            "SavageCombatSpeedBuff",
            "SavageCrushResistanceBuff",
            "SavageDPSBuff",
            "SavageEnduranceHeal",
            "SavageEvadeBuff",
            "SavageParryBuff",
            "SavageSlashResistanceBuff",
            "SavageThrustResistanceBuff",
            "Silence",
            "SlashResistDebuff",
            "SpeedDecrease",
            "SpeedEnhancement",
            "SpeedOfTheRealm",
            "SpeedWrapWard",
            "SpiritResistBuff",
            "SpiritResistDebuff",
            "SpreadHeal",
            "StrengthBuff",
            "StrengthConstitutionBuff",
            "StrengthConstitutionDebuff",
            "StrengthConstitutionShear",
            "StrengthDebuff",
            "StrengthShear",
            "Stun",
            "StyleAbsDecrease",
            "StyleArmorFactorDebuff",
            "StyleBleeding",
            "StyleCombatSpeedDebuff",
            "StyleHandler",
            "StylePowerDrain",
            "StyleSpeedDecrease",
            "StyleStun",
            "StyleTaunt",
            "SummonAnimistFnF",
            "SummonAnimistPet",
            "SummonCommander",
            "SummonDruidPet",
            "SummonHunterPet",
            "SummonMastery",
            "SummonMinion",
            "SummonMonster",
            "SummonNecroPet",
            "SummonNoveltyPet",
            "SummonSiegeWeapon",
            "SummonSimulacrum",
            "SummonSpiritFighter",
            "SummonTheurgistPet",
            "SummonTitan",
            "SummonUnderhill",
            "SummonWarcrystal",
            "SummonWood",
            "TargetModifier",
            "Taunt",
            "ThrustResistDebuff",
            "ToHitBuff",
            "TurretPBAoE",
            "TurretsRelease",
            "UnbreakableSpeedDecrease",
            "Uninterruptable",
            "UniPortal",
            "UniPortalKeep",
            "ValkyrieOffensiveProc",
            "VampiirArmorDebuff",
            "VampiirBolt",
            "VampiirEffectivenessDeBuff",
            "VampiirMagicResistance",
            "VampiirMeleeResistance",
            "VampiirSkillBonusDeBuff",
            "VampiirStealthDetection",
            "VampSpeedDecrease",
            "WarlockSpeedDecrease",
            "WaterBreathing",
            "WeaponSkillBuff"});
            this.SpellTypecomboBox.Location = new System.Drawing.Point(256, 19);
            this.SpellTypecomboBox.Name = "SpellTypecomboBox";
            this.SpellTypecomboBox.Size = new System.Drawing.Size(134, 21);
            this.SpellTypecomboBox.Sorted = true;
            this.SpellTypecomboBox.TabIndex = 43;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(187, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "Type";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(396, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "Concentration";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(396, 153);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 39;
            this.label24.Text = "LifeDrainReturn";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(396, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Value";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(396, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "ResurrectMana";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(396, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 35;
            this.label20.Text = "ResurrectHealth";
            // 
            // ResurrectManatextBox
            // 
            this.ResurrectManatextBox.Location = new System.Drawing.Point(511, 72);
            this.ResurrectManatextBox.Name = "ResurrectManatextBox";
            this.ResurrectManatextBox.Size = new System.Drawing.Size(61, 20);
            this.ResurrectManatextBox.TabIndex = 30;
            this.ResurrectManatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResurrectHealthtextBox
            // 
            this.ResurrectHealthtextBox.Location = new System.Drawing.Point(511, 46);
            this.ResurrectHealthtextBox.Name = "ResurrectHealthtextBox";
            this.ResurrectHealthtextBox.Size = new System.Drawing.Size(61, 20);
            this.ResurrectHealthtextBox.TabIndex = 29;
            this.ResurrectHealthtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ValuetextBox
            // 
            this.ValuetextBox.Location = new System.Drawing.Point(511, 98);
            this.ValuetextBox.Name = "ValuetextBox";
            this.ValuetextBox.Size = new System.Drawing.Size(61, 20);
            this.ValuetextBox.TabIndex = 32;
            this.ValuetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LifeDrainReturntextBox
            // 
            this.LifeDrainReturntextBox.Location = new System.Drawing.Point(511, 150);
            this.LifeDrainReturntextBox.Name = "LifeDrainReturntextBox";
            this.LifeDrainReturntextBox.Size = new System.Drawing.Size(61, 20);
            this.LifeDrainReturntextBox.TabIndex = 33;
            this.LifeDrainReturntextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ConcentrationtextBox
            // 
            this.ConcentrationtextBox.Location = new System.Drawing.Point(511, 124);
            this.ConcentrationtextBox.Name = "ConcentrationtextBox";
            this.ConcentrationtextBox.Size = new System.Drawing.Size(61, 20);
            this.ConcentrationtextBox.TabIndex = 31;
            this.ConcentrationtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "CastTime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Radius";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "RecastDelay";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pulse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "PulsePower";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Duration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "DamageType";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Damage";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Range";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Power";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Target";
            // 
            // RecastDelaytextBox
            // 
            this.RecastDelaytextBox.Location = new System.Drawing.Point(511, 20);
            this.RecastDelaytextBox.Name = "RecastDelaytextBox";
            this.RecastDelaytextBox.Size = new System.Drawing.Size(61, 20);
            this.RecastDelaytextBox.TabIndex = 16;
            this.RecastDelaytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PulsetextBox
            // 
            this.PulsetextBox.Location = new System.Drawing.Point(272, 96);
            this.PulsetextBox.Name = "PulsetextBox";
            this.PulsetextBox.Size = new System.Drawing.Size(65, 20);
            this.PulsetextBox.TabIndex = 15;
            this.PulsetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PulsePowertextBox
            // 
            this.PulsePowertextBox.Location = new System.Drawing.Point(272, 122);
            this.PulsePowertextBox.Name = "PulsePowertextBox";
            this.PulsePowertextBox.Size = new System.Drawing.Size(65, 20);
            this.PulsePowertextBox.TabIndex = 14;
            this.PulsePowertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RadiustextBox
            // 
            this.RadiustextBox.Location = new System.Drawing.Point(272, 148);
            this.RadiustextBox.Name = "RadiustextBox";
            this.RadiustextBox.Size = new System.Drawing.Size(65, 20);
            this.RadiustextBox.TabIndex = 13;
            this.RadiustextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrequencytextBox
            // 
            this.FrequencytextBox.Location = new System.Drawing.Point(273, 72);
            this.FrequencytextBox.Name = "FrequencytextBox";
            this.FrequencytextBox.Size = new System.Drawing.Size(64, 20);
            this.FrequencytextBox.TabIndex = 12;
            this.FrequencytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DurationtextBox
            // 
            this.DurationtextBox.Location = new System.Drawing.Point(273, 49);
            this.DurationtextBox.Name = "DurationtextBox";
            this.DurationtextBox.Size = new System.Drawing.Size(64, 20);
            this.DurationtextBox.TabIndex = 11;
            this.DurationtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DamageTypetextBox
            // 
            this.DamageTypetextBox.Location = new System.Drawing.Point(80, 150);
            this.DamageTypetextBox.Name = "DamageTypetextBox";
            this.DamageTypetextBox.Size = new System.Drawing.Size(59, 20);
            this.DamageTypetextBox.TabIndex = 10;
            this.DamageTypetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RangetextBox
            // 
            this.RangetextBox.Location = new System.Drawing.Point(80, 46);
            this.RangetextBox.Name = "RangetextBox";
            this.RangetextBox.Size = new System.Drawing.Size(59, 20);
            this.RangetextBox.TabIndex = 4;
            this.RangetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PowertextBox
            // 
            this.PowertextBox.Location = new System.Drawing.Point(80, 72);
            this.PowertextBox.Name = "PowertextBox";
            this.PowertextBox.Size = new System.Drawing.Size(59, 20);
            this.PowertextBox.TabIndex = 8;
            this.PowertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DamagetextBox
            // 
            this.DamagetextBox.Location = new System.Drawing.Point(80, 124);
            this.DamagetextBox.Name = "DamagetextBox";
            this.DamagetextBox.Size = new System.Drawing.Size(59, 20);
            this.DamagetextBox.TabIndex = 9;
            this.DamagetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CastTimetextBox
            // 
            this.CastTimetextBox.Location = new System.Drawing.Point(80, 98);
            this.CastTimetextBox.Name = "CastTimetextBox";
            this.CastTimetextBox.Size = new System.Drawing.Size(59, 20);
            this.CastTimetextBox.TabIndex = 7;
            this.CastTimetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.DescriptionTextBox);
            this.groupBox9.Controls.Add(this.label43);
            this.groupBox9.Controls.Add(this.label44);
            this.groupBox9.Controls.Add(this.NametextBox);
            this.groupBox9.Location = new System.Drawing.Point(168, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(418, 100);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(75, 35);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(337, 59);
            this.DescriptionTextBox.TabIndex = 20;
            this.DescriptionTextBox.Text = "";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(9, 13);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 13);
            this.label43.TabIndex = 19;
            this.label43.Text = "Name";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 38);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(60, 13);
            this.label44.TabIndex = 18;
            this.label44.Text = "Description";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(75, 10);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(337, 20);
            this.NametextBox.TabIndex = 4;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label48);
            this.groupBox10.Controls.Add(this.label49);
            this.groupBox10.Controls.Add(this.label50);
            this.groupBox10.Controls.Add(this.spellIDtextBox);
            this.groupBox10.Controls.Add(this.ClientEffecttextBox);
            this.groupBox10.Controls.Add(this.IcontextBox);
            this.groupBox10.Location = new System.Drawing.Point(8, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(154, 100);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(8, 65);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(28, 13);
            this.label48.TabIndex = 20;
            this.label48.Text = "Icon";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(8, 13);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 13);
            this.label49.TabIndex = 19;
            this.label49.Text = "SpellID";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 39);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(61, 13);
            this.label50.TabIndex = 18;
            this.label50.Text = "ClientEffect";
            // 
            // spellIDtextBox
            // 
            this.spellIDtextBox.Location = new System.Drawing.Point(83, 10);
            this.spellIDtextBox.Name = "spellIDtextBox";
            this.spellIDtextBox.Size = new System.Drawing.Size(65, 20);
            this.spellIDtextBox.TabIndex = 0;
            this.spellIDtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spellIDtextBox.TextChanged += new System.EventHandler(this.spellID_TextChanged);
            // 
            // ClientEffecttextBox
            // 
            this.ClientEffecttextBox.Location = new System.Drawing.Point(83, 36);
            this.ClientEffecttextBox.Name = "ClientEffecttextBox";
            this.ClientEffecttextBox.Size = new System.Drawing.Size(65, 20);
            this.ClientEffecttextBox.TabIndex = 1;
            this.ClientEffecttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IcontextBox
            // 
            this.IcontextBox.Location = new System.Drawing.Point(83, 62);
            this.IcontextBox.Name = "IcontextBox";
            this.IcontextBox.Size = new System.Drawing.Size(65, 20);
            this.IcontextBox.TabIndex = 2;
            this.IcontextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(226, 62);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(61, 20);
            this.textBox51.TabIndex = 6;
            this.textBox51.Text = "Range";
            // 
            // dataGridSpell
            // 
            this.dataGridSpell.AllowUserToAddRows = false;
            this.dataGridSpell.AllowUserToOrderColumns = true;
            this.dataGridSpell.AutoGenerateColumns = false;
            this.dataGridSpell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridSpell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpell.DataSource = this.SpellbindingSource;
            this.dataGridSpell.Location = new System.Drawing.Point(7, 74);
            this.dataGridSpell.MultiSelect = false;
            this.dataGridSpell.Name = "dataGridSpell";
            this.dataGridSpell.ReadOnly = true;
            this.dataGridSpell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpell.Size = new System.Drawing.Size(973, 695);
            this.dataGridSpell.TabIndex = 19;
            this.dataGridSpell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSpell_CellContentClick);
            // 
            // SpelldataAdapter
            // 
            this.SpelldataAdapter.DeleteCommand = null;
            this.SpelldataAdapter.InsertCommand = null;
            this.SpelldataAdapter.SelectCommand = null;
            this.SpelldataAdapter.UpdateCommand = null;
            // 
            // commandBuilder
            // 
            this.commandBuilder.DataAdapter = this.SpelldataAdapter;
            this.commandBuilder.QuotePrefix = "`";
            this.commandBuilder.QuoteSuffix = "`";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewSpellButton);
            this.groupBox1.Controls.Add(this.SpellListingButton);
            this.groupBox1.Controls.Add(this.SaveNewbutton);
            this.groupBox1.Controls.Add(this.Savebutton);
            this.groupBox1.Location = new System.Drawing.Point(785, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 67);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // AddNewSpellButton
            // 
            this.AddNewSpellButton.Location = new System.Drawing.Point(15, 14);
            this.AddNewSpellButton.Name = "AddNewSpellButton";
            this.AddNewSpellButton.Size = new System.Drawing.Size(83, 23);
            this.AddNewSpellButton.TabIndex = 23;
            this.AddNewSpellButton.Text = "Add new spell";
            this.AddNewSpellButton.UseVisualStyleBackColor = true;
            this.AddNewSpellButton.Click += new System.EventHandler(this.AddNewSpell_Click);
            // 
            // SpellListingButton
            // 
            this.SpellListingButton.Location = new System.Drawing.Point(104, 14);
            this.SpellListingButton.Name = "SpellListingButton";
            this.SpellListingButton.Size = new System.Drawing.Size(75, 23);
            this.SpellListingButton.TabIndex = 22;
            this.SpellListingButton.Text = "Spell Listing";
            this.SpellListingButton.UseVisualStyleBackColor = true;
            this.SpellListingButton.Click += new System.EventHandler(this.SpellListing_Click);
            // 
            // LoadSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(985, 778);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridSpell);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadSpell";
            this.Text = "Spells Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlMenu.ResumeLayout(false);
            this.ControlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellbindingNavigator)).EndInit();
            this.SpellbindingNavigator.ResumeLayout(false);
            this.SpellbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpellbindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguageSpell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LanguageSpellbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellLanguagebindingNavigator)).EndInit();
            this.SpellLanguagebindingNavigator.ResumeLayout(false);
            this.SpellLanguagebindingNavigator.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineXSpellbindingNavigator)).EndInit();
            this.LineXSpellbindingNavigator.ResumeLayout(false);
            this.LineXSpellbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineXSpellbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLineXSpell)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private TabPage tabPage1;

        private Button SaveNewbutton;
        private Button Savebutton;

        private TabControl tabControl1;
        
        private TextBox SharedTimerGrouptextBox;
        private TextBox SpellGrouptextBox;
        private TextBox InstrumentRequirementtextBox;
        private TextBox EffectGrouptextBox;
        private TextBox SubSpellIDtextBox;

        private RichTextBox Message4richTextBox;
        private RichTextBox Message3richTextBox;
        private RichTextBox Message2richTextBox;
        private RichTextBox Message1richTextBox;
        private RichTextBox DescriptionTextBox;

        private GroupBox ControlMenu;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private GroupBox groupBox8;
        private GroupBox groupBox10;
        private GroupBox groupBox9;

        private TextBox SearchSpellIDtextBox;
        private TextBox SearchBySpellNametextBox;
        private TextBox textBox36;
        private TextBox textBox7;
        private TextBox textBox3;
        private TextBox textBox34;
        private TextBox textBox33;
        private TextBox textBox6;
        private TextBox textBox39;
        private TextBox TranslationIDtextBox;
        private TextBox RecastDelaytextBox;
        private TextBox PulsetextBox;
        private TextBox PulsePowertextBox;
        private TextBox RadiustextBox;
        private TextBox FrequencytextBox;
        private TextBox DurationtextBox;
        private TextBox DamageTypetextBox;
        private TextBox RangetextBox;
        private TextBox PowertextBox;
        private TextBox DamagetextBox;
        private TextBox CastTimetextBox;
        private TextBox NametextBox;
        private TextBox spellIDtextBox;
        private TextBox ClientEffecttextBox;
        private TextBox IcontextBox;
        private TextBox textBox51;        
        private TextBox AmnesiaChancetextBox;
        private TextBox ResurrectManatextBox;
        private TextBox ResurrectHealthtextBox;
        private TextBox ValuetextBox;
        private TextBox LifeDrainReturntextBox;
        private TextBox ConcentrationtextBox;

        private Label label19;
        private Label label18;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label43;
        private Label label44;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;        
        private Label label26;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;

        private DataGridView dataGridSpell;

        private ComboBox SpellHandlerSearchcomboBox;
        private ComboBox LineNameSpellSearchcomboBox;
        private ComboBox SpellTypecomboBox;
        private ComboBox UninterruptiblecomboBox;
        private ComboBox MoveCastcomboBox;
        private ComboBox IsFocuscomboBox;
        private ComboBox AllowBoltcomboBox;
        private ComboBox IsSecondarycomboBox;
        private ComboBox IsPrimarycomboBox;
        private ComboBox TargetcomboBox;
        private ComboBox PackageIDcomboBox;
        private GroupBox groupBox4;
        private DataGridView dataGridViewLineXSpell;
        private BindingSource LineXSpellbindingSource;
        private BindingNavigator LineXSpellbindingNavigator;
        private ToolStripButton bindingNavigatorDeleteItem1;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton bindingNavigatorDeleteItem;
        private BindingNavigator SpellbindingNavigator;
        private TextBox LinexSpellAddLeveltextBox;
        private Button button3;
        private ComboBox PackageIDAddLineXSpellcomboBox;
        private ComboBox LineNameAddLineXSpellcomboBox;
        private GroupBox groupBox12;
        private BindingNavigator SpellLanguagebindingNavigator;
        private ToolStripButton bindingNavigatorDeleteItem2;
        private BindingSource LanguageSpellbindingSource;
        private DataGridView dataGridViewLanguageSpell;
        private RichTextBox LanguageSpellMessage4richTextBox;
        private TextBox textBox9;
        private RichTextBox LanguageSpellMessage3richTextBox;
        private TextBox textBox10;
        private Button button1;
        private RichTextBox LanguageSpellMessage2richTextBox;
        private TextBox textBox8;
        private RichTextBox LanguageSpellMessage1richTextBox;
        private TextBox textBox4;
        private Label label51;
        private TextBox LanguageSpellNametextBox;
        private Label label31;
        private RichTextBox LanguageSpellDescriptionrichTextBox;
        private Label label53;
        private ComboBox LanguageSpellLAnguageChoicecomboBox;
        private TextBox LanguageSpellTagtextBox;
        private Label label52;
        private Label label27;
        private Label label54;
        private Label label55;
        private GroupBox groupBox1;
        private Button AddNewSpellButton;
        private Button SpellListingButton;

    }
}