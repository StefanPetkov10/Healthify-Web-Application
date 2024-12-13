using HealthifyApp.Data;
using HealthifyApp.Data.Configuration;
using HealthifyApp.Service.Data.Interfaces;
using HealthifyApp.Services.Mapping;
using HealthifyApp.Web.Infrastructure.Extensions;
using HealthifyApp.Web.ViewModels.UserProfile;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetConnectionString("SQLServer");

// Add services to the container.
builder.Services.AddDbContext<HealthifyDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddSingleton<SeedData>();

// Add Identity with GUID keys
builder.Services
    .AddIdentity<ApplicationUser, IdentityRole<Guid>>(options =>
    {
        ConfigureIdentityOptions(builder, options);
    })
    .AddEntityFrameworkStores<HealthifyDbContext>()
    .AddDefaultTokenProviders()
    .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddUserManager<UserManager<ApplicationUser>>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
});

builder.Services.RegisterRepositories(typeof(ApplicationUser).Assembly);
builder.Services.RegisterUserDefinedServices(typeof(IUserProfileService).Assembly);


// Add Authentication, Authorization, ControllersWithViews, and RazorPages
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

WebApplication app = builder.Build();

//AutoMapperConfig.RegisterMappings(
//    typeof(UserProfileViewModel).Assembly, // ViewModels
//    typeof(UserProfile).Assembly); // Models

AutoMapperConfig.RegisterMappings(typeof(UserProfileViewModel).Assembly);

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    RolesSeeder.SeedRoles(services);
    RolesSeeder.AssignAdminRole(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Add Authentication and Authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Errors",
    pattern: "{controller=Home}/{action=Index}/{statusCode?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.ApplyMigrations();
app.Run();

static void ConfigureIdentityOptions(WebApplicationBuilder builder, IdentityOptions configuration)
{
    configuration.Password.RequireLowercase =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
    configuration.Password.RequireUppercase =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
    configuration.Password.RequireNonAlphanumeric =
        builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
    configuration.Password.RequiredLength =
        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
    configuration.Password.RequiredUniqueChars =
        builder.Configuration.GetValue<int>("Identity:Password:RequiredUniqueChars");

    configuration.User.RequireUniqueEmail =
        builder.Configuration.GetValue<bool>("Identity:User:RequireUniqueEmail");
}
