using Microsoft.EntityFrameworkCore;
using MVC2.Data;
using MVC2.Repository.Interface;
using MVC2.Repository.Repo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IStudent, StudentRepo>();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ConnectionString"]));

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
