using ERaceApp.Components;
using ERaceLibrary;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


//  :added
//  code retrieves the ERace2024 connection string
//  NOTE:  You must update the server name in the appsettings.json for your machine.
var connectionStringERace2024 = builder.Configuration.GetConnectionString("ERace2024");
//  add backend dependencies here



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
