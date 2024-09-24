using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
Debug.WriteLine("HELLO signalr");
app.Run();
