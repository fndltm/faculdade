using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.CCelula
{
    #region Classe CFila - Fila (ou lista FIFO: first-in first-out)
    /// <summary>
    /// Classe que representa uma Fila (ou lista FIFO: first-in first-out)
    /// </summary>
    public class CFila
    {
        private CCelula Frente; // Referencia a primeira célula da CFila (Célula cabeça)
        private CCelula Tras; // Referencia a última célula da CFila
        private int Qtde = 0;

        /// <summary>
        /// Função construtora. Cria a célula cabeça e faz as referências Frente e Tras apontarem para ela.
        /// </summary>
        public CFila(int Tamanho)
        {
            for (int i = 0; i < Tamanho; i++)
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
    }
    #endregion
}
