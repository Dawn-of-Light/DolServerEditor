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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;

    /// <summary>
    /// Generic purpose utility collection
    /// </summary>
public static class Util
{
    /// <summary>
    /// Connection informations
    /// </summary>
    public static MySqlConnection Connection = new MySqlConnection("server=" + DolEditor.Properties.Settings.Default.ServerIP + ";port= " + DolEditor.Properties.Settings.Default.PortNumber + ";uid=" + DolEditor.Properties.Settings.Default.Username + ";pwd=" + DolEditor.Properties.Settings.Default.Password + ";database=" + DolEditor.Properties.Settings.Default.DatabaseName + ";Persist Security Info=True" + "");

    #region Random Utilities

    /// <summary>
    /// Holds the random number generator instance
    /// </summary>
    [ThreadStatic]
    private static Random m_random = null;

    /// <summary>
    /// Gets the random number generator
    /// </summary>
    public static Random RandomGen
    {
        get
        {
            if (m_random == null)
            {
                m_random = new Random();
            }

            return m_random;
        }
    }

    /// <summary>
    /// Generates a random number between 0..max inclusive 0 AND max
    /// </summary>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int Random(int max)
    {
        return RandomGen.Next(max + 1);
    }

    /// <summary>
    /// Generates a random number between min..max inclusive min AND max
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int Random(int min, int max)
    {
        return RandomGen.Next(min, max + 1);
    }

    #endregion Random Utilities

    #region Bool Utilities

    /// <summary>
    /// Find Bool value (true false) with value number
    /// </summary>
    /// <param name="bool value as string"></param>
    /// <returns></returns>
    public static string Find_Bool_Value(string text)
    {
        if (text.ToLower() == "0" || text.ToLower() == "" || text == null)
            return "False";
        if (text == "False" || text == "" || text == null)
            return "0";
        if (text == "True")
            return "1";
        if (text == "1")
            return "True";

        return "0";
    }


    /// <summary>
    /// Find Bool value (true false) with value number
    /// </summary>
    /// <param name="bool value as string"></param>
    /// <returns></returns>
    public static string Find_Gender_Value(string text)
    {
        if (text == "0" || text == "" || text == null)
            return "Neutral";
        if (text == "Neutral")
            return "0";
        if (text == "1") 
            return "Male";
        if (text == "Male")
            return "1";
        if (text == "2")
            return "Female";
        if (text == "Female")
            return "2";

        return "0";
    }

    #endregion Bool Utilities

    #region Realm Utilities

    /// <summary>
    /// Find Realm Id with realm name
    /// </summary>    
    /// <param name="realm name"></param>
    /// <returns></returns>
    public static int Find_Realm_Value(string text)
    {
        if (text.ToLower() == "albion")
            return 1;
        else if (text.ToLower() == "midgard")
            return 2;
        else if (text.ToLower() == "hibernia")
            return 3;

        return 0;
    }

    /// <summary>
    /// Find Realm name with realm ID
    /// </summary>
    /// <param name="realm ID as string"></param>
    /// <returns></returns>
    public static string Find_Realm_String_Value(string text)
    {
        if (text.ToLower() == "1")
            return "Albion";
        else if (text.ToLower() == "2")
            return "Midgard";
        else if (text.ToLower() == "3")
            return "Hibernia";
        else if (text.ToLower() == "0")
            return "None";

        return "None";
    }

    #endregion Realm Utilities

    #region Style Utilities

    /// <summary>
    /// Find OpeningRequirementType name with OpeningRequirementType Id
    /// </summary>    
    /// <param name="OpeningRequirementType ID as string"></param>
    /// <returns></returns>
    public static string Find_OpeningRequirementType_String_Value(string text)
    {
        if (text.ToLower() == "0")
            return "Back";
        if (text.ToLower() == "1")
            return "Side";
        if (text.ToLower() == "2")
            return "Front";
        return "Not Defined";
    }

    /// <summary>
    /// Find AttackResultRequirement name with AttackResultRequirement ID
    /// </summary>    
    /// <param name="AttackResultRequirement ID as string"></param>
    /// <returns></returns>
    public static string Find_AttackResultRequirement_String_Value(string text)
    {

        if (text.ToLower() == "0")
            return "Any";
        if (text.ToLower() == "1")
            return "Miss";
        if (text.ToLower() == "2")
            return "Hit";
        if (text.ToLower() == "3")
            return "Parry";
        if (text.ToLower() == "4")
            return "Block";
        if (text.ToLower() == "5")
            return "Evade";
        if (text.ToLower() == "6")
            return "Fumble";
        if (text.ToLower() == "7")
            return "Style";

        return "Any";
    }

