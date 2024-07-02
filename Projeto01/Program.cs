//Localização da classe no projeto
using Projeto01.Controllers;
using Projeto01.Entities;
using System.Runtime.CompilerServices;

namespace Projeto01 {

    //Declaração da classe
    public class Program
    {   
        //Método (função) para inicializar o projeto
        public static void Main(string[] args)
        {
            var clienteController = new ClienteController();
            clienteController.CadastrarCliente();
        }
    }
}