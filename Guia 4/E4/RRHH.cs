namespace E4
{
    public class RRHH : Empleado
    {

        public RRHH() : base()
        {
        }
        public override void depositar(int personaReferida){
            cajaBancaria += 5000 + (5000 * personaReferida);
        }
    }
}