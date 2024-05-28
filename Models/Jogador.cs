using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Models
{
    public sealed class Jogador
    {
        public sealed Jogador
        {
            public string Nome { get; set; }
            public Opcao Escolha { get; set; }
            public int Pontuacao { get; set; }


        public Jogador(string nome)
        {
            Nome = nome;
            Pontuacao = 0;
            Escolha = new Opcao();
        }
     
    }
}
