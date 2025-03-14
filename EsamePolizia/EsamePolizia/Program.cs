using Microsoft.EntityFrameworkCore;
using EsamePolizia.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura il DbContext per la connessione al database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EsamePoliziaDb")));

// Aggiungi i servizi per controller e viste
builder.Services.AddControllersWithViews();

// Configura il WebHost per usare la porta specifica
builder.WebHost.UseUrls("http://localhost:2525");

var app = builder.Build();

// Configura la pipeline delle richieste HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configura la route predefinita
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();