using Curso_C_;
using Curso_C_.ParadigmasOO;
using System;
using System.Collections.Generic;

//Programa Biblioteca e Programa Veiculo

/*
namespace BibliotecaVeiculos
{  
 
     *  class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }    

}
*/

/*

// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();

*/

/*
// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();
*/

/*
// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();
*/

/*
// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();
*/

/*
// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();
*/

/*
AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();
*/

//// Criando instâncias de classes que implementam a interface
//IAnimal cachorro = new CachorroInter("Rex");
//IAnimal gato = new GatoInter("Mimi");

//// Exibindo informações e sons dos animais
//cachorro.ExibirInformacoes();
//cachorro.FazerSom();

//gato.ExibirInformacoes();
//gato.FazerSom();

//// Explicando o conceito de interface
//ExplicadorDeInterface explicador = new ExplicadorDeInterface();
//explicador.ExplicarInterface()

/*
var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SistemaGerenciamentoSalaoBeleza
{
    class Program
    {
        static List<Servico> servicos = new List<Servico>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<PrestacaoServico> prestacoes = new List<PrestacaoServico>();

        static string caminhoServicos = @"C:\Users\Aluno Noite\Downloads\Curso-C--master\Curso-C--master\servicos.json";
        static string caminhoClientes = @"C:\Users\Aluno Noite\Downloads\Curso-C--master\Curso-C--master\clientes.json";
        static string caminhoPrestacoes = @"C:\Users\Aluno Noite\Downloads\Curso-C--master\Curso-C--master\prestacoes.json";

        static void CentralizarTexto(string texto)
        {
            // Obtém a largura da janela do console
            int larguraConsole = Console.WindowWidth;

            // Calcula a largura do texto
            int larguraTexto = texto.Length;

            // Calcula o número de espaços antes do texto para centralizar
            int espacosAntes = (larguraConsole - larguraTexto) / 2;

            // Cria a string com os espaços necessários para centralizar o texto
            string textoCentralizado = new string(' ', espacosAntes) + texto;

            // Exibe o texto centralizado no console
            Console.WriteLine(textoCentralizado);
        }

        private const string VersaoSistema = "1.0.0";

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║               SISTEMA DE GERENCIAMENTO                ║");
                Console.WriteLine("║                     DE SALÃO DE BELEZA                ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"║Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                          ║");
                Console.WriteLine($"║Versão do Sistema: {VersaoSistema}                               ║");
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║1. Gerenciar Serviços de Beleza                        ║");
                Console.WriteLine("║2. Gerenciar Clientes                                  ║");
                Console.WriteLine("║3. Gerenciar Prestação de Serviços                     ║");
                Console.WriteLine("║0. Sair                                                ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Escolha uma opção: ");
                Console.ForegroundColor = ConsoleColor.White;
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuServicos();
                        break;
                    case 2:
                        MenuClientes();
                        break;
                    case 3:
                        MenuPrestacoes();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);

        }

        static void MenuServicos()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║           SISTEMA DE GERENCIAMENTO DE SALÃO           ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"║Data e Hora: {DateTime.Now:yyyy-MM-dd HH:mm:ss}                       ║");
                Console.WriteLine($"║Versão do Sistema: {VersaoSistema}                               ║");
                Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
                Console.WriteLine("║                 GERENCIAR SERVIÇOS DE BELEZA          ║");
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.WriteLine("║1. Adicionar Serviço                                   ║");
                Console.WriteLine("║2. Listar Serviços                                     ║");
                Console.WriteLine("║3. Atualizar Serviço                                   ║");
                Console.WriteLine("║4. Remover Serviço                                     ║");
                Console.WriteLine("║0. Voltar                                              ║");
               
                Console.WriteLine("╚═══════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarServico();
                        break;
                    case 2:
                        ListarServicos();
                        break;
                    case 3:
                        AtualizarServico();
                        break;
                    case 4:
                        RemoverServico();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }

        static void MenuClientes()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║               SISTEMA DE GERENCIAMENTO DE SALÃO                ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"║ Data e Hora: {DateTime.Now:yyyy-MM-dd HH:mm:ss}                               ║");
                Console.WriteLine($"║ Versão do Sistema: {VersaoSistema}                                       ║");
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                      GERENCIAR CLIENTES                        ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("║ 1. Adicionar Cliente                                           ║");
                Console.WriteLine("║ 2. Listar Clientes                                             ║");
                Console.WriteLine("║ 3. Atualizar Cliente                                           ║");
                Console.WriteLine("║ 4. Remover Cliente                                             ║");
                Console.WriteLine("║ 0. Voltar                                                      ║");               
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        AtualizarCliente();
                        break;
                    case 4:
                        RemoverCliente();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }

        static void MenuPrestacoes()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║               SISTEMA DE GERENCIAMENTO DE SALÃO                ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"║ Data e Hora: {DateTime.Now:yyyy-MM-dd HH:mm:ss}                               ║");
                Console.WriteLine($"║ Versão do Sistema: {VersaoSistema}                                       ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                    GERENCIAR PRESTAÇÃO DE SERVIÇO              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");                
                Console.WriteLine("║ 1. Adicionar Prestação de Serviço                              ║");
                Console.WriteLine("║ 2. Listar Prestações de Serviço                                ║");
                Console.WriteLine("║ 3. Atualizar Prestação de Serviço                              ║");
                Console.WriteLine("║ 4. Remover Prestação de Serviço                                ║");
                Console.WriteLine("║ 0. Voltar                                                      ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPrestacao();
                        break;
                    case 2:
                        ListarPrestacoes();
                        break;
                    case 3:
                        AtualizarPrestacao();
                        break;
                    case 4:
                        RemoverPrestacao();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);

        }

        static void AdicionarServico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║               ADICIONAR NOVO SERVIÇO                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            string nome;
            bool nomeValido = false;

            do
            {
                Console.Write("║ Digite o nome do serviço: ");
                nome = Console.ReadLine();

                // Verifica se o nome é vazio ou contém apenas espaços
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║       Nome inválido. O nome não pode estar em branco ║");
                    Console.WriteLine("║       ou conter apenas espaços.                       ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                // Verifica se o nome contém números
                if (nome.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║      Nome inválido. O nome não pode conter números.   ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                nomeValido = true;

            } while (!nomeValido);

            int id = servicos.Count > 0 ? servicos[^1].Id + 1 : 1;
            Servico servico = new Servico(id, nome);
            servicos.Add(servico);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           Serviço adicionado com sucesso!              ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            SalvarDados();
        }



        static void ListarServicos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   LISTA DE SERVIÇOS                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (servicos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║           Nenhum serviço cadastrado.                   ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("╔═══════╦════════════════════════════════════════════════╗");
                Console.WriteLine("║  ID   ║                     Nome                       ║");
                Console.WriteLine("╠═══════╬════════════════════════════════════════════════╣");

                foreach (var servico in servicos)
                {
                    Console.WriteLine($"║ {servico.Id,-5} ║ {servico.Nome,-44} ║");
                }

                Console.WriteLine("╚═══════╩════════════════════════════════════════════════╝");
            }
        }


        static void AtualizarServico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ATUALIZAR SERVIÇO                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID do serviço a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            var servico = servicos.Find(s => s.Id == id);

            if (servico != null)
            {
                Console.Write("║ Digite o novo nome do serviço: ");
                servico.Nome = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║           Serviço atualizado com sucesso!              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║               Serviço não encontrado.                  ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void RemoverServico()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    REMOVER SERVIÇO                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID do serviço a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            var servico = servicos.Find(s => s.Id == id);

            if (servico != null)
            {
                servicos.Remove(servico);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║             Serviço removido com sucesso!              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                Serviço não encontrado.                 ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void AdicionarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                 ADICIONAR NOVO CLIENTE                 ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            string nome;
            bool nomeValido = false; // Inicialize a variável aqui

            do
            {
                Console.Write("║ Digite o nome do cliente: ");
                nome = Console.ReadLine();

                // Verifica se o nome é vazio ou contém apenas espaços
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║         Nome inválido. O nome não pode estar em       ║");
                    Console.WriteLine("║         branco ou conter apenas espaços.               ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                // Verifica se o nome contém números
                if (nome.Any(char.IsDigit))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║      Nome inválido. O nome não pode conter números.    ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                nomeValido = true;

            } while (!nomeValido);

            int id = clientes.Count > 0 ? clientes[^1].Id + 1 : 1;
            Cliente cliente = new Cliente(id, nome);
            clientes.Add(cliente);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            Cliente adicionado com sucesso!             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            SalvarDados();
        }



        static void ListarClientes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   LISTA DE CLIENTES                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (clientes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║              Nenhum cliente cadastrado.               ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("╔═══════╦════════════════════════════════════════════════╗");
                Console.WriteLine("║  ID   ║                     Nome                       ║");
                Console.WriteLine("╠═══════╬════════════════════════════════════════════════╣");

                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"║ {cliente.Id,-5} ║ {cliente.Nome,-44} ║");
                }

                Console.WriteLine("╚═══════╩════════════════════════════════════════════════╝");
            }
        }


        static void AtualizarCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  ATUALIZAR CLIENTE                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID do cliente a ser atualizado: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║           ID inválido. Por favor, insira um número.    ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                string nome;
                bool nomeValido = false;

                do
                {
                    Console.Write("║ Digite o novo nome do cliente: ");
                    nome = Console.ReadLine();

                    // Verifica se o nome é vazio ou contém apenas espaços
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║         Nome inválido. O nome não pode estar em       ║");
                        Console.WriteLine("║         branco ou conter apenas espaços.               ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    // Verifica se o nome contém números
                    if (nome.Any(char.IsDigit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║      Nome inválido. O nome não pode conter números.    ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    nomeValido = true;

                } while (!nomeValido);

                cliente.Nome = nome;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║              Cliente atualizado com sucesso!           ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                Cliente não encontrado.                ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }



        static void RemoverCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    REMOVER CLIENTE                    ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID do cliente a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║              Cliente removido com sucesso!            ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                Cliente não encontrado.                ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void AdicionarPrestacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      ADICIONAR PRESTAÇÃO DE SERVIÇO                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID do cliente: ");
            int clienteId = int.Parse(Console.ReadLine());
            var cliente = clientes.Find(c => c.Id == clienteId);

            Console.Write("║ Digite o ID do serviço: ");
            int servicoId = int.Parse(Console.ReadLine());
            var servico = servicos.Find(s => s.Id == servicoId);

            if (cliente != null && servico != null)
            {
                int id = prestacoes.Count > 0 ? prestacoes[^1].Id + 1 : 1;
                PrestacaoServico prestacao = new PrestacaoServico(id, cliente, servico);
                prestacoes.Add(prestacao);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║  Prestação de serviço adicionada com sucesso!         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║       Cliente ou serviço não encontrado.                 ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void ListarPrestacoes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════════════════╗");
            Console.WriteLine("║          LISTA DE PRESTAÇÕES DE SERVIÇO                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            if (prestacoes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║       Nenhuma prestação de serviço cadastrada.             ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("╔═══════╦════════════════════════╦════════════════════ ╗");
                Console.WriteLine("║  ID   ║        Cliente          ║       Serviço      ║");
                Console.WriteLine("╠═══════╬════════════════════════╬════════════════════ ╣");

                foreach (var prestacao in prestacoes)
                {
                    Console.WriteLine($"║ {prestacao.Id,-5} ║ {prestacao.Cliente.Nome,-22} ║ {prestacao.Servico.Nome,-18} ║");
                }

                Console.WriteLine("╚═══════╩════════════════════════╩════════════════════╝");
            }
        }


        static void AtualizarPrestacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  ATUALIZAR PRESTAÇÃO                 ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            // Validação do ID da prestação
            int id;
            while (true)
            {
                Console.Write("║ Digite o ID da prestação a ser atualizada: ");
                if (int.TryParse(Console.ReadLine(), out id))
                {
                    var prestacao = prestacoes.Find(p => p.Id == id);
                    if (prestacao != null)
                    {
                        // Validação do ID do cliente
                        int clienteId;
                        while (true)
                        {
                            Console.Write("║ Digite o novo ID do cliente: ");
                            if (int.TryParse(Console.ReadLine(), out clienteId))
                            {
                                var cliente = clientes.Find(c => c.Id == clienteId);
                                if (cliente != null)
                                {
                                    // Validação do ID do serviço
                                    int servicoId;
                                    while (true)
                                    {
                                        Console.Write("║ Digite o novo ID do serviço: ");
                                        if (int.TryParse(Console.ReadLine(), out servicoId))
                                        {
                                            var servico = servicos.Find(s => s.Id == servicoId);
                                            if (servico != null)
                                            {
                                                prestacao.Cliente = cliente;
                                                prestacao.Servico = servico;

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                                                Console.WriteLine("║  Prestação de serviço atualizada com sucesso!         ║");
                                                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                                                Console.ForegroundColor = ConsoleColor.White;

                                                SalvarDados();
                                                return;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                                                Console.WriteLine("║       Serviço não encontrado.                         ║");
                                                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                                            Console.WriteLine("║       ID do serviço inválido. Tente novamente.         ║");
                                            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                                    Console.WriteLine("║       Cliente não encontrado.                         ║");
                                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                                Console.WriteLine("║       ID do cliente inválido. Tente novamente.         ║");
                                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                        Console.WriteLine("║       Prestação não encontrada.                        ║");
                        Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║       ID inválido. Tente novamente.                    ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }



        static void RemoverPrestacao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    REMOVER PRESTAÇÃO                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("║ Digite o ID da prestação a ser removida: ");
            int id = int.Parse(Console.ReadLine());

            var prestacao = prestacoes.Find(p => p.Id == id);

            if (prestacao != null)
            {
                prestacoes.Remove(prestacao);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║               Prestação removida com sucesso!         ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;

                SalvarDados();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                 Prestação não encontrada.              ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


        static void CarregarDados()
        {
            if (File.Exists(caminhoServicos))
            {
                var servicosJson = File.ReadAllText(caminhoServicos);
                servicos = JsonSerializer.Deserialize<List<Servico>>(servicosJson);
            }

            if (File.Exists(caminhoClientes))
            {
                var clientesJson = File.ReadAllText(caminhoClientes);
                clientes = JsonSerializer.Deserialize<List<Cliente>>(clientesJson);
            }

            if (File.Exists(caminhoPrestacoes))
            {
                var prestacoesJson = File.ReadAllText(caminhoPrestacoes);
                prestacoes = JsonSerializer.Deserialize<List<PrestacaoServico>>(prestacoesJson);
            }
        }

        static void SalvarDados()
        {
            File.WriteAllText(caminhoServicos, JsonSerializer.Serialize(servicos));
            File.WriteAllText(caminhoClientes, JsonSerializer.Serialize(clientes));
            File.WriteAllText(caminhoPrestacoes, JsonSerializer.Serialize(prestacoes));
        }
    }

    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Servico(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }

    public class PrestacaoServico
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Servico Servico { get; set; }

        public PrestacaoServico(int id, Cliente cliente, Servico servico)
        {
            Id = id;
            Cliente = cliente;
            Servico = servico;
        }
    }
}

