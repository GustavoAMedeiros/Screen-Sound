using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    public class Episodios
    {
        public Episodios(int ordem, string titulo, float duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
            Ordem = ordem;
        }
        public float Duracao { get;}
        public int Ordem { get; }
        public string Titulo { get;}
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

        private List<string> convidados = new List<string>();

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}
