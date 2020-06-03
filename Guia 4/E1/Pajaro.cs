namespace E1
{
    public class Pajaro : Animal
    {
        public Pajaro() : base()
        {
        }
        public override void comer() => energia += 10;
        public override void jugar() => energia -= 5;
    }
}