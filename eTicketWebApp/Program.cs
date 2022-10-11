using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using eTicketData;
//using eTicketServices;
using eTicketData.Entities;
using AutoMapper;
using eTicketWebApp;
using Microsoft.VisualBasic;
using eTicketData.Repositories;

using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using eTicketWebApp.Models;
using eTicketServices.Services;
using eTicketServices.IServices;
using eTicketServices;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.AddScoped<HttpContextUnitOfWork>();
builder.Services.AddMemoryCache();
builder.Services.AddETicketData(); 
builder.Services.AddETicketServices();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddControllersWithViews();

AddAuthorizationPolicies();

//builder.Services.AddDefaultIdentity<AspNetUser>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper); 

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

void AddAuthorizationPolicies()
{
    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("EmployeeOnly", policy => policy.RequireClaim("EmployeeNumber"));
    });

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy(Constantss.Policies.RequireAdmin, policy => policy.RequireRole(Constantss.Roles.Administrator));
        options.AddPolicy(Constantss.Policies.RequireManager, policy => policy.RequireRole(Constantss.Roles.Manager));
    });
        
}

void AddScoped()
{
 
}
