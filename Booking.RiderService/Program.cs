using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using RiderService.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Booking.RiderService API", Version = "v1" }); });

builder.Services.AddDbContext<RiderServiceDbContext>(o => { o.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")).UseLowerCaseNamingConvention(); });

var app = builder.Build();

app.Services.CreateScope().ServiceProvider.GetService<RiderServiceDbContext>()?.Database.Migrate();

if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseSwagger();
app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "Booking.RiderService API V1"); });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.Run();