using ChatWithMe.DataAccess.Data;
using ChatWithMe.Entities.Identity;
using ChatWithMe.MVC.Hubs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SignalContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ConnectionString"]));

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SignalContext>().AddDefaultTokenProviders();
builder.Services.AddTransient<UserManager<AppUser>>();


builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapHub<ChatHub>("/chat"));
// app.MapHub<ChatHub>("/chat");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