    #endregion Style Utilities

    #region Class Utilities

    /// <summary>
    /// Find Class Name with Class ID
    /// </summary>    
    /// <param name="class ID as string"></param>
    /// <returns></returns>
    public static string ClassIDToName(string classID)
    {
        switch (classID)
        {
            case "1":
                return "Paladin";
            case "2":
                return "Armsman";
            case "3":
                return "Scout";
            case "4":
                return "Minstrel";
            case "5":
                return "Theurgist";
            case "6":
                return "Cleric";
            case "7":
                return "Wizard";
            case "8":
                return "Sorcerer";
            case "9":
                return "Infiltrator";
            case "10":
                return "Friar";
            case "11":
                return "Mercenary";
            case "12":
                return "Necromancer";
            case "13":
                return "Cabalist";
            case "14":
                return "Fighter";
            case "15":
                return "Elementalist";
            case "16":
                return "Acolyte";
            case "17":
                return "AlbionRogue";
            case "18":
                return "Mage";
            case "19":
                return "Reaver";
            case "20":
                return "Disciple";
            case "21":
                return "Thane";
            case "22":
                return "Warrior";
            case "23":
                return "Shadowblade";
            case "24":
                return "Skald";
            case "25":
                return "Hunter";
            case "26":
                return "Healer";
            case "27":
                return "Spiritmaster";
            case "28":
                return "Shaman";
            case "29":
                return "Runemaster";
            case "30":
                return "Bonedancer";
            case "31":
                return "Berserker";
            case "32":
                return "Savage";
            case "33":
                return "Heretic";
            case "34":
                return "Valkyrie";
            case "35":
                return "Viking";
            case "36":
                return "Mystic";
            case "37":
                return "Seer";
            case "38":
                return "MidgardRogue";
            case "39":
                return "Bainshee";
            case "40":
                return "Eldritch";
            case "41":
                return "Enchanter";
            case "42":
                return "Mentalist";
            case "43":
                return "Blademaster";
            case "44":
                return "Hero";
            case "45":
                return "Champion";
            case "46":
                return "Warden";
            case "47":
                return "Druid";
            case "48":
                return "Bard";
            case "49":
                return "Nightshade";
            case "50":
                return "Ranger";
            case "51":
                return "Magician";
            case "52":
                return "Guardian";
            case "53":
                return "Naturalist";
            case "54":
                return "Stalker";
            case "55":
                return "Animist";
            case "56":
                return "Valewalker";
            case "57":
                return "Forester";
            case "58":
                return "Vampiir";
            case "59":
                return "Warlock";
            case "60":
                return "Mauler_Alb";
            case "61":
                return "Mauler_Mid";
            case "62":
                return "Mauler_Hib";
        }
        return "unknow class name";
    }

    /// <summary>
    /// Find Class ID with Class Name
    /// </summary>    
    /// <param name="Class name"></param>
    /// <returns></returns>
    public static string ClassNameToID(string classname)
    {
        switch (classname)
        {
            case " All":
                return " All";
            case "Paladin":
                return "1";
            case "Armsman":
                return "2";
            case "Scout":
                return "3";
            case "Minstrel":
                return "4";
            case "Theurgist":
                return "5";
            case "Cleric":
                return "6";
            case "Wizard":
                return "7";
            case "Sorcerer":
                return "8";
            case "Infiltrator":
                return "9";
            case "Friar":
                return "10";
            case "Mercenary":
                return "11";
            case "Necromancer":
                return "12";
            case "Cabalist":
                return "13";
            case "Fighter":
                return "14";
            case "Elementalist":
                return "15";
            case "Acolyte":
                return "16";
            case "AlbionRogue":
                return "17";
            case "Mage":
                return "18";
            case "Reaver":
                return "19";
            case "Disciple":
                return "20";
            case "Thane":
                return "21";
            case "Warrior":
                return "22";
            case "Shadowblade":
                return "23";
            case "Skald":
                return "24";
            case "Hunter":
                return "25";
            case "Healer":
                return "26";
            case "Spiritmaster":
                return "27";
            case "Shaman":
                return "28";
            case "Runemaster":
                return "29";
            case "Bonedancer":
                return "30";
            case "Berserker":
                return "31";
            case "Savage":
                return "32";
            case "Heretic":
                return "33";
            case "Valkyrie":
                return "34";
            case "Viking":
                return "35";
            case "Mystic":
                return "36";
            case "Seer":
                return "37";
            case "MidgardRogue":
                return "38";
            case "Bainshee":
                return "39";
            case "Eldritch":
                return "40";
            case "Enchanter":
                return "41";
            case "Mentalist":
                return "42";
            case "Blademaster":
                return "43";
            case "Hero":
                return "44";
            case "Champion":
                return "45";
            case "Warden":
                return "46";
            case "Druid":
                return "47";
            case "Bard":
                return "48";
            case "Nightshade":
                return "49";
            case "Ranger":
                return "50";
            case "Magician":
                return "51";
            case "Guardian":
                return "52";
            case "Naturalist":
                return "53";
            case "Stalker":
                return "54";
            case "Animist":
                return "55";
            case "Valewalker":
                return "56";
            case "Forester":
                return "57";
            case "Vampiir":
                return "58";
            case "Warlock":
                return "59";
            case "Mauler_Alb":
                return "60";
            case "Mauler_Mid":
                return "61";
            case "Mauler_Hib":
                return "62";
        }
        return "unknown class name";
    }

