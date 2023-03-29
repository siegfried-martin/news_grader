using AutoMapper;
using Microsoft.Extensions.Options;
using NewsGraderServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();



var mapperConfig = new MapperConfiguration(config =>
    {
        config.AllowNullCollections = true;
        config.AllowNullDestinationValues = true;
        config.AddProfile(new DefaultMappingProfile());
    });
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddMvc();

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("corsapp");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
