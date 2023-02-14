using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Modelos
{
    public class Producto
    {
        private long id;
        private string descripciones;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private long idUsuario;


        /* Constructor
        public Producto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            this.Id = id;
            this.Descripciones = descripciones;
            this.Costo = costo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
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

        public string Descripciones
        {
            get
            { return descripciones; }
            set
            { descripciones = value; }
        }

        public decimal Costo
        {
            get
            { return costo; }
            set
            { costo = value; }
        }

        public decimal PrecioVenta
        {
            get
            { return precioVenta; }
            set
            { precioVenta = value; }
        }

        public int Stock
        {
            get
            { return stock; }
            set
            { stock = value; }
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

