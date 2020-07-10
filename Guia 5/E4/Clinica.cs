using System;
using System.Collections.Generic;
using System.Linq;
namespace E4
{
    public class Clinica
    {
        public List<Medico> medicos;
        Medico gustavo;
        Medico patricia;
        Medico luciano;
        Medico mariano;
        Medico federico;
        Medico pablo;
        public Clinica(){
            gustavo = new Medico("Gustavo","Parelli","Pediatria",32);
            patricia = new Medico("Patricia","White","Pediatria",100);
            luciano = new Medico("Luciano","Maddox","Obstetricia",45);
            mariano = new Medico("Mariano","Ester","Obstetricia",30);
            federico = new Medico("Federico","Micelo","Odontologia",60);
            pablo = new Medico("Pablo","Serreno","Odontologia",70);
            medicos = new List<Medico>{gustavo,patricia,luciano,mariano,federico,pablo};
        }
        public Medico buscarMedico(string especialidad1){
            List <Medico> medicosElegidos;
            Medico medicoAux;
            medicosElegidos = medicos.Where(Medico => Medico.Especialidad == especialidad1 && Medico.estaDisponible()).
            ToList();
            return medicoAux = medicosElegidos.Count() > 0 ? medicosElegidos.First() : null;
            
        }


    }
}