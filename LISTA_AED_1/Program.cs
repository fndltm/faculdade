using System;
using System.Collections;
using System.Collections.Generic;

namespace Trabalho_AED
{
    class Program
    {
        /** Exercícios opcionais. */

        /**
         * 1 – Crie a função public ArrayList CopiaArrayList(ArrayList origem) que copia todos os
         * dados do ArrayList origem e retorna o novo ArrayList criado.
         * Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
         */
        /// <summary>
        /// Método responsável por receber um ArrayList como parâmetro
        /// e criar uma cópia do mesmo.
        /// </summary>
        /// <param name="origem">O ArrayList que se deseja copiar.</param>
        /// <returns>O novo ArrayList.</returns>
        public static ArrayList CopiaArrayList(ArrayList origem)
        {
            ArrayList copiedArrayList = new ArrayList();

            foreach (Object arrayListItem in origem)
                copiedArrayList.Add(arrayListItem);
            return copiedArrayList;
        }

        /**
         * 2 – Crie a função public ArrayList CopiaQueueParaArrayList(Queue origem), que copia todos os
         * dados do Queue origem e retorna o novo ArrayList criado.
         * Atenção: para esse exercício não será permitido usar os métodos Clone() e CopyTo().
         */
        /// <summary>
        /// Método responsável por receber uma Queue como parâmetro
        /// e adicionar seus itens em um ArrayList.
        /// </summary>
        /// <param name="origem">A Queue que se deseja copiar.</param>
        /// <returns>O novo ArrayList.</returns>
        public static ArrayList CopiaQueueParaArrayList(Queue origem)
        {
            ArrayList queueToArrayList = new ArrayList();

            foreach (Object queueItem in origem)
                queueToArrayList.Add(queueItem);

            return queueToArrayList;
        }

        /**
         * 3 – Crie a função public ArrayList CopiaParteArrayList (ArrayList origem, int inicio, int final), a qual retorna
         * um ArrayList contendo todos os elementos dentro do intervalo determinado pelos parâmetros inicio e final.
         * Não é permitido usar o método CopyTo() do ArrayList.
         * Atenção: caso o ArrayList origem tenha menos posições do que a determinada pelo parâmetro final, copie até a sua última posição.
         * Caso o parâmetro inicio seja maior que a quantidade de elementos do ArrayList origem, retorne um ArrayList vazio.
         * Por fim, se o parâmetro inicio for maior que o parâmetro final, indica que o usuário deseja copiar os dados na ordem invertida.
         */
        /// <summary>
        /// Método responsável por receber um ArrayList de origem e de acordo com cada situação
        /// abaixo, retornar um ArrayList.
        /// </summary>
        /// <param name="origem">O ArrayList que se deseja copiar.</param>
        /// <param name="inicio">A posição inicial para os itens que serão copiados.</param>
        /// <param name="final">A posição final para os itens que serão copiados.</param>
        /// <returns></returns>
        public static ArrayList CopiaParteArrayList(ArrayList origem, int inicio, int final)
        {
            ArrayList copyArrayListInterval = new ArrayList();

            // Caso o ArrayList origem seja menor do que final, copia todos os itens.
            if (origem.Count < final)
                foreach (Object obj in origem)
                    copyArrayListInterval.Add(obj);

            // Caso inicio seja maior que os itens do ArrayList origem, retorna um ArrayList vazio.
            else if (inicio > origem.Count)
            {
                copyArrayListInterval = null;
                return copyArrayListInterval;
            }

            // Se inicio for maior que final, os dados são copiados em ordem invertida.
            else if (inicio > final)
            {
                copyArrayListInterval = origem;
                copyArrayListInterval.Reverse();
            }

            // Caso não seja nenhuma das condições, executa a ação padrão, que é copiar os elementos dentro do intevalo.
            else
                for (int i = inicio; i < final; i++)
                    copyArrayListInterval.Add(origem[i]);

            return copyArrayListInterval;
        }

        /**
         * 4 – Crie o procedimentopublic void ApagaArrayList(ArrayList origem, int inicio, int final), o qual apaga todos os
         * elementos no intervalo determinado pelos parâmetros inicio e final.
         * Atenção: não é permitido usar o método RemoveRange(). Apenas Remove() e RemoveAt().
         */
        /// <summary>
        /// Método responsável por apagar todos os itens do ArrayList passado como parâmetro
        /// no intervalo das posições parametrizadas por inicio e final.
        /// </summary>
        /// <param name="origem">O ArrayList que se deseja apagar.</param>
        /// <param name="inicio">A posição inicial que os itens serão apagados.</param>
        /// <param name="final">Até onde os elementos serão apagados.</param>
        public static void ApagaArrayList(ArrayList origem, int inicio, int final)
        {
            for (int i = inicio; i <= final; i++)
                origem.Remove(i);
        }

