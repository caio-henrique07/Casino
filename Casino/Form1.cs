using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class Form1 : Form
    {
        int[] roleta;
        int[] tempos;
        Label[] tela;
        Random r;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            roleta = new int[3];
            tempos = new int[3];
            tela = new Label[] { lbl1, lbl2, lbl3 };
            r = new Random();

            for (int i = 0; i < roleta.Length; i++)
            {
                roleta[i] = r.Next(0, 10);
                Atualizar(i);
            }
        }

        void Atualizar(int indice)
        {
            tela[indice].Text = roleta[indice].ToString();
        }

        private void btGirar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < roleta.Length; i++)
            {
                tempos[i] = r.Next(1, 21);
                tela[i].ForeColor = Color.Black;
            }
            Array.Sort(tempos);
            btGirar.Enabled = false;
            tmrGiro.Enabled = true;
        }

        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            bool parado = true;
            for (int i = 0; i < roleta.Length; i++)
            {
                if (tempos[i] > 0)
                {
                    tempos[i]--;

                    if (tempos[i] == 0)
                    {
                        tela[i].ForeColor = Color.DarkRed;
                    }

                    roleta[i]++;
                    
                    if (roleta[i] == 10)
                    {
                        roleta[i] = 0;
                    }

                    Atualizar(i);
                    parado = false;
                }
            }

            if (parado)
            {
                btGirar.Enabled = true;
                tmrGiro.Enabled = false;

                lbxUltimos.Items.Add($"{roleta[0]}-{roleta[1]}-{roleta[2]}");

                if (roleta[0] == 7 && roleta[1] == 7 && roleta[2] == 7)
                {
                    MessageBox.Show("VOCÊ GANHOU O PRÊMIO MÁXIMO! PARABÉNS!", "BÔNUS!");
                }
                else if (roleta[0] == roleta[1] && roleta[1] == roleta[2])
                {
                    MessageBox.Show("Parabéns! Você VENCEU!", "VITÓRIA!");
                }
                else
                {
                    MessageBox.Show("Que pena! Você perdeu, tente novamente...", "DERROTA!");
                }
            }
        }

        List<string> jogadas;

        private void chbVitorias_CheckedChanged(object sender, EventArgs e)
        {
            if (chbVitorias.Checked)
            {
                jogadas = new List<string>();
                foreach (string item in lbxUltimos.Items)
                {
                    jogadas.Add(item.ToString());
                }
                lbxUltimos.Items.Clear();

                foreach (string item in jogadas)
                {
                    string[] partes = item.Split('-');
                    if (partes[0] == partes[1] && partes[1] == partes[2])
                    {
                        lbxUltimos.Items.Add(item);
                    }
                }
            }
            else
            {
                foreach (string item in jogadas)
                {
                    lbxUltimos.Items.Add(item);
                }
            }
        }
    }
}