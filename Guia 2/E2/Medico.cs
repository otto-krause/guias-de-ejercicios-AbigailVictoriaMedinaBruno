namespace E2
{
    public class Medico
    {
        private string nombre;
        public string Nombre { get => nombre;}
        private string apellido;
        public string Apellido { get => apellido; }
        private string especialidad;
        public string Especialidad { get => especialidad;}
        private int cantidadDeTurnos=0;
        public int CantidadDeTurnos { get => cantidadDeTurnos;}

        public Medico(string nombre,string apellido,string especialidad,int cantidadDeTurnos){
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidadDeTurnos=cantidadDeTurnos;
        }

        public bool estaDisponible(){
            return cantidadDeTurnos<50;
        }

        public void asignarTurno(){
            cantidadDeTurnos++;
        }

    }
}