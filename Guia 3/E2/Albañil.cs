using System;
namespace E2
{
    public class Albañil:Contratistas
    {
        private int horasDeTrabajo=0;
        private int sueldo=0;
        private int edad=0;
        private bool tituloMMO;

        public Albañil(int edad,bool tituloMMO)
        {
            this.edad = edad;
            this.tituloMMO = tituloMMO;
        }
        public void trabajar(int horasTrabajadas){
            horasDeTrabajo += horasTrabajadas;
        }
        public int cobrar(){
            if(edad>20 && edad<30)
                sueldo = horasDeTrabajo*50;
            else
            {
                if(edad>30 && edad<50)
                    sueldo = horasDeTrabajo*90;
                else
                    sueldo = horasDeTrabajo*120;
            } 
            sueldo = tituloMMO ? sueldo+50 : sueldo+0 ;
            return sueldo;
        } 
    }
}