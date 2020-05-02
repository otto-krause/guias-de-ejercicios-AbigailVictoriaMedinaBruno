using System;
using System.Collections.Generic;
namespace E2
{
    public class Clinica
    {
        public List<Medico> medicos = new List<Medico>();
        Medico gustavo = new Medico("Gustavo","Parelli","Pediatria",32);
        Medico patricia = new Medico("Patricia","White","Pediatria",100);
        Medico luciano = new Medico("Luciano","Maddox","Obstetricia",45);
        Medico mariano = new Medico("Mariano","Ester","Obstetricia",30);
        Medico federico = new Medico("Federico","Micelo","Odontologia",60);
        Medico pablo = new Medico("Pablo","Serreno","Odontologia",70);
        public Clinica(){
            medicos.Add(gustavo);
            medicos.Add(patricia);
            medicos.Add(luciano);
            medicos.Add(mariano);
            medicos.Add(federico);
            medicos.Add(pablo);
        }
        public Medico buscarMedico(string especialidad1){
            foreach (Medico i in medicos)
            {
                if(i.Especialidad==especialidad1 && i.estaDisponible()){
                    i.asignarTurno();
                    return i;
                }
            }
            return null;
        }


    }
}