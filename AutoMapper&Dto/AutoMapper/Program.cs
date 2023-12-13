using AutoMapper_Dto.AutoMapper;
using AutoMapper_Dto.Data;
using AutoMapper_Dto.Identity;
using AutoMapper_Dto.Repository.Interface;
using AutoMapper_Dto.Repository.Repo;
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
builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddScoped<IDepartment, DepartmentRepo>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
}); 

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
