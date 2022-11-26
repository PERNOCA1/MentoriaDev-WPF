using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDev.ViewModel
{
    public class UcClienteViewModel : PropertyChange
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        private DateTime _dataNascimento;
        public DateTime DataNascimento
        {
            get => _dataNascimento;
            set
            {
                _dataNascimento = value;
                OnPropertyChanged(nameof(DataNascimento));
            }
        }

        private int _cep;
        public int Cep
        {
            get => _cep;
            set
            {
                _cep = value;
                OnPropertyChanged(nameof(Cep));
            }
        }

        private string _endereco;
        public string Endereco
        {
            get => _endereco; 
            set
            {
                _endereco = value;
                OnPropertyChanged(nameof(Endereco));
            }
        }

        private string _cidade;
        public string Cidade
        {
            get => _cidade;
            set
            {
                _endereco = value;
                OnPropertyChanged(nameof(Cidade));
            }
        }

        private bool _alteracao;
        public bool Alteracao
        {
            get => _alteracao;
            set
            {
                _alteracao = value;
                OnPropertyChanged(nameof(Alteracao));
            }
        }

        private ObservableCollection<ClienteViewModel> _clienteAdicionados;
        public ObservableCollection<ClienteViewModel> ClienteAdicionados
        {
            get => _clienteAdicionados;
            set
            {
                _clienteAdicionados = value;
                OnPropertyChanged(nameof(ClienteAdicionados));
            }
        }
    }
}
