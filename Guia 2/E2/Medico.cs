namespace E2
{
    public class Medico
    {
        string nombre, apellido, especialidad;
        int cantidadDeTurnos=0;
        public Medico(string nombre,string apellido,string especialidad,int cantidadDeTurnos){
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantidadDeTurnos=cantidadDeTurnos;
        }
        public bool estaDisponible(){
            return cantidadDeTurnos<50;
        }
        
    }
}