using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioSeries = new SerieRepositorio();
        static FilmeRepositorio repositorioFilmes = new FilmeRepositorio();
        // static string tipoConteudo;
        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoConteudo();
            // obterOpcaoConteudo() retorna uma string com a opção do menu e o tipo de conteúdo SERIE ou FILME
            string[] opcaoUsuarioComTipoConteudo = opcaoUsuario.Split(" ");
            opcaoUsuario = opcaoUsuarioComTipoConteudo[0];
            string tipoConteudo = opcaoUsuarioComTipoConteudo[1];


            while (opcaoUsuario.ToUpper() != "X")
            {
                if (tipoConteudo == "SERIE")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            ListarSeries();
                            break;
                        case "2":
                            InserirSerie();
                            break;
                        case "3":
                            AtualizarSerie();
                            break;
                        case "4":
                            ExcluirSerie();
                            break;
                        case "5":
                            VisualizarSerie();
                            break;
                        case "6":
                            PopularListaSeries();
                            break;
                        case "C":
                            try
                            {
                                Console.Clear();
                            }
                            catch
                            {
                                // Caso a função Clear falhe chamo o Clear atráves do método Process.Start
                                System.Diagnostics.Process.Start("Clear");
                            }
                            break;
                        case "X":
                            break;
                        default:
                            Console.WriteLine("Opção invalida!!!");
                            break;
                    }
                    opcaoUsuario = ObterOpcaoUsuarioSeries();
                    opcaoUsuarioComTipoConteudo = opcaoUsuario.Split(" ");
                    opcaoUsuario = opcaoUsuarioComTipoConteudo[0];
                }
                else
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            ListarFilmes();
                            break;
                        case "2":
                            InserirFilmes();
                            break;
                        case "3":
                            AtualizarFilmes();
                            break;
                        case "4":
                            ExcluirFilme();
                            break;
                        case "5":
                            VisualizarFilme();
                            break;
                        case "6":
                            PopularListaFilmes();
                            break;
                        case "C":
                            try
                            {
                                Console.Clear();
                            }
                            catch
                            {
                                // Caso a função Clear falhe chamo o Clear atráves do método Process.Start
                                System.Diagnostics.Process.Start("Clear");
                            }
                            break;
                        case "X":
                            break;
                        default:
                            Console.WriteLine("Opção invalida!!!");
                            break;
                    }
                    opcaoUsuario = ObterOpcaoUsuarioFilmes();
                    opcaoUsuarioComTipoConteudo = opcaoUsuario.Split(" ");
                    opcaoUsuario = opcaoUsuarioComTipoConteudo[0];

                }


            }


            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void PopularListaSeries()
        {
            int indice = repositorioSeries.ProximoId();
            int entradaGenero = 9;
            string entradaTitulo = "Star trek discovery";
            int entradaAno = 2017;
            string entradaDescricao = "Star Trek: Discovery é uma série de televisão norte-americana criada por Bryan Fuller e Alex Kurtzman, é exibida pela CBS All Access nos Estados Unidos e Canada e pela Netflix no resto do mundo.";

            repositorioSeries.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao));

            indice = repositorioSeries.ProximoId();
            entradaGenero = 3;
            entradaTitulo = "Bing Bang Theory";
            entradaAno = 2007;
            entradaDescricao = "The Big Bang Theory é uma series de que conta a história de um grupo de amigos cientistas e a Penny";
            repositorioSeries.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao));

            indice = repositorioSeries.ProximoId();
            entradaGenero = 3;
            entradaTitulo = "Young Sheldon";
            entradaAno = 2017;
            entradaDescricao = "Young Sheldon é uma série de televisão americana da CBS como um spin-off da série The Big Bang Theory e serve como uma prequela da série, apresentando o personagem Sheldon Cooper como uma criança vivendo com sua família no Leste do Texas e indo ao colégio.";
            repositorioSeries.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao));

            static Serie Adicionar(int indice, int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao)
            {
                return new Serie(id: indice,
                                  genero: (Genero)entradaGenero,
                                  titulo: entradaTitulo,
                                  ano: entradaAno,
                                  descricao: entradaDescricao);
            }

            Console.WriteLine("Series adicionadas com sucesso!!!");
        }
        private static void PopularListaFilmes()
        {
            int indice = repositorioFilmes.ProximoId();
            int entradaGenero = 9;
            string entradaTitulo = "Interestelar";
            int entradaAno = 2014;
            double entradaNotaIMDB = 8.6;
            string entradaDescricao = "Conta a história de uma equipe de astronautas que viaja através de um buraco de minhoca à procura de um novo lar para a humanidade.";

            repositorioFilmes.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao, entradaNotaIMDB));

            indice = repositorioFilmes.ProximoId();
            entradaGenero = 3;
            entradaTitulo = "Kung Fusão";
            entradaAno = 2004;
            entradaNotaIMDB = 7.8;
            entradaDescricao = "m Xangai, no ano de 1940 vários grupos disputam o poder, e o mais temido de todos é a Gangue do Machado, liderada pelo Irmão Sum infame e apropriadamente chamado após a sua escolha de arma.";
            repositorioFilmes.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao, entradaNotaIMDB));

            indice = repositorioFilmes.ProximoId();
            entradaGenero = 3;
            entradaTitulo = "Minha Mãe É Uma Peça 3";
            entradaAno = 2019;
            entradaNotaIMDB = 7.1;
            entradaDescricao = "Após ter um piripaque, Dona Hermínia (Paulo Gustavo) recebe duas notícias: Marcelina (Mariana Xavier) está grávida de um cara que mal conhece e Juliano (Rodrigo Pandolfo) está noivo. Sofrendo ao ver que seus filhos já estão formando suas próprias famílias, ela decide focar nos preparativos para o casamento. Com o apoio de sua diarista Waldeia (Samantha Schmütz) e de suas irmãs Iesa (Alexandra Richter) e Lucia Helena (Patricya Travassos), a matriarca terá que driblar a sogra de seu filho, além de lidar com as novas investidas de Carlos Alberto (Herson Capri), seu ex-marido.";
            repositorioFilmes.Insere(Adicionar(indice, entradaGenero, entradaTitulo, entradaAno, entradaDescricao, entradaNotaIMDB));

            static Filme Adicionar(int indice, int entradaGenero, string entradaTitulo, int entradaAno, string entradaDescricao, double entradaNotaIMDB)
            {
                return new Filme(id: indice,
                                  genero: (Genero)entradaGenero,
                                  titulo: entradaTitulo,
                                  ano: entradaAno,
                                  descricao: entradaDescricao,
                                  notaIMDB: entradaNotaIMDB);
            }

            Console.WriteLine("Filmes adicionados com sucesso!!!");
        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            indiceSerie = testarEntradaSeries(indiceSerie);

            if (indiceSerie != -1)
            {
                repositorioSeries.Exclui(indiceSerie);
            }

        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            int indice = repositorioSeries.ProximoId();

            Serie novaSerie = ManagerSeries(indice);

            repositorioSeries.Insere(novaSerie);
        }


        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");

            int indiceSerie = int.Parse(Console.ReadLine());
            indiceSerie = testarEntradaSeries(indiceSerie);

            if (indiceSerie != -1)
            {
                var serie = repositorioSeries.RetornaPorId(indiceSerie);
                Console.WriteLine(serie);
            }


        }

        private static int testarEntradaSeries(int indiceSerie)
        {
            //Retorna true se a entrada for valida caso contrario retorna false
            if (repositorioSeries.ProximoId() == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada!!!");
                return -1;
            }
            if (indiceSerie > repositorioSeries.ProximoId())
            {
                //Vefica se o ID informado é valido
                while (indiceSerie > repositorioSeries.ProximoId() - 1)
                {
                    Console.WriteLine($"ID invalido, o repositório só possui {repositorioSeries.ProximoId()} séries cadastradas!!!");
                    indiceSerie = int.Parse(Console.ReadLine());
                }
            }

            return indiceSerie;
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            indiceSerie = testarEntradaSeries(indiceSerie);
            if (indiceSerie != -1)
            {
                Serie atualizaSerie = ManagerSeries(indiceSerie);
                repositorioSeries.Atualiza(indiceSerie, atualizaSerie);
            }
        }

        private static Serie ManagerSeries(int indice)
        {
            //Gerencia a criação e atualização da series!
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indice,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            return atualizaSerie;
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioSeries.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("");
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }
        private static int testarEntradaFilmes(int indiceFilmes)
        {
            //Retorna true se a entrada for valida caso contrario retorna false
            if (repositorioFilmes.ProximoId() == 0)
            {
                Console.WriteLine("Nenhuma filme cadastrado!!!");
                return -1;
            }
            if (indiceFilmes > repositorioFilmes.ProximoId())
            {
                //Vefica se o ID informado é valido
                while (indiceFilmes > repositorioFilmes.ProximoId() - 1)
                {
                    Console.WriteLine($"ID invalido, o repositório só possui {repositorioFilmes.ProximoId()} filmes cadastrados!!!");
                    indiceFilmes = int.Parse(Console.ReadLine());
                }
            }

            return indiceFilmes;
        }
        private static void ExcluirFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            indiceFilme = testarEntradaFilmes(indiceFilme);
            if (indiceFilme != -1)
            {
                repositorioFilmes.Exclui(indiceFilme);
            }
        }

        private static void VisualizarFilme()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            indiceFilme = testarEntradaFilmes(indiceFilme);
            if (indiceFilme != -1)
            {
                var filme = repositorioFilmes.RetornaPorId(indiceFilme);
                Console.WriteLine(filme);
            }
        }
        private static void AtualizarFilmes()
        {
            Console.Write("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            indiceFilme = testarEntradaFilmes(indiceFilme);
            if (indiceFilme != -1)
            {
                Filme atualizaFilme = ManagerFilmes(indiceFilme);
                repositorioFilmes.Atualiza(indiceFilme, atualizaFilme);
            }
        }
        private static Filme ManagerFilmes(int indice)
        {
            //Gerencia a criação e atualização da series!
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.Write("Digite a Nota do Filme: ");
            double entradaNotaIMDB = double.Parse(Console.ReadLine());

            Filme atualizaFilme = new Filme(id: indice,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        notaIMDB: entradaNotaIMDB);

            return atualizaFilme;
        }
        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            var lista = repositorioFilmes.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("");
                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirFilmes()
        {
            Console.WriteLine("Inserir novo filme");

            int indice = repositorioFilmes.ProximoId();

            Filme novoFilme = ManagerFilmes(indice);

            repositorioFilmes.Insere(novoFilme);
        }

        private static string obterOpcaoConteudo()
        {
            Console.WriteLine();
            Console.WriteLine("DIO FLIX a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Filmes");
            Console.WriteLine("2- Séries");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            while (!(opcaoUsuario != "FILME" || opcaoUsuario != "SÉRIE" || opcaoUsuario != "FILMES" || opcaoUsuario != "SÉRIES" || opcaoUsuario != "1" || opcaoUsuario != "2" || opcaoUsuario != "X"))
            {
                Console.WriteLine("Opcao invalida!!!");
                opcaoUsuario = Console.ReadLine().ToUpper();
            }
            if (opcaoUsuario == "1")
            {
                return ObterOpcaoUsuarioFilmes();
            }
            else if (opcaoUsuario == "2")
            {
                return ObterOpcaoUsuarioSeries();
            }
            else
            {
                return "X ";
            }
        }

        private static string ObterOpcaoUsuarioSeries()
        {
            Console.WriteLine();

            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("6- Popular lista de séries");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            opcaoUsuario += " SERIE";
            Console.WriteLine();
            return opcaoUsuario;
        }
        private static string ObterOpcaoUsuarioFilmes()
        {
            Console.WriteLine();

            Console.WriteLine("1- Listar Filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar filme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("6- Popular lista de filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            opcaoUsuario += " FILME";
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
