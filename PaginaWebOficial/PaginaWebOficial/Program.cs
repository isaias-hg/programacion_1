using PaginaWebOficial;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
RegistroHistorial.Ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PaginaWebOficial", "historial.json");

// Cultura fija (punto decimal) para que "3.5" se lea igual en cualquier PC
var cultura = new RequestLocalizationOptions()
    .SetDefaultCulture("en-US")
    .AddSupportedCultures("en-US")
    .AddSupportedUICultures("en-US");
cultura.RequestCultureProviders.Clear();
app.UseRequestLocalization(cultura);

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
