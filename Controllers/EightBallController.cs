namespace MiniChallengeEightToTen.Controllers;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.EightBallService;

[ApiController]
[Route("[controller]")]

    public class EightBallController : ControllerBase{

        private readonly IEightBallService _EightBallService;

    public EightBallController(IEightBallService EightBallService)
    {
        _EightBallService = EightBallService;
    }

    [HttpGet]
        [Route("EightBall/{question}")]
        
        public string EightBall(){
        
        return _EightBallService.EightBall();

    }
    }
