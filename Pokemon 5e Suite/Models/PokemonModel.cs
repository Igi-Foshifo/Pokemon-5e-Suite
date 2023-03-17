namespace Pokemon_5e_Suite.Models
{
    public class PokemonModel
    {
        public int id { get; set; }
        public int name { get; set; }
        public int hp { get; set; }
        public int level { get; set; }
        public int exp { get; set; }
        public int walkSpd { get; set; }
        public int swimSpd { get; set; }
        public int flySpd { get; set; }
        public string firstType { get; set; }
        public string secondType { get; set; }
        public string nature { get; set; }
        public int loyalty { get; set; }
        public int ac { get; set; }
        public int prof { get; set; }
        public int stab { get; set; }
        public int hitDie { get; set; }
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int inte { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
        public List<Move> moves { get; set; }
        public List<Ability> abilities { get; set; }
        public List<string> senses { get; set; }
        public List<string> skills { get; set; }
        public List<Feat> feats { get; set; }
        public List<string> resistances { get; set; }
        public List<string> vulnerabilities { get; set; }
        public List<string> immunities { get; set; }

        public struct Move
        {
            public string name { get; set; }
            public string type { get; set; }
            public string powerOne { get; set; }
            public string powerTwo { get; set; }
            public string cost { get; set; }
            public string duration { get; set; }
            public bool concentration { get; set; }
            public int range { get; set; }
            public string description { get; set; }
            public string higherLevels { get; set; }
        }

        public class Ability
        {
            public string name { get; set; }
            public string description { get; set; }
        }

        public class Feat
        {
            public string name { get; set; }
            public string description { get; set; }
        }
    }
}
