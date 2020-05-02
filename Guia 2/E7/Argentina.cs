using System;
using System.Collections.Generic;
namespace E7
{
    public class Argentina
    {
        List<Alfajor> alfajores = new List<Alfajor>();

        public List<Alfajor> Alfajores { get => alfajores;}

        public Argentina(){
            Alfajor fulbito1 = new Alfajor("Dulce de leche","fulbito",30);
            Alfajor jorgito1 = new Alfajor("Chocolate","jorgito",40);
            Alfajor waymayen1 = new Alfajor("Triple fruta","waymayen",100);
            alfajores.Add(fulbito1);
            alfajores.Add(jorgito1);
            alfajores.Add(waymayen1);
        }
        public void bajarElPrecioDelPetroleo(){
            foreach(Alfajor i in alfajores){
                i.Precio+=80;
            }
        }
        public void millaiHablaPorTv(){
            foreach(Alfajor i in alfajores){
                i.Precio*=2;
            }
        }
        public void coronaVairas(){
            foreach(Alfajor i in alfajores){
                if(i.Empresa!="waymayen")
                    i.Precio+=1000;
            }
        }
        public string estadoInflacion(){
            int total=0;
            string inflacion;
            foreach(Alfajor i in alfajores){
                total+=i.Precio;
            }
            return inflacion = total<500 ? "normal" : total>=500 && total<=1000 ? "super" : "hyper";
        }
        public bool siDefault(){
            return estadoInflacion() == "hyper" && alfajores.Count == 1;
        }
    }
}