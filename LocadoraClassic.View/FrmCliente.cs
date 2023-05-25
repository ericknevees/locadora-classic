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

        public FrmCliente()
        {
            InitializeComponent();
            
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
    }
}
