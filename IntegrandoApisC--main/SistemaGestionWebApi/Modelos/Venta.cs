using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Modelos
{
    public class Venta
{
    private long id;
    private string comentarios;
    private long idUsuario;

     /* Constructor
    public Venta(long id, string comentarios, long idUsuario)
    {
        this.Id = id;
        this.Comentarios = comentarios;
        this.IdUsuario = idUsuario;
    }
        */
    public long Id
    {
        get
        { return id; }
        set
        { id = value; }
    }
    public string Comentarios
    {
        get
        { return comentarios; }
        set
        { comentarios = value; }
    }
    public long IdUsuario
    {
        get
        { return idUsuario; }
        set
        { idUsuario = value; }
    }
}
}
