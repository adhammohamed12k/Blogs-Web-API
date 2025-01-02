using Microsoft.EntityFrameworkCore;
using Try3;
using Try3.Repository_s.ReactionRepository;
using Try3.Repository_s.UserRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContextt>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("newconn")));
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IReactionRepo , ReactionRepo>();
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
