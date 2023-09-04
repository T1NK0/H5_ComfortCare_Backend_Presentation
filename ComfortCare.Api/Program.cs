using ComfortCare.Data;
using ComfortCare.Data.Interfaces;
using ComfortCare.Domain.BusinessLogic;
using ComfortCare.Domain.BusinessLogic.interfaces;
using ComfortCare.Service;
using ComfortCare.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Context used by EF Core
builder.Services.AddDbContext<ComfortCareDbContext>(opt =>
{
    var configuration = builder.Configuration;
    var connectionString = configuration.GetConnectionString("ComfortCareDbConnectionString");
    opt.UseSqlServer(connectionString);
}
 );

// Dependency injections
builder.Services.AddTransient<RouteGenerator>();
builder.Services.AddTransient<SchemaGenerator>();
builder.Services.AddTransient<IPeriodManager, PeriodManager>();
builder.Services.AddTransient<IRouteRepo, ComfortCareRepository>();
builder.Services.AddTransient<IEmployeesRepo, ComfortCareRepository>();
builder.Services.AddTransient<IUserRepo, ComfortCareRepository>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IPeriodRepo, PeriodRepo>();
builder.Services.AddTransient<IPeriodService, PeriodService>();
builder.Services.AddTransient<IEntityFactory, EntityFactoryImpl>();

var _allowAllOriginsForDevelopment = "_allowAllOriginsForDevelopment";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: _allowAllOriginsForDevelopment,
        builder =>
        {
            builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(_allowAllOriginsForDevelopment);
app.UseAuthorization();

app.MapControllers();

app.Run();
