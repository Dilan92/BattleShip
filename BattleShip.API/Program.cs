using BattleShip.API.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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
app.UseSwagger();
//app.UseSwaggerUI(c =>
//{

//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//});
app.UseSwaggerUI(c => c.SwaggerEndpoint("openapi.json", "AddoExplorerService.Api v1"));
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
