using System;

using System.Threading;

namespace Farmacia

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int opcao = 0;

            while (opcao != 5)

            {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(@"

███████╗░█████╗░██████╗░███╗░░░███╗░█████╗░░█████╗░██╗░█████╗░

██╔════╝██╔══██╗██╔══██╗████╗░████║██╔══██╗██╔══██╗██║██╔══██╗

█████╗░░███████║██████╔╝██╔████╔██║███████║██║░░╚═╝██║███████║

██╔══╝░░██╔══██║██╔══██╗██║╚██╔╝██║██╔══██║██║░░██╗██║██╔══██║

██║░░░░░██║░░██║██║░░██║██║░╚═╝░██║██║░░██║╚█████╔╝██║██║░░██║

╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝╚═╝░░╚═╝

");

                Console.ResetColor();

                Console.WriteLine("\nBem vindo ao Sistema da Farmácia\n");

                Console.WriteLine("1 - Cadastrar medicamentos");

                Console.WriteLine("2 - Cadastrar clientes");

                Console.WriteLine("3 - Cadastrar funcionários");

                Console.WriteLine("4 - Cadastrar fornecedores");

                Console.WriteLine("5 - Sair");

                Console.Write("\nDigite a opção: ");

                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)

                {

                    case 1:

                        CadastrarMedicamentos();

                        break;

                    case 2:

                        CadastrarClientes();

                        break;

                    case 3:

                        CadastrarFuncionarios();

                        break;

                    case 4:

                        CadastrarFornecedores();

                        break;

                    case 5:

                        Console.WriteLine("Saindo do sistema...");

                        break;

                    default:

                        Console.WriteLine("Opção inválida!");

                        Thread.Sleep(1500);

                        break;

                }

            }

        }

        static void CadastrarMedicamentos()

        {

            Console.WriteLine("\n=== CADASTRO DE MEDICAMENTOS ===\n");

            Console.Write("Nome do medicamento: ");

            string nome = Console.ReadLine();

            Console.Write("Descrição: ");

            string descricao = Console.ReadLine();

            Console.Write("Preço: ");

            string preco = Console.ReadLine();

            Console.Write("Quantidade: ");

            string quantidade = Console.ReadLine();

            Console.WriteLine("\nMedicamento cadastrado com sucesso!");

            Thread.Sleep(1500);

        }

        static void CadastrarClientes()

        {

            Console.WriteLine("\n=== CADASTRO DE CLIENTES ===\n");

            Console.Write("Nome do cliente: ");

            string nome = Console.ReadLine();

            Console.Write("CPF do cliente: ");

            string cpf = Console.ReadLine();

            Console.Write("Telefone do cliente: ");

            string telefone = Console.ReadLine();

            Console.WriteLine("\nCliente cadastrado com sucesso!");

            Thread.Sleep(1500);

        }

        static void CadastrarFuncionarios()

        {

            Console.WriteLine("\n=== CADASTRO DE FUNCIONÁRIOS ===\n");

            Console.Write("Nome do funcionário: ");

            string nome = Console.ReadLine();

            Console.Write("Função do funcionário: ");

            string funcao = Console.ReadLine();

            Console.Write("Salário: ");

            string salario = Console.ReadLine();

            Console.WriteLine("\nFuncionário cadastrado com sucesso!");

            Thread.Sleep(1500);

        }

        static void CadastrarFornecedores()

        {

            Console.WriteLine("\n=== CADASTRO DE FORNECEDORES ===\n");

            Console.Write("Nome do fornecedor: ");

            string nome = Console.ReadLine();

            Console.Write("CNPJ: ");

            string cnpj = Console.ReadLine();

            Console.Write("Telefone: ");

            string telefone = Console.ReadLine();

            Console.Write("Marca: ");

            string marca = Console.ReadLine();

            Console.WriteLine("\nFornecedor cadastrado com sucesso!");

            Thread.Sleep(1500);

        }

    }

}
