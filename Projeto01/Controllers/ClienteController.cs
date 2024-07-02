using Projeto01.Entities;
using Projeto01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Controllers
{
    public class ClienteController
    {
        //Método para fazer fluxo de dados de cadastrar cliente (Void pois não precisa retornar nada)
        public void CadastrarCliente()
        {
            Console.WriteLine("\tCADASTRO DE CLIENTE");

            var cliente = new Cliente();

            cliente.IdCliente = Guid.NewGuid();

            Console.Write("INFORME O NOME DO CLIENTE....: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE...: ");
            cliente.Email = Console.ReadLine();

            Console.Write("INFORME O CPF DO CLIENTE.....: ");
            cliente.Cpf = Console.ReadLine();

            Console.WriteLine("DADOS DO CLIENTE: ");
            Console.WriteLine("ID......: " + cliente.IdCliente);
            Console.WriteLine("Nome....: " + cliente.Nome);
            Console.WriteLine("Email...: " + cliente.Email);
            Console.WriteLine("Cpf.....: " + cliente.Cpf);
            
            //Exportar os dados gravados
            var clienteReposity = new ClienteRepository();
            clienteReposity.Exportar(cliente);

            Console.WriteLine("DADOS GRAVADOS COM SUCESSO!");

            Console.ReadKey();
        }
    }
}
