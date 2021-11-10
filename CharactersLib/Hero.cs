namespace CharactersLib
{
    public class Hero
    {
        public int HeroID { get; set; }
        public string HeroName { get; set; }
        public int MinDiceValue { get; set; }
        public int MaxDiceValue { get; set; }
        public int InitialUses { get; set; }
        public string ImageFileName { get; set; }

        public Hero() { } //empty constructor used for adding Hero to database

        public Hero(int HeroID, string HeroName, int MinDiceValue, int MaxDiceValue, int InitialUses, string ImageFileName)
        {
            this.HeroID = HeroID;
            this.HeroName = HeroName;
            this.MinDiceValue = MinDiceValue;
            this.MaxDiceValue = MaxDiceValue;
            this.InitialUses = InitialUses;
            this.ImageFileName = ImageFileName;
        }
    }
}
