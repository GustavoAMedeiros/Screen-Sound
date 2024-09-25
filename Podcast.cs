using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Podcast
    {
        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
        }

        public string Host { get; }
        public string Nome { get; }
        public int totalEpisodios => episodios.Count;
        public List<Episodios> episodios = new List<Episodios>(); 

        public void AdicionarEpisodio(Episodios episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast: {Nome} apresentado por {Host}\n");
            Console.WriteLine("Nossos episódios até agora:\n");

            foreach(Episodios episode in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine($"Episódio: {episode.Resumo}");
            }

            Console.WriteLine($"\nEsse podcast possui {totalEpisodios} episódios.");
        }  
    }
}
