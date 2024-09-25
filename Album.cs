using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Album
    {
        List<Musica> musicas = new List<Musica>();

        public Album(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do album {Nome}:\n ");

            foreach (var musica in musicas)
            {
                Console.WriteLine(musica.Nome);
            }

            Console.WriteLine($"\nEsse álbum possui um total de {DuracaoTotal} segundos.");
        }
    }
}
