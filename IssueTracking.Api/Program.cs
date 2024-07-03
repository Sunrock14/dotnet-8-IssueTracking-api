using IssueTracking.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.LoadCustomServices(builder.Configuration);
builder.Services.LoadAutoMapperService();
builder.Services.LoadAutoMapperService();
builder.Services.LoadConfigureSwagger(builder.Configuration);
builder.Services.LoadConfigureJWTAuthentication(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
