using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{

    public partial class FrmCliente : Form
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        Cliente cliente = new Cliente();
        int id = 0;

        public FrmCliente()
        {

            InitializeComponent();
            DGVCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVCliente.CellDoubleClick += DGVCliente_CellDoubleClick;
            CarregarGrid();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //objeto VO
            Cliente cliente = new Cliente();
            //objeto DAL

            //Pegar o valor da caixinha e colocar na propriedade Nome
            cliente.Nome = txtNomeCli.Text;
            cliente.Endereco = txtEnde.Text;
            cliente.Whatsapp = mkdTxtTel.Text;
            cliente.CPF = TxtCpF.Text;
            cliente.RG = txtRg.Text;

            //INSERIR NO BANCO DE DADOS
            clienteDAL.InserirCliente(cliente);

            //Limpar a caixa
            txtNomeCli.Text = "";
            txtEnde.Text = "";
            mkdTxtTel.Text = "";
            TxtCpF.Text = "";
            txtRg.Text = "";
            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {

            DGVCliente.DataSource = clienteDAL.ObterCliente().ToList();

        }

        private void FrmCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (DGVCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = DGVCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE
            ClienteDAL clienteDAL = new ClienteDAL();
            clienteDAL.ExcluirCliente(id);
            CarregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNomeCli.Text;
            cliente.Id = id;
            cliente.Endereco = txtEnde.Text;
            cliente.Whatsapp = mkdTxtTel.Text;
            cliente.CPF = TxtCpF.Text;
            cliente.RG = txtRg.Text;
            clienteDAL.AtualizarCliente(cliente);
            txtNomeCli.Text = "";
            txtEnde.Text = "";
            txtRg.Text = "";
            TxtCpF.Text = "";
            CarregarGrid();
        }

        private void DGVCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = DGVCliente.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (DGVCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = DGVCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                string endereco = selectedRow.Cells["endereco"].Value.ToString();
                string whatsapp = selectedRow.Cells["Whatsapp"].Value.ToString();
                string CPF = selectedRow.Cells["CPF"].Value.ToString();
                string RG = selectedRow.Cells["RG"].Value.ToString();

                txtNomeCli.Text = nome;
                txtEnde.Text = endereco;
                mkdTxtTel.Text = whatsapp;
                TxtCpF.Text = CPF;
                txtRg.Text = RG;

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo

            }
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCpF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