    #endregion Class Utilities

    #region Object Utilities

    /// <summary>
    /// Find ObjectType Name with ObjectType ID
    /// </summary>    
    /// <param name="objectType ID as string"></param>
    /// <returns></returns>
    public static string ObjectIDToName(string objectTypeID)
    {
        switch (objectTypeID)
        {
            case "1": return "Generic";
            case "2": return "Crushing";
            case "3": return "Slashing";
            case "4": return "Thrusting";
            case "6": return "Twohanded";
            case "7": return "Polearm";
            case "8": return "Staff";
            case "11": return "Sword";
            case "12": return "Hammer";
            case "13": return "Axe";
            case "14": return "Spear";
            case "17": return "Left axe";
            case "19": return "Blades";
            case "20": return "Blunt";
            case "21": return "Piercing";
            case "22": return "Large";
            case "23": return "Celtic spear";
            case "24": return "Flexible";
            case "25": return "Hand to hand";
            case "26": return "Scythe";
            case "27": return "Fist wraps";
            case "28": return "Mauler staff";
        }
        return "unknown (item)";
    }

    /// <summary>
    /// Find Object ID with Object Name
    /// </summary>    
    /// <param name="Object Name"></param>
    /// <returns></returns>
    public static string ObjectNameToID(string objectNametoID)
    {
        switch (objectNametoID)
        {
            case "Generic":
                return "1";
            case "Crushing":
                return "2";
            case "Slashing":
                return "3";
            case "Thrusting":
                return "4";
            case "Twohanded":
                return "6";
            case "Polearm":
                return "7";
            case "Staff":
                return "8";
            case "Sword":
                return "11";
            case "Hammer":
                return "12";
            case "Axe":
                return "13";
            case "Spear":
                return "14";
            case "Left axe":
                return "17";
            case "Blades":
                return "19";
            case "Blunt":
                return "20";
            case "Piercing":
                return "21";
            case "Large":
                return "22";
            case "Celtic spear":
                return "23";
            case "Flexible":
                return "24";
            case "Hand to hand":
                return "25";
            case "Scythe":
                return "26";
            case "Fist wraps":
                return "27";
            case "Mauler staff":
                return "28";
        }
        return "unknown (item)";
    }

    #endregion Object Utilities

    #region DamageType Utilities

    /// <summary>
    /// Find DamageType ID with DamageType name
    /// </summary>    
    /// <param name="DamageType name"></param>
    /// <returns></returns>
    public static byte Find_DamageType_Value(string text)
    {
        if (text.ToLower() == "natural")
            return 0;
        if (text.ToLower() == "crush")
            return 1;
        if (text.ToLower() == "slash")
            return 2;
        if (text.ToLower() == "thrust")
            return 3;
        if (text.ToLower() == "body")
            return 10;
        if (text.ToLower() == "cold")
            return 11;
        if (text.ToLower() == "energy")
            return 12;
        if (text.ToLower() == "heat")
            return 13;
        if (text.ToLower() == "matter")
            return 14;
        if (text.ToLower() == "spirit")
            return 15;
        return 0;
    }

