using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Localização da classe no projeto
namespace Projeto01.Entities
{
    //Declaração da classe
    public class Cliente
    {
        //Declaração de atributos da classe
        private Guid? _idCliente;
        private string? _nome;
        private string? _email;
        private string? _cpf;

        //Método de encapsulamento/Properties(Set e Get)
        public Guid? IdCliente
        {
            set { _idCliente = value; } //Entrada de dados (Set)
            get { return _idCliente; } //Saida de dados (Get)
        }

        public string? Nome
        {
            set { _nome = value; } //Entrada de dados (Set)
            get { return _nome; } //Saida de dados (Get)
        }

        public string? Cpf
        {
            set { _cpf = value; } //Entrada de dados (Set)
            get { return _cpf; } //Saida de dados (Get)
        }

        public string? Email
        {
            set { _email = value; } //Entrada de dados (Set)
            get { return _email; } //Saida de dados (Get)
        }


    }
}
