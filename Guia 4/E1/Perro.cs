namespace E1
{
    public class Perro : Animal
    {
        public Perro() : base()
        {
        }
        public override void comer() => energia += 15;
        public override void jugar() => energia -= 20;
    }
}