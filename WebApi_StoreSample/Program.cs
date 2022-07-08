using Microsoft.OpenApi.Models;
using Services.ConfigurationLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(Gen => {
    Gen.SwaggerDoc("V1", new OpenApiInfo() {
        Description = "Api de la prueba de conocimiento",
        Title = "StoreSample",
        Version = "V1",
    });
    Gen.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});
builder.Services.AddServices(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("../swagger/V1/swagger.json", "V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
