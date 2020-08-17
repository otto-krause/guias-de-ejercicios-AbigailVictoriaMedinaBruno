namespace Ejercicio
{
    public class Blaster : Arma
    {
        public Blaster(int potencia, int desgaste) : base(potencia, desgaste)
        {
        }
        public override int poder(){
            return potencia > desgaste ? potencia - desgaste : 1 ;
        }
        public override void usar(){
            desgaste += 1;
            potencia -= 1;
        }
    }
}