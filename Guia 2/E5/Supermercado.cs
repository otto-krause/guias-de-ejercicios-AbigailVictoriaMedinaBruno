namespace E5
{
    public class Supermercado
    {
        public float total;
        public List<Carrito> carritosUsados = new List<Carrito>();
        public void ganancias(){
            foreach (Carrito i in carritosUsados){
                foreach (Producto j in i)
                {
                    total += j.precio;
                }
            }
        }
    }
}