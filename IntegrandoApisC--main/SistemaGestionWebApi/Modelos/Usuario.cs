using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Modelos
{
    public class Usuario
    {
        private long id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        /* Constructor
        public Usuario(long id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Mail = mail;
        }
        */

        public long Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public string Nombre
        {
            get
            { return nombre; }
            set
            { nombre = value; }
        }
        public string Apellido
        {
            get
            { return apellido; }
            set
            { apellido = value; }
        }
        public string NombreUsuario
        {
            get
            { return nombreUsuario; }
            set
            { nombreUsuario = value; }
        }
        public string Contraseña
        {
            get
            { return contraseña; }
            set
            { contraseña = value; }
        }
        public string Mail
        {
            get
            { return mail; }
            set
            { mail = value; }
        }
    }
}



