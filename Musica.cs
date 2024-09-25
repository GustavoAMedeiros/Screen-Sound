using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Musica
    {

        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome { get;}
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public string DescricaoResumida => $"A música {Nome} é do artista {Artista}";


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");

            if (Disponivel)
            {
                Console.WriteLine($"A música {Nome} está disponível no seu plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano Premium");
            }
        }
    }
}
