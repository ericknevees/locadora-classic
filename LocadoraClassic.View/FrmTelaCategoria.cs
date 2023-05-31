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
    public partial class FrmTelaCategoria : Form
    {

        Categoria categoria = new Categoria();
        int id = 0;
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        public FrmTelaCategoria()
        {
            InitializeComponent();
            dGVCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVCat.CellDoubleClick += dGVCat_CellDoubleClick;
            CarregarGrid();
            
        }

        private void FrmTelaCategoria_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //objeto VO
            Categoria categoria = new Categoria();
            //objeto DAL

            //Pegar o valor da caixinha e colocar na propriedade Nome
            categoria.Nome = txtNomecad.Text;
            categoria.Valor_diaria = txtValorDia.Text;

            //INSERIR NO BANCO DE DADOS
            categoriaDAL.InserirCategoria(categoria);

            //Limpar a caixa
            txtNomecad.Text = "";
            txtValorDia.Text = "";
            MessageBox.Show("Dados inseridos com sucesso!");
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            dGVCat.DataSource = categoriaDAL.ObterCategoria().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dGVCat.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dGVCat.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE
            CategoriaDAL categoriaDAL = new CategoriaDAL();
            categoriaDAL.ExcluirCategoria(id);
            CarregarGrid();

        }
        private void dGVCat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = dGVCat.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (dGVCat.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dGVCat.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                
                txtNomecad.Text = nome;
                
                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo



            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            categoria.Nome = txtNomecad.Text;
            categoria.Id = id;
            categoria.Valor_diaria = txtValorDia.Text;
            categoriaDAL.AtualizarCategoria(categoria);
            txtNomecad.Text = "";
            txtValorDia.Text = "";
            CarregarGrid();
        }

        private void txtValorDia_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
 }

