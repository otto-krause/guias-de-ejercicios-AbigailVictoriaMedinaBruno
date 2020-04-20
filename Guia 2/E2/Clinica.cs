namespace E2
{
    public class Clinica
    {
        List<Medico> medicos=new System.Collections.Generic.List<Medico>();
        public Clinica(){
            
            Medico gustavo = new Medico("Gustavo","Parelli","Pediatria",32);
            Medico patricia = new Medico("Patricia","White","Pediatria",100);
            Medico luciano = new Medico("Luciano","Maddox","Obstetricia",45);
            Medico federico = new Medico("Federico","Micelo","Odontologia",60);
            medicos.Add(gustavo);
            medicos.Add(patricia);
            medicos.Add(luciano);
            medicos.Add(federico);
        }
        


    }
}