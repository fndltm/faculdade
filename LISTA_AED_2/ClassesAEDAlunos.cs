using System;
using System.Collections;

namespace AED
{
    #region Classe CCelula - representa a célula utilizada pelas classes CLista, CFila e CPilha
    /// <summary>
    /// Classe utilizada pelas classes CLista, CFila e CPilha
    /// </summary>
    class CCelula
    {
        public Object Item; // O Item armazendo pela célula
        public CCelula Prox; // Referencia a próxima célula

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo null aos atributos Item e Prox.
        /// </summary>
        public CCelula()
        {
            Item = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo o valor passado por parâmetro ao atributo Item e null ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        public CCelula(object ValorItem)
        {
            Item = ValorItem;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo ValorItem ao atributo Item e ProxCelula ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula</param>
        /// <param name="ProxCelula">Referência para a próxima célula.</param>
        public CCelula(object ValorItem, CCelula ProxCelula)
        {
            Item = ValorItem;
            Prox = ProxCelula;
        }
    }
    #endregion

    #region Classe CCelulaDup - representa a célula utilizada pela classe CListaDup
    /// <summary>
    /// Classe utilizada pela classe CListaDup
    /// </summary>
    class CCelulaDup
    {

        public Object Item; // O Item armazendo pela célula
        public CCelulaDup Ant; // Referencia a célula anterior
        public CCelulaDup Prox; // Referencia a próxima célula

        /// <summary>
        /// Inicializa uma nova instância da classe CCelulaDup atribuindo null aos atributos Item, Ant e Prox.
        /// </summary>
        public CCelulaDup()
        {
            Item = null;
            Ant = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo o valor passado por parâmetro ao atributo Item e null aos atributos Ant e Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        public CCelulaDup(object ValorItem)
        {
            Item = ValorItem;
            Ant = null;
            Prox = null;
        }

        /// <summary>
        /// Inicializa uma nova instância da classe CCelula atribuindo ValorItem ao atributo Item e ProxCelular ao atributo Prox.
        /// </summary>
        /// <param name="ValorItem">Valor a ser armazenado pela célula.</param>
        /// <param name="celulaAnt">Referência para a célula anterior.</param>
        /// <param name="ProxCelula">Referência para a próxima célula.</param>
        public CCelulaDup(object ValorItem,
                          CCelulaDup celulaAnt,
                          CCelulaDup proxCelula)
        {
            Item = ValorItem;
            Ant = celulaAnt;
            Prox = proxCelula;
        }
    }
    #endregion

    #region Classe CFila - Fila (ou lista FIFO: first-in first-out)
    /// <summary>
    /// Classe que representa uma Fila (ou lista FIFO: first-in first-out)
    /// </summary>
    class CFila
    {
        private CCelula Frente; // Referencia a primeira célula da CFila (Célula cabeça)
        private CCelula Tras; // Referencia a última célula da CFila
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Cria a célula cabeça e faz as referências Frente e Tras apontarem para ela.
        /// </summary>
        public CFila()
        {
            Frente = new CCelula();
            Tras = Frente;
        }

        /// <summary>
        /// Verifica se a fila está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a lista estiver vazia e FALSE caso contrário.</returns>
        public bool Vazia()
        {
            return Frente == Tras;
        }

        /// <summary>
        /// Imprime os elementos da fila.
        /// </summary>
        public void mostra()
        {
            Console.Write("[ ");
            for (CCelula c = Frente.Prox; c != null; c = c.Prox)
                Console.Write(c.Item + " ");
            Console.WriteLine("] ");
        }

        /// <summary>
        /// Insere um novo Item no fim da fila.
        /// </summary>
        /// <param name="ValorItem">Um Object contendo o elemento a ser inserido no final da fila.</param>
        public void Enfileira(Object ValorItem)
        {
            Tras.Prox = new CCelula(ValorItem);
            Tras = Tras.Prox;
            Qtde++;
        }

        /// <summary>
        /// Retira e retorna o primeiro elemento da fila.
        /// </summary>
        /// <returns>Um Object contendo o primeiro elemento da fila. Caso a fila esteja vazia retorna null.</returns>
        public Object Desenfileira()
        {
            Object Item = null;
            if (Frente != Tras)
            {
                Frente = Frente.Prox;
                Item = Frente.Item;
                Qtde--;
            }
            return Item;
        }

        /// <summary>
        /// Retorna o primeiro Item da fila sem removê-lo.
        /// </summary>
        /// <returns>Um Object contendo o primeiro Item da fila.</returns>
        public Object Peek()
        {
            if (Frente != Tras)
                return Frente.Prox.Item;
            else
                return null;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Frente.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Frente.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da fila.
        /// </summary>
        /// <returns>Quantidade de itens da fila.</returns>
        public int Quantidade() //Função
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CFila usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Frente.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        /**
         * 5 – Crie a função CFila ConcatenaFila(CFila F1, CFila F2) que concatena as filas F1 e F2 passadas por
         * parâmetro.
         */
        /// <summary>
        /// Concatena as duas Filas passadas por parâmetro em apenas uma.
        /// </summary>
        /// <param name="F1">A primeira Fila a ser concatenada.</param>
        /// <param name="F2">A segunda Fila a ser concatenada.</param>
        /// <returns>A Fila que foi concatenada.</returns>
        public CFila ConcatenaFila(CFila F1, CFila F2)
        {
            CFila FilaConcatenada = new CFila();

            int QtdF1 = F1.Quantidade();
            int QtdF2 = F2.Quantidade();

            for (int i = 0; i < QtdF1; i++)
            {
                FilaConcatenada.Enfileira(F1.Desenfileira());
            }

            for (int i = 0; i < QtdF2; i++)
            {
                FilaConcatenada.Enfileira(F2.Desenfileira());
            }

            return FilaConcatenada;
        }
    }
    #endregion

    #region Classe CPilha - CPilha (ou lista LIFO: last-in first-out)
    /// <summary>
    /// Classe que representa uma Pilha (ou lista LIFO: last-in first-out)
    /// </summary>
    class CPilha
    {
        private CCelula Topo = null;
        private int Qtde = 0;

        /// <summary>
        /// Função construtora.
        /// </summary>
        public CPilha()
        {
            // nenhum código
        }

        /// <summary>
        /// Verifica se a Pilha está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a PILHA estiver vazia e FALSE caso contrário.</returns>
        public bool Vazia()
        {
            return Topo == null;
        }

        /// <summary>
        /// Insere o novo Item no Topo da Pilha
        /// </summary>
        /// <param name="ValorItem">Um Object contendo o Item a ser inserido no Topo da Pilha.</param>
        public void Empilha(Object ValorItem)
        {
            Topo = new CCelula(ValorItem, Topo);
            Qtde++;
        }

        /// <summary>
        /// Retira e retorna o Item do Topo da Pilha.
        /// </summary>
        /// <returns>Um Object contendo o Item retirado do Topo da Pilha. Caso a Pilha esteja vazia retorna null.</returns>
        public Object Desempilha()
        {
            Object Item = null;
            if (Topo != null)
            {
                Item = Topo.Item;
                Topo = Topo.Prox;
                Qtde--;
            }
            return Item;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Topo;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Topo; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Retorna o Item do Topo da Pilha sem removê-lo.
        /// </summary>
        /// <returns>Um Object contendo o Item do Topo da Pilha. Caso a Pilha esteja vazia retorna null.</returns>
        public Object Peek()
        {
            if (Topo != null)
                return Topo.Item;
            else
                return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da Pilha.
        /// </summary>
        /// <returns>Quantidade de itens da Pilha.</returns>
        public int Quantidade() //Função
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CPilha usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Topo; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        /**
         * 6 – Crie a função CPilha ConcatenaPilha(CPilha P1, CPilha P2) que concatena as pilhas P1 e P2 passadas
         * por parâmetro.
         */
        /// <summary>
        /// Concatena as duas Pilhas passadas por parâmetro em apenas uma.
        /// </summary>
        /// <param name="P1">A primeira Pilha a ser concatenada.</param>
        /// <param name="P2">A segunda Pilha a ser concatenada.</param>
        /// <returns>A Pilha que foi concatenada.</returns>
        public CPilha ConcatenaPilha(CPilha P1, CPilha P2)
        {
            CPilha PilhaConcatenada = new CPilha();

            int QtdP1 = P1.Quantidade();
            int QtdP2 = P2.Quantidade();

            for (int i = 0; i < QtdP1; i++)
            {
                PilhaConcatenada.Empilha(P1.Desempilha());
            }

            for (int i = 0; i < QtdP2; i++)
            {
                PilhaConcatenada.Empilha(P2.Desempilha());
            }

            return PilhaConcatenada;
        }
    }
    #endregion

    #region Classe CLista - Lista encadeada (simples) com célula cabeça
    /// <summary>
    /// Implementa uma lista encadeada com célula cabeça.
    /// </summary>
    class CLista
    {
        private CCelula Primeira; // Referencia a célula cabeça 
        private CCelula Ultima; // Referencia a última célula da lista
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Aloca a célula cabeça e faz todas as referências apontarem para ela.
        /// </summary>
        public CLista()
        {
            Primeira = new CCelula();
            Ultima = Primeira;
        }

        /// <summary>
        /// Verifica se a lista está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a lista estiver vazia e FALSE se ela tiver elementos.</returns>
        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        /// <summary>
        /// Insere um novo Item no fim da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void InsereFim(Object ValorItem)
        {
            Ultima.Prox = new CCelula(ValorItem);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        /// <summary>
        /// Insere um novo Item no começo da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void InsereComeco(Object ValorItem)
        {
            Primeira.Prox = new CCelula(ValorItem, Primeira.Prox);
            if (Primeira.Prox.Prox == null)
                Ultima = Primeira.Prox;
            Qtde++;
        }

        /// <summary>
        /// Insere o Item passado por parâmetro na posição determinada.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido na lista.</param>
        /// <param name="Posicao">Posição na qual o elemento será inserido. O primeiro elemento está na posição 1, e assim por diante.</param>
        /// <returns>Se a posição existir e o método conseguir inserir o elemento, retorna TRUE. Caso a posição não exista, retorna FALSE</returns>
        public bool InsereIndice(Object ValorItem, int Posicao)
        {
            // Verifica se a posição passada por parâmetro é uma posição válida, ou seja, no intervalo entre 1 e Qtde+1
            if (Posicao >= 1 && Posicao <= Qtde + 1)
            {
                int i = 0;
                CCelula aux = Primeira;
                // Procura a posição a ser inserido
                while (i < Posicao - 1)
                {
                    aux = aux.Prox;
                    i++;
                }
                aux.Prox = new CCelula(ValorItem, aux.Prox);
                if (aux.Prox.Prox == null) // se a célula inserida está na última posição.
                    Ultima = aux.Prox;
                Qtde++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Imprime todos os elementos da lista usando o comando while
        /// </summary>
        public void Imprime(bool ItemPorLinha)
        {
            CCelula aux = Primeira.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Prox;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista usando o comando for
        /// </summary>
        public void ImprimeFor()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write(aux.Item);
        }

        /// <summary>
        /// Imprime todos os elementos simulando formato de lista: [/]->[7]->[21]->[13]->null
        /// </summary>
        public void ImprimeFormatoLista()
        {
            Console.Write("[/]->");
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.Write("[" + aux.Item.ToString() + "]->");
            Console.WriteLine("null");
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">O Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = Primeira.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">O Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelula aux = Primeira.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Remove e retorna o primeiro Item da lista (remoção física, ou seja, elimina a célula que contém o elemento).
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaComeco()
        {
            // Verifica se há elementos na lista
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira.Prox;
                Primeira.Prox = aux.Prox;
                if (Primeira.Prox == null) // Se a célula cabeça está apontando para null, significa que o único elemento da lista foi removido
                    Ultima = Primeira;
                Qtde--;
                return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove e retorna o primeiro Item da lista (remoção lógica, ou seja, remove a célula cabeça fazendo com que a célula seguinte ela se torne a nova célula cabeça).
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaComecoSimples()
        {
            // Verifica se há elementos na lista
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
                return Primeira.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove o primeiro Item da lista fazendo com que a célula seguinte à célula cabeça se torne a nova célula cabeça. Não retorna o Item removido.
        /// </summary>
        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Qtde--;
            }
        }

        /// <summary>
        /// Remove o último Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                CCelula aux2 = aux.Prox;
                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
                return aux2.Item;
            }
            return null;
        }

        /// <summary>
        /// Remove o último Item da lista sem retorná-lo.
        /// </summary>
        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                while (aux.Prox != Ultima)
                    aux = aux.Prox;

                Ultima = aux;
                Ultima.Prox = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Localiza o Item passado por parâmetro e o remove da Lista
        /// </summary>
        /// <param name="ValorItem">Item a ser removido da lista.</param>
        public void Remove(Object ValorItem)
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                bool achou = false;
                while (aux.Prox != null && !achou)
                {
                    achou = aux.Prox.Item.Equals(ValorItem);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    aux.Prox = aux.Prox.Prox;
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde--;
                }
            }
        }

        /// <summary>
        /// Retorna o primeiro Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o primeiro Item da lista. Se a lista estiver vazia ou pos estiver posicionado em uma posição inválida a função retorna null.</returns>
        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.Prox.Item;
            else
                return null;
        }

        /// <summary>
        /// Retorna o último Item da lista.
        /// </summary>
        /// <returns>Um Object contendo o último Item da lista. Se a lista estiver vazia ou pos estiver posicionado em uma posição inválida a função retorna null.</returns>
        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.Item;
            else
                return null;
        }

        /// <summary>
        /// Retorna o Item contido na posição p da lista.
        /// </summary>
        /// <param name="Posicao">A posição desejada. A primeira posição da lista é a posição 1.</param>
        /// <returns>Um Object contendo o Item da posição p da lista.</returns>
        public Object RetornaIndice(int Posicao)
        {
            // EXERCÍCIO : deve retornar o elemento da posição p passada por parâmetro
            // [cabeça]->[7]->[21]->[13]->null
            // retornaIndice(2) deve retornar o elemento 21. retornaIndice de uma posiçao inexistente deve retornar null.
            // Se é uma posição válida e a lista possui elementos
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                int i = 1;
                CCelula aux = Primeira.Prox;
                // Procura a posição a ser inserido
                while (i < Posicao)
                {
                    aux = aux.Prox;
                    i++;
                }
                return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de itens da lista.
        /// </summary>
        /// <returns>Quantidade de itens da lista.</returns>
        public int Quantidade()
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CLista usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelula aux = Primeira.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        /**
         * 1 – Crie na CLista o método void InsereAntesDe(Object ElementoAInserir, Object Elemento) que insere o
         * ElementoAInserir na posição anterior ao Elemento passado por parâmetro.
         */
        /// <summary>
        /// Insere um elemento na posição anterior ao elemento encontrado.
        /// </summary>
        /// <param name="ElementoAInserir">O elemento que será inserido na posição anterior.</param>
        /// <param name="Elemento">O elemento que será procurado.</param>
        public void InsereAntesDe(Object ElementoAInserir, Object Elemento)
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                bool achou = false;
                while (aux.Prox != null && !achou)
                {
                    achou = aux.Prox.Item.Equals(Elemento);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    aux = new CCelula(ElementoAInserir, aux);
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde++;
                }
            }
        }

        /**
         * 2 – Crie na CLista o método void InsereDepoisDe(Object ElementoAInserir, Object Elemento) que insere
         * o ElementoAInserir na posição anterior ao Elemento passado por parâmetro.
         */
        /// <summary>
        /// Insere um elemento na posição posterior ao elemento encontrado.
        /// </summary>
        /// <param name="ElementoAInserir">O elemento que será inserido na posição posterior.</param>
        /// <param name="Elemento">O elemento que será procurado.</param>
        public void InsereDepoisDe(Object ElementoAInserir, Object Elemento)
        {
            if (Primeira != Ultima)
            {
                CCelula aux = Primeira;
                bool achou = false;
                while (aux.Prox != null && !achou)
                {
                    achou = aux.Prox.Item.Equals(Elemento);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    aux.Prox = new CCelula(ElementoAInserir, aux.Prox.Prox);
                    if (aux.Prox == null)
                        Ultima = aux;
                    Qtde++;
                }
            }
        }

        /**
         * 11 – Crie na CLista o método void RemovePos(int n) que remove o elemento na n-ésima posição da lista.
         */
        /// <summary>
        /// Remove o elemento na n-ésima posição da lista.
        /// </summary>
        /// <param name="n">A posição desejada. A primeira posição da lista é a posição 1.</param>
        public void RemovePos(int n)
        {
            if ((n >= 1) && (n <= Qtde) && (Primeira != Ultima))
            {
                int i = 1;
                CCelula aux = Primeira.Prox;
                // Procura a posição a ser removida
                while (i < n)
                {
                    aux = aux.Prox;
                    i++;
                }
                aux.Prox = aux.Prox.Prox;
                if (aux.Prox == null)
                    Ultima = aux;
                Qtde--;
            }
        }
    }
    #endregion

    #region Classe CListaDup - Lista duplamente encadeada com célula cabeça
    /// <summary>
    /// Implementa uma lista duplamente encadeada.
    /// </summary>
    class CListaDup
    {
        private CCelulaDup Primeira; // Referencia a primeira célula da lista (célula cabeça)
        private CCelulaDup Ultima; // Referencia a última célula da lista 
        private int Qtde = 0;

        /// <summary>
        /// Aloca a célula cabeça e faz todas as referências
        /// apontarem para ela.
        /// </summary>
        public CListaDup()
        {
            Primeira = new CCelulaDup();
            Ultima = Primeira;
        }

        /// <summary>
        /// Verifica se a lista está vazia.
        /// </summary>
        /// <returns>Retorna true se a lista estiver vazia.</returns>
        public bool Vazia()
        {
            return Primeira == Ultima;
        }

        /// <summary>
        /// Insere um novo elemento no fim da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido no final da lista.</param>
        public void InsereFim(Object ValorItem)
        {
            Ultima.Prox = new CCelulaDup(ValorItem, Ultima, null);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        /// <summary>
        /// Insere um novo elemento no começo da lista.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido no começo da lista.</param>
        public void InsereComeco(Object ValorItem)
        {
            if (Primeira == Ultima) // Se a lista estiver vazia insere no fim
            {
                Ultima.Prox = new CCelulaDup(ValorItem, Ultima, null);
                Ultima = Ultima.Prox;
            }
            else // senão insere no começo
            {
                Primeira.Prox = new CCelulaDup(ValorItem, Primeira, Primeira.Prox);
                Primeira.Prox.Prox.Ant = Primeira.Prox;
            }
            Qtde++;
        }

        /// <summary>
        /// Remove o primeiro elemento da lista. Na verdade, remove a referência para a célula cabeça, e torna a primeira célula na nova célula cabeça
        /// </summary>
        public void RemoveComecoSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Primeira = Primeira.Prox;
                Primeira.Ant = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada usando o comando while.
        /// </summary>
        public void Imprime()
        {
            CCelulaDup aux = Primeira.Prox;
            while (aux != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Prox;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada usando o comando for.
        /// </summary>
        public void ImprimeFor()
        {
            for (CCelulaDup aux = Primeira.Prox; aux != null; aux = aux.Prox)
                Console.WriteLine(aux.Item);
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada em sentido inverso usando o comando while.
        /// </summary>
        public void ImprimeInv()
        {
            CCelulaDup aux = Ultima;
            while (aux.Ant != null)
            {
                Console.WriteLine(aux.Item);
                aux = aux.Ant;
            }
        }

        /// <summary>
        /// Imprime todos os elementos da lista duplamente encadeada em sentido inverso usando o comando for.
        /// </summary>
        public void ImprimeInvFor()
        {
            for (CCelulaDup aux = Ultima; aux.Ant != null; aux = aux.Ant)
                Console.WriteLine(aux.Item);
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool Contem(Object elemento)
        {
            bool achou = false;
            CCelulaDup aux = Primeira.Prox;
            while (aux != null && !achou)
            {
                achou = aux.Item.Equals(elemento);
                aux = aux.Prox;
            }
            return achou;
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista. (Obs: usa o comando FOR)
        /// </summary>
        /// <param name="elemento">Um object contendo o Item a ser localiado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na lista.</returns>
        public bool ContemFor(Object elemento)
        {
            bool achou = false;
            for (CCelulaDup aux = Primeira.Prox; aux != null && !achou; aux = aux.Prox)
                achou = aux.Item.Equals(elemento);
            return achou;
        }

        /// <summary>
        /// Retorna o primeiro elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o primeiro elemento da lista ou null caso a lista esteja vazia.</returns>
        public Object RetornaPrimeiro()
        {
            if (Primeira != Ultima)
                return Primeira.Prox.Item;
            return null;
        }

        /// <summary>
        /// Retorna o Item contido na posição p da lista.
        /// </summary>
        /// <param name="p">A posição desejada. A Primeira posição da lista é a posição 1.</param>
        /// <returns>Um Object contendo o Item da posição p da lista.</returns>
        public Object RetornaIndice(int Posicao)
        {
            // EXERCÍCIO : deve retornar o elemento da posição p passada por parâmetro
            // [cabeça]->[7]->[21]->[13]->null
            // retornaIndice(2) deve retornar o elemento 21. retornaIndice de uma posiçao inexistente deve retornar null.
            // Se é uma posição válida e a lista possui elementos
            if ((Posicao >= 1) && (Posicao <= Qtde) && (Primeira != Ultima))
            {
                CCelulaDup aux = Primeira.Prox;
                // Procura a posição a ser inserido
                for (int i = 1; i < Posicao; i++, aux = aux.Prox) ;
                if (aux != null)
                    return aux.Item;
            }
            return null;
        }

        /// <summary>
        /// Retorna o elemento da última posição.
        /// </summary>
        /// <returns>Um object contendo o último elemento da lista ou null caso a lista esteja vazia.</returns>
        public Object RetornaUltimo()
        {
            if (Primeira != Ultima)
                return Ultima.Item;
            return null;
        }

        /// <summary>
        /// Remove o último elemento da lista. Na verdade, remove as referências para a última célula, forçando que o Garbage Collector desaloque a última célula
        /// </summary>
        public void RemoveFimSemRetorno()
        {
            if (Primeira != Ultima)
            {
                Ultima = Ultima.Ant;
                Ultima.Prox = null;
                Qtde--;
            }
        }

        /// <summary>
        /// Localiza o Item passado por parâmetro e o remove da Lista
        /// </summary>
        /// <param name="ValorItem">Item a ser removido da lista.</param>
        public void Remove(Object ValorItem)
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Primeira.Prox;
                bool achou = false;
                while (aux != null && !achou)
                {
                    achou = aux.Item.Equals(ValorItem);
                    if (!achou)
                        aux = aux.Prox;
                }
                if (achou) // achou o elemento
                {
                    CCelulaDup anterior = aux.Ant;
                    CCelulaDup proximo = aux.Prox;
                    anterior.Prox = proximo;
                    if (proximo != null)
                        proximo.Ant = anterior;
                    else
                        Ultima = anterior;
                    Qtde--;
                }
            }
        }

        /// <summary>
        /// Remove e retorna o primeiro elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o primeiro elemento da lista.</returns>
        public Object RemoveRetornaComeco()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Primeira.Prox;
                Primeira = Primeira.Prox;
                Primeira.Ant = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }

        /// <summary>
        /// Remove e retorna o último elemento da lista.
        /// </summary>
        /// <returns>Um object contendo o último elemento da lista.</returns>
        public Object RemoveRetornaFim()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Ultima;
                Ultima = Ultima.Ant;
                Ultima.Prox = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }

        /// <summary>
        /// Função que retorna a quantidade de elementos da lista.
        /// </summary>
        /// <returns>Quantidade de elementos da lista.</returns>
        public int Quantidade()
        {
            return Qtde;
        }

        /// <summary>
        /// Torna possível iterar sobre a CListaDup usando o comando foreach
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            for (CCelulaDup aux = Primeira.Prox; aux != null; aux = aux.Prox)
                yield return aux.Item;
        }

        /// <summary>
        /// Permite iterar sobre uma CListaDup de forma invertida usando o comando foreach
        /// </summary>
        /// Exemplo de uso: foreach(Object x in LD.Reverse)
        public IEnumerable Reverse
        {
            get
            {
                for (CCelulaDup aux = Ultima; aux != Primeira; aux = aux.Ant)
                    yield return aux.Item;
            }
        }

        /**
         * 4 – Crie a função CListaDup ConcatenaLD(CListaDup L1, CListaDup L2) que concatena as listas L1 e L2
         * passadas por parâmetro, retornando uma lista duplamente encadeada.
         */
        /// <summary>
        /// Concatena duas listas duplamente encadeadas passadas por parâmetros em apenas uma,
        /// contendo todos os elementos das duas listas.
        /// </summary>
        /// <param name="L1">A primeira lista a ser concatenada.</param>
        /// <param name="L2">A segunda lista a ser concatenada.</param>
        /// <returns>A lista concatenada.</returns>
        CListaDup ConcatenaLD(CListaDup L1, CListaDup L2)
        {
            CListaDup ListaDupConcatenada = new CListaDup();

            foreach (CCelulaDup item in L1)
            {
                ListaDupConcatenada.InsereFim(item);
            }

            foreach (CCelulaDup item in L2)
            {
                ListaDupConcatenada.InsereFim(item);
            }

            return ListaDupConcatenada;
        }
        /**
         * 8 – Crie na CListaDup o método int primeiraOcorrenciaDe(Object elemento) que busca e retorna o índice
         * da primeira ocorrência do elemento passado por parâmetro. Caso o elemento não exista, sua função deve
         * retornar um valor negativo. Obs: considere que o primeiro elemento está na posição 1.
         */
        /// <summary>
        /// Busca e retorna a primeira ocorrência do índice do elemento passado por parâmetro dentro da CListaDup.
        /// Caso não encontre o elemento, será retornado -1.
        /// </summary>
        /// <param name="elemento">O elemento que será pesquisado dentro da CListaDup.</param>
        /// <returns>O primeiro índice do elemento dentro da CListaDup ou -1, caso não exista.</returns>
        public int primeiraOcorrenciaDe(Object elemento)
        {
            if (Primeira != Ultima)
            {
                int indice = 1;
                CCelulaDup aux = Primeira.Prox;
                bool achou = false;
                while (aux != null && !achou)
                {
                    achou = aux.Item.Equals(elemento);
                    if (!achou)
                    {
                        aux = aux.Prox;
                        indice++;
                    }
                }
                return achou ? indice : -1;
            }
            else
                return -1;
        }

        /**
         * 9 – Crie na CListaDup o método int ultimaOcorrenciaDe(Object elemento) que busca e retorna o índice
         * da ultima ocorrência do elemento passado por parâmetro. Caso o elemento não exista, sua função deve
         * retornar um valor negativo. Obs: considere que o primeiro elemento está na posição 1.
         */
        /// <summary>
        /// Busca e retorna a última ocorrência do índice do elemento passado por parâmetro dentro da CListaDup.
        /// Caso não encontre o elemento, será retornado -1.
        /// </summary>
        /// <param name="elemento">O elemento que será pesquisado dentro da CListaDup.</param>
        /// <returns>O último índice do elemento dentro da CListaDup ou -1, caso não exista.</returns>
        public int ultimaOcorrenciaDe(Object elemento)
        {
            if (Primeira != Ultima)
            {
                int indice = 1, indiceElemento = 1;
                CCelulaDup aux = Primeira.Prox;
                bool achou = false;
                while (aux != null)
                {
                    achou = aux.Item.Equals(elemento);
                    if (!achou)
                    {
                        aux = aux.Prox;
                        indice++;
                    }
                    else
                    {
                        indiceElemento = indice;
                    }
                }
                return achou ? indiceElemento : -1;
            }
            else
                return -1;
        }

        /**
         * 12 – Crie na CListaDup o método void RemovePos(int n) que remove o elemento na n-ésima posição da lista.
         */
        /// <summary>
        /// Remove o elemento na n-ésima posição da lista
        /// </summary>
        /// <param name="n">A posição desejada. A Primeira posição da lista é a posição 1.</param>
        public void RemovePos(int n)
        {
            if ((n >= 1) && (n <= Qtde) && (Primeira != Ultima))
            {
                CCelulaDup aux = Primeira.Prox;
                // Procura a posição a ser removida
                for (int i = 1; i < n; i++, aux = aux.Prox) ;
                if (aux != null)
                {
                    CCelulaDup anterior = aux.Ant;
                    CCelulaDup proximo = aux.Prox;
                    anterior.Prox = proximo;
                    if (proximo != null)
                        proximo.Ant = anterior;
                    else
                        Ultima = anterior;
                    Qtde--;
                }
            }
        }
    }
    #endregion

    #region Classe RandomQueue - Fila que retorna elementos aleatórios
    /**
     * * 7 – A classe RandomQueue é uma Fila que retorna elementos aleatórios ao invés de sempre retornar o
     *  primeiro elemento.
     */
    /// <summary>
    /// Classe que representa uma fila aleatória
    /// </summary>
    public class RandomQueue
    {
        private CCelula Frente; // Referencia a primeira célula da RandomQueue (Célula cabeça)
        private CCelula Tras; // Referencia a última célula da RandomQueue
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Cria a célula cabeça e faz as referências Frente e Tras apontarem para ela.
        /// </summary>
        public RandomQueue()
        {
            Frente = new CCelula();
            Tras = Frente;
        }

        /// <summary>
        /// Verifica se a RandomQueue está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a RandomQueue estiver vazia e FALSE caso contrário.</returns>
        public bool isEmpty()
        {
            return Frente == Tras;
        }

        /// <summary>
        /// Insere um novo Item no fim da RandomQueue.
        /// </summary>
        /// <param name="item">Um Object contendo o elemento a ser inserido no final da RandomQueue.</param>
        public void Enqueue(Object item)
        {
            Tras.Prox = new CCelula(item);
            Tras = Tras.Prox;
            Qtde++;
        }

        /// <summary>
        /// Retira e retorna um elemento aleatório da RandomQueue.
        /// </summary>
        /// <returns>Um Object contendo um elemento aleatório da fila. Caso a fila esteja vazia retorna null.</returns>
        public Object Dequeue()
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, Qtde), cont = 0;

            Object Item = null;
            if (Frente != Tras)
            {
                bool achou = false;
                CCelula aux = Frente.Prox;
                while (aux != null && !achou)
                {
                    achou = cont.Equals(numAleatorio);
                    aux = aux.Prox;
                    cont++;
                }
                if (achou)
                {
                    Frente = aux.Prox;
                    Item = Frente.Item;
                    Qtde--;
                }
            }
            return Item;
        }

        /// <summary>
        /// Retorna um Item aleatório da RandomQueue sem removê-lo.
        /// </summary>
        /// <returns>Um Item aleatório da RandomQueue.</returns>
        public Object Sample()
        {
            Random random = new Random();
            int numAleatorio = random.Next(1, Qtde), cont = 0;

            if (Frente != Tras)
            {
                bool achou = false;
                CCelula aux = Frente.Prox;
                while (aux != null && !achou)
                {
                    achou = cont.Equals(numAleatorio);
                    aux = aux.Prox;
                    cont++;
                }
                if (achou)
                {
                    return aux.Item;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
    #endregion

    #region Classe Deque - Tipo Abstrato de Dados que funciona como uma Fila e Pilha
    /**
     * * 10 – Deque (Double-ended-queue) é um Tipo Abstrato de Dados (TAD) que funciona como uma Fila e
     * como uma Pilha, permitindo que itens sejam adicionados em ambos os extremos. 
     */
    /// <summary>
    /// Classe que representa uma Fila e Pilha
    /// </summary>
    public class Deque
    {
        private CCelulaDup Primeira; // Referencia a primeira célula do deque (célula cabeça)
        private CCelulaDup Ultima; // Referencia a última célula do deque
        private int Qtde = 0;

        /// <summary>
        /// Aloca a célula cabeça e faz todas as referências
        /// apontarem para ela.
        /// </summary>
        public Deque()
        {
            Primeira = new CCelulaDup();
            Ultima = Primeira;
        }

        /// <summary>
        /// Verifica se o deque está vazio.
        /// </summary>
        /// <returns>Retorna true se o deque estiver vazio.</returns>
        public bool isEmpty()
        {
            return Primeira == Ultima;
        }

        /// <summary>
        /// Função que retorna a quantidade de elementos do deque.
        /// </summary>
        /// <returns>Quantidade de elementos do deque.</returns>
        public int size()
        {
            return Qtde;
        }

        /// <summary>
        /// Insere um novo elemento no lado esquerdo do deque.
        /// </summary>
        /// <param name="item">O Item a ser inserido na esquerda do deque.</param>
        public void pushLeft(Object item)
        {
            if (Primeira == Ultima) // Se o deque estiver vazio insere no fim
            {
                Ultima.Prox = new CCelulaDup(item, Ultima, null);
                Ultima = Ultima.Prox;
            }
            else // senão insere na esquerda
            {
                Ultima.Ant = new CCelulaDup(item, Ultima.Ant.Ant, Ultima.Prox);
            }

            Qtde++;
        }

        /// <summary>
        /// Insere um novo elemento na direita do deque.
        /// </summary>
        /// <param name="item">O Item a ser inserido na direita do deque.</param>
        public void pushRight(Object item)
        {
            Ultima.Prox = new CCelulaDup(item, Ultima, null);
            Ultima = Ultima.Prox;
            Qtde++;
        }

        /// <summary>
        /// Remove e retorna um elemento à esquerda do deque.
        /// </summary>
        /// <returns>Um object contendo o elemento à esquerda do deque.</returns>
        public Object popLeft()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Primeira.Prox;
                Primeira = Primeira.Prox;
                Primeira.Ant = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }

        /// <summary>
        /// Remove e retorna um elemento à direita do deque.
        /// </summary>
        /// <returns>Um object contendo o elemento à direita do deque.</returns>
        public Object popRight()
        {
            if (Primeira != Ultima)
            {
                CCelulaDup aux = Ultima;
                Ultima = Ultima.Ant;
                Ultima.Prox = null;
                Qtde--;
                return aux.Item;
            }
            else
                return null;
        }
    }
    #endregion

    #region Classe CCelulaDicionario - representa a célula utilizada pela classe CDicionario
    /// <summary>
    /// Classe utilizada pela CDicionario
    /// </summary>
    public class CCelulaDicionario
    {
        // Atributos
        public Object key, value;
        public CCelulaDicionario prox;

        // Construtora que anula os três atributos da célula
        public CCelulaDicionario()
        {
            this.key = null;
            this.value = null;
            this.prox = null;
        }

        // Construtora que inicializa key e value com os argumentos passados
        // por parâmetro e anula a referência à próxima célula
        public CCelulaDicionario(Object chave, Object valor)
        {
            this.key = chave;
            this.value = valor;
            this.prox = null;
        }

        // Construtora que inicializa todos os atribulos da célula com os argumentos
        // passados por parâmetro
        public CCelulaDicionario(Object chave, Object valor, CCelulaDicionario proxima)
        {
            this.key = chave;
            this.value = valor;
            this.prox = proxima;
        }
    }
    #endregion

    #region Classe CDicionario - Lista encadeada do tipo dicionário com chave e valor
    /**
     * * 30 – Crie as classes CCelulaDicionario e CDicionario conforme a interface abaixo.
     */
    /// <summary>
    /// Lista encadeada com célula do tipo dicionário (chave, valor).
    /// </summary>
    public class CDicionario
    {
        private CCelulaDicionario primeira, ultima;

        /// <summary>
        /// Construtora para criar a célula cabeça.
        /// </summary>
        public CDicionario()
        {
            primeira = new CCelulaDicionario();
            ultima = primeira;
        }

        /// <summary>
        /// Verifica se o dicionário está vazio.
        /// </summary>
        /// <returns>Retorna TRUE se o dicionário estiver vazio e FALSE se ela tiver elementos.</returns>
        public bool vazio()
        {
            return primeira == ultima;
        }

        /// <summary>
        /// Adiciona um novo elemento com chave e valor no fim do dicionário.
        /// Não é possível adicionar uma chave duplicada.
        /// </summary>
        /// <param name="chave">A chave que será adicionada.</param>
        /// <param name="valor">O valor que será adicionado.</param>
        public void adiciona(Object chave, Object valor)
        {
            bool achou = false;
            CCelulaDicionario aux = primeira.prox;

            while (aux != null && !achou)
            {
                achou = aux.key.Equals(chave);
                aux = aux.prox;
            }

            if (!achou)
            {
                ultima.prox = new CCelulaDicionario(chave, valor);
                ultima = ultima.prox;
            }
        }

        /// <summary>
        /// Recebe uma chave e retorna um valor. Caso não exista retorna null.
        /// </summary>
        /// <param name="chave">A chave que será pesquisada dentro do dicionário.</param>
        /// <returns>O valor que será retornado de acordo com a chave pesquisada.</returns>
        public Object recebeValor(Object chave)
        {
            bool achou = false;
            CCelulaDicionario aux = primeira.prox;

            while (aux != null && !achou)
            {
                achou = aux.key.Equals(chave);
                aux = aux.prox;
            }

            if (achou)
            {
                return aux.value;
            }

            return null;
        }

        /**
         * * 30 - Agora usando sua classe CDicionario, crie um dicionário com URL’s e IP’s dos websites abaixo e mais 5 à
         *   sua escolha. O seu dicionário deve ser implementado usando a classe CDicionario e terá a URL como chave
         *   e o IP correspondente como valor (por exemplo, se digitarmos como chave a URL www.google.com, seu
         *   programa deve retornar o IP 74.125.234.81). O seu programa deve permitir que o usuário digite uma URL
         *   e deve imprimir o IP correspondente. Para descobrir o IP de um website, basta digitar ping + URL do
         *   website (exemplo: ping www.google.com).
         */
        /// <summary>
        /// Monta um dicionário utilizando a classe CDicionario.
        /// </summary>
        /// <param name="chave">Parâmetro para testar o método recebeValor.</param>
        public static void IpsFromUrls(Object chave)
        {
            Object valor = "";
            bool achou;
            CDicionario cDicionario = new CDicionario();
            cDicionario.adiciona("www.google.com", "172.217.172.132");
            cDicionario.adiciona("www.pucminas.br", "200.229.32.27");
            cDicionario.adiciona("www.gmail.com", "172.217.28.69");
            cDicionario.adiciona("www.youtube.com", "172.217.30.46");
            cDicionario.adiciona("www.capes.gov.br", "200.130.18.222");
            cDicionario.adiciona("www.yahoo.com", "72.30.35.10");
            cDicionario.adiciona("www.microsoft.com", "184.51.132.196");
            cDicionario.adiciona("www.twitter.com", "104.244.42.65");
            cDicionario.adiciona("www.brasil.gov.br", "170.246.252.243");
            cDicionario.adiciona("www.wikipedia.com", "208.80.154.232");
            cDicionario.adiciona("www.amazon.com", "72.246.131.124");
            cDicionario.adiciona("research.microsoft.com", "13.67.218.189");
            cDicionario.adiciona("www.facebook.com", "31.13.85.36");
            cDicionario.adiciona("www.whitehouse.gov", "23.74.201.158");
            cDicionario.adiciona("www.answers.com", "151.101.92.203");
            cDicionario.adiciona("www.uol.com.br", "52.84.169.238");
            cDicionario.adiciona("www.hotmail.com", "204.79.197.212");
            cDicionario.adiciona("www.cplusplus.com", "167.114.170.15");
            cDicionario.adiciona("www.nyt.com", "151.101.93.164");
            cDicionario.adiciona("www.apple.com", "23.55.32.111");

            valor = cDicionario.recebeValor(chave);

            Console.WriteLine("Valor: " + valor);
        }

        /**
         * * 31 – Um biólogo precisa de um programa que traduza uma trinca de nucleotídeos em seu aminoácido
         *  correspondente. Por exemplo, a trinca de aminoácidos ACG é traduzida como o aminoácido Treonina, e
         *  GCA em Alanina. Crie um programa em Java que use a sua classe CDicionario para criar um dicionário do
         *  código genético. O usuário deve digitar uma trinca (chave) e seu programa deve mostrar o nome (valor)
         *  do aminoácido correspondente. Use a tabela a seguir para cadastrar todas as trincas/aminoácidos.
         */
        /// <summary>
        /// Cria uma tabela de nucleotídeos utilizando a classe CDicionario.
        /// </summary>
        /// <param name="chave">A chave que será pesquisada para encontrar o valor.</param>
        /// <returns>O valor encontrado de acordo com a chave.</returns>
        public static string TabelaNucleotideos(string chave)
        {
            bool achou;

            string valor;

            CDicionario cDicionario = new CDicionario();

            // Fenilalanina
            cDicionario.adiciona("UUU", "Fenilalanina");
            cDicionario.adiciona("UUC", "Fenilalanina");
            // Leucina
            cDicionario.adiciona("UUA", "Leucina");
            cDicionario.adiciona("UUG", "Leucina");
            cDicionario.adiciona("CUU", "Leucina");
            cDicionario.adiciona("CUC", "Leucina");
            cDicionario.adiciona("CUA", "Leucina");
            cDicionario.adiciona("CUG", "Leucina");
            // Isoleucina
            cDicionario.adiciona("AUU", "Isoleucina");
            cDicionario.adiciona("AUC", "Isoleucina");
            cDicionario.adiciona("AUA", "Isoleucina");
            // Metionina
            cDicionario.adiciona("AUG", "Metionina");
            // Valina
            cDicionario.adiciona("GUU", "Valina");
            cDicionario.adiciona("GUC", "Valina");
            cDicionario.adiciona("GUA", "Valina");
            cDicionario.adiciona("GUG", "Valina");
            // Serina
            cDicionario.adiciona("UCU", "Serina");
            cDicionario.adiciona("UCC", "Serina");
            cDicionario.adiciona("UCA", "Serina");
            cDicionario.adiciona("UCG", "Serina");
            // Prolina
            cDicionario.adiciona("CCU", "Prolina");
            cDicionario.adiciona("CCC", "Prolina");
            cDicionario.adiciona("CCA", "Prolina");
            cDicionario.adiciona("CCG", "Prolina");
            // Treonina
            cDicionario.adiciona("ACU", "Treonina");
            cDicionario.adiciona("ACC", "Treonina");
            cDicionario.adiciona("ACA", "Treonina");
            cDicionario.adiciona("ACG", "Treonina");
            // Alanina
            cDicionario.adiciona("GCU", "Alanina");
            cDicionario.adiciona("GCC", "Alanina");
            cDicionario.adiciona("GCA", "Alanina");
            cDicionario.adiciona("GCG", "Alanina");
            // Tirosina
            cDicionario.adiciona("UAU", "Tirosina");
            cDicionario.adiciona("UAC", "Tirosina");
            cDicionario.adiciona("UAA", "Tirosina");
            cDicionario.adiciona("UAG", "Tirosina");
            // Histidina
            cDicionario.adiciona("CAU", "Histidina");
            cDicionario.adiciona("CAC", "Histidina");
            // Glutamina
            cDicionario.adiciona("CAA", "Glutamina");
            cDicionario.adiciona("CAG", "Glutamina");
            // Asparagina
            cDicionario.adiciona("AAU", "Asparagina");
            cDicionario.adiciona("AAC", "Asparagina");
            // Lisina
            cDicionario.adiciona("AAA", "Lisina");
            cDicionario.adiciona("AAG", "Lisina");
            // Aspartato
            cDicionario.adiciona("GAU", "Aspartato");
            cDicionario.adiciona("GAC", "Aspartato");
            // Glutamato
            cDicionario.adiciona("GAA", "Glutamato");
            cDicionario.adiciona("GAG", "Glutamato");
            // Cisteína
            cDicionario.adiciona("UGU", "Cisteína");
            cDicionario.adiciona("UGC", "Cisteína");
            // Parada
            cDicionario.adiciona("UGA", "Parada");
            // Triptofano
            cDicionario.adiciona("UGG", "Triptofano");
            // Arginina
            cDicionario.adiciona("CGU", "Arginina");
            cDicionario.adiciona("CGC", "Arginina");
            cDicionario.adiciona("CGA", "Arginina");
            cDicionario.adiciona("CGG", "Arginina");
            // Serina
            cDicionario.adiciona("AGU", "Serina");
            cDicionario.adiciona("AGC", "Serina");
            // Arginina
            cDicionario.adiciona("AGA", "Arginina");
            cDicionario.adiciona("AGG", "Arginina");
            // Glicina
            cDicionario.adiciona("GGU", "Glicina");
            cDicionario.adiciona("GGC", "Glicina");
            cDicionario.adiciona("GGA", "Glicina");
            cDicionario.adiciona("GGG", "Glicina");

            while (string.IsNullOrEmpty(chave))
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                chave = Console.ReadLine();
            }

            chave = chave.ToUpper();

            valor = cDicionario.recebeValor(chave).ToString();

            achou = !string.IsNullOrEmpty(valor);
            while (!achou)
            {
                Console.WriteLine("Valor não encontrado, digite outra chave: ");
                chave = Console.ReadLine();

                chave = chave.ToUpper();
                valor = cDicionario.recebeValor(chave).ToString();

                achou = !string.IsNullOrEmpty(valor);
            }

            return valor;
        }
    }
    #endregion

    #region Classe CCelula - representa a célula utilizada pela classe CListaSimples
    /**
     * * 32 – Crie a classe CListaSimples que é uma lista simplesmente encadeada sem célula cabeça e que possui
     *  apenas os métodos definidos na interface abaixo. Atenção: não podem ser acrescentados novos
     *  atributos ou métodos às classes CListaSimples e/ou CCelula abaixo.
     */
    /// <summary>
    /// Classe que será utilizada pela CListaSimples.
    /// </summary>
    public class CCelula
    {
        public int item;
        public CCelula prox;
    }
    #endregion

    #region Classe CListaSimples - Lista simplesmente encadeada sem célula cabeça
    /**
     * * 32 – Crie a classe CListaSimples que é uma lista simplesmente encadeada sem célula cabeça e que possui
     *  apenas os métodos definidos na interface abaixo. Atenção: não podem ser acrescentados novos
     *  atributos ou métodos às classes CListaSimples e/ou CCelula abaixo.
     */
    /// <summary>
    /// Representa uma Lista simplesmente encadeada.
    /// </summary>
    public class CListaSimples
    {
        private CCelula primeira, ultima;

        /// <summary>
        /// Função construtora. Inicializa a CListaSimples.
        /// </summary>
        public CListaSimples()
        {
            primeira = new CCelula();
            ultima = primeira;
        }

        /// <summary>
        /// Verifica se a lista está vazia.
        /// </summary>
        /// <returns>Retorna TRUE se a CListaSimples estiver vazia ou FALSE caso exista elementos.</returns>
        public bool vazia()
        {
            return primeira == ultima;
        }

        /// <summary>
        /// Insere um novo Item no começo da CListaSimples.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void insereComeco(Object ValorItem)
        {
            primeira.prox = (CCelula)ValorItem;
            if (primeira.prox.prox == null)
                ultima = primeira.prox;
        }

        /// <summary>
        /// Remove e retorna o primeiro Item da CListaSimples.
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a lista esteja vazia.</returns>
        public Object removeComeco()
        {
            // Verifica se há elementos na lista
            if (primeira != ultima)
            {
                primeira = primeira.prox;
                return primeira.item;
            }
            return null;
        }

        /// <summary>
        /// Insere um novo Item no fim da CListaSimples.
        /// </summary>
        /// <param name="ValorItem">O Item a ser inserido.</param>
        public void insereFim(Object ValorItem)
        {
            ultima.prox = (CCelula)ValorItem;
            ultima = ultima.prox;
        }

        /// <summary>
        /// Remove o último Item da CListaSimples.
        /// </summary>
        /// <returns>Um Object contendo o Item removido ou null caso a CListaSimples esteja vazia.</returns>
        public Object removeFim()
        {
            if (primeira != ultima)
            {
                CCelula aux = primeira;
                while (aux.prox != ultima)
                    aux = aux.prox;

                CCelula aux2 = aux.prox;
                ultima = aux;
                ultima.prox = null;
                return aux2.item;
            }
            return null;
        }

        /// <summary>
        /// Imprime todos os elementos da CListaSimples usando o comando while
        /// </summary>
        public void imprime()
        {
            CCelula aux = primeira.prox;
            while (aux != null)
            {
                Console.WriteLine(aux.item);
                aux = aux.prox;
            }
        }

        /// <summary>
        /// Verifica se o Item passado como parâmetro está contido na lista.
        /// </summary>
        /// <param name="elemento">O Item a ser localizado.</param>
        /// <returns>Retorna TRUE caso o Item esteja presente na CListaSimples.</returns>
        public bool contem(Object elemento)
        {
            bool achou = false;
            CCelula aux = primeira.prox;
            while (aux != null && !achou)
            {
                achou = aux.item.Equals(elemento);
                aux = aux.prox;
            }
            return achou;
        }
    }
    #endregion
}