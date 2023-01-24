using System;

namespace MentoriaDevSti3.Data.Entidades
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set;}
        public string Cidade { get; set; }
    }
}
