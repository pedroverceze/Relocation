using Microsoft.EntityFrameworkCore;
using Relocation.Infrastructure.Data;
using MediatR;
using Relocation.Application.CommandHandler.CreateClient;
using System.Reflection;
using Relocation.Application.CommandHandler.CreateClient.Input;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddDbContext<Context>(o =>
                o.UseSqlServer(builder.Configuration.GetConnectionString("relocationDb")));

    builder.Services.AddMediatR(typeof(CreateClientCommandRequest));

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}





