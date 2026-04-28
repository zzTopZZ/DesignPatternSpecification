using SeuProjeto.Domain.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<CarroValidation>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Estoque API - Design Pattern Specification",
        Version = "v1",
        Description = "**Specification Pattern - API**",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Renato Souza",
            Email = "renatozz@gmail.com",
            Url = new Uri("https://escoladev.com.br")  //Não existe, é só um exemplo
        }
    });
});

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
