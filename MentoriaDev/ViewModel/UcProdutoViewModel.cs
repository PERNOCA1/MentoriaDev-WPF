using MentoriaDev.View.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDev.ViewModel
{
    public class UcProdutoViewModel : PropertyChange
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

        private decimal _valor;
        public decimal Valor
        {
            get => _valor;
            set
            {
                _valor = value;
                OnPropertyChanged(nameof(Valor));
            }
        }

        private bool _altecao;
        public bool Altecao
        {
            get => _altecao;
            set
            {
                _altecao = value;
                OnPropertyChanged(nameof(Altecao));
            }
        }

        private ObservableCollection<ProdutoViewModel> _produtosAdicionados;
        public ObservableCollection<ProdutoViewModel> ProdutosAdicionados
        {
            get => _produtosAdicionados;
            set
            {
                _produtosAdicionados = value;
                OnPropertyChanged(nameof(ProdutosAdicionados));
            }
        }
    }
}
