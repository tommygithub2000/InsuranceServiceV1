using InsuranceServiceApi.Clients.StorageServiceClient;
using InsuranceServiceApi.Clients.StorageServiceClient.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Add the HttpClient service
builder.Services.AddHttpClient<IStorageServiceApiClient, StorageServiceApiClient>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5098"); //Base url should be in an applicationSetting.
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
