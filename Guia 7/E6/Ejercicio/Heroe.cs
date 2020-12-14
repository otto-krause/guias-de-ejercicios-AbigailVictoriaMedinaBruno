namespace Ejercicio
{
    public class Heroe
    {
        Quirk quirkHeroe;
        int victorias;
        int derrotas;
        string permiso;

        public Quirk QuirkHeroe { get => quirkHeroe; }
        public int Victorias { get => victorias;}
        public int Derrotas { get => derrotas;}
        public string Permiso { get => permiso;}

        public Heroe(Quirk quirkHeroe)
        {
            this.quirkHeroe = quirkHeroe;
            victorias = 0;
            derrotas = 0;
            permiso = "licencia de heroe";
        }

        public void vencerAUnVillano(Villano villano){
            if(quirkHeroe.poder()>villano.poderDeQuirk())
                victorias++;
            else 
                derrotas++; 
        }
        public void vencerAUnaPandillaVillano(PandillaDeVillanos pandillavillano){
            if(quirkHeroe.poder()>pandillavillano.poderDeQuirk()){
                victorias += pandillavillano.villanoParticipantes();
            }
            permiso = "acta de defuncion";
        }
    }
}