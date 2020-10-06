using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nosso_Banco
{
    public partial class Form1 : Form
    {
        int numeroSenha = 0;
        string[] senhas = new string[18];
        string[] historico = new string[14];
        string senhaAtual;
        double saldo = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_gerarSenha_Click(object sender, EventArgs e)
        {
            int posicao = DefinePosicao(senhas);
            if (posicao < senhas.Length - 1)
            {
                numeroSenha++;
                for (int i = 0; i < senhas.Length; i++)
                {

                    if (senhas[i] == null)
                    {
                        senhas[i] = "B" + numeroSenha.ToString("0#");
                        break;
                    }
                }
                GerarList_senha();
            }
        }
        private void btn_chamarSenha_Click(object sender, EventArgs e)
        {
            int posicoes = DefinePosicao(senhas);
            Array.Sort(senhas, 0, posicoes);
            if (senhas[0] != null)
                senhaAtual = senhas[0];
            txt_Senha.Text = senhaAtual;

            senhas[0] = null;
            for (int i = 0; i < senhas.Length; i++)
            {
                if (i < senhas.Length - 1)
                    senhas[i] = senhas[i + 1];
                else
                    senhas[i] = null;
            }
            GerarList_senha();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txt_operações.Text += btn.Text;
        }
        private void btn_sacar_Click(object sender, EventArgs e)
        {
            if (senhaAtual != null)
            {
                double saque;
                if (String.IsNullOrEmpty(txt_operações.Text))
                    saque = 0;
                else
                    saque = double.Parse(txt_operações.Text);
                if (saldo > saque)
                {
                    saldo -= saque;
                    GravarHistoricoSaque(saque);
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente", "Atenção!!");
                }
                txt_operações.Clear();
                txt_operações.Focus();
                txt_saldo.Text = saldo.ToString("###,##0.00");
                GerarList_Historico();
            }
            else
                MessageBox.Show("Chame uma senha", "Atenção!");
        }
        private void btn_depositar_Click(object sender, EventArgs e)
        {
            if (senhaAtual != null)
            {
                double deposito;
                if (String.IsNullOrEmpty(txt_operações.Text))
                    deposito = 0;
                else
                    deposito = double.Parse(txt_operações.Text);
                saldo += deposito;
                GravarHistoricoDeposito(deposito);
                txt_operações.Clear();
                txt_operações.Focus();
                txt_saldo.Text = saldo.ToString("###,##0.00");
                GerarList_Historico();
            }
            else
                MessageBox.Show("Chame uma senha", "Atenção!");
        }
        private void btn_saldo_Click(object sender, EventArgs e)
        {
            txt_saldo.Text = saldo.ToString("###,##0.00");
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            char[] tela = txt_operações.Text.ToArray();
            txt_operações.Clear();
            for (int i = 0; i < tela.Length - 1; i++)
            {
                txt_operações.Text += tela[i].ToString();
            }
        }
        private void btn_gerarSenhaPref_Click(object sender, EventArgs e)
        {
            int posicao = DefinePosicao(senhas);
            if (posicao < senhas.Length - 1)
            {
                numeroSenha++;
                for (int i = 0; i < senhas.Length; i++)
                {
                    if (senhas[i] == null)
                    {
                        senhas[i] = "A" + numeroSenha.ToString("0#");
                        break;
                    }
                }
                GerarList_senha();
            }
        }
        private void GerarList_Historico()
        {
            
            list_histórico.Items.Clear();
            for (int i = 0; i < historico.Length; i++)
                if (historico[i] != null)
                    list_histórico.Items.Add((Environment.NewLine + historico[i].ToString()));
        }

        private void GerarList_senha()
        {

            list_senhas.Items.Clear();
            for (int i = 0; i < senhas.Length; i++)
                if (senhas[i] != null)
                    list_senhas.Items.Add((Environment.NewLine + senhas[i].ToString()));
        }
        private void GravarHistoricoDeposito(double deposito)
        {
            if (historico[historico.Length - 1] != null)
            {
                for (int i = 0; i < historico.Length; i++)
                {
                    if (i < historico.Length - 1)
                        historico[i] = historico[i + 1];
                    else
                        historico[i] = null;
                }
            }
            for (int i = 0; i < historico.Length; i++)
                if (historico[i] == null)
                {
                    if (deposito > 0)
                        historico[i] = senhaAtual + "  Deposito  " + deposito.ToString("R$ ###,##0.00");
                    break;
                }
        }

        private void GravarHistoricoSaque(double saque)
        {
            if (historico[historico.Length - 1] != null)
            {
                for (int i = 0; i < historico.Length; i++)
                {
                    if (i < historico.Length - 1)
                        historico[i] = historico[i + 1];
                    else
                        historico[i] = null;
                }
            }
            for (int i = 0; i < historico.Length; i++)
                if (historico[i] == null)
                {
                    if (saque > 0)
                        historico[i] = senhaAtual + "  Saque  " + saque.ToString("R$ ###,##0.00");
                    break;
                }
        }
        private int DefinePosicao(string[] vetor)
        {
            int posicao = 0;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                if (vetor[i] != null)
                    posicao++;
            }
            return posicao;
        }
    }
}
