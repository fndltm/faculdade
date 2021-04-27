using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.CCelula
{
    #region Classe CLista - Lista encadeada (simples) com célula cabeça
    /// <summary>
    /// Implementa uma lista encadeada com célula cabeça.
    /// </summary>
    public class CLista
    {
        private CCelula Primeira; // Referencia a célula cabeça 
        private CCelula Ultima; // Referencia a última célula da lista
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Aloca a célula cabeça e faz todas as referências apontarem para ela.
        /// </summary>
        public CLista(int Tamanho)
        {
            for (int i = 0; i < Tamanho; i++)
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
        /// <param name="p">A posição desejada. A primeira posição da lista é a posição 1.</param>
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
    }
    #endregion
}
