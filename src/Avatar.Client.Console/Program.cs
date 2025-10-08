using System.Diagnostics;
using System.Reflection;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

using var traceProvider = OpenTelemetry.Sdk.CreateTracerProviderBuilder()
    .SetResourceBuilder(
        ResourceBuilder.CreateDefault()
            .AddService("Avatar.Client.Console")
            .AddAttributes([
                new KeyValuePair<string, object>("service.version", Assembly.GetExecutingAssembly().GetName().Version!.ToString())
            ])
    )
    .AddSource(ApplicationDiagnostics.ActivitySourceName)
    .AddConsoleExporter()
    .Build();

using var activity = ApplicationDiagnostics.ActivitySource.StartActivity("Do Work");
Console.WriteLine("Hello, World!");


public static class ApplicationDiagnostics
{
    public static readonly ActivitySource ActivitySource = new(ActivitySourceName);
    public const string ActivitySourceName = "Console.Tool.Diagnostics";
}






