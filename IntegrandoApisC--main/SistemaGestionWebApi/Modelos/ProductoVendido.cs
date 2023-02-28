using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionWebApi.Modelos
{
    public class ProductoVendido
    {
        private long id;
        private int stock;
        private long idProducto;
        private long idVenta;

        /*
        public ProductoVendido(long id, int stock, long idProducto, long idVenta)
        {
            this.Id = id;
            this.Stock = stock;
            this.IdProducto = idProducto;
            this.IdVenta = idVenta;
        }
        */
        public long Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public int Stock
        {
            get
            { return stock; }
            set
            { stock = value; }
        }
        public long IdProducto
        {
            get
            { return idProducto; }
            set
            { idProducto = value; }
        }
        public long IdVenta
        {
            get
            { return idVenta; }
            set
            { idVenta = value; }
        }
    }

}
