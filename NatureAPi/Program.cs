using Microsoft.EntityFrameworkCore;
using NatureAPi;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// -------- SERVICES (todo antes de Build) --------
builder.Services.AddControllers()
    .AddJsonOptions(o =>
    {
        o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });

// OpenAPI con Swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// DbContext
var connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<NatureDBContext>(o => o.UseSqlServer(connectionString));

// -------- BUILD --------
var app = builder.Build();

// -------- MIDDLEWARE --------
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();       // genera /swagger/v1/swagger.json
    app.UseSwaggerUI();     // UI en /swagger
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowAll");


app.Run();