namespace rpgoopcsharp.src.Entities
{
    public class Arus
    {
        public string Name;
        public int level;
        public string HeroType;
        public Arus(string Name,int level,string HeroType){
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }

        public override string ToString(){
            return this.Name + " " + this.level + " " + this.HeroType;
        }
    }
}