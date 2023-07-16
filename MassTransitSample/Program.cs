// See https://aka.ms/new-console-template for more information
using MassTransit;
using MassTransitSample;

var builder = WebApplication.CreateBuilder();

builder.Services.AddHostedService<PingPublisher>();

builder.Services.AddMassTransit(options =>
{
    options.AddConsumers(typeof(Program).Assembly);
    options.UsingRabbitMq((context, cfg) =>
    {
        cfg.Host("localhost", "/", h =>
        {
            h.Username("guest");
            h.Password("guest");
        });

        cfg.ConfigureEndpoints(context);
    });
});

var app = builder.Build();

app.Run();