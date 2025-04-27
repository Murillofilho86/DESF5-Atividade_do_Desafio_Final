using XPEducacao.API.Repository;
using XPEducacao.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();



#region Configuração injeção de dependencia

builder.Services.AddTransient<ICostumerService, CostumerService>();
builder.Services.AddTransient<ICostumerRepository, CostumerRepository>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "XP Educacao API V1");
    });
}
;

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
