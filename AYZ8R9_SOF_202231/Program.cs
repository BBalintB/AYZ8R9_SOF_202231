using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Repository;
using AYZ8R9_SOF_202231.Logic;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SCRUMDbContext>(opt =>
{
    //opt.UseInMemoryDatabase("db");
    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SCRUMDB;Trusted_Connection=True;MultipleActiveResultSets=true")
    .UseLazyLoadingProxies();
});

builder.Services.AddDefaultIdentity<AppUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SCRUMDbContext>();


builder.Services.AddRazorPages();

builder.Services.AddAuthentication()
    .AddFacebook(opt =>
    {
        opt.AppId = "666379255279692";
        opt.AppSecret = "5dcc3cdc5508c6e79f0f573821883d31";
    });
builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();
builder.Services.AddTransient<IAppUserLogic, AppUserLogic>();

builder.Services.AddTransient<IProjectRepository, ProjectRepository>();
builder.Services.AddTransient<IProjectLogic, ProjectLogic>();

builder.Services.AddTransient<ISprintRepository, SprintRepository>();
builder.Services.AddTransient<ISprintLogic, SprintLogic>();

builder.Services.AddTransient<IUserStoryRepository, UserStoryRepository>();
builder.Services.AddTransient<IUserStoryLogic, UserStoryLogic>();

builder.Services.AddTransient<IProjectAppUserRepository, ProjectAppUserRepository>();
builder.Services.AddTransient<IProjectAppUserLogic, ProjectAppUserLogic>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); ;
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();