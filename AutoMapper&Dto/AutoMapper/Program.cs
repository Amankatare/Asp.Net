using AutoMapper_Dto.Data;
using AutoMapper_Dto.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Added DbContext
builder.Services.AddDbContext<DatabaseDBContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ConnectionString"]));
builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ConnectionString"]));

//Added Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDBContext>().AddDefaultTokenProviders();

//Added AutoMapper
builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
