using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Persona
    {
        DateTime fechaDeNacimiento;
        double felicidad;
        List<Emocion> emociones;
        List<Recuerdo> listaDeRecuerdos;
        List<Recuerdo> pensamientoCentral; 
        List<Recuerdo> memoriaALargoPlazo; 
        List<Recuerdo> recuerdosDelDia;
        public List<Recuerdo> ListaDeRecuerdos{get => listaDeRecuerdos;}
        public List<Recuerdo> PensamientoCentral{get => pensamientoCentral;}
        public List<Emocion> Emociones{get => emociones;}
        public Persona(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.felicidad = 1000;
            listaDeRecuerdos = new List<Recuerdo>();     
            pensamientoCentral = new List<Recuerdo>();  
            memoriaALargoPlazo = new List<Recuerdo>();   
            recuerdosDelDia = new List<Recuerdo>();
            emociones = new List<Emocion>{new Emocion("Alegría",true),new Emocion("Tristeza",false),new Emocion("Disgusto",false)
            ,new Emocion("Furia",false),new Emocion("Temor",false)};
         }
        public void cambiarDeEmocion(){
            var rnd = new Random();
            Emocion emocionAux = emociones.Where(e => e.EsDominante).ToList().First();
            emocionAux.cambio();
            emociones[rnd.Next(0,4)].cambio();
        }
        public void crearRecuerdo(string descripcion){
            Recuerdo recuerdoNuevo = new Recuerdo(descripcion,emociones.Where(e => e.EsDominante).ToList().First());
            listaDeRecuerdos.Add(recuerdoNuevo);
        }
        public void asentarRecuerdo(Recuerdo recuerdoDelDia,string palabraClave){
            if(recuerdoDelDia.Descripcion.Contains(palabraClave));
            {    
                switch(recuerdoDelDia.EmocionDominanteMomento.Nombre){
                    case "Alegría":
                        if(felicidad>500){
                            pensamientoCentral.Add(recuerdoDelDia);
                            recuerdoDelDia.recuerdoSeHaceCentral();
                            }
                        break;
                    case "Triteza":
                            pensamientoCentral.Add(recuerdoDelDia);
                            recuerdoDelDia.recuerdoSeHaceCentral();
                            felicidad -= ((felicidad*10)/100);
                            if(felicidad<1){
                                throw new Exception("Error. La felicidad quedo en números menores a 1.");
                            }
                        break;
                    default:break;
                }
            }
        }
        public List<Recuerdo> recuerdosRecientesDelDia(){
            if(listaDeRecuerdos.Count()<5)
                return listaDeRecuerdos;
            return listaDeRecuerdos.TakeLast(5).ToList();
        }
        public List<Recuerdo> pensamientosCentrales(){
            pensamientoCentral.Distinct().ToList();
            return pensamientoCentral;
        }
        public List<Recuerdo> pensamientosCentralesDificilesDeExplicar(){
            return pensamientoCentral.Where(recuerdo => recuerdo.Descripcion.Split().Count()>10).ToList();
        }
        public bool negarRecuerdo(Recuerdo recuerdoAux){
            switch(emociones.Where(i => i.EsDominante).ToList().First().Nombre){
                case "Alegría":
                    return recuerdoAux.EmocionDominanteMomento.Nombre != "Alegría";
                case "Triteza":
                    return recuerdoAux.EmocionDominanteMomento.Nombre == "Alegría";
                default:return false;
            }
        }
        private void profundizacion(){
            foreach (Recuerdo r in recuerdosDelDia)
            {
                if(!(r.EsCentral) && !(negarRecuerdo(r)))
                    memoriaALargoPlazo.Add(r);
            }
        }
        private void ControlHormonal(){
            Emocion emocionAux = recuerdosDelDia[0].EmocionDominanteMomento;
            if(memoriaALargoPlazo.Any(r => r.EsCentral) || recuerdosDelDia.All(r => r.EmocionDominanteMomento == emocionAux))
            { 
                felicidad -= (felicidad*0.15);
                if(pensamientoCentral.Count()>3){
                    pensamientoCentral.RemoveAt(0);
                    pensamientoCentral.RemoveAt(0);
                    pensamientoCentral.RemoveAt(0);
                }else
                    pensamientoCentral.Clear();
            }
            
        }
        /*Restauración cognitiva: se restauran hasta 100 puntos de felicidad (nunca se superan los 1000)
Liberación de recuerdos del día: todos los recuerdos del día se liberan, es decir, dejan de ser recuerdos del día. Este proceso siempre es el último en ocurrir. 
*/
        private void restauracionCognitiva(){
            if(felicidad>900)
                felicidad = 1000;
            else
                felicidad += 100;
        }

        public void dormir(string palabraClave1){
            recuerdosDelDia = listaDeRecuerdos.Where(r => r.FechaActual == DateTime.Today).ToList();
            listaDeRecuerdos.ForEach(i => Console.WriteLine(i.fechaActual));
            Console.WriteLine(DateTime.Today);
            recuerdosDelDia.ForEach(i => asentarRecuerdo(i,""));
            recuerdosDelDia.ForEach(i => asentarRecuerdo(i,palabraClave1));
            profundizacion();
            ControlHormonal();
            restauracionCognitiva();
            recuerdosDelDia.Clear();
        }

    }
}