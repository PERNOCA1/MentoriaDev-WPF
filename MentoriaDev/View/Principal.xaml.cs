using MentoriaDev.View.UserControls;
using MentoriaDevSti3.Data.Context;
using MentoriaDevSti3.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MentoriaDev.View
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
            Testes();
        }

        private void Testes()
        {
            using var context = new MentoriaDevSTI3Context();

            //context.Database.EnsureCreated();

            //     context.Clientes.Add(new Cliente 
            //     {
            //         Nome = "Tiago",
            //         Cep = "17204222",
            //         Cidade = "Jaú",
            //         DataNascimento = DateTime.Now,
            //         Endereco = "Rua sem saída",
            //     });

            
            var cliente = context.Clientes.First(x => x.Id == 1);
            
            context.Clientes.Remove(cliente); 

            context.SaveChanges();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            InicializarUc(sender);
        }

        private void InicializarUc(object sender)
        {
            if(sender is Button btn)
            {
                switch (btn.Name)
                {
                    case nameof(BtnProdutos):
                        Conteudo.Content = new UcProdutos();
                        break;

                    case nameof(BtnClientes):
                        Conteudo.Content = new UcClientes();
                        break;

                    case nameof(BtnPedido):
                        Conteudo.Content = new UcPedido();
                        break;

                    default:
                        break;
                }
            }
        }

        
    }
}