        /**
         * 5 – Crie o procedimento public void ApagaArrayList2(ArrayList origem, int inicio, int qtde), o qual apaga todos os
         * qtde elementos à partir da posição determinada pelo parâmetro início.
         * Atenção: não é permitido usar o método RemoveRange(), apenas Remove() e RemoveAt().
         */
        /// <summary>
        /// Método responsável por remover determinada quantidade de itens do ArrayList
        /// a partir da posição inicial, passada por parâmetro.
        /// </summary>
        /// <param name="origem">O ArrayList que se deseja apagar.</param>
        /// <param name="inicio">A posição inicial para começar a apagar os itens do ArrayList.</param>
        /// <param name="qtde">A quantidade de itens a partir da posição inicial que será removido do ArrayList.</param>
        public static void ApagaArrayList2(ArrayList origem, int inicio, int qtde)
        {
            int cont = 0;
            while (cont != qtde)
            {
                origem.Remove(inicio++);
                cont++;
            }
        }

        /**
         * 6 – Crie a função public ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2), o qual retorna
         * um novo ArrayList como todos os elementos de AL1 e AL2.
         */
        /// <summary>
        /// Método responsável por mesclar dois ArrayList passados por parâmetro.
        /// </summary>
        /// <param name="AL1">O primeiro ArrayList a ser mesclado.</param>
        /// <param name="AL2">O segundo ArrayList a ser mesclado.</param>
        /// <returns></returns>
        public static ArrayList ConcatenaArrayList(ArrayList AL1, ArrayList AL2)
        {
            ArrayList mergeArrayList = new ArrayList();

            foreach (Object obj in AL1)
                mergeArrayList.Add(obj);
            foreach (Object obj in AL2)
                mergeArrayList.Add(obj);

            return mergeArrayList;
        }

        /**
         * 7 – Crie o procedimentopublic void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3),
         * o qual copia todos os elementos de AL1 e AL2 para AL3. 
         */
        /// <summary>
        /// Método responsável por copiar todos os itens de 2 ArrayList passados por parâmetro
        /// para um terceiro ArrayList.
        /// </summary>
        /// <param name="AL1">O primeiro ArrayList que será copiado.</param>
        /// <param name="AL2">O segundoArrayList que será copiado.</param>
        /// <param name="AL3">O ArrayList que terá os itens do ArrayList 1 e do ArrayList 2.</param>
        public static void ConcatenaArrayList2(ArrayList AL1, ArrayList AL2, ArrayList AL3)
        {
            foreach (Object obj in AL1)
                AL3.Add(obj);

            foreach (Object obj in AL2)
                AL3.Add(obj);

            foreach (Object obj in AL3)
                Console.WriteLine(obj);
        }

        /**
         * 12 – Crie a função public Queue CopiaQueue(Queue origem) a qual retorna uma cópia da Queue origem passada como parâmetro.
         * Os elementos da Queue origem devem permacer na mesma ordem original.
         * Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Queue.
         */
        /// <summary>
        /// Método responsável por receber uma Queue e copiar seus elementos em uma nova Queue
        /// retornando a nova Queue com os elementos copiados.
        /// </summary>
        /// <param name="origem">A Queue que será copiada.</param>
        /// <returns></returns>
        public static Queue CopiaQueue(Queue origem)
        {
            Queue queueCopiada = new Queue();
            foreach (Object obj in origem)
                queueCopiada.Enqueue(obj);

            return queueCopiada;
        }

        /**
         * 13 – Crie a função public Stack CopiaStack (Stack origem) a qual retorna uma cópia da Stack origem passada como parâmetro.
         * Os elementos da Stack origem devem permacer na mesma ordem original.
         * Atenção: não é permitido usar os métodos Clone() e CopyTo() da classe Stack. 
         */
        /// <summary>
        /// Método responsável por receber uma Stack e copiar seus elementos em uma nova Stack
        /// retornando a nova Stack com os elementos copiados.
        /// </summary>
        /// <param name="origem">A Stack que será copiada.</param>
        /// <returns></returns>
        public static Stack CopiaStack(Stack origem)
        {
            Stack stackCopiada = new Stack();
            foreach (Object obj in origem)
                stackCopiada.Push(obj);

            return stackCopiada;
        }

