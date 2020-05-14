using System;
namespace E2
{
    public class Pintor:Contratistas
    {
        private int horasDeTrabajo=0;
        private int sueldo=0;

        public Pintor()
        {
            this.sueldo = 0;
        }

        public void trabajar(int horasTrabajadas){
            horasDeTrabajo += horasTrabajadas;
        }
        public int cobrar(){
            sueldo = 150*horasDeTrabajo;
            return sueldo;
        }
    }
}