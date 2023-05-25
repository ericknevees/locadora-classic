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
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        public FrmTelaCategoria()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