    /// <summary>
    /// Find DamageType name with DamageType ID
    /// </summary>    
    /// <param name="DamageType ID"></param>
    /// <returns></returns>
    public static string Find_DamageType_String_Value(string text)
    {
        if (text.ToLower() == "0")
            return "Natural";
        if (text.ToLower() == "1")
            return "Crush";
        if (text.ToLower() == "2")
            return "Slash";
        if (text.ToLower() == "3")
            return "Thrust";
        if (text.ToLower() == "10")
            return "Body";
        if (text.ToLower() == "11")
            return "Cold";
        if (text.ToLower() == "12")
            return "Energy";
        if (text.ToLower() == "13")
            return "Heat";
        if (text.ToLower() == "14")
            return "Matter";
        if (text.ToLower() == "15")
            return "Spirit";
        return "Not Defined";
    }

    #endregion DamageType Utilities

    #region BodyType Utilities

    /// <summary>
    /// Find BodyType name with BodyType ID
    /// </summary>    
    /// <param name="BodyType ID"></param>
    /// <returns></returns>
    public static string Find_BodyType_String_Value(string text)
    {
        if (text.ToLower() == "0")
            return "None";
        if (text.ToLower() == "1")
            return "Animal";
        if (text.ToLower() == "2")
            return "Demon";
        if (text.ToLower() == "3")
            return "Dragon";
        if (text.ToLower() == "4")
            return "Elemental";
        if (text.ToLower() == "5")
            return "Giant";
        if (text.ToLower() == "6")
            return "Humanoid";
        if (text.ToLower() == "7")
            return "Insect";
        if (text.ToLower() == "8")
            return "Magical";
        if (text.ToLower() == "9")
            return "Reptile";
        if (text.ToLower() == "10")
            return "Plant";
        if (text.ToLower() == "11")
            return "Undead";
        return "Not Defined";
    }

    /// <summary>
    /// Find BodyType ID with BodyType name
    /// </summary>    
    /// <param name="BodyType name"></param>
    /// <returns></returns>
    public static int Find_BodyType_Value(string text)
    {
        if (text.ToLower() == "none")
            return 0;
        if (text.ToLower() == "animal")
            return 1;
        if (text.ToLower() == "demon")
            return 2;
        if (text.ToLower() == "dragon")
            return 3;
        if (text.ToLower() == "elemental")
            return 4;
        if (text.ToLower() == "giant")
            return 5;
        if (text.ToLower() == "humanoid")
            return 6;
        if (text.ToLower() == "insect")
            return 7;
        if (text.ToLower() == "magical")
            return 8;
        if (text.ToLower() == "reptile")
            return 9;
        if (text.ToLower() == "plant")
            return 10;
        if (text.ToLower() == "undead")
            return 11;
        return 0;
    }

    #endregion BodyType Utilities

    #region Craft Utilities

    /// <summary>
    /// Find Craft name with CraftID
    /// </summary>    
    /// <param name="Craft ID"></param>
    /// <returns></returns>
    public static string CraftIDToName(string craftID)
    {
        switch (craftID)
        {
            case "1": return "WeaponCrafting";
            case "2": return "ArmorCrafting";
            case "3": return "SiegeCrafting";
            case "4": return "Alchemy";
            case "6": return "MetalWorking";
            case "7": return "LeatherCrafting";
            case "8": return "ClothWorking";
            case "9": return "GemCutting";
            case "10": return "HerbalCrafting";
            case "11": return "Tailoring";
            case "12": return "Fletching";
            case "13": return "SpellCrafting";
            case "14": return "WoodWorking";
            case "15": return "BasicCrafting";
        }
        return "unknown craftid";
    }

    /// <summary>
    /// Find CrafID with Craft name
    /// </summary>    
    /// <param name="Craft name"></param>
    /// <returns></returns>
    public static string CraftNameToID(string craftName)
    {
        switch (craftName)
        {
            case "WeaponCrafting":
                return "1";
            case "ArmorCrafting":
                return "2";
            case "SiegeCrafting":
                return "3";
            case "Alchemy":
                return "4";
            case "MetalWorking":
                return "6";
            case "LeatherCrafting":
                return "7";
            case "ClothWorking":
                return "8";
            case "GemCutting":
                return "9";
            case "HerbalCrafting":
                return "10";
            case "Tailoring":
                return "11";
            case "Fletching":
                return "12";
            case "SpellCrafting":
                return "13";
            case "WoodWorking":
                return "14";
            case "BasicCrafting":
                return "15";
        }
        return "unknown craftname";
    }

