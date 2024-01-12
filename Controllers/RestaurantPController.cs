namespace MiniChallengeEightToTen.Controllers;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen.Services.RestaurantPService;

[ApiController]
[Route("[controller]")]
public class RestaurantPController : ControllerBase{
 private readonly IRestaurantPService _RestaurantPService;

    public RestaurantPController(IRestaurantPService RestaurantPService)
    {
        _RestaurantPService = RestaurantPService;
    }

[HttpGet]
[Route("Breakfast/{userInput}")]



public string Breakfast(string userInput){
 
    return _RestaurantPService.Breakfast(userInput);
}
[HttpGet]
[Route("Mexican/{userInput}")]
public string Mexican(string userInput){
    
    
    return _RestaurantPService.Mexican(userInput);

}
[HttpGet]
[Route("Pizza/{userInput}")]
public string Pizza(string userInput){

    return _RestaurantPService.Pizza(userInput);

}
}