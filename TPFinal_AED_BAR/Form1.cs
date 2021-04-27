using System;
using System.Windows.Forms;
using TPFinal_AED_BAR.Estruturas.CCelula;
using TPFinal_AED_BAR.Estruturas.Arvore;
using TPFinal_AED_BAR.Estruturas.Hash;
using System.Diagnostics;
using System.Collections.Generic;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TPFinal_AED_BAR
{
    public partial class Form1 : MaterialForm
    {
        public void SetTimeout(Action action, int timeout)
        {
            var timer = new Timer();
            timer.Interval = timeout;
            timer.Tick += delegate (object sender, EventArgs args)
            {
                action();
                timer.Stop();
            };
            timer.Start();
        }

        public static int cbIndex;
        private static readonly int Tamanho = 100000;
        int indice = 0;

        private static CPilha Pilha = new CPilha(Tamanho);
        private static CFila Fila = new CFila(Tamanho);
        private static CLista Lista = new CLista(Tamanho);
        private static Arvore Arvore = new Arvore(Tamanho);
        private static TabelaHash Hash = new TabelaHash(Tamanho);

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue900, Primary.LightBlue700, Primary.LightBlue600, Accent.LightBlue200, TextShade.WHITE);
            cbStructure.SelectedIndex = 0;
            cbIndex = cbStructure.SelectedIndex;
        }

        private void CBStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIndex = cbStructure.SelectedIndex;
            this.btnClear_Click(this, new EventArgs());
        }

        private void TBValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInsert_Click(this, new EventArgs());
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            bool inseridoSucesso = true;
            try
            {
                int num = int.Parse(tbValue.Text);
                switch (cbIndex)
                {
                    case 0:
                        Pilha.Empilha(num);
                        break;
                    case 1:
                        Fila.Enfileira(num);
                        break;
                    case 2:
                        Lista.InsereFim(num);
                        break;
                    case 3:
                        if (!Arvore.Add(num))
                        {
                            inseridoSucesso = false;
                            tbValue.Focus();
                            toolTipBtnInsert.Show("Valor já existente na árvore!", panelInsertSuccess);
                            SetTimeout(() => toolTipBtnInsert.Hide(panelInsertSuccess), 500);
                        }
                        break;
                    case 4:
                        Hash.put(new Registro(this.indice++, num.ToString()));
                        break;
                }
                if (inseridoSucesso)
                {
                    toolTipBtnInsert.Show("Inserido com sucesso!", panelInsertSuccess);
                    SetTimeout(() => toolTipBtnInsert.Hide(panelInsertSuccess), 500);
                }
                tbValue.Focus();

                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                lblTimeElapsedInsert.Text = String.Format("Tempo gasto para inserção: {0} (ms)", ts.Milliseconds.ToString());

                this.btnGetData_Click(this, new EventArgs());
            }
            catch
            {
                tbValue.Focus();
                toolTipBtnInsert.Show("Digite um valor inteiro!", panelInsertSuccess);
                SetTimeout(() => toolTipBtnInsert.Hide(panelInsertSuccess), 500);
            }
            tbValue.Focus();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            this.indice = 0;
            switch (cbIndex)
            {
                case 0:
                    this.indice = Pilha.Quantidade() - 1;
                    this.dGVData.Rows.Clear();
                    foreach (Object obj in Pilha)
                    {
                        if (obj != null)
                            this.dGVData.Rows.Add(this.indice, obj);
                        this.indice--;
                    }
                    break;
                case 1:
                    this.indice = 0;
                    this.dGVData.Rows.Clear();
                    foreach (Object obj in Fila)
                    {
                        if (obj != null)
                            this.dGVData.Rows.Add(this.indice, obj);
                        this.indice++;
                    }
                    break;
                case 2:
                    this.indice = 0;
                    this.dGVData.Rows.Clear();
                    foreach (Object obj in Lista)
                    {
                        if (obj != null)
                            this.dGVData.Rows.Add(this.indice, obj);
                        this.indice++;
                    }
                    break;
                case 3:
                    this.indice = 0;
                    this.dGVData.Rows.Clear();
                    List<int> arv = Arvore.GetListaNum();
                    for (int i = 0; i < Arvore.GetQuantidade(); i++)
                    {
                        this.dGVData.Rows.Add(this.indice++, arv[i]);
                    }
                    break;
                case 4:
                    this.indice = 0;
                    this.dGVData.Rows.Clear();
                    for (int i = 0; i < Hash.GetQuantidade(); i++)
                    {
                        Registro registro = Hash.get(this.indice);
                        this.dGVData.Rows.Add(registro.getKey(), registro.getValue());
                        this.indice++;
                    }
                    break;
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            lblTimeElapsedGetData.Text = String.Format("Tempo gasto para listagem: {0} (ms)", ts.Milliseconds.ToString());
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            tBSize.Visible = true;
            switch (cbIndex)
            {
                case 0:
                    tBSize.Text = Pilha.Quantidade().ToString();
                    break;
                case 1:
                    tBSize.Text = Fila.Quantidade().ToString();
                    break;
                case 2:
                    tBSize.Text = Lista.Quantidade().ToString();
                    break;
                case 3:
                    tBSize.Text = Arvore.GetQuantidade().ToString();
                    break;
                case 4:
                    tBSize.Text = Hash.GetQuantidade().ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dGVData.Rows.Clear();
            Pilha = new CPilha(Tamanho);
            Fila = new CFila(Tamanho);
            Lista = new CLista(Tamanho);
            Arvore = new Arvore(Tamanho);
            Hash = new TabelaHash(Tamanho);
            this.indice = 0;
        }
    }
}
