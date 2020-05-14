using System;
namespace E2
{
    public class Plomero:Contratistas
    {
        private int horasDeTrabajo=0;
        private int sueldo=0;

        public Plomero()
        {
            this.sueldo = 0;
        }

        public void trabajar(int horasTrabajadas){
            horasDeTrabajo += horasTrabajadas;
        }
        public int cobrar(){
            sueldo = 80*horasDeTrabajo;
            return sueldo;
        }
    }
}