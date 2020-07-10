using System;
using System.Collections.Generic;
using System.Linq;
namespace E2
{
    public class Supermercado
    {
        private double total;
        List<Carrito> carritosUsados;

        public Supermercado()
        {
            Producto agua = new Producto("agua",1.55);
            Producto pochoclos = new Producto("pochoclos",3);
            Producto cafe = new Producto("cafe",10);
            List<Producto> listaDeProductos1 = new List<Producto>{agua,pochoclos}; 
            List<Producto> listaDeProductos2 = new List<Producto>{pochoclos,cafe}; 
            
            Carrito carrito1 = new Carrito(listaDeProductos1);
            Carrito carrito2 = new Carrito(listaDeProductos2);
            
            carritosUsados = new List<Carrito>();
            carritosUsados.Add(carrito1);
            carritosUsados.Add(carrito2);
        }

        public double ganancias(){
            carritosUsados.
            ForEach(Carrito => Carrito.ListaDeProductos.
            ForEach(Producto => total += Producto.Precio));
            return total;
        }
    }
}