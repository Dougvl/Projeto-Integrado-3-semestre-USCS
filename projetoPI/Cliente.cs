using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoPI
{
    public  class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }

        //public Cliente(string nome, string cpf, string telefone, string email, Endereco endereco)
        //{
        //    this.Nome = nome;
        //    this.Cpf = cpf;
        //    this.Telefone = telefone;
        //    this.Email = email;
        //    this.Endereco = endereco;
        //}
    }
}
