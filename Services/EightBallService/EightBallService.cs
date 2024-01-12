namespace MiniChallengeEightToTen.Services.EightBallService
{
    public class EightBallService : IEightBallService{
                public string EightBall(){
        Random outCome = new Random();
        int number = outCome.Next(8);
        switch (number){
            case 0:
                return "Wisdom is withheld for the wise";
            case 1:
                return "I live in fear for thy fart may be a shart";
            case 2:
                return "You'll get older one day and realize Squiward had every right to feel the way he felt";
            case 3:
                return "Be like water my friend";
            case 4:
                return "SkyNet will takeover one day and it will be humans that become a tool for machines";
            case 5:
                return "Siri is always listening......";
            case 6:
                return "Boxing is just PokeMon but with humans, The coach (PokeMaster) guides his boxer (Pokemon) through a fight against another boxer. You know what.....every sport is pokemon";
            default:
                return "Beware of cracks, for one wrong step could break thy mothers back";
        }
    }
    }
}