using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.Arvore
{
    public class Arvore
    {
        public Noh Raiz { get; set; }
        private int Quantidade = 0;
        private List<int> ListaNum = new List<int>();

        public Arvore(int Tamanho)
        {
            this.Raiz = null;
            this.ListaNum = new List<int>();
            for (int i = 0; i < Tamanho; i++)
            {
                Noh noh = new Noh();
                noh.Esquerda = null;
                noh.Direita = null;
                noh.Valor = 0;
            }
        }

        public bool Add(int value)
        {
            Noh before = null, after = this.Raiz;

            while (after != null)
            {
                before = after;
                if (value < after.Valor) //Is new Noh in left tree? 
                    after = after.Esquerda;
                else if (value > after.Valor) //Is new Noh in right tree?
                    after = after.Direita;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Noh newNoh = new Noh();
            newNoh.Valor = value;

            if (this.Raiz == null)//Tree is empty
                this.Raiz = newNoh;
            else
            {
                if (value < before.Valor)
                    before.Esquerda = newNoh;
                else
                    before.Direita = newNoh;
            }

            this.Quantidade++;
            this.ListaNum.Add(newNoh.Valor);
            return true;
        }

        public Noh Pesquisar(int value)
        {
            return this.Pesquisar(value, this.Raiz);
        }

        public void Remover(int value)
        {
            Remover(this.Raiz, value);
        }

        private Noh Remover(Noh parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Valor) parent.Esquerda = Remover(parent.Esquerda, key);
            else if (key > parent.Valor)
                parent.Direita = Remover(parent.Direita, key);

            // if value is same as parent's value, then this is the Noh to be deleted  
            else
            {
                // Noh with only one child or no child  
                if (parent.Esquerda == null)
                    return parent.Direita;
                else if (parent.Direita == null)
                    return parent.Esquerda;

                // Noh with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Valor = ValorMinimo(parent.Direita);

                // Delete the inorder successor  
                parent.Direita = Remover(parent.Direita, parent.Valor);
            }

            return parent;
        }

        private int ValorMinimo(Noh Noh)
        {
            int minv = Noh.Valor;

            while (Noh.Esquerda != null)
            {
                minv = Noh.Esquerda.Valor;
                Noh = Noh.Esquerda;
            }

            return minv;
        }

        private Noh Pesquisar(int value, Noh parent)
        {
            if (parent != null)
            {
                if (value == parent.Valor) return parent;
                if (value < parent.Valor)
                    return Pesquisar(value, parent.Esquerda);
                else
                    return Pesquisar(value, parent.Direita);
            }

            return null;
        }

        public int GetProfundidadeArv()
        {
            return this.GetProfundidadeArv(this.Raiz);
        }

        private int GetProfundidadeArv(Noh parent)
        {
            return parent == null ? 0 : Math.Max(GetProfundidadeArv(parent.Esquerda), GetProfundidadeArv(parent.Direita)) + 1;
        }

        public void PreOrdem(Noh parent)
        {
            if (parent != null)
            {
                this.ListaNum.Add(parent.Valor);
                PreOrdem(parent.Esquerda);
                PreOrdem(parent.Direita);
            }
        }

        public void EmOrdem(Noh parent)
        {
            if (parent != null)
            {
                EmOrdem(parent.Esquerda);
                this.ListaNum.Add(parent.Valor);
                EmOrdem(parent.Direita);
            }
        }

        public void PosOrdem(Noh parent)
        {
            if (parent != null)
            {
                PosOrdem(parent.Esquerda);
                PosOrdem(parent.Direita);
                this.ListaNum.Add(parent.Valor);
            }
        }

        public int GetQuantidade()
        {
            return this.Quantidade;
        }

        public List<int> GetListaNum()
        {
            return this.ListaNum;
        }
    }
}
