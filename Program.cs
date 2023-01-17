namespace Projeto_Web_Lh_Pets_versão_1Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Lh Pets - prótotpo 1");
        app.UseStaticFiles();




    Banco dba = new Banco();
        //app.MapGet("/listaClientes",()=>{
            //return "Olá Lista";

        //}); 
    app.MapGet("/listaClientes", (HttpContext context) =>
        {
            context.Response.WriteAsync(dba.GetListaString());
        });
        
        
        
        
        
        
        
        app.Run();
    }
}
