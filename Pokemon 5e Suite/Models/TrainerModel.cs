namespace Pokemon_5e_Suite.Models
{
    public class TrainerModel
    {

        public int id { get; set; } // uniquely generated id
        public string name { get; set; }
        public int hp { get; set; }
        public int ac { get; set; }
        public int prof { get; set; }
        public int hitDie { get; set; }
        public int speed { get; set; }
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int inte { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
        public int pokeDollars { get; set; }
        public List<string> toolProfs { get; set; }
        public string background { get; set; }
        public string battlePhrase { get; set; }
        public List<string> flaws { get; set; }
        public List<string> ideals { get; set; }
        public IDictionary<string, bool> abilityProfs { get; set; } // ability name, true or false if proficient or not
        public List<Pokeballs> pokeballs { get; set; } // name, quantity
        public List<KeyItems> keyItems { get; set; } // name, quantity, description
        public List<Consumables> consumables { get; set; } // name, quantity, description
        public List<TrainerAbility> trainerAbilities { get; set; } // name, level, description
        public List<PokemonModel> pokemon { get; set; }  // pokemon in inventory
        public List<PokemonModel> pcPokemon { get; set; } // pokemon in pc
        public string notes { get; set; }

        public struct Pokeballs
        {
            public string name { get; set; }
            public int quantity { get; set; }
            public string description { get; set; }
        }

        public struct KeyItems
        {
            public string name { get; set; }
            public int quantity { get; set; }
            public string description { get; set; }
        }

        public struct Consumables
        {
            public string name { get; set; }
            public int quantity { get; set; }
            public string description { get; set; }
        }

        public struct TrainerAbility
        {
            public string name { get; set; }
            public int level { get; set; }
            public string description { get; set; }
        }

    }
}
