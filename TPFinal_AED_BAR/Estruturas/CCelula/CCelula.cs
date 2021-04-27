using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal_AED_BAR.Estruturas.CCelula
{
    #region Classe CCelula - representa a célula utilizada pelas classes CLista, CFila e CPilha
    /// <summary>
    /// Classe utilizada pelas classes CLista, CFila e CPilha
    /// </summary>
    public class CCelula
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
}
