using CalculoCDB.Aplicaca.Servicos;
using CalculoCDB.ModuloCalculos.CalculoCDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IResgateAplicacaoServico, ResgateAplicacaoServico>();
builder.Services.AddScoped<ICalculaCDBServico, CalculaCDBServico>();
builder.Services.AddCors(x => x.AddDefaultPolicy(x => { x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
