using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AYZ8R9_SOF_202231.Data;
using AYZ8R9_SOF_202231.Repository;
using AYZ8R9_SOF_202231.Logic;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Configuration;
using AYZ8R9_SOF_202231.Hubs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("AzureConnection");
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SCRUMDbContext>(opt =>
{
    //opt.UseInMemoryDatabase("db");
    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SCRUMDB;Trusted_Connection=True;MultipleActiveResultSets=true")
    .UseLazyLoadingProxies();
});

builder.Services.AddSignalR();

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

})
    .AddEntityFrameworkStores<SCRUMDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddRazorPages();

builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = "http://www.security.org",
        ValidIssuer = "http://www.security.org",
        IssuerSigningKey = new SymmetricSecurityKey
    (Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"))
    };
});

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

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseExceptionHandler("/Home/Error");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<EventHub>("/events");

app.UseAuthentication(); ;
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();