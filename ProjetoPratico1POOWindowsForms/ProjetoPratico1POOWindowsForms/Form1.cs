using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class FormPrincipalConvencional : Form
    {
        //Inicializa o primeiro Noh como a primeira senha
        Noh noh = new Noh("C0001");

        //Cria uma instância da classe FilaFIFO para enfileirar novos elementos
        FilaFIFO fila = new FilaFIFO();

        /**
         * Atribuição do tipo DateTime. Será utilizada
         * para pegar a data e hora atual e exibir em um label
         */
        DateTime dataHora;

        //Inicializa como 1 porque o primeiro elemento já existe
        int contSenhas = 1;

        //Inicializa como 0 porque deseja-se percorrer todos da fila
        int contProximasSenhas = 0;

        //Declara um Array de string com 100 posições para guardar até 100 senhas
        string[] senhas = new string[5];

        //Inicializa o componente das senhas
        public FormPrincipalConvencional()
        {
            InitializeComponent();

            //Chama o método estático da classe FilaFIFO para testar se seus métodos funcionam ou não
            FilaFIFO.TestaFilaFIFO();

            /**
             * Bloco para verificar qual elemento (senha) será adicionada
             * ------------------------------------------------------------------------
             * Caso menor que 10 a string deve ser C000 - e o próximo número de 1 até 9
             * ------------------------------------------------------------------------
             * Caso maior ou igual a 10 e menor que 100 a string deve ser C00 -
             * e o próximos números de 10 até 99
             * ------------------------------------------------------------------------
             * Caso seja igual a 100 monta a string C0100
            */
            for (int i = 0; i < senhas.Length; i++)
            {
                if (contSenhas < 10)
                {
                    senhas[i] = "C000" + contSenhas;
                }
                else if (contSenhas >= 10 && contSenhas < 100)
                {
                    senhas[i] = "C00" + contSenhas;
                }
                else if (contSenhas == 100)
                {
                    senhas[i] = "C0100";
                }
                contSenhas++;

                //Cria uma fila do tamanho do Array 'senhas' e insere elementos nesta
                fila.Enfileira(senhas[i]);
            }

            /**
            * Atribui na label senhaAtual o primeiro elemento da fila,
            * que sempre será a senha C0001, inicialmente
            */
            labelSenhaAtual.Text = fila.GetElementoFrente().ToString();

            //Se houver alguém na fila, Setta a label tamanho da fila com a quantidade de pessoas que estão na fila
            if (!fila.Vazia())
                labelNumeroTamFila.Text = fila.GetTamanho().ToString();
        }

        /**
         * Método para inicializar a classe Timer (definido no Form)
         * com um intervalo de 1 segundo, ou seja, fica contando de 1 em 1 segundo
         */
        public void TimerLabelDateTime_Tick(object sender, EventArgs e)
        {
            //Atribuição da data e hora atual
            dataHora = DateTime.Now;

            //Inicializa (exibe) o contador de segundos no painel
            labelDateTime.Text = dataHora.ToShortDateString() + " " + dataHora.ToLongTimeString();
        }

        /**
         * Método responsável por atribuir ação de click no botão PRÓXIMO para
         * chamar a próxima pessoa da fila, atualizando a senha atual e anterior
         * Conta quantas pessoas há na fila
        */
        private void Button1_Click(object sender, EventArgs e)
        {
            /**
             * Se a contagem de senhas (próximas senhas) for menor que a quantidade de pessoas na fila, executa
             * senão, é porque a fila está vazia e o expediente é encerrado
            */
            if (contProximasSenhas < senhas.Length)
            {
                /**
                 * Tratamento de exceção IndexOutOfRangeException
                 * Caso aparece essa exceção é porque o índice do array é maior do que o tamanho do array
                 * Se isto acontece, é porque a fila está vazia
                 * Caso caia na exceção será enviada a mensagem "O expediente acabou!" e fechará o programa
                */
                try
                {
                    //Se a fila estiver vazia, exibe mensagem e fecha o programa
                    if (fila.Vazia())
                    {
                        MessageBox.Show("O expediente acabou!", "Atenção!");
                        this.Close();
                    }

                    //Se a fila não estiver vazia, executa
                    else
                    {
                        //Desenfileira a fila a cada vez que o botão for clicado, ou seja, é a vez do próximo da fila
                        fila.Desenfileira();

                        //Setta a label número tamanho da fila com a quantidade de pessoas que estão na fila
                        labelNumeroTamFila.Text = fila.GetTamanho().ToString();

                        //Setta a label senha anterior como visível e setta o texto como a última senha chamada
                        labelSenhasAnteriores1.Visible = true;
                        labelSenhasAnteriores1.Text = noh.GetElemento().ToString();

                        //Incrementa a contagem das senhas para anexa-lá ao índice do array
                        contProximasSenhas++;

                        /**
                         * Setta o elemento do nó com a próxima senha do array e
                         * atribui no texto da label senha atual com o primeiro elemento da fila
                        */
                        noh.SetElemento(senhas[contProximasSenhas]);
                        labelSenhaAtual.Text = fila.GetElementoFrente().ToString();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("O expediente acabou!", "Atenção!");
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("O expediente acabou!", "Atenção!");
                this.Close();
            }
        }
    }
}
