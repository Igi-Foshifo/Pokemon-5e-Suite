using Pokemon_5e_Suite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace Pokemon_5e_Suite
{
    public static class Globals
    {
        // populated on form load based on saved sessions, trainers and pokemon
        public static List<SessionModel> allSessions = new List<SessionModel>();
        public static List<TrainerModel> allTrainers = new List<TrainerModel>();
        public static List<PokemonModel> allPokemon = new List<PokemonModel>();


        #region Trainer Specific
        // used to calculate stat modifier based on stat score
        public static IDictionary<string, string> statMods = new Dictionary<string, string>()
        {
            {"1", "-5"},
            {"2", "-4"},
            {"3", "-4"},
            {"4", "-3"},
            {"5", "-3"},
            {"6", "-2"},
            {"7", "-2"},
            {"8", "-1"},
            {"9", "-1"},
            {"10", "+0"},
            {"11", "+0"},
            {"12", "+1"},
            {"13", "+1"},
            {"14", "+2"},
            {"15", "+2"},
            {"16", "+3"},
            {"17", "+3"},
            {"18", "+4"},
            {"19", "+4"},
            {"20", "+5"},
            {"21", "+5"},
            {"22", "+6"},
            {"23", "+6"},
            {"24", "+7"},
            {"25", "+7"},
            {"26", "+8"},
            {"27", "+8"},
            {"28", "+9"},
            {"29", "+9"},
            {"30", "+10"}
        };

        // used to determine sum of pokemon levels required based on trainer level
        public static IDictionary<string, string> trainerPokeLvlsRequired = new Dictionary<string, string>()
        {
            {"1st", "0"},
            {"2nd", "3"},
            {"3rd", "6"},
            {"4th", "9"},
            {"5th", "12"},
            {"6th", "20"},
            {"7th", "24"},
            {"8th", "28"},
            {"9th", "32"},
            {"10th", "36"},
            {"11th", "50"},
            {"12th", "55"},
            {"13th", "60"},
            {"14th", "65"},
            {"15th", "70"},
            {"16th", "90"},
            {"17th", "96"},
            {"18th", "102"},
            {"19th", "108"},
            {"20th", "114"}
        };

        // used to determine trainer proficiency bonus based on trainer level
        public static IDictionary<string, string> trainerProfBonus = new Dictionary<string, string>()
        {
            {"1st", "+2"},
            {"2nd", "+2"},
            {"3rd", "+2"},
            {"4th", "+2"},
            {"5th", "+3"},
            {"6th", "+3"},
            {"7th", "+3"},
            {"8th", "+3"},
            {"9th", "+4"},
            {"10th", "+4"},
            {"11th", "+4"},
            {"12th", "+4"},
            {"13th", "+5"},
            {"14th", "+5"},
            {"15th", "+5"},
            {"16th", "+5"},
            {"17th", "+6"},
            {"18th", "+6"},
            {"19th", "+6"},
            {"20th", "+6"}
        };

        // used to determined number of pokemon slots a trainer has based on their level
        public static IDictionary<string, string> trainerPokeSlots = new Dictionary<string, string>()
        {
            {"1st", "3"},
            {"2nd", "3"},
            {"3rd", "3"},
            {"4th", "3"},
            {"5th", "4"},
            {"6th", "4"},
            {"7th", "4"},
            {"8th", "4"},
            {"9th", "4"},
            {"10th", "5"},
            {"11th", "5"},
            {"12th", "5"},
            {"13th", "5"},
            {"14th", "5"},
            {"15th", "6"},
            {"16th", "6"},
            {"17th", "6"},
            {"18th", "6"},
            {"19th", "6"},
            {"20th", "6"}
        };

        // used to determine the max sr of pokemon a trainer can control based on level
        public static IDictionary<string, string> trainerMaxSR = new Dictionary<string, string>()
        {
            {"1st", "2"},
            {"2nd", "2"},
            {"3rd", "5"},
            {"4th", "5"},
            {"5th", "5"},
            {"6th", "8"},
            {"7th", "8"},
            {"8th", "10"},
            {"9th", "10"},
            {"10th", "10"},
            {"11th", "12"},
            {"12th", "12"},
            {"13th", "12"},
            {"14th", "14"},
            {"15th", "14"},
            {"16th", "14"},
            {"17th", "15"},
            {"18th", "15"},
            {"19th", "15"},
            {"20th", "15"}
        };
        #endregion Trainer Specific

        #region Pokemon Specific
        // used to determine xp required for a pokemon to level up
        public static IDictionary<string, string> pokemonXPRequired = new Dictionary<string, string>()
        {
            {"1st", "0"},
            {"2nd", "200"},
            {"3rd", "800"},
            {"4th", "2000"},
            {"5th", "6000"},
            {"6th", "12000"},
            {"7th", "20000"},
            {"8th", "30000"},
            {"9th", "44000"},
            {"10th", "62000"},
            {"11th", "82000"},
            {"12th", "104000"},
            {"13th", "128000"},
            {"14th", "158000"},
            {"15th", "194000"},
            {"16th", "234000"},
            {"17th", "278000"},
            {"18th", "326000"},
            {"19th", "382000"},
            {"20th", "450000"}
        };

        // used to determine a pokemon's proficiency bonus based on their level
        public static IDictionary<string, string> pokemonProfBonus = new Dictionary<string, string>()
        {
            {"1st", "+2"},
            {"2nd", "+2"},
            {"3rd", "+2"},
            {"4th", "+2"},
            {"5th", "+3"},
            {"6th", "+3"},
            {"7th", "+3"},
            {"8th", "+3"},
            {"9th", "+4"},
            {"10th", "+4"},
            {"11th", "+4"},
            {"12th", "+4"},
            {"13th", "+5"},
            {"14th", "+5"},
            {"15th", "+5"},
            {"16th", "+5"},
            {"17th", "+6"},
            {"18th", "+6"},
            {"19th", "+6"},
            {"20th", "+6"}
        };

        // used to determine a pokemon's stab bonus based on level
        public static IDictionary<string, string> pokemonSTAB = new Dictionary<string, string>()
        {
            {"1st", "+0"},
            {"2nd", "+0"},
            {"3rd", "+1"},
            {"4th", "+1"},
            {"5th", "+1"},
            {"6th", "+1"},
            {"7th", "+2"},
            {"8th", "+2"},
            {"9th", "+2"},
            {"10th", "+2"},
            {"11th", "+3"},
            {"12th", "+3"},
            {"13th", "+3"},
            {"14th", "+3"},
            {"15th", "+4"},
            {"16th", "+4"},
            {"17th", "+4"},
            {"18th", "+4"},
            {"19th", "+5"},
            {"20th", "+5"}
        };

        #endregion Pokemon Specific

        #region Shared
        public static IDictionary<string, string> abilityProfStats = new Dictionary<string, string>()
        {
            {"Acrobats", "DEX"},
            {"Animal Handling", "WIS"},
            {"Arcana", "INT"},
            {"Athletics", "STR"},
            {"Deception", "CHA"},
            {"History", "INT"},
            {"Insight", "WIS"},
            {"Intimidation", "CHA"},
            {"Investigation", "INT"},
            {"Medicine", "WIS"},
            {"Nature", "INT"},
            {"Perception", "WIS"},
            {"Performance", "CHA"},
            {"Persuasion", "CHA"},
            {"Religion", "INT"},
            {"Sleight of Hand", "DEX"},
            {"Stealth", "DEX"},
            {"Survival", "WIS"},
        };
        #endregion Shared

        #region Saved Data Functions
        public static string appDataPath = AppDomain.CurrentDomain.BaseDirectory + @"SaveData";

        // --------Session--------
        // save session data using the global list
        public static void SaveSession()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var sessionJson = JsonSerializer.Serialize(allSessions, options);
            File.WriteAllText(appDataPath + @"\sessions.json", sessionJson);
        }

        // load session data from json file into the global list
        public static void LoadSession()
        {
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            if (!File.Exists(appDataPath + @"\sessions.json"))
            {
                File.Create(appDataPath + @"\sessions.json").Dispose();
                using (TextWriter tw = new StreamWriter(appDataPath + @"\sessions.json"))
                {
                    tw.WriteLine("[]");
                }
            }

            var sessionJson = File.ReadAllText(appDataPath + @"\sessions.json");
            allSessions = JsonSerializer.Deserialize<List<SessionModel>>(sessionJson)!;
        }


        // --------Trainer--------
        // save trainer data using the global list
        public static void SaveTrainer()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var trainerJson = JsonSerializer.Serialize(allTrainers, options);
            File.WriteAllText(appDataPath + @"\trainers.json", trainerJson);
        }

        // load trainer data from json file into the global list
        public static void LoadTrainer()
        {
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            if (!File.Exists(appDataPath + @"\trainers.json"))
            {
                File.Create(appDataPath + @"\trainers.json").Dispose();
                using (TextWriter tw = new StreamWriter(appDataPath + @"\trainers.json"))
                {
                    tw.WriteLine("[]");
                }
            }

            var trainerJson = File.ReadAllText(appDataPath + @"\trainers.json");
            allTrainers = JsonSerializer.Deserialize<List<TrainerModel>>(trainerJson)!;
        }


        // --------Pokemon--------
        // save pokemon data using the global list
        public static void SavePokemon()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var pokemonJson = JsonSerializer.Serialize(allPokemon, options);
            File.WriteAllText(appDataPath + @"\pokemon.json", pokemonJson);
        }

        // load pokemon data from json file into the global list
        public static void LoadPokemon()
        {
            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            if (!File.Exists(appDataPath + @"\pokemon.json"))
            {
                File.Create(appDataPath + @"\pokemon.json").Dispose();
                using (TextWriter tw = new StreamWriter(appDataPath + @"\pokemon.json"))
                {
                    tw.WriteLine("[]");
                }
            }

            var pokemonJson = File.ReadAllText(appDataPath + @"\pokemon.json");
            allPokemon = JsonSerializer.Deserialize<List<PokemonModel>>(pokemonJson)!;
        }
        #endregion Saved Data Functions
    }
}
