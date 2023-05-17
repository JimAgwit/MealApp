using MealApp.Services;
using MealApp.Services.Interface;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGetMealCategoryInterface, GetMealCategoryService>();
builder.Services.AddScoped<ISearchMealByNameInterface, SearchMealByNameService>();
builder.Services.AddScoped<IGetRandomMealInterface, GetRandomMealService>();

builder.Services.AddHttpClient();
builder.Services.AddHttpClient("MealDbClient", client =>
{
    client.BaseAddress = new Uri("https://www.themealdb.com/api/json/v1/1/categories.php");
});
Host.CreateDefaultBuilder(args)
       .ConfigureServices((hostContext, services) =>
       {
           // Configure services here
           services.AddControllers();
       })
       .ConfigureWebHostDefaults(webBuilder =>
       {
           webBuilder.Configure(app =>
           {
               // Configure middleware pipeline here
               app.UseRouting();
               app.UseAuthorization();
               app.UseEndpoints(endpoints =>
               {
                   endpoints.MapControllers();
               });
           });
       });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
