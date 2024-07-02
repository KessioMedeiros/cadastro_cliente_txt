using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    //Declaração de classe
    public class ClienteRepository
    {
        //Método para fazer o fluxo de dados do cliente (Gravar dados)
        public void Exportar(Cliente cliente)
        {
            //variavel para verificar o caminho onde o arquivo será gravado
            var path = "c:\\temp\\";
            //Verificando se o diretório existe
            if (!Directory.Exists(path))
                //Criando o diretório caso ele não exista
                Directory.CreateDirectory(path);

            //Abrino o arquivo em modo de escrita
            var streamWriter = new StreamWriter(path + "Clientes.txt", true);

            //Escrevendo o conteudo
            streamWriter.WriteLine("ID........: " + cliente.IdCliente);
            streamWriter.WriteLine("NOME......: " + cliente.Nome);
            streamWriter.WriteLine("CPF.......: " + cliente.Cpf);
            streamWriter.WriteLine("EMAIL.....: " + cliente.Email);

            streamWriter.Close();
        }   
    }
}
