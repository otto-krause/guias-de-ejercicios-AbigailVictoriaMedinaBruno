namespace Ejercicio
{
    public class QuirkNormal : Quirk
    {/*
        int tiempoDeUso;
        string nombre;*/
        public QuirkNormal(string nombre, bool tieneConsecuencias,int tiempoDeUso) : base(tiempoDeUso)
        {
            this.nombre = nombre;
            this.tieneConsecuencias = tieneConsecuencias;
        }
    }
}