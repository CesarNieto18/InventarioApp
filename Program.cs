// =====================================
// SISTEMA DE INVENTARIO - Clase 1.1
// Estado: Mensaje de bienvenida
//======================================


using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("-----SISTEMA DE GESTIÓN DE INVENTARIO-----");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Versión: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".NET Versión: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto");
Console.WriteLine(" InventarioApp/");
Console.WriteLine(" |-- Program.cs");
Console.WriteLine(" |-- Inventario.csproj");
Console.WriteLine(" |-- README");
Console.WriteLine(" |-- src/");
Console.WriteLine("     |--Models");
Console.WriteLine("Configuración.csproj");
Console.WriteLine("Carpeta src/creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine("");
Console.WriteLine("Proximo paso: Checkpoint");

