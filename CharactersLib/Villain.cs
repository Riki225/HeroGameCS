namespace CharactersLib
{
    public class Villain
    {
        public int VillainID { get; set; }
        public string VillainName { get; set; }
        public int VillainHealth { get; set; }

        public string ImageFileName { get; set; }

        public Villain() { } //empty constructor for adding Villain/API

        public Villain(int VillainID, string VillainName, int VillainHealth, string ImageFileName)
        {
            this.VillainID = VillainID;
            this.VillainName = VillainName;
            this.VillainHealth = VillainHealth;
            this.ImageFileName = ImageFileName;
        }
    }
}
