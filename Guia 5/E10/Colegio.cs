using System;
using System.Collections.Generic;
using System.Linq;
namespace E10
{
    public class Colegio
    {
        ExAlumno ricardo,maria,mariano,lucia,lucas,abigail,fabrizio,karenina,pablo,patricia,lucio,lere;
        List<ExAlumno> losExalumnos;
        /*Un colegio realiza reuniones de ex compañeros de secundaria,
         de los cuales quiere recolectar información. Los compañeros son:
            Políglotas: cuando hablan más de 5 idiomas.
            Bilingües: hablan al menos 2 idiomas.
            Exitosos: cuando ganan más de 200000 al mes.
            Viajeros: cuando visitaron más de 4 países.
            El colegio quiere saber si el curso fueExitoso,
             esto sucede cuando más de 5 exalumnos son exitosos, más de 3 son viajeros,
             todos son bilingües y hay por lo menos un políglota.
            */
        public Colegio()
        {
            ricardo = new ExAlumno(6,200300,21);
            maria = new ExAlumno(2,30042,8);
            mariano = new ExAlumno(2,10000,0);
            lucia = new ExAlumno(2,23000,3);
            lucas = new ExAlumno(3,340000,6);
            abigail = new ExAlumno(2,300000,4);
            fabrizio = new ExAlumno(6,300000,9);
            karenina = new ExAlumno(3,300000,7);
            pablo = new ExAlumno(2,400000,2);
            patricia = new ExAlumno(2,309900,0);
            lucio = new ExAlumno(2,20000,1);
            lere = new ExAlumno(8,2000000,34);
            losExalumnos = new List<ExAlumno>{ricardo,maria,mariano,lucia,lucas,abigail,fabrizio,
            karenina,pablo,patricia,lucio,lere};
        }
        public bool fueExitoso(){
            return losExalumnos.Where(exalumno => exalumno.Sueldo > 200000).ToList().Count() > 5 &&
            losExalumnos.Where(exalumno => exalumno.Viajes > 4).ToList().Count() > 5 && 
            losExalumnos.All(exalumno => exalumno.IdiomasEstuadiados >= 2) &&
            losExalumnos.Any(exalumno => exalumno.IdiomasEstuadiados > 5);
        }
    }
}