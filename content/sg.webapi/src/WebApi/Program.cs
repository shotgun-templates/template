var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run();

// We need to declare partial class so that we can use
// it in E2ETests.
public partial class Program { }