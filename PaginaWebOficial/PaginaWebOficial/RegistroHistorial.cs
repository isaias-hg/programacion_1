using System.Text.Json;

namespace PaginaWebOficial;

public record Entrada(DateTime Fecha, string Categoria, string Detalle);

/// <summary>Guarda cada actividad en un archivo JSON (la más reciente primero).</summary>
public static class RegistroHistorial
{
    private static readonly object Candado = new();

    public static string Ruta { get; set; } = Path.Combine(Path.GetTempPath(), "historial.json");

    public static List<Entrada> Obtener()
    {
        lock (Candado) return Leer();
    }

    public static void Agregar(string categoria, string detalle)
    {
        lock (Candado)
        {
            var lista = Leer();
            lista.Insert(0, new Entrada(DateTime.Now, categoria, detalle));
            Directory.CreateDirectory(Path.GetDirectoryName(Ruta)!);
            File.WriteAllText(Ruta, JsonSerializer.Serialize(lista));
        }
    }

    public static void Limpiar()
    {
        lock (Candado) { if (File.Exists(Ruta)) File.Delete(Ruta); }
    }

    private static List<Entrada> Leer()
    {
        try { return File.Exists(Ruta) ? JsonSerializer.Deserialize<List<Entrada>>(File.ReadAllText(Ruta)) ?? new() : new(); }
        catch { return new(); }
    }
}
