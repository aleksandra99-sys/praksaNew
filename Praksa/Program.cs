using Praksa.Middleware;
using Praksa.Repository;
using Praksa.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IBooksRepository, BooksRepository>();
builder.Services.AddScoped<IBookServices, BookServices>();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*app.Use(async (ctx, next) =>
{
    var start = DateTime.UtcNow;
    await next.Invoke(ctx);
    app.Logger.LogInformation($"Request {ctx.Request.Path}: {(DateTime.UtcNow - start).TotalMilliseconds} ms");
});

app.Use((HttpContext ctx, Func<Task> next) =>
{
    app.Logger.LogInformation("Terminating the request");
    return Task.CompletedTask;
}); */

app.UseMiddleware<MiddlewareConfiguration>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
