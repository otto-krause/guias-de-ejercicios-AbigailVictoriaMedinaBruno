namespace Ejercicio
{
    public class Sable : Arma
    {
        public Sable(int potencia, int desgaste) : base(potencia, desgaste)
        {
        }

        public override int poder(){
            return potencia * desgaste * 2;
        }
        public override void usar(){
            desgaste += 1;
        }
    }
}