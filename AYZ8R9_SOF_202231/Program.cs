using AYZ8R9_SOF_202231.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AYZ8R9_SOF_202231.Data;

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
        opt.AppId = "666379255279692";
        opt.AppSecret = "5dcc3cdc5508c6e79f0f573821883d31";
    });

//builder.Services.AddTransient<IEmailSender, EmailSender>();

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