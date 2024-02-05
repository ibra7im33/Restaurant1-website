var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.MapGet("/", () => "Hello World!");

builder.Services.AddMvc(x => x.EnableEndpointRouting = false);

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(app =>
{
    app.MapControllerRoute
    (
        name:"areas",
        pattern: "{areas/exist}{controller=Home}/{action/Index}/{Id?}"
    );
    app.MapControllerRoute
    (
        name:"default",
        pattern:"{controller=Home}/{action=Index}/{Id?}"
    ) ;
});

app.Run();
