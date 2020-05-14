using System;
using System.Collections.Generic;
namespace E2
{
    public class EmpresaConstructora
    {
        List<Contratistas> contratistas = new List<Contratistas>();
        
        int presupuesto=0;
        int cantidadDeHorasDeTrabajo=0;

        int presupuestoTotal=0;

        public EmpresaConstructora(int presupuesto, int cantidadDeHorasDeTrabajo)
        {
            this.presupuesto = presupuesto;
            this.cantidadDeHorasDeTrabajo = cantidadDeHorasDeTrabajo;
            contratistas.Add(new Albañil(23,true));
            contratistas.Add(new Albañil(31,false));
            contratistas.Add(new Albañil(45,true));
            contratistas.Add(new Albañil(54,true));
            contratistas.Add(new Albañil(65,false));
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Pintor());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            contratistas.Add(new Plomero());
            
        }
        public bool sePuedeRealizarElProyecto(){ 
            foreach(Contratistas aux in contratistas){
                aux.trabajar(cantidadDeHorasDeTrabajo);
                presupuestoTotal += aux.cobrar();
            }
            return presupuesto == presupuestoTotal || presupuesto>presupuestoTotal;
        }

    }
}