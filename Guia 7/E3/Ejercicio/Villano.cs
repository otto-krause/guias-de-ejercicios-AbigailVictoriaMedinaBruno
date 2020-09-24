namespace Ejercicio
{
    public interface Villano
    {
        public int fuerza();
        public void cometerCrimen(CiudadGotica ciudad);
        public int cuantosVillanosSon();
        public void peleaConBatman(string comoMeDejoBatman);
        public bool estaProfugo();
    }
}