using CharacterCopyKata.Core;
using CharacterCopyKata.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<ISource>(provider => new SourceImplementation("Hello\n"));
builder.Services.AddTransient<IDestination, DestinationImplementation>();
builder.Services.AddTransient<Copier>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
