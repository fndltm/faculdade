using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_AED_FILA_PILHA
{
    public class Aluno
    {
        private int numeroAluno = 1;

        private Stack pilhaAlunos;

        private Queue filaAlunos;

        public void CadastrarAluno()
        {
            this.pilhaAlunos.Push(numeroAluno++);

            Console.WriteLine("Digite o nome do aluno: ");
            this.pilhaAlunos.Push(Console.ReadLine());

            Console.WriteLine("Aluno cadastrado.");
        }

        public void CadastrarNota(int numeroAluno)
        {
            if (pilhaAlunos.Contains(numeroAluno))
            {
                this.filaAlunos.Enqueue(numeroAluno);

                Console.WriteLine("Digite a nota do aluno: ");
                this.filaAlunos.Enqueue(Console.ReadLine());

                Console.WriteLine("Nota cadastrada.");
            }
            else
                Console.WriteLine("Aluno não cadastrado.");
        }

        public void DadosAluno()
        {
            Console.WriteLine("Digite o número do aluno para saber seus dados: ");
            int numero = int.Parse(Console.ReadLine());

            if (this.pilhaAlunos.Contains(numero))
            {
                Queue temp = new Queue();
                Object aux;
                double soma = 0, media = 0;
                int count = 0;

                // Remove o nome.
                temp.Enqueue(this.pilhaAlunos.Pop());

                // Remove novamente, para verificar o número.
                aux = this.pilhaAlunos.Pop();
                temp.Enqueue(aux);

                while ((int)temp.Peek() != numero)
                {
                    // Remove o nome.
                    temp.Enqueue(this.pilhaAlunos.Pop());

                    // Remove novamente, para verificar o número.
                    aux = this.pilhaAlunos.Pop();
                    temp.Enqueue(aux);
                }


                for (int i = 0; i < temp.Count; i++)
                {
                    this.pilhaAlunos.Push(temp.Dequeue());
                }

                Queue auxFila = new Queue();
                int contteste = 0, num = 0;

                if (this.filaAlunos.Contains(numero))
                {
                    while (filaAlunos.Count > contteste)
                    {
                        aux = this.filaAlunos.Dequeue();
                        auxFila.Enqueue(auxFila);

                        if ((int)aux == numero)
                        {
                            num = (int)this.filaAlunos.Dequeue();
                            soma =+ num;
                            count++;
                            auxFila.Enqueue(num);
                        }
                        contteste++;
                    }


                    Console.WriteLine("Nome do aluno: " + aux);
                    Console.WriteLine("Média das notas = " + (soma/count));
                }
                else
                    Console.WriteLine("Aluno sem notas.");
            }
            else
            {
                Console.WriteLine("Aluno não cadastrado.");
            }
        }
    }
}
