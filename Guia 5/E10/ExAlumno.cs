namespace E10
{
    public class ExAlumno
    {
        int idiomasEstuadiados = 0;
        double sueldo = 0;
        int viajes = 0;

        public ExAlumno(int idiomasEstuadiados, double sueldo, int viajes)
        {
            this.idiomasEstuadiados = idiomasEstuadiados;
            this.sueldo = sueldo;
            this.viajes = viajes;
        }

        public int IdiomasEstuadiados { get => idiomasEstuadiados; }
        public double Sueldo { get => sueldo; }
        public int Viajes { get => viajes; }
    }
}