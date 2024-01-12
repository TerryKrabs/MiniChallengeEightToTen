using MiniChallengeEightToTen.Services.EightBallService;
using MiniChallengeEightToTen.Services.GuessItService;
using MiniChallengeEightToTen.Services.RestaurantPService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEightBallService, EightBallService>();
builder.Services.AddScoped<IGuessItService, GuessItService>();
builder.Services.AddScoped<IRestaurantPService, RestaurantPService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
