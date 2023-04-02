using UniMix.Controllers.Auth;
using UniMix.Controllers.Search;
using UniMix.Services.AppleMusic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<AppleMusicService>();
builder.Services.AddScoped<AppleMusicService>();
builder.Services.AddScoped<AppleMusicAuthController>();
builder.Services.AddScoped<SearchController>();
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
