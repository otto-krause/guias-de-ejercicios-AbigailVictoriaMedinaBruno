using System;
namespace E1
{
    public class Planta
    {
        private int barrasDeUranio;
        MrBurns burns;
        private Empleado empleado;

        public Planta(int barrasDeUranio, Empleado empleado, MrBurns burns)
        {
            this.barrasDeUranio = barrasDeUranio;
            this.burns = burns;
            this.empleado = empleado;
        }

        public bool estaEnPeligro(){
            return (barrasDeUranio > 10000 && empleado.estaDistraido())
                    || !burns.esMillonario();
        }

        public void CambiarEmpleado(Empleado nuevoEmpleado){
            empleado = nuevoEmpleado;
        }
        public void llegaCargamento(int uranio){
            barrasDeUranio+=uranio;
            Console.WriteLine(barrasDeUranio);
        }
    }
}