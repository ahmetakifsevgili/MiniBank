using Microsoft.EntityFrameworkCore;
using MiniBank.Data; // Kendi Data klasörümüzü içeri alıyoruz

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// 👇 Veritabanı motorunu (AppDbContext) ve bağlantı adresini (appsettings.json) sisteme tanıtıyoruz
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// 👆 ----------------------------------------------------------------------------------------- 👆

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); // BU SATIRDAN SONRA SERVİS EKLENMEZ

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