    #endregion Craft Utilities

    #region Free ID Finder Utilities

    /// <summary>
    /// Find First Free Spell ID
    /// </summary>
    public static int Find_Free_SpellID()
    {
        MySqlDataAdapter FindFreeIDdataAdapter = new MySqlDataAdapter("select distinct spellid from spell ORDER BY spellid ASC", Connection);
        MySqlCommandBuilder commandBuilderSpellIDDatatable = new MySqlCommandBuilder(FindFreeIDdataAdapter);
        DataTable SpellIDDatatable = new DataTable();
        FindFreeIDdataAdapter.Fill(SpellIDDatatable);
        int id_retenu = 1;
        int oldid = 0;
        foreach (DataRow foundRows in SpellIDDatatable.Rows)
        {
            string idstr = foundRows["SpellID"].ToString();
            if (idstr == id_retenu.ToString())
            {
                oldid = id_retenu;
                id_retenu++;
            }
            else
            {
                if (id_retenu == oldid)
                    continue;
                else
                    break;
            }
        }
        return id_retenu;
    }

    /// <summary>
    /// Find First Free Faction ID
    /// </summary>
    public static int Find_Free_FactionID()
    {
        MySqlDataAdapter FindFreeIDdataAdapter = new MySqlDataAdapter("select distinct id from faction ORDER BY id ASC", Connection);
        MySqlCommandBuilder commandBuilderSpellIDDatatable = new MySqlCommandBuilder(FindFreeIDdataAdapter);
        DataTable SpellIDDatatable = new DataTable();
        FindFreeIDdataAdapter.Fill(SpellIDDatatable);
        int id_retenu = 1;
        int oldid = 0;
        foreach (DataRow foundRows in SpellIDDatatable.Rows)
        {
            string idstr = foundRows["ID"].ToString();
            if (idstr == id_retenu.ToString())
            {
                oldid = id_retenu;
                id_retenu++;
            }
            else
            {
                if (id_retenu == oldid)
                    continue;
                else
                    break;
            }
        }
        return id_retenu;
    }

    /// <summary>
    /// Find First Free Region ID
    /// </summary>
    public static int Find_Free_Region_ID()
    {
        MySqlDataAdapter FindFreeIDdataAdapter = new MySqlDataAdapter("select distinct RegionID from regions ORDER BY RegionID ASC", Connection);
        MySqlCommandBuilder commandBuilderSpellIDDatatable = new MySqlCommandBuilder(FindFreeIDdataAdapter);
        DataTable SpellIDDatatable = new DataTable();
        FindFreeIDdataAdapter.Fill(SpellIDDatatable);
        int id_retenu = 1;
        int oldid = 0;
        foreach (DataRow foundRows in SpellIDDatatable.Rows)
        {
            string idstr = foundRows["RegionID"].ToString();
            if (idstr == id_retenu.ToString())
            {
                oldid = id_retenu;
                id_retenu++;
            }
            else
            {
                if (id_retenu == oldid)
                    continue;
                else
                    break;
            }
        }
        return id_retenu;
    }

    /// <summary>
    /// Find First Free Zone ID
    /// </summary>
    public static int Find_Free_Zone_ID()
    {
        MySqlDataAdapter FindFreeIDdataAdapter = new MySqlDataAdapter("select distinct zoneID from zones ORDER BY zoneID ASC", Connection);
        MySqlCommandBuilder commandBuilderSpellIDDatatable = new MySqlCommandBuilder(FindFreeIDdataAdapter);
        DataTable ZoneIDDatatable = new DataTable();
        FindFreeIDdataAdapter.Fill(ZoneIDDatatable);
        int id_retenu = 1;
        int oldid = 1;
        foreach (DataRow foundRows in ZoneIDDatatable.Rows)
        {
            string idstr = foundRows["zoneID"].ToString();
            if (idstr == id_retenu.ToString())
            {
                oldid = id_retenu;
                id_retenu++;
            }
            else
            {
                if (id_retenu == oldid)
                    continue;
                else
                    break;
            }
        }
        return id_retenu;
    }

