using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa
{
    public partial class Frm_Caixa : Form
    {
        string nome, senha = "2749";
        double preço, total = 0, valor,troco;
        int quantidade = 0, posição, posiçãoInvariável;
        public Frm_Caixa()
        {
            InitializeComponent();
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            nome = txt_NP.Text;
            preço = double.Parse(txt_VU.Text);
            quantidade = int.Parse(txt_QP.Text);
            lst1.Items.Add(nome);
            lst2.Items.Add(quantidade);
            lst3.Items.Add(preço);
            total += preço * quantidade;
        }
        private void lst1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nome = Convert.ToString(lst1.SelectedItem);
            posição = lst1.SelectedIndex;
            lst2.SelectedIndex = posição;
            lst3.SelectedIndex = posição;
            quantidade = Convert.ToInt32(lst2.SelectedItem);
            preço = Convert.ToDouble(lst3.SelectedItem);
        }

        private void lst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantidade = Convert.ToInt32(lst2.SelectedItem);
            posição = lst2.SelectedIndex;
            lst1.SelectedIndex = posição;
            lst3.SelectedIndex = posição;
            nome = Convert.ToString(lst1.SelectedItem);
            preço = Convert.ToDouble(lst3.SelectedItem);
        }
        private void lst3_SelectedIndexChanged(object sender, EventArgs e)
        {
            preço = Convert.ToDouble(lst3.SelectedItem);
            posição = lst3.SelectedIndex;
            lst1.SelectedIndex = posição;
            lst2.SelectedIndex = posição;
            nome = Convert.ToString(lst1.SelectedItem);
            quantidade = Convert.ToInt32(lst2.SelectedItem);
        }
        
        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if(txt_senha.Text == senha)
            {
                posiçãoInvariável = posição;
                total = total - preço * quantidade;
                lst1.Items.RemoveAt(posiçãoInvariável);
                lst2.Items.RemoveAt(posiçãoInvariável);
                lst3.Items.RemoveAt(posiçãoInvariável);
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            lbl_PT.Text = "R$ "+total.ToString();
        }

        private void btn_Tr_Click(object sender, EventArgs e)
        {
            if(txt_VP.Text == "")
            {
                MessageBox.Show("Você tem que pagar");
            }
            else
                if (double.Parse(txt_VP.Text) < total)
                {
                    MessageBox.Show("Dinheiro insuficiente");
                }
                else
                {
                    valor = double.Parse(txt_VP.Text);
                    troco = valor - total;
                    lbl_T.Text = "Troco: R$ " + troco.ToString();
                }
        }

    }
}
