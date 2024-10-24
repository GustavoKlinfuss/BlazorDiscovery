using BlazorDiscovery.Areas.Identity.Services;
using BlazorDiscovery.Areas.PersonManagement.Services;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorBootstrap();
builder.Services.AddSingleton<PersonManagementService>();
builder.Services.AddHttpClient<LoginService>(options =>
{
    options.BaseAddress = new Uri(builder.Configuration["IdentityServer:BaseAddress"]);
});
builder.Services.AddHttpClient<PersonManagementService>(options =>
{
    options.BaseAddress = new Uri(builder.Configuration["PersonManagementAPI:BaseAddress"]);
});
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
