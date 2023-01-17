using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Repository;
using AYZ8R9_SOF_202231.Logic;

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
    options.Password.RequireDigit = false;
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
        opt.AppId = "432880205364301";
        opt.AppSecret = "057aabcf79ef365533cdab4cae0f3112";
    })
    .AddMicrosoftAccount(opt =>
    {
        opt.ClientId = "e31119ab-d694-44c7-928c-46da1588192c";
        opt.ClientSecret = "yRG8Q~Z-AE88PwQudM0w_69-IGFiPFqRY.vOScJF";
        opt.SaveTokens = true;
    });

//builder.Services.AddTransient<IEmailSender, EmailSender>();

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