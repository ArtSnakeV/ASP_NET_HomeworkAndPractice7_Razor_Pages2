var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(); // Added to use razor pages
var app = builder.Build();

app.MapRazorPages();


app.Run();
