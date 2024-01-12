using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen.Services.GuessItService
{
    public class GuessItService : IGuessItService
    {
         public string GuessItEasy(string guess){
        if (int.TryParse(guess, out int number))
        {
            Random generator = new();
            int randNum = generator.Next(1, 11);
            string response = "";
            if (number > randNum)
            {
                response = $"The number you chose {number} is greater than {randNum}.";
            }
            else if (number < randNum)
            {
                response = $"The number you chose {number} is less than {randNum}.";
            }
            else
            {
                response = $"Congratulations!! the number was {number} it took you {randNum} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Your Input Aint Valid Homie";
    }

    public string GuessItMedium(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            Random generator = new();
            int randNum = generator.Next(1, 51);
            string response = "";
            if (number > randNum)
            {
              response = $"The number you chose {number} is greater than {randNum}.";
            }
            else if (number < randNum)
            {
                  response = $"The number you chose {number} is less than {randNum}.";
            }
            else
            {
                response = $"Congratulations!! The number was {number} it took you {randNum} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Your Input Aint Valid Homie";
    }


      public string GuessItHard(string guess)
    {
        if (int.TryParse(guess, out int number))
        {
            Random generator = new();
            int randNum = generator.Next(1, 101);
            string response = "";
            if (number > randNum)
            {
              response = $"The number you chose {number} is greater than {randNum}.";
            }
            else if (number < randNum)
            {
                    response = $"The number you chose {number} is less than {randNum}.";
            }
            else
            {
               response = $"Congratulations!! The number was {number} it took you {randNum} guesses to get it right. Great job!!";
            }
            return response;
        }
        return "Your Input Aint Valid Homie";
    }
    }
}