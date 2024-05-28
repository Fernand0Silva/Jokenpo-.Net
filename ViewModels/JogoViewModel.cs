using Android.App;
using CommunityToolkit.Mvvm.ComponentModel;
using Jokenpo.Models;
using Jokenpo.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.ViewModels
{
    public partial class JogoViewModel : ObservableObject
    {
       /* public JogoViewModel()  
        {
        }*/
        [ObservableProperty]
        public string _nome; // private string _name
        [ObservableProperty]
        public string _escolha; // private Jogador _jogador
        [ObservableProperty]
        public int _pontuacao; // private Jogador _maquina private Opcao _escolha private string _result
        [ObservableProperty]
        public string _resultado;
                             
        public Icommand MakeChoiceCommand { get; }

       
        public JokenPoViewModel()
        { 
            Jogador = new Jogador(Nome)
            Maquina = new Jogador("Máquina");
            MakeChoiceCommand = new Command(MakeChoice);
        }
        private void MakeChoice()
        {
            Jogador.Nome = Nome;
            Jogador.Escolha = _escolha;
            Maquina.Escolha = (Opcao)new Random().Next(0, 3);
            DetermineWinner();
            Pontuacao = Jogador.Pontuacao;
        }
        private void DetermineWinner()
        {
            if (Jogador.Escolha == Maquina.Escolha)
            {
                Jogador.Pontuacao++;
                Maquina.Pontuacao++;
                Result = "Empate!";
            }
            else if ((Jogador.Escolhar == Opcao.PEDRA && Maquina.Escolha == Opcao.TESOURA) ||
                    (Jogador.Escolha == Opcao.PAPEL && Maquina.Escolha == Opcao.PEDRA) ||
                    (Jogador.Escolha == Opcao.Tessoura && MAQUINA.ESCOLHA == Opcao.PAPEL)
            {
                Jogador.Pontuacao += 3;
                Result = $"{Jogador.Nome} Venceu";
            }
            else
            {

            }
        }
    }
}
