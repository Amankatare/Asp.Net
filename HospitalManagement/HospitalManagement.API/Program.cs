using HospitalManagement.DataAccess.Data;
using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.DataAccess.Repository.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration["ConnectionString:ConnectionString"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
/*

AppDomain.CurrentDomain.GetAssemblies(): This part retrieves all the loaded assemblies in the current application domain. This is commonly used when you want AutoMapper to scan all assemblies in your application to discover and register mapping profiles. 

typeof(Program): This version of AddAutoMapper is specifying a specific type (Program in this case) from which to scan the assembly. This means AutoMapper will only look in the assembly where the Program class is defined. It's a more targeted approach compared to scanning all assemblies in the current application domain.

 */

builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
