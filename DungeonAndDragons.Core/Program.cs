using DungeonAndDragons.Core;
using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EfContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ConnectionString")));
builder.Services.AddScoped<IDbContext, EfContext>();
builder.Services.AddScoped<IBattleService, BattleService>();
builder.Services.AddScoped<IEnemyService, EnemyService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();