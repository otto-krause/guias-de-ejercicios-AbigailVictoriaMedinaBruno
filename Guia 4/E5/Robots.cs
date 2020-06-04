namespace E5
{
    public class Robots : SerPensante
    {
        public Robots() : base()
        {
        }

        public override void estudiar(string conocimientoNuevo){
            listaDeConocimientos.Add(conocimientoNuevo);
        }
    }
}