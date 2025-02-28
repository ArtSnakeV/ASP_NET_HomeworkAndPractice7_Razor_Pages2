using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Implementation;
using ASP_NET_HomeworkAndPractice8_Razor_Pages3.Data;
using ASP_NET_HomeworkAndPractice8_Razor_Pages3.Services.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); // Added to use razor pages

string connStr = builder.Configuration
    .GetConnectionString("MSSQCinema") ??
    throw new InvalidOperationException("You should specify connection string!");
builder.Services.AddDbContext<CinemaContext>(optionsBuilder =>
{
    optionsBuilder.UseSqlServer(connStr);
});
//builder.Services.AddSingleton<IMovieRepository, MockMovieRepository>();
builder.Services.AddScoped<IMovieRepository, EFMovieRepository>();



var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();


app.Run();
