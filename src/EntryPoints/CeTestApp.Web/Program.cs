using CeTestApp.Application.Interfaces;
using CeTestApp.Infrastructure;
using CeTestApp.Infrastructure.Workflows;
using CeTestApp.MerchantClient.Api;
using CeTestApp.RestClient;
using CeTestApp.Web.Application.Interfaces;
using CeTestApp.Web.Infrastructure;
using CeTestApp.Web.Infrastructure.Workflows;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration
    .AddEnvironmentVariables();

// Add services to the container.
builder.Services.AddControllersWithViews();

var services = builder.Services;
services.AddSingleton<IReadableConfiguration>(s => new Configuration()
{
    ApiKey = builder.Configuration.GetValue<string>("API_KEY") ?? throw new ArgumentNullException("API_KEY"),
    BasePath = builder.Configuration.GetValue<string>("MERCHANT_API") ?? throw new ArgumentException("MERCHANT_API")
});
services.AddHttpClient<IApiClient, ApiClient>();
services
    .AddScoped<IOrderApi, OrderApi>()
    .AddScoped<IOfferApi, OfferApi>()
    .AddScoped<ICustomMapper, CustomMapper>()
    .AddScoped<IMerchantWorkflow, MerchantWorkflow>()
    .AddScoped<IHomeWorkflow, HomeWorkflow>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();