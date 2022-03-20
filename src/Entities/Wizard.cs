namespace rpgoopcsharp.src.Entities
{
    public class Wizard : Hero
    {
        public override string Attack(){
            return this.Name + "Attacks with his spade";
        }
    }
}