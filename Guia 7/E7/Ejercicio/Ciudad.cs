namespace Ejercicio
{
    public class Ciudad
    {
        LaLuna laLuna;
        SueroMutante sueroMutante;
        Piramide piramide;  
        int temperatura;
        public int Temperatura{get => temperatura;}
        public Ciudad(LaLuna laLuna,SueroMutante sueroMutante,Piramide piramide,int temperatura)
        {
            
        }
        public void ciudadFria(){
            temperatura-=30;
        }
    }
}