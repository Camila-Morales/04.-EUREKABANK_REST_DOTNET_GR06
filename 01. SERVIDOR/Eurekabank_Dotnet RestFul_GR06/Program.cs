var builder = WebApplication.CreateBuilder(args);

// Configura los servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()   // Permitir cualquier origen
              .AllowAnyMethod()   // Permitir cualquier método HTTP
              .AllowAnyHeader();  // Permitir cualquier encabezado
    });
});

var app = builder.Build();

// Configura el pipeline de solicitudes
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

// Habilitar CORS en el pipeline
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
