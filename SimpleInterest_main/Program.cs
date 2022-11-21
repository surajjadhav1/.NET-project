global using Microsoft.AspNetCore.Mvc;
using SimpleInterest.Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ICalculate, SimpleIntrest>();
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
