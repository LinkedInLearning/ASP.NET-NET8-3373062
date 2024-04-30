using EvaluationProduit.MVC.CoreDI;
using EvaluationProduit.MVC.Models;
using EvaluationProduit.MVC.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Logging.AddJsonConsole(options =>
    {
        options.JsonWriterOptions = new JsonWriterOptions()
        { Indented = true };
    });
// Add services to the container.
builder.Services.AddTransient<IValidator<ProduitModel>, ProduitValidator>();
builder.Services.AjouterProduitServices();
builder.Services.AddControllersWithViews().AddFluentValidation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