        /**
         * 17 – Crie a função public Hashtable ConcatenaHashtable(Hashtable  HT1, Hashtable  HT2),
         * o qual retorna um novo Hashtable contendo todos os elementos de HT1 e HT2.
         */
        /// <summary>
        /// Método responsável por receber 2 Hashtable e criar um novo contendo todos os elementos
        /// dos dois hashtables, sem mudar a ordem dos respectivos elementos.
        /// </summary>
        /// <param name="HT1">O primeiro Hashtable a ter seus elementos copiados.</param>
        /// <param name="HT2">O segundo Hashtable a ter seus elementos copiados.</param>
        /// <returns></returns>
        public static Hashtable ConcatenaHashtable(Hashtable HT1, Hashtable HT2)
        {
            Hashtable hashtableConcatenado = new Hashtable();
            foreach (DictionaryEntry de in HT1)
            {
                hashtableConcatenado.Add(de.Key, de.Value);
            }

            foreach (DictionaryEntry de in HT2)
            {
                hashtableConcatenado.Add(de.Key, de.Value);
            }

            return hashtableConcatenado;
        }


        /** Exercícios obrigatórios. */

        /**
         * * 18 – Um biólogo precisa de um programa que traduza uma trinca de nucleotídeos em seu aminoácido correspondente.
         * Por exemplo, a trinca de aminoácidos ACG é traduzida como o aminoácido Treonina, e GCA em Alanina.
         * Crie um programa em C# que use um Hashtable para criar um dicionário do código genético.
         * O usuário deve digitar uma trinca (chave) e seu programa deve mostrar o nome (valor) do aminoácido correspondente.
         * Use a tabela abaixo para cadastrar todas as trincas/aminoácidos.
         */
        /// <summary>
        /// Método responsável por criar uma tabela de nucleotídeos,
        /// pesquisar seu valor dentro de um Dicionário e retornar caso encontre.
        /// </summary>
        /// <param name="chave">A chave que será pesquisada para encontrar o valor.</param>
        /// <returns>O valor encontrado de acordo com a chave.</returns>
        public static string TabelaNucleotideos(string chave)
        {
            bool achou;

            string valor = "";

            Hashtable hashtable = new Hashtable()
   {
    // Fenilalanina
    {"UUU", "Fenilalanina"},
    {"UUC", "Fenilalanina"},
    // Leucina
    {"UUA", "Leucina"},
    {"UUG", "Leucina"},
    {"CUU", "Leucina"},
    {"CUC", "Leucina"},
    {"CUA", "Leucina"},
    {"CUG", "Leucina"},
    // Isoleucina
    {"AUU", "Isoleucina"},
    {"AUC", "Isoleucina"},
    {"AUA", "Isoleucina"},
    // Metionina
    {"AUG", "Metionina"},
    // Valina
    {"GUU", "Valina"},
    {"GUC", "Valina"},
    {"GUA", "Valina"},
    {"GUG", "Valina"},
    // Serina
    {"UCU", "Serina"},
    {"UCC", "Serina"},
    {"UCA", "Serina"},
    {"UCG", "Serina"},
    // Prolina
    {"CCU", "Prolina"},
    {"CCC", "Prolina"},
    {"CCA", "Prolina"},
    {"CCG", "Prolina"},
    // Treonina
    {"ACU", "Treonina"},
    {"ACC", "Treonina"},
    {"ACA", "Treonina"},
    {"ACG", "Treonina"},
    // Alanina
    {"GCU", "Alanina"},
    {"GCC", "Alanina"},
    {"GCA", "Alanina"},
    {"GCG", "Alanina"},
    // Tirosina
    {"UAU", "Tirosina"},
    {"UAC", "Tirosina"},
    {"UAA", "Tirosina"},
    {"UAG", "Tirosina"},
    // Histidina
    {"CAU", "Histidina"},
    {"CAC", "Histidina"},
    // Glutamina
    {"CAA", "Glutamina"},
    {"CAG", "Glutamina"},
    // Asparagina
    {"AAU", "Asparagina"},
    {"AAC", "Asparagina"},
    // Lisina
    {"AAA", "Lisina"},
    {"AAG", "Lisina"},
    // Aspartato
    {"GAU", "Aspartato"},
    {"GAC", "Aspartato"},
    // Glutamato
    {"GAA", "Glutamato"},
    {"GAG", "Glutamato"},
    // Cisteína
    {"UGU", "Cisteína"},
    {"UGC", "Cisteína"},
    // Parada
    {"UGA", "Parada"},
    // Triptofano
    {"UGG", "Triptofano"},
    // Arginina
    {"CGU", "Arginina"},
    {"CGC", "Arginina"},
    {"CGA", "Arginina"},
    {"CGG", "Arginina"},
    // Serina
    {"AGU", "Serina"},
    {"AGC", "Serina"},
    // Arginina
    {"AGA", "Arginina"},
    {"AGG", "Arginina"},
    // Glicina
    {"GGU", "Glicina"},
    {"GGC", "Glicina"},
    {"GGA", "Glicina"},
    {"GGG", "Glicina"},
   };

            while (string.IsNullOrEmpty(chave))
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                chave = Console.ReadLine();
            }

            chave = chave.ToUpper();
            foreach (DictionaryEntry de in hashtable)
                if (chave == de.Key.ToString())
                    valor = de.Value.ToString();

