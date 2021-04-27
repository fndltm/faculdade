using System.Windows.Forms;

namespace TPFinal_AED_BAR
{
    partial class Form1
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
            this.cbStructure = new System.Windows.Forms.ComboBox();
            this.toolTipBtnInsert = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnInsert = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGetData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSize = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dGVData = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInsertSuccess = new System.Windows.Forms.Panel();
            this.lblTimeElapsedInsert = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimeElapsedGetData = new MaterialSkin.Controls.MaterialLabel();
            this.tbValue = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblValue = new MaterialSkin.Controls.MaterialLabel();
            this.lblStructure = new MaterialSkin.Controls.MaterialLabel();
            this.tBSize = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStructure
            // 
            this.cbStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStructure.FormattingEnabled = true;
            this.cbStructure.Items.AddRange(new object[] {
            "Pilha",
            "Fila",
            "Lista",
            "Árvore",
            "Hash"});
            this.cbStructure.Location = new System.Drawing.Point(189, 73);
            this.cbStructure.Name = "cbStructure";
            this.cbStructure.Size = new System.Drawing.Size(134, 21);
            this.cbStructure.TabIndex = 6;
            this.cbStructure.SelectedIndexChanged += new System.EventHandler(this.CBStructure_SelectedIndexChanged);
            // 
            // toolTipBtnInsert
            // 
            this.toolTipBtnInsert.AutomaticDelay = 100;
            this.toolTipBtnInsert.IsBalloon = true;
            this.toolTipBtnInsert.ShowAlways = true;
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(329, 73);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpar";
            this.toolTipBtnInsert.SetToolTip(this.btnClear, "Limpa um valor na estrutura selecionada");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Depth = 0;
            this.btnInsert.Location = new System.Drawing.Point(329, 102);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = true;
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Inserir";
            this.toolTipBtnInsert.SetToolTip(this.btnInsert, "Insere um valor na estrutura selecionada");
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Depth = 0;
            this.btnGetData.Location = new System.Drawing.Point(12, 444);
            this.btnGetData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Primary = true;
            this.btnGetData.Size = new System.Drawing.Size(105, 23);
            this.btnGetData.TabIndex = 17;
            this.btnGetData.Text = "Listar Dados";
            this.toolTipBtnInsert.SetToolTip(this.btnGetData, "Lista os dados de uma estrutura selecionada");
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnSize
            // 
            this.btnSize.Depth = 0;
            this.btnSize.Location = new System.Drawing.Point(123, 444);
            this.btnSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSize.Name = "btnSize";
            this.btnSize.Primary = true;
            this.btnSize.Size = new System.Drawing.Size(90, 23);
            this.btnSize.TabIndex = 18;
            this.btnSize.Text = "Quantidade";
            this.toolTipBtnInsert.SetToolTip(this.btnSize, "Lista os dados de uma estrutura selecionada");
            this.btnSize.UseVisualStyleBackColor = true;
            this.btnSize.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // dGVData
            // 
            this.dGVData.AllowUserToAddRows = false;
            this.dGVData.AllowUserToDeleteRows = false;
            this.dGVData.AllowUserToOrderColumns = true;
            this.dGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnValue});
            this.dGVData.Location = new System.Drawing.Point(12, 131);
            this.dGVData.Name = "dGVData";
            this.dGVData.ReadOnly = true;
            this.dGVData.Size = new System.Drawing.Size(392, 308);
            this.dGVData.TabIndex = 7;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.HeaderText = "Índice";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            // 
            // ColumnValue
            // 
            this.ColumnValue.HeaderText = "Valor";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            // 
            // panelInsertSuccess
            // 
            this.panelInsertSuccess.Location = new System.Drawing.Point(282, 445);
            this.panelInsertSuccess.Name = "panelInsertSuccess";
            this.panelInsertSuccess.Size = new System.Drawing.Size(10, 10);
            this.panelInsertSuccess.TabIndex = 8;
            // 
            // lblTimeElapsedInsert
            // 
            this.lblTimeElapsedInsert.AutoSize = true;
            this.lblTimeElapsedInsert.Depth = 0;
            this.lblTimeElapsedInsert.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimeElapsedInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeElapsedInsert.Location = new System.Drawing.Point(9, 470);
            this.lblTimeElapsedInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeElapsedInsert.Name = "lblTimeElapsedInsert";
            this.lblTimeElapsedInsert.Size = new System.Drawing.Size(0, 19);
            this.lblTimeElapsedInsert.TabIndex = 13;
            // 
            // lblTimeElapsedGetData
            // 
            this.lblTimeElapsedGetData.AutoSize = true;
            this.lblTimeElapsedGetData.Depth = 0;
            this.lblTimeElapsedGetData.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTimeElapsedGetData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimeElapsedGetData.Location = new System.Drawing.Point(9, 493);
            this.lblTimeElapsedGetData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeElapsedGetData.Name = "lblTimeElapsedGetData";
            this.lblTimeElapsedGetData.Size = new System.Drawing.Size(0, 19);
            this.lblTimeElapsedGetData.TabIndex = 14;
            // 
            // tbValue
            // 
            this.tbValue.Depth = 0;
            this.tbValue.Hint = "";
            this.tbValue.Location = new System.Drawing.Point(189, 102);
            this.tbValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbValue.Name = "tbValue";
            this.tbValue.PasswordChar = '\0';
            this.tbValue.SelectedText = "";
            this.tbValue.SelectionLength = 0;
            this.tbValue.SelectionStart = 0;
            this.tbValue.Size = new System.Drawing.Size(134, 23);
            this.tbValue.TabIndex = 19;
            this.tbValue.UseSystemPasswordChar = false;
            this.tbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBValue_KeyDown);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Depth = 0;
            this.lblValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValue.Location = new System.Drawing.Point(69, 106);
            this.lblValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(114, 19);
            this.lblValue.TabIndex = 20;
            this.lblValue.Text = "Digite um valor:";
            // 
            // lblStructure
            // 
            this.lblStructure.AutoSize = true;
            this.lblStructure.Depth = 0;
            this.lblStructure.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblStructure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStructure.Location = new System.Drawing.Point(9, 74);
            this.lblStructure.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(176, 19);
            this.lblStructure.TabIndex = 21;
            this.lblStructure.Text = "Selecione uma estrutura:";
            // 
            // tBSize
            // 
            this.tBSize.AutoSize = true;
            this.tBSize.Depth = 0;
            this.tBSize.Font = new System.Drawing.Font("Roboto", 11F);
            this.tBSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tBSize.Location = new System.Drawing.Point(219, 445);
            this.tBSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.tBSize.Name = "tBSize";
            this.tBSize.Size = new System.Drawing.Size(0, 19);
            this.tBSize.TabIndex = 23;
            this.tBSize.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 517);
            this.Controls.Add(this.tBSize);
            this.Controls.Add(this.lblStructure);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btnSize);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTimeElapsedGetData);
            this.Controls.Add(this.lblTimeElapsedInsert);
            this.Controls.Add(this.panelInsertSuccess);
            this.Controls.Add(this.dGVData);
            this.Controls.Add(this.cbStructure);
            this.Name = "Form1";
            this.Text = "TPFinal_AED_BAR";
            ((System.ComponentModel.ISupportInitialize)(this.dGVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbStructure;
        private System.Windows.Forms.ToolTip toolTipBtnInsert;
        private System.Windows.Forms.DataGridView dGVData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private Panel panelInsertSuccess;
        private MaterialSkin.Controls.MaterialLabel lblTimeElapsedInsert;
        private MaterialSkin.Controls.MaterialLabel lblTimeElapsedGetData;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialRaisedButton btnInsert;
        private MaterialSkin.Controls.MaterialRaisedButton btnGetData;
        private MaterialSkin.Controls.MaterialRaisedButton btnSize;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbValue;
        private MaterialSkin.Controls.MaterialLabel lblValue;
        private MaterialSkin.Controls.MaterialLabel lblStructure;
        private MaterialSkin.Controls.MaterialLabel tBSize;
    }
}

