namespace MiniChallengeEightToTen.Services.GuessItService
{
    public interface IGuessItService
    {
        public string GuessItEasy(string guess);
        public string GuessItMedium(string guess);
        public string GuessItHard(string guess);


    }
}