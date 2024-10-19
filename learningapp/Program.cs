var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Configuration.AddAzureAppConfiguration("Endpoint=https://learningconfig204.azconfig.io;Id=JK8c;Secret=FCMZExRsqIRQ2JRqawjK4mDE2Tg4HtiqVCuJFRLmaQzTLu0ytVcEJQQJ99AJACi5YpzoTeHCAAABAZACwgbe");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
