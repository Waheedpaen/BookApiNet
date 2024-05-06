

using CoreWebApi.Hubs;
using ImplementDAL.Services;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
 

builder.Services.Configure<FormOptions>(x =>
{
    x.ValueLengthLimit = int.MaxValue;
    x.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
});
 
builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = 500 * 1024 * 1024; // 500 MB
});

builder.Services.AddDependencies();
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddSignalR();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

 
app.UseHttpsRedirection();
app.UseCors("AllowAllHeaders");
app.UseAuthorization();
app.UseRouting();
app.UseStaticFiles();

app.MapControllers();
app.MapHub<ChatHub>("/sara");
app.Run();
