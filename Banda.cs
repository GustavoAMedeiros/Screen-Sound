using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Banda
    {
        List<Album> albuns = new List<Album>();

        public Banda(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void Discografia()
        {
            Console.WriteLine($"Exibindo os albuns da banda: {Nome}");

            foreach(Album album in albuns)
            {
                Console.WriteLine($"\nAlbum: {album.Nome} ({album.DuracaoTotal})");
            }
        }
    }
}
