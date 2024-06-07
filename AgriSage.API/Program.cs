using AgriSage.API.Shared.Interfaces.ASP.Configuration;

using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using AgriSage.API.Profiles.Application.Internal.CommandServices;
using AgriSage.API.Profiles.Application.Internal.QueryServices;
using AgriSage.API.Profiles.Domain.Repositories;
using AgriSage.API.Profiles.Domain.Services;
using AgriSage.API.Profiles.Infrastructure.Persistence.EFC.Repositories;
using AgriSage.API.Profiles.Interfaces.ACL;
using AgriSage.API.Profiles.Interfaces.ACL.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using AgriSage.API.Shared.Domain.Repositories;
using AgriSage.API.Shared.Infrastructure.Persistence.EFC.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySQL(connectionString));

// Register the Swagger generator, defining one or more Swagger documents
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Profile API", Version = "v1" });
});

// Register application services
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IProfileCommandService, ProfileCommandService>();
builder.Services.AddScoped<IProfileQueryService, ProfileQueryService>();
builder.Services.AddScoped<IProfilesContextFacade, ProfilesContextFacade>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Profile API v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();