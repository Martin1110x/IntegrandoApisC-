using SistemaGestionWebApi.Controllers;
using SistemaGestionWebApi.Modelos;
using SistemaGestionWebApi.Repositorio;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();

        Producto producto_1 = new Producto();
        producto_1.Descripciones = "Zapatillas Nike";
        producto_1.Costo = 1200;
        producto_1.PrecioVenta = 7000;
        producto_1.Stock = 40;
        producto_1.IdUsuario = 2;

        /*
        //Agregar producto.

        ProductoController.InsertarProducto(producto_1); 

        //Modificar producto.

        producto_1.PrecioVenta = 8000;
        ProductoController.ActualizarProducto(producto_1); 

        Eliminar producto.

       ProductoController.BorrarProducto(7); 

        //Modificar usuario.
        
        Usuario usuario_1 = new Usuario();
        usuario_1 = UsuarioController.ObtenerUsuario(3);
        usuario_1.Contraseña = "NuevaContraseña1234";

        UsuarioController.ActualizarUsuario(usuario_1, 3); */
    }
}