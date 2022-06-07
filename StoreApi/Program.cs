using StoreBL;
using StoreDL;
using StoreModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Customer>, SQLCustomerRepository>(repo => new SQLCustomerRepository(Environment.GetEnvironmentVariable("Arjun_Nair")));
builder.Services.AddScoped<ICustomerBL, CustomerBL>();
builder.Services.AddScoped<IRepository<Products>, SQLProductRepository>(repo => new SQLProductRepository(Environment.GetEnvironmentVariable("Arjun_Nair")));
builder.Services.AddScoped<IProductBL, ProductBL>();


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
