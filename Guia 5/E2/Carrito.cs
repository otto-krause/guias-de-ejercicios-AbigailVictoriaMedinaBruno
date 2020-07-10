using System;
using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Carrito
    {
        List<Producto> listaDeProductos;

        public Carrito(List<Producto> listaDeProductos)
        {
            this.listaDeProductos = listaDeProductos;
        }
        public Carrito(){
            listaDeProductos = new List<Producto>();
        }
        public List<Producto> ListaDeProductos { get => listaDeProductos;}
    }
}