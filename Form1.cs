using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Taks : Form
    {
        public Taks()
        {
            InitializeComponent();
        }

        private void lbl_tabela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string tarefa;

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            tarefa = tbl_tarefa.Text;

            if (tarefa.Length == 0 || string.IsNullOrWhiteSpace(tarefa))
            {
                MessageBox.Show("Digite sua tarefa","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning); ;
            }
            else
            {
                lbl_tabela.Items.Add(tarefa);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(lbl_tabela.SelectedIndex>=0)
            {
                lbl_tabela.Items.RemoveAt(lbl_tabela.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning); ;
            }
        }

        private void btn_subir_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbl_tabela.SelectedIndex;
            if (selectedIndex > 0)
            {
                object selectedItem = lbl_tabela.SelectedItem;
                lbl_tabela.Items.RemoveAt(selectedIndex);
                lbl_tabela.Items.Insert(selectedIndex - 1, selectedItem);
                lbl_tabela.SetSelected(selectedIndex - 1, true);
            }
        }

        private void btn_baixo_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbl_tabela.SelectedIndex;
            if (selectedIndex < lbl_tabela.Items.Count - 1)
            {
                object selectedItem = lbl_tabela.SelectedItem;
                lbl_tabela.Items.RemoveAt(selectedIndex);
                lbl_tabela.Items.Insert(selectedIndex + 1, selectedItem);
                lbl_tabela.SetSelected(selectedIndex + 1, true);
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void CriarNovo()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).Items.Clear();
                }
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarNovo();
            
        }

        private void tbl_tarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
