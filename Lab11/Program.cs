var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<Calc, SimpleCalc>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

public interface Calc
{
    public int Value();

}
public class SimpleCalc : Calc
{
    private Random rnd = new Random();
    public int Value()
    {
        return rnd.Next(0, 10);
    }
}
