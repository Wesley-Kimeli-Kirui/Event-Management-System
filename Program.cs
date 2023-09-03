using EventsApplication.Context;
using EventsApplication.Services;
using EventsApplication.Services.IServices;
using Auth.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EventsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection"));
});

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEventsService, EventsService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.AddAppAuthentication();

builder.addAuthorizationExtension();
builder.AddSwaggenGenExtension();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.ApplyMigration();

app.Run();

// ApplyMigration();
app.Run();

// //Migration
// void ApplyMigration()
// {
//     using (var scope = app.Services.CreateScope())
//     {
//         var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//         if (_db.Database.GetPendingMigrations().Count() > 0)
//         {
//             _db.Database.Migrate();
//         }
//     }
// }