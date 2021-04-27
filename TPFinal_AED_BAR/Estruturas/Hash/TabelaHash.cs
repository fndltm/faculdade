using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.Hash
{
    public class TabelaHash
    {
        private Registro[] valores;
        private int Quantidade = 0;
        public TabelaHash(int Tamanho)
        {
            valores = new Registro[Tamanho];
        }
        public void put(Registro registro)
        {
            int posicao = registro.hashCode();
            if (valores[posicao] == null)
            {
                valores[posicao] = registro;
                //Console.WriteLine("=====Posicao vazia!! Novo Registro");
                Quantidade++;
            }
            else
            {
                //Console.WriteLine("Ops... colisao! >>>");
                Registro reg = valores[posicao];
                // especial para tratar o primeiro elemento
                if (reg.getKey() == registro.getKey())
                { // o registro que quero inserir é o mesmo que já existe?
                    reg.setValue(registro.getValue());  // apenas substituo o valor
                                                        //Console.WriteLine("É o primeiro Registro Existente - atualizando...");
                    Quantidade++;
                    return;
                }
                // se ele tá no meio da lista
                while (reg.getProximo() != null)
                {
                    if (reg.getKey() == registro.getKey())
                    { // o registro que quero inserir é o mesmo que já existe?
                        reg.setValue(registro.getValue());  // apenas substituo o valor
                        Quantidade++;
                        return;
                    }
                    reg = reg.getProximo();
                }
                // se ele é o último da lista
                //if (reg.getProximo() == null){
                if (reg.getKey() == registro.getKey())
                {
                    reg.setValue(registro.getValue());
                    //Console.WriteLine("É o ultimo! Registro Existente - atualizando...");
                    Quantidade++;
                    return;
                }
                //}
                reg.setProximo(registro); // coloquei o novo registro na última posicao
                                          //Console.WriteLine("Novo Registro!");


            }
        }
        public Registro get(int key)
        {
            Registro r = new Registro();
            r.setKey(key);
            int posicao = r.hashCode();
            Registro resultado = valores[posicao]; // tento encontrar o registro
            if (resultado != null && resultado.getKey() == key)
            { // é o que eu tô procurando?
                return resultado;
            }
            else
            {
                while (resultado != null)
                { // enquanto tiver gente na lista...
                    resultado = resultado.getProximo();  // vou pro próximo
                    if (resultado != null && resultado.getKey() == key)
                    {// é o cara?
                        return resultado; // se for, retorno ele
                    }
                }
            }
            return null;
        }

        public int GetQuantidade()
        {
            return this.Quantidade;
        }
    }
}
