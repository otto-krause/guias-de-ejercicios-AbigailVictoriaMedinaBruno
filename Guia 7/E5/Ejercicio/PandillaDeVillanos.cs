using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class PandillaDeVillanos

    {
        List<Villano> todosLosVillanos;
        public PandillaDeVillanos(List<Villano> todosLosVillanos)
        {
            this.todosLosVillanos = todosLosVillanos;
        }

        public List<Villano> TodosLosVillanos { get => todosLosVillanos;}

        public int poderDeQuirk(){
            return todosLosVillanos.Sum(villano => villano.poderDeQuirk());
        }
        public int villanoParticipantes(){
            return todosLosVillanos.Count();
        }
    }
}