using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Super_Cartes_Infinies.Hubs;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Services;
using Super_Cartes_Infinies.Services.Interfaces;
using Super_Cartes_Infinies.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.UseLazyLoadingProxies();
});
// Permet d'obtenir des erreurs de BD plus claires et même d'appliquer des migrations manquantes
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//builder.Services.AddDefaultIdentity<IdentityUser>()
  //  .AddRoles<IdentityRole>()
    //.AddEntityFrameworkStores<ApplicationDbContext>();



builder.Services.AddSignalR();

builder.Services.AddControllersWithViews();



// Injection de dépendance
builder.Services.AddScoped<PlayersService>();
builder.Services.AddScoped<AccountService>();
builder.Services.AddScoped<CardsService>();
builder.Services.AddSingleton<WaitingUserService>();
builder.Services.AddScoped<MatchesService>();
builder.Services.AddScoped<StartingCardsService>();
builder.Services.AddScoped<MatchConfigurationService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Authentifiction par cookie
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
     .AddRoles<IdentityRole>()// jai add ca maybe not 
    .AddEntityFrameworkStores<ApplicationDbContext>();

/*builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("http://localhost:4200", "https://localhost:4200");
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.AllowCredentials();
    });
});*/

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.WithOrigins("https://localhost:4200")
               .AllowAnyMethod()
               .AllowAnyHeader()
               .AllowCredentials();

    });
});

builder.Services.AddHttpContextAccessor();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = false;
});

//fin cookie
/*
builder.Services.AddAntiforgery();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidAudience = "http://localhost:4200",
        ValidIssuer = "https://localhost:7011",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]!))
    };
})
.AddCookie(options =>
{
    options.Cookie.Name = ".AspNetCore.Antiforgery.tK-DXvb_1jc";
    options.Cookie.Name = ".AspNetCore.Identity.Application"; 
});*/

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseStaticFiles();

app.UseRouting();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllerRoute( //routing admin
    name: "Admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute( //routing default
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.MapHub<MatchHub>("/matchHub");

app.Run();
