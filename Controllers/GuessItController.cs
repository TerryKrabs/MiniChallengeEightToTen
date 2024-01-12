namespace MiniChallengeEightToTen.Controllers;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.GuessItService;

public class GuessItController : ControllerBase{
        private readonly IGuessItService _GuessItService;

    public GuessItController(IGuessItService GuessItService)
    {
        _GuessItService = GuessItService;
    }

    [HttpGet]
        [Route("GuessItEasy/{guess}")]

        public string GuessItEasy(string guess){

            return _GuessItService.GuessItEasy(guess);

    }

    [HttpGet]
    [Route("GuessItHard/{guess}")]
    public string GuessItHard(string guess)
    {
        return _GuessItService.GuessItHard(guess);
    }

    [HttpGet]
    [Route("GuessItMedium/{guess}")]
    public string GuessItMedium(string guess)
    {
      return _GuessItService.GuessItMedium(guess);
    }
    }
    