    /// <summary>
    /// Find First Free NPCTemplate ID
    /// </summary>
    public static int Find_Free_NPCTemplateID()
    {
        MySqlDataAdapter FindFreeIDdataAdapter = new MySqlDataAdapter("select distinct templateid from npctemplate ORDER BY templateid ASC", Connection);
        MySqlCommandBuilder commandBuilderNPCTemplateIDDatatable = new MySqlCommandBuilder(FindFreeIDdataAdapter);
        DataTable NPCTemplateIDDatatable = new DataTable();
        FindFreeIDdataAdapter.Fill(NPCTemplateIDDatatable);
        int id_retenu = 1;
        int oldid = 0;
        foreach (DataRow foundRows in NPCTemplateIDDatatable.Rows)
        {
            string idstr = foundRows["TemplateID"].ToString();
            if (idstr == id_retenu.ToString())
            {
                oldid = id_retenu;
                id_retenu++;
            }
            else
            {
                if (id_retenu == oldid)
                    continue;
                else
                    break;
            }
        }
        return id_retenu;
    }

    #endregion Free ID Finder Utilities

    /// <summary>
    /// Various flags for this npc
    /// </summary>
    [Flags]
    public enum eFlags : uint
    {
        /// <summary>
        /// The npc is translucent (like a ghost)
        /// </summary>
        GHOST = 0x01,
        /// <summary>
        /// The npc is stealthed (nearly invisible, like a stealthed player; new since 1.71)
        /// </summary>
        STEALTH = 0x02,
        /// <summary>
        /// The npc doesn't show a name above its head but can be targeted
        /// </summary>
        DONTSHOWNAME = 0x04,
        /// <summary>
        /// The npc doesn't show a name above its head and can't be targeted
        /// </summary>
        CANTTARGET = 0x08,
        /// <summary>
        /// Not in nearest enemyes if different vs player realm, but can be targeted if model support this
        /// </summary>
        PEACE = 0x10,
        /// <summary>
        /// The npc is flying (z above ground permitted)
        /// </summary>
        FLYING = 0x20,
        /// <summary>
        /// npc's torch is lit
        /// </summary>
        TORCH = 0x40,
        /// <summary>
        /// npc is a statue (no idle animation, no target...)
        /// </summary>
        STATUE = 0x80,
        /// <summary>
        /// npc is swimming
        /// </summary>
        SWIMMING = 0x100
    }

    /// <summary>
    /// Parse a string in CSV mode with separator ';'
    /// </summary>
    /// <param name="str">the string to parse</param>
    /// <param name="rangeCheck">the ranges are burst and put into the list</param>
    /// <returns>a List of strings with the values parsed</string></returns>a></returns>
    public static List<string> SplitCSV(this string str, bool rangeCheck = false)
    {
        char primarySeparator = ';';
        char secondarySeparator = '-';

        if (str == null) return null;

        // simple parsing on priSep
        var resultat = str.Split(new char[] { primarySeparator }, StringSplitOptions.RemoveEmptyEntries).ToList();
        if (!rangeCheck)
            return resultat;

        // advanced parsing with range handling
        List<string> advancedResultat = new List<string>();
        foreach (var currentResultat in resultat)
        {
            if (currentResultat.Contains('-'))
            {
                int from = 0;
                int to = 0;

                if (int.TryParse(currentResultat.Split(secondarySeparator)[0], out from) && int.TryParse(currentResultat.Split(secondarySeparator)[1], out to))
                {
                    if (from > to)
                    {
                        int tmp = to;
                        to = from;
                        from = tmp;
                    }

                    for (int i = from; i <= to; i++)
                        advancedResultat.Add(i.ToString());
                }
            }
            else
                advancedResultat.Add(currentResultat);
        }
        return advancedResultat;
    }

    /// <summary>
    /// Checks wether string is empty.
    /// empty means either null or ""
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool IsEmpty(string str, bool zeroMeansEmpty = false)
    {
        if (string.IsNullOrEmpty(str))
            return true;

        // various common db troubles
        string currentStr = str.ToLower();
        if (currentStr == "null" || currentStr == "\r\n")
            return true;

        if (zeroMeansEmpty && currentStr.Trim() == "0")
            return true;

        return false;
    }

    public static void AddRange<T>(this IList<T> list, IList<T> addList)
    {
        foreach (T item in addList)
        {
            list.Add(item);
        }
    }

    public static void ForEach<T>(this IEnumerable<T> array, Action<T> action)
    {
        foreach (var cur in array)
            action(cur);
    }
}