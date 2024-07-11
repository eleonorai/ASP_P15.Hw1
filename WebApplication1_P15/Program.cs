using ASP_P15.Services.Hash;
using ASP_P15.Services.Kdf;
using ASP_P15.Services.KdfService;
using ASP_P15.Services.OTP;
using ASP_P15.Services.FileName;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//builder.Services.AddSingleton<IHashService, Md5HashService>();
builder.Services.AddScoped<IHashService, ShaHashService>();
builder.Services.AddSingleton<IKdfService, Pbkdf1Service>();
builder.Services.AddSingleton<IOtpService, Otp6Service>();
builder.Services.AddTransient<IFileNameService, IFileNameService>();
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