            achou = !string.IsNullOrEmpty(valor);
            while (!achou)
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                chave = Console.ReadLine();

                chave = chave.ToUpper();
                foreach (DictionaryEntry de in hashtable)
                    if (chave == de.Key.ToString())
                        valor = de.Value.ToString();
                achou = !string.IsNullOrEmpty(valor);
            }

            return valor;
        }

        /**
         * * 19 – Crie um dicionário com URL’s e IP’s dos websites abaixo e mais 5 à sua escolha.
         * O seu dicionário deve ser implementado usando a classe Hashtable e terá a URL como chave e o IP correspondente
         * como valor (por exemplo, se digitarmos como chave a URL www.google.com, seu programa deve retornar o IP 74.125.234.81).
         * O seu programa deve permitir que o usuário digite uma URL e deve imprimir o IP correspondente.
         * Para descobrir o IP de um website, basta digitar ping + URL do website (exemplo: ping www.google.com). 
         */
        /// <summary>
        /// Método responsável por montar um Hashtable contendo a url e seu respectivo IP,
        /// descoberto através do comando ping[url] no terminal.
        /// O usuário pode digitar uma url que contenha no Hashtable e o método retornará
        /// o IP respectivo à chave.
        /// </summary>
        /// <param name="url">A URL cujo IP deseja ser consultado.</param>
        /// <returns></returns>
        public static string IpsFromUrls(string url)
        {
            string valor = "";
            bool achou;
            Hashtable hashtable = new Hashtable()
   {
    {"www.google.com", "172.217.172.132"},
    {"www.pucminas.br", "200.229.32.27"},
    {"www.gmail.com", "172.217.28.69"},
    {"www.youtube.com", "172.217.30.46"},
    {"www.capes.gov.br", "200.130.18.222"},
    {"www.yahoo.com", "72.30.35.10"},
    {"www.microsoft.com", "184.51.132.196"},
    {"www.twitter.com", "104.244.42.65"},
    {"www.brasil.gov.br", "170.246.252.243"},
    {"www.wikipedia.com", "208.80.154.232"},
    {"www.amazon.com", "72.246.131.124"},
    {"research.microsoft.com", "13.67.218.189"},
    {"www.facebook.com", "31.13.85.36"},
    {"www.whitehouse.gov", "23.74.201.158"},
    {"www.answers.com", "151.101.92.203"},
    {"www.uol.com.br", "52.84.169.238"},
    {"www.hotmail.com", "204.79.197.212"},
    {"www.cplusplus.com", "167.114.170.15"},
    {"www.nyt.com", "151.101.93.164"},
    {"www.apple.com", "23.55.32.111"},

    // Websites escolhidos.
    {"www.netflix.com", "52.20.168.249"},
    {"material.angular.io", "151.101.65.195"},
    {"angular.io", "151.101.65.195"},
    {"www.primefaces.org", "88.99.94.208"},
    {"www.typescriptlang.org", "40.118.235.113"},
    {"spring.io", "104.20.6.247"},
    {"nodejs.org", "104.20.23.46"}
   };

            while (string.IsNullOrEmpty(url))
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                url = Console.ReadLine();
            }

            url = url.ToLower();
            foreach (DictionaryEntry de in hashtable)
                if (url == de.Key.ToString())
                    valor = de.Value.ToString();

            achou = !string.IsNullOrEmpty(valor);
            while (!achou)
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                url = Console.ReadLine();

                url = url.ToLower();
                foreach (DictionaryEntry de in hashtable)
                    if (url == de.Key.ToString())
                        valor = de.Value.ToString();
                achou = !string.IsNullOrEmpty(valor);
            }

            return valor;
        }

        /**
         * * 21 – Faça um programa que use um SortedList para adicionar a matrícula (key) e nome (value) de vários alunos.
         * Para encerrar o cadastramento de alunos, o usuário deve digitar uma matrícula negativa.
         * Após o cadastro, seu programa deve permitir ao usuário pesquisar alunos através de sua matrícula.
         * O usuário deve digitar um número negativo para interromper a pesquisa.
         */
        /// <summary>
        /// Método responsável por permitir ao usuário cadastrar alunos de acordo com sua matrícula e nome
        /// e buscar o mesmo de acordo com a matrícula.
        /// </summary>
        public static void CadastrarPesquisarAlunos()
        {
            SortedList sortedList = new SortedList();
            int matricula = 0, opcao;
            string nome, num;
            bool isNumeroInteiro;

            Console.WriteLine("Bem-Vindo ao programa de cadastramento e busca de alunos.\n" +
                 "Para começar, cadastre alguns alunos.\n");

            void MenuOpcoes()
            {
                Console.Clear();

                Console.WriteLine(
                 "Digite 1 para cadastrar mais alunos ou 2 para pesquisar alunos (tenha a matrícula do aluno em mãos).");

                num = Console.ReadLine();

                // Validando se é inteiro utilizando o recurso TryParse.
                // No método passamos primeiro uma string, e depois a saída "out".
                isNumeroInteiro = int.TryParse(num, out opcao);

                //Verificando se é um número inteiro.
                while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                {
                    Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                    num = Console.ReadLine();
                    isNumeroInteiro = int.TryParse(num, out opcao);
                }

                switch (opcao)
                {
                    case 1:
                        matricula = 0;
                        CadastrarAlunos();
                        break;

                    case 2:
                        matricula = 0;
                        Console.Clear();

                        while (matricula >= 0)
                        {
                            Console.WriteLine(
                             "Digite uma matrícula para pesquisar o nome do aluno: (Para sair digite um número negativo).");
                            num = Console.ReadLine();

                            // Validando se é inteiro utilizando o recurso TryParse.
                            // No método passamos primeiro uma string, e depois a saída "out".
                            isNumeroInteiro = int.TryParse(num, out matricula);

                            //Verificando se é um número inteiro.
                            while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                            {
                                Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                                num = Console.ReadLine();
                                isNumeroInteiro = int.TryParse(num, out matricula);
                            }

                            if (matricula < 0)
                            {
                                MenuOpcoes();
                                return;
                            }

                            // Se a matrícula pesquisada for null ou vazia, pede para digitar uma nova matrícula.
                            while (string.IsNullOrEmpty(matricula.ToString()))
                            {
                                Console.WriteLine("Para pesquisar digite uma matrícula válida:");
                                num = Console.ReadLine();

                                // Validando se é inteiro utilizando o recurso TryParse.
                                // No método passamos primeiro uma string, e depois a saída "out".
                                isNumeroInteiro = int.TryParse(num, out matricula);

                                //Verificando se é um número inteiro.
                                while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                                {
                                    Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                                    num = Console.ReadLine();
                                    isNumeroInteiro = int.TryParse(num, out matricula);
                                }
                            }

                            void BuscarAluno()
                            {
                                try
                                {
                                    // Procura o index de acordo com a matrícula.
                                    int index = sortedList.IndexOfKey(matricula);

                                    // Se o index for null ou vazio, quer dizer que não há a matrícula digitada. Então pede-se uma nova matrícula.
                                    while (string.IsNullOrEmpty(index.ToString()))
                                    {
                                        Console.WriteLine("Matrícula {0} não encontrada. Digite novamente: ",
                                         matricula);
                                        num = Console.ReadLine();

                                        // Validando se é inteiro utilizando o recurso TryParse.
                                        // No método passamos primeiro uma string, e depois a saída "out".
                                        isNumeroInteiro = int.TryParse(num, out matricula);

                                        //Verificando se é um número inteiro.
                                        while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                                        {
                                            Console.WriteLine(
                                             "O valor digitado deve ser inteiro.\nDigite outro número: ");
                                            num = Console.ReadLine();
                                            isNumeroInteiro = int.TryParse(num, out matricula);
                                        }

                                        // Se a matrícula digitada for null ou vazia, pede uma nova matrícula.
                                        while (string.IsNullOrEmpty(matricula.ToString()))
                                        {
                                            Console.WriteLine("Para pesquisar digite uma matrícula válida: ");
                                            num = Console.ReadLine();

                                            // Validando se é inteiro utilizando o recurso TryParse.
                                            // No método passamos primeiro uma string, e depois a saída "out".
                                            isNumeroInteiro = int.TryParse(num, out matricula);

                                            //Verificando se é um número inteiro.
                                            while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                                            {
                                                Console.WriteLine(
                                                 "O valor digitado deve ser inteiro.\nDigite outro número: ");
                                                num = Console.ReadLine();
                                                isNumeroInteiro = int.TryParse(num, out matricula);
                                            }
                                        }

                                        // Tenta procurar o índice novamente de acordo com o valor da matrícula.
                                        index = sortedList.IndexOfKey(matricula);
                                    }

                                    // Caso o índice for válido, pega a chave de acordo com o índice.
                                    Object valorEncontrado = sortedList.GetByIndex(index);

                                    // Escreve a matrícula e o nome do aluno.
                                    Console.WriteLine("Matrícula: {0}\tAluno: {1}\n", matricula, valorEncontrado);
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("Matrícula não encontrada, digite novamente: ");
                                    num = Console.ReadLine();

                                    // Validando se é inteiro utilizando o recurso TryParse.
                                    // No método passamos primeiro uma string, e depois a saída "out".
                                    isNumeroInteiro = int.TryParse(num, out matricula);

                                    //Verificando se é um número inteiro.
                                    while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                                    {
                                        Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                                        num = Console.ReadLine();
                                        isNumeroInteiro = int.TryParse(num, out matricula);
                                    }

                                    if (matricula < 0)
                                    {
                                        MenuOpcoes();
                                        return;
                                    }

                                    BuscarAluno();
                                }
                            }

                            BuscarAluno();
                        }

                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        break;
                }
            }

            // Criação de função local, pois será chamada novamente caso o usuário queira cadastrar mais alunos.
            void CadastrarAlunos()
            {
                while (matricula >= 0)
                {
                    Console.WriteLine("Digite a matrícula do aluno: (Para sair digite um número negativo)");
                    num = Console.ReadLine();

                    // Validando se é inteiro utilizando o recurso TryParse.
                    // No método passamos primeiro uma string, e depois a saída "out".
                    isNumeroInteiro = int.TryParse(num, out matricula);

                    //Verificando se é um número inteiro.
                    while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                    {
                        Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                        num = Console.ReadLine();
                        isNumeroInteiro = int.TryParse(num, out matricula);
                    }

                    if (matricula < 0)
                    {
                        MenuOpcoes();
                        return;
                    }

                    // Caso a matrícula digitada for null ou vazia, pede uma nova matrícula.
                    while (string.IsNullOrEmpty(matricula.ToString()))
                    {
                        Console.WriteLine("O aluno deve ter uma matrícula. Digite novamente: ");
                        num = Console.ReadLine();

                        // Validando se é inteiro utilizando o recurso TryParse.
                        // No método passamos primeiro uma string, e depois a saída "out".
                        isNumeroInteiro = int.TryParse(num, out matricula);

                        //Verificando se é um número inteiro.
                        while (isNumeroInteiro == false || string.IsNullOrEmpty(num))
                        {
                            Console.WriteLine("O valor digitado deve ser inteiro.\nDigite outro número: ");
                            num = Console.ReadLine();
                            isNumeroInteiro = int.TryParse(num, out matricula);
                        }
                    }

                    Console.WriteLine("Digite o nome do aluno para a matrícula {0}:", matricula);
                    nome = Console.ReadLine();

                    // Caso o nome digitado for null ou vazio, pede um novo nome.
                    while (string.IsNullOrEmpty(nome))
                    {
                        Console.WriteLine("O aluno da matrícula {0} deve ter um nome. Digite novamente: ", matricula);
                        nome = Console.ReadLine();
                    }

                    // Adiciona a matrícula e o nome à lista sorteada.
                    sortedList.Add(matricula, nome);
                }
            }

            CadastrarAlunos();
            Console.Clear();

            // Verificação para conferir que há alguém cadastrado.
            if (sortedList.Count <= 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.\nCadastre alguns alunos para liberar a função de busca.");
                matricula = 0;
                CadastrarAlunos();
            }
            else
                MenuOpcoes();
        }

        /**
         * * 22 – Faça um programa que cadastre em um Hashtable alguns modelos de carros de montadoras nacionais,
         * conforme a tabela abaixo (você deve fazer esse cadastro internamente, não o usuário – crie uma função para isso).
         * Seu Hashtable tem como chave o nome da montadora, e como valor um Arraylist contendo os modelos de carros da tabela abaixo.
         * Após o cadastro, peça ao usuário que digite o nome de uma montadora.
         * Você deve imprimir a quantidade de modelos e nome de cada um. 
         */
        /// <summary>
        /// Método responsável por cadastrar o nome de montadoras e vários modelos de carros.
        /// Após cadastrar internamente, o usuário poderá digitar uma montadora para verificar seus modelos
        /// e a quantidade de modelos que este possui. 
        /// </summary>
        public static void CadastrarModeloCarroNacional()
        {
            int qtdeModelos = 0;

            // Inicia vários arrayLists para serem adicionados ao hashtable posteriormente.
            ArrayList arrayListFiat = new ArrayList();
            arrayListFiat.Add("Mille");
            arrayListFiat.Add("Novo Uno");
            arrayListFiat.Add("Palio");
            arrayListFiat.Add("Siena");
            arrayListFiat.Add("Freemont");
            arrayListFiat.Add("Bravo");
            arrayListFiat.Add("Punto");
            arrayListFiat.Add("Linea");
            arrayListFiat.Add("Palio Weekend");

            ArrayList arrayListVolkswagen = new ArrayList();
            arrayListVolkswagen.Add("Gol");
            arrayListVolkswagen.Add("Voyage");
            arrayListVolkswagen.Add("Polo");
            arrayListVolkswagen.Add("Passat");
            arrayListVolkswagen.Add("Amarok");
            arrayListVolkswagen.Add("Fox");
            arrayListVolkswagen.Add("Golf");
            arrayListVolkswagen.Add("Jetta");
            arrayListVolkswagen.Add("Tiguan");

            ArrayList arrayListFord = new ArrayList();
            arrayListFord.Add("Focus");
            arrayListFord.Add("Fiesta");
            arrayListFord.Add("Ka");
            arrayListFord.Add("New Fiesta");
            arrayListFord.Add("Fusion");
            arrayListFord.Add("Edge");

            ArrayList arrayListGM = new ArrayList();
            arrayListGM.Add("Celta");
            arrayListGM.Add("Classic");
            arrayListGM.Add("Prisma");
            arrayListGM.Add("Agile");
            arrayListGM.Add("Omega");
            arrayListGM.Add("Cruze");
            arrayListGM.Add("Camaro");
            arrayListGM.Add("Malibu");

            // Cria um hashtable com o nome da montadora e seus respectivos modelos.
            Hashtable hashtable = new Hashtable()
   {
    {"Fiat", arrayListFiat},
    {"Volkswagen", arrayListVolkswagen},
    {"Ford", arrayListFord},
    {"GM", arrayListGM},
   };

            Console.WriteLine("Digite o nome da montadora para ver os modelos: ");
            string nomeMontadora = Console.ReadLine();

            // Caso o nome digitado for null ou vazio, pede um novo nome.
            while (string.IsNullOrEmpty(nomeMontadora))
            {
                Console.WriteLine("É necessário o nome da montadora para pesquisar os modelos. Digite novamente: ");
                nomeMontadora = Console.ReadLine();
            }

            // Se dentro da hashtable, houver uma chave com o valor do nome da montadora, executa.
            if (hashtable.ContainsKey(nomeMontadora))
            {
                // Para cada item na hashtable cria um DictionaryEntry, para que seja possível pegar sua chave e valor.
                foreach (DictionaryEntry DE in hashtable)
                    // Se a chave do objeto dentro do hashtable for igual ao nome digitado, executa.
                    if ((string)DE.Key == nomeMontadora)
                        // Para cada valor dentro do ArrayList, exibe seu valor e soma mais um na qtde de modelos.
                        foreach (Object obj in (ArrayList)DE.Value)
                        {
                            Console.WriteLine(obj);
                            qtdeModelos++;
                        }
            }
            else
                Console.WriteLine("Nome da montadora não encontrado. Tente novamente mais tarde!");

            Console.WriteLine("\nQuantidade de modelos da montadora {0}: {1}", nomeMontadora, qtdeModelos);
        }

        /**
         * * 33 – Faça um programa que monte a estrutura abaixo usando Dictionary<> ou SortedList<>: 
         * Você deve inserir pelo menos 3 continentes com no mínimo 6 países em cada um.
         * Gere um relatório com base no layout abaixo:
         * Continente: nome do continente
         * Nome do país 1 – População: população do país 1
         * Nome do país 2 – População: população do país 2
         * ...
         * Nome do país n – População: população do país n
         * População total: 999999
         * No link http://www.indexmundi.com/map/?l=pt você encontrará uma tabela com as populações de diversos países.
         * Obs: você pode implementar todo o seu código dentro do Main().
         * O objetivo desse exercício é que você aprenda a manipular uma estrutura tão sofisticada quanto essa.
         */
        /// <summary>
        /// Método responsável por exibir países e sua população dentro de um continente.
        /// Depois, mostra a soma de todos os países adicionados no SortedList daquele continente.
        /// </summary>
        public static void ContinentesPaisesPopulacao()
        {
            SortedList<Object, Hashtable> continentes = new SortedList<Object, Hashtable>();
            Hashtable paisesAmerica = new Hashtable();
            Hashtable paisesAsia = new Hashtable();
            Hashtable paisesEuropa = new Hashtable();
            double somaPopAmerica = 0, somaPopAsia = 0, somaPopEuropa = 0;

            paisesAmerica.Add("Brasil", "207.353.392");
            paisesAmerica.Add("México", "124.574.792");
            paisesAmerica.Add("Estados Unidos", "318.892.096");
            paisesAmerica.Add("Canadá", "35.623.680");
            paisesAmerica.Add("Gronelândia", "57.713");
            paisesAmerica.Add("Argentina", "44.293.292");
            paisesAmerica.Add("Chile", "17.789.268");

            continentes.Add("América", paisesAmerica);

            paisesAsia.Add("China", "1.379.302.784");
            paisesAsia.Add("Índia", "1.281.935.872");
            paisesAsia.Add("Rússia", "142.257.520");
            paisesAsia.Add("Japão", "126.451.400");
            paisesAsia.Add("Coréia do Sul", "51.181.300");
            paisesAsia.Add("Coréia do Norte", "25.248.140");
            paisesAsia.Add("Taiwan", "23.508.428");

            continentes.Add("Ásia", paisesAsia);

            paisesEuropa.Add("Finlândia", "5.518.371");
            paisesEuropa.Add("Dinamarca", "5.605.948");
            paisesEuropa.Add("Espanha", "48.958.160");
            paisesEuropa.Add("Itália", "62.137.800");
            paisesEuropa.Add("Turquia", "80.845.216");
            paisesEuropa.Add("República Checa", "10.674.723");
            paisesEuropa.Add("Alemanha", "80.594.016");

            continentes.Add("Europa", paisesEuropa);

            Console.WriteLine("Continente: {0}", "América");
            continentes.TryGetValue("América", out Hashtable paisAmerica);
            foreach (DictionaryEntry infoPais in paisAmerica)
            {
                Console.WriteLine("{0} - População: {1}", infoPais.Key, infoPais.Value);
                somaPopAmerica = somaPopAmerica + Double.Parse(infoPais.Value.ToString());
            }

            Console.WriteLine("População total: {0:0,0}", somaPopAmerica);

            Console.WriteLine("\nContinente: {0}", "Ásia");
            continentes.TryGetValue("Ásia", out Hashtable paisAsia);
            foreach (DictionaryEntry infoPais in paisAsia)
            {
                Console.WriteLine("{0} - População: {1}", infoPais.Key, infoPais.Value);
                somaPopAsia = somaPopAsia + Double.Parse(infoPais.Value.ToString());
            }

            Console.WriteLine("População total: {0:0,0}", somaPopAsia);

            Console.WriteLine("\nContinente: {0}", "Europa");
            continentes.TryGetValue("Europa", out Hashtable paisEuropa);
            foreach (DictionaryEntry infoPais in paisEuropa)
            {
                Console.WriteLine("{0} - População: {1}", infoPais.Key, infoPais.Value);
                somaPopEuropa = somaPopEuropa + Double.Parse(infoPais.Value.ToString());
            }

            Console.WriteLine("População total: {0:0,0}", somaPopEuropa);
        }

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            ArrayList arrayListAleatorio = new ArrayList();
            ArrayList AmaisB = new ArrayList();
            Queue queue = new Queue();
            Stack stack = new Stack();
            Hashtable hashtable1 = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            string chave, url;

            int inicio = 7, final = 5, qtde = 5;
            Random random = new Random();

            for (int i = 1; i <= 5; i++)
            {
                arrayList.Add(i);
                arrayListAleatorio.Add(random.Next(50));
                queue.Enqueue(random.Next(50));
                stack.Push(random.Next(50));
                hashtable1.Add("Hashtable 1, Elemento: " + i, random.Next(50));
                hashtable2.Add("Hashtable 2, Elemento: " + i, random.Next(50));
            }

            // Chamada do Exercício 1.
            foreach (Object obj in CopiaArrayList(arrayList))
                Console.WriteLine(obj);

            // Chamada do Exercício 2.
            foreach (Object obj in CopiaQueueParaArrayList(queue))
                Console.WriteLine(obj);

            // Chamada do Exercício 3.
            foreach (Object obj in CopiaParteArrayList(arrayList, inicio, final))
                Console.WriteLine(obj);

            // Chamada do Exercício 4.
            ApagaArrayList(arrayList, inicio, final);

            // Chamada do Exercício 5.
            ApagaArrayList2(arrayList, inicio, qtde);

            // Chamada do Exercício 6.
            foreach (Object obj in ConcatenaArrayList(arrayList, arrayListAleatorio))
                Console.WriteLine(obj);

            // Chamada do Exercício 7.
            ConcatenaArrayList2(arrayList, arrayListAleatorio, AmaisB);

            // Chamada do Exercício 12.
            foreach (Object obj in CopiaQueue(queue))
                Console.WriteLine(obj);

            // Chamada do Exercício 13.
            foreach (Object obj in CopiaStack(stack))
                Console.WriteLine(obj);

            // Chamada do Exercício 17.
            foreach (DictionaryEntry de in ConcatenaHashtable(hashtable1, hashtable2))
            {
                Console.WriteLine(de.Key);
                Console.WriteLine(de.Value);
            }

            // Chamada do Exercício 18.
            Console.WriteLine("Digite uma trinca (código do nucleotídeo) para pesquisar seu valor: ");
            chave = Console.ReadLine();

            Console.WriteLine(TabelaNucleotideos(chave));

            // Chamada do Exercício 19.
            Console.WriteLine("Digite a url de um website para pesquisar seu IP: ");
            url = Console.ReadLine();

            Console.WriteLine(IpsFromUrls(url));

            // Chamada do Exercício 21.
            CadastrarPesquisarAlunos();

            // Chamada do Exercício 22.
            CadastrarModeloCarroNacional();

            // Chamada do Exercício 33.
            ContinentesPaisesPopulacao();

            Console.ReadKey();
        }
    }
}