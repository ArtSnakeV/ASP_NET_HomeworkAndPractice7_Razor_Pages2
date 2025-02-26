using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Abstract;
using ASP_NET_HomeworkAndPractice7_Razor_Pages2.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); // Added to use razor pages

builder.Services.AddSingleton<IMovieRepository, MockMovieRepository>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapRazorPages();


app.Run();
