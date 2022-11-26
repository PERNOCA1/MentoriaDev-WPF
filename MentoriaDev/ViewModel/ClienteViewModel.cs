using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentoriaDev.ViewModel
{
    public class ClienteViewModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }

    }
}
