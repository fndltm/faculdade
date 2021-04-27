using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * A idéia do programa, é uma fila de banco como se fosse apenas um guichê
 * 
 * ----------------------------------------------------------
 * No painel inicial do programa, há 4 labels
 * Um de senha atual (o elemento do nó)
 * Um de senha anterior (o elemento que foi removido da fila)
 * A quantidade de pessoas na fila (o tamanho da fila)
 * Um label exibindo a data e hora em tempo real
 * 
 * ----------------------------------------------------------
 * Há também um botão com o texto PRÓXIMO
 * Este será responsável por chamar a próxima pessoa da fila,
 * atualizando a senha atual e anterior
 * Conta quantas pessoas há na fila
 * ----------------------------------------------------------
 * 
 * ------------------- CÓDIGO DE HONRA ----------------------
 * ALUNOS AJUDADOS:
 * DIEGO LEITE PORTES CAETANO
 * JOÃO VITOR DE ARAÚJO PINTO
 * LUIZ GUSTAVO DUARTE
 * 
 * PESSOAS DAS QUAIS RECEBI AJUDA:
 * 
 * ------------------------------------------------------------------
 * GEANDERSON ESTEVES - PROFESSOR LAB POO
 * JOÃO VITOR DE ARAÚJO PINTO
 * MARCOS MELO DE OLIVEIRA - PRIMO
 * 
 * João Vitor me ajudou na correção da implementação da classe FilaFIFO pois meu método GetElementoFrente() não funcionava
 * corretamente. O mesmo me ajudou a fixá-lo.
 * Trecho de código: Program.cs - linha 98
 * ------------------------------------------------------------------
 * Geanderson e Marcos Melo me ajudaram a desenvolver a lógica geral do programa,
 * alguns aperfeiçoamentos, idéias e correções.
 * Logo não marcarei trechos de códigos pois as ajudas foram no geral
 * ------------------------------------------------------------------
 * 
 * O código principal do programa está no arquivo Form1.cs, juntamente com os eventos,
 * settagem de texto, atribuições e controle geral da fila
 * No Program.cs há apenas a implementação da classe Noh e FilaFIFO
*/

namespace ProjetoPratico1POOWindowsForms
{
    class Noh
    {
        private Object elemento;
        private Noh próximo;
        public Noh(Object elemento)
        {
            this.elemento = elemento;
        }
        public Object GetElemento()
        {
            return this.elemento;
        }
        public void SetElemento(Object novoElemento)
        {
            this.elemento = novoElemento;
        }
        public Noh GetProximo()
        {
            return this.próximo;
        }
        public void SetProximo(Noh próximo)
        {
            this.próximo = próximo;
        }
    }
    class FilaFIFO
    {
        private Noh cabeça;
        private Noh frente;
        private Noh tras;
        private int tamanho; // número de elementos na fila

        /**
        * Cria uma fila vazia.
        */
        public FilaFIFO()
        {
            this.cabeça = new Noh("CABEÇA");
            this.tras = new Noh("VAZIO");
            this.cabeça.SetProximo(this.tras);
            this.frente = this.tras;
            this.tamanho = 0;
        }
        /*
        * Verifica se a fila está vazia ou não.
        */
        public bool Vazia()
        {
            return this.frente == this.tras;
        }
        public Object GetElementoFrente()
        {
            return this.frente.GetElemento();
        }
        public int GetTamanho()
        {
            return this.tamanho;
        }
        /**
        * Enfileira um novo elemento na última posição da fila.
        */
        public void Enfileira(Object novoElemento)
        {
            // seta o novo elemento como o elemento de this.tras
            this.tras.SetElemento(novoElemento);

            // cria um novo Noh para ser o novo tras
            Noh aux = new Noh(null);

            // encadeia o novo nó usando this.tras e aux
            this.tras.SetProximo(aux);

            //atualiza this.tras
            this.tras = this.tras.GetProximo();
            this.tamanho++;
        }
        public void Desenfileira()
        {
            // se esta fila estiver vazia então indica erro
            if (this.Vazia())
            {
            }
            else
            {
                // desliga o nó referenciado por this.frente
                this.cabeça.SetProximo(this.frente.GetProximo());

                // atualiza this.frente
                this.frente = this.frente.GetProximo();

                // atualiza this.tamanho
                this.tamanho--;
            }
        }

        /**
         * Criação do procedimento para testar a Fila FIFO
        */
        public static void TestaFilaFIFO()
        {
            //Criação da instância da classe FilaFIFO
            FilaFIFO fila = new FilaFIFO();

            //Array de string para criação de 3 elementos com o objetivo de popular a fila
            string[] elementos = new string[3];

            //Bloco para atribuir elementos no array e preencher a fila
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = "Elemento número: " + i;
                fila.Enfileira(elementos[i]);
            }

            //Mensagem para informar que o teste será executado
            MessageBox.Show("Será executado um teste automático para saber se todos os métodos" +
                " da classe FilaFIFO está funcionando", "ATENÇÃO!");

            //Bloco para informar se o método FilaFIFO.Vazia() funciona
            if (fila.Vazia())
            {
                MessageBox.Show("A fila está vazia!", "FilaFIFO.Vazia() == true!");
            }
            else
            {
                MessageBox.Show("A fila não está vazia!", "FilaFIFO.Vazia() == false!");
            }

            //Mensagem para informar o tamanho da fila
            MessageBox.Show(fila.GetTamanho().ToString(), "Tamanho da fila (FilaFIFO.GetTamanho())");

            //Mensagem para informar o primeiro elemento
            MessageBox.Show(fila.GetElementoFrente().ToString(), "Primeiro elemento da fila (FilaFIFO.GetElementoFrente()");

            //Bloco para desenfileirar todos os elementos da fila
            for (int i = 0; i < elementos.Length; i++)
            {
                fila.Desenfileira();
            }

            //Bloco para mostrar o tamanho da fila após todos os elementos serem desenfileirados
            MessageBox.Show(fila.GetTamanho().ToString(), "Tamanho da fila após desenfileirar todos os elementos");

            //Bloco para verificar se o método FilaFifo.Desenfileira() funciona
            if (fila.GetTamanho() == 0)
            {
                MessageBox.Show("A fila está vazia, ou seja, método desenfileira funciona",
                    "Método FilaFIFO.Desenfileira() funciona!");
            }
            else
            {
                MessageBox.Show("A fila não está vazia, ou seja, método desenfileira não funciona",
                    "Método FilaFIFO.Desenfileira() não funciona!");
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipalConvencional());
        }
    }
}
