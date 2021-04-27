namespace ProjetoPratico1POOWindowsForms
{
    partial class FormPrincipalConvencional
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelFila = new System.Windows.Forms.Panel();
            this.labelNumeroTamFila = new System.Windows.Forms.Label();
            this.labelTamanhoFila = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSenha = new System.Windows.Forms.Panel();
            this.labelTituloSCSenha = new System.Windows.Forms.Label();
            this.labelSenhaAtual = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.panelSenhasAnteriores = new System.Windows.Forms.Panel();
            this.labelSenhasAnteriores1 = new System.Windows.Forms.Label();
            this.labelTituloSenhasAnteriores = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.timerLabelDateTime = new System.Windows.Forms.Timer(this.components);
            this.panelFila.SuspendLayout();
            this.panelSenha.SuspendLayout();
            this.panelSenhasAnteriores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFila
            // 
            this.panelFila.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelFila.Controls.Add(this.labelNumeroTamFila);
            this.panelFila.Controls.Add(this.labelTamanhoFila);
            this.panelFila.Controls.Add(this.button1);
            this.panelFila.Controls.Add(this.panelSenha);
            this.panelFila.Controls.Add(this.labelDateTime);
            this.panelFila.Controls.Add(this.panelSenhasAnteriores);
            this.panelFila.Controls.Add(this.labelTitulo);
            this.panelFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFila.Location = new System.Drawing.Point(12, 12);
            this.panelFila.Name = "panelFila";
            this.panelFila.Size = new System.Drawing.Size(335, 176);
            this.panelFila.TabIndex = 0;
            // 
            // labelNumeroTamFila
            // 
            this.labelNumeroTamFila.AutoSize = true;
            this.labelNumeroTamFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTamFila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelNumeroTamFila.Location = new System.Drawing.Point(127, 119);
            this.labelNumeroTamFila.Name = "labelNumeroTamFila";
            this.labelNumeroTamFila.Size = new System.Drawing.Size(36, 20);
            this.labelNumeroTamFila.TabIndex = 7;
            this.labelNumeroTamFila.Text = "100";
            // 
            // labelTamanhoFila
            // 
            this.labelTamanhoFila.AutoSize = true;
            this.labelTamanhoFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanhoFila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTamanhoFila.Location = new System.Drawing.Point(3, 119);
            this.labelTamanhoFila.Name = "labelTamanhoFila";
            this.labelTamanhoFila.Size = new System.Drawing.Size(131, 20);
            this.labelTamanhoFila.TabIndex = 2;
            this.labelTamanhoFila.Text = "Tamanho da Fila:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "PRÓXIMO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panelSenha
            // 
            this.panelSenha.Controls.Add(this.labelTituloSCSenha);
            this.panelSenha.Controls.Add(this.labelSenhaAtual);
            this.panelSenha.Location = new System.Drawing.Point(3, 36);
            this.panelSenha.Name = "panelSenha";
            this.panelSenha.Size = new System.Drawing.Size(117, 80);
            this.panelSenha.TabIndex = 5;
            // 
            // labelTituloSCSenha
            // 
            this.labelTituloSCSenha.AutoSize = true;
            this.labelTituloSCSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloSCSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTituloSCSenha.Location = new System.Drawing.Point(18, 10);
            this.labelTituloSCSenha.Name = "labelTituloSCSenha";
            this.labelTituloSCSenha.Size = new System.Drawing.Size(70, 20);
            this.labelTituloSCSenha.TabIndex = 0;
            this.labelTituloSCSenha.Text = "SENHA";
            // 
            // labelSenhaAtual
            // 
            this.labelSenhaAtual.AutoSize = true;
            this.labelSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelSenhaAtual.Location = new System.Drawing.Point(4, 30);
            this.labelSenhaAtual.Name = "labelSenhaAtual";
            this.labelSenhaAtual.Size = new System.Drawing.Size(110, 37);
            this.labelSenhaAtual.TabIndex = 1;
            this.labelSenhaAtual.Text = "C0001";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDateTime.Location = new System.Drawing.Point(158, 119);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(174, 20);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "01/05/2019 23:26:00";
            // 
            // panelSenhasAnteriores
            // 
            this.panelSenhasAnteriores.Controls.Add(this.labelSenhasAnteriores1);
            this.panelSenhasAnteriores.Controls.Add(this.labelTituloSenhasAnteriores);
            this.panelSenhasAnteriores.Location = new System.Drawing.Point(122, 36);
            this.panelSenhasAnteriores.Name = "panelSenhasAnteriores";
            this.panelSenhasAnteriores.Size = new System.Drawing.Size(210, 80);
            this.panelSenhasAnteriores.TabIndex = 4;
            // 
            // labelSenhasAnteriores1
            // 
            this.labelSenhasAnteriores1.AutoSize = true;
            this.labelSenhasAnteriores1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhasAnteriores1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelSenhasAnteriores1.Location = new System.Drawing.Point(49, 30);
            this.labelSenhasAnteriores1.Name = "labelSenhasAnteriores1";
            this.labelSenhasAnteriores1.Size = new System.Drawing.Size(112, 37);
            this.labelSenhasAnteriores1.TabIndex = 2;
            this.labelSenhasAnteriores1.Text = "C0002";
            this.labelSenhasAnteriores1.Visible = false;
            // 
            // labelTituloSenhasAnteriores
            // 
            this.labelTituloSenhasAnteriores.AutoSize = true;
            this.labelTituloSenhasAnteriores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloSenhasAnteriores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTituloSenhasAnteriores.Location = new System.Drawing.Point(20, 10);
            this.labelTituloSenhasAnteriores.Name = "labelTituloSenhasAnteriores";
            this.labelTituloSenhasAnteriores.Size = new System.Drawing.Size(166, 20);
            this.labelTituloSenhasAnteriores.TabIndex = 1;
            this.labelTituloSenhasAnteriores.Text = "SENHA ANTERIOR";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTitulo.Location = new System.Drawing.Point(53, 2);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(245, 31);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "CONVENCIONAL";
            // 
            // timerLabelDateTime
            // 
            this.timerLabelDateTime.Enabled = true;
            this.timerLabelDateTime.Interval = 1000;
            this.timerLabelDateTime.Tick += new System.EventHandler(this.TimerLabelDateTime_Tick);
            // 
            // FormPrincipalConvencional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 193);
            this.Controls.Add(this.panelFila);
            this.Name = "FormPrincipalConvencional";
            this.Text = "Convencional";
            this.panelFila.ResumeLayout(false);
            this.panelFila.PerformLayout();
            this.panelSenha.ResumeLayout(false);
            this.panelSenha.PerformLayout();
            this.panelSenhasAnteriores.ResumeLayout(false);
            this.panelSenhasAnteriores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFila;
        private System.Windows.Forms.Label labelSenhaAtual;
        private System.Windows.Forms.Label labelTituloSCSenha;
        private System.Windows.Forms.Timer timerLabelDateTime;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTituloSenhasAnteriores;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Panel panelSenhasAnteriores;
        private System.Windows.Forms.Panel panelSenha;
        private System.Windows.Forms.Label labelSenhasAnteriores1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTamanhoFila;
        private System.Windows.Forms.Label labelNumeroTamFila;
    }
}

