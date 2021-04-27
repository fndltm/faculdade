using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.CCelula
{
    #region Classe CPilha - CPilha (ou lista LIFO: last-in first-out)
    /// <summary>
    /// Classe que representa uma Pilha (ou lista LIFO: last-in first-out)
    /// </summary>
    public class CPilha
    {
        private CCelula Topo = null;
        private int Qtde = 0;

        /// <summary>
        /// Função construtora.
        /// </summary>
        public CPilha(int Tamanho)
        {
            for (int i = 0; i < Tamanho; i++)
                this.Topo = new CCelula();
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
    }
    #endregion
}
