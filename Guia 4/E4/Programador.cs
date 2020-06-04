namespace E4
{
    public class Programador : Empleado
    {
        string tipoDeProgramador;

        public Programador(string tipoDeProgramador) : base()
        {
            this.tipoDeProgramador = tipoDeProgramador;
        }
        public override void depositar(int numero){
            cajaBancaria += 20000;
            switch(tipoDeProgramador){
                case "junior": cajaBancaria += 10000;
                    break;
                case "semiSenior": cajaBancaria += 20000;
                    break;
                case "senior": cajaBancaria += 40000;
                    break;
                default: 
                    break;
            }
        }
    }
}