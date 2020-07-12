using System;
using System.Linq;
using System.Collections.Generic;
namespace E7
{
    public class Cuenta
    {
        string nombreCompleto;
        List<string> amigos;
        List<string> publicaciones;
        List<Foto> albumDeFotos;

        public Cuenta(string nombreCompleto, List<string> amigos, List<string> publicaciones, List<Foto> albumDeFotos)
        {
            this.nombreCompleto = nombreCompleto;
            this.amigos = amigos;
            this.publicaciones = publicaciones;
            this.albumDeFotos = albumDeFotos;
        }

        public List<string> Amigos { get => amigos; }
        public List<string> Publicaciones { get => publicaciones; }
        public List<Foto> AlbumDeFotos { get => albumDeFotos; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}