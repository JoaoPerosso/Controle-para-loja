using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Trabalho
{
    public partial class FProduto : Form
    {
        public FProduto()
        {
            InitializeComponent();
            
        }
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produto obj;
            ProdutoDAO DAO;
            try
            {
                obj = new Produto();
                obj.setDescr(txtDescr.Text);
                obj.setQtde(txtQtde.Text);
                obj.setPreco(txtPreco.Text);

                DAO =new ProdutoDAO();
                DAO.gravar(obj);
                txtDescr.Clear();
                txtPreco.Clear();
                txtQtde.Clear();
                txtCodigo.Focus();
                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            ProdutoDAO dao;
            Produto obj;
            int codigo;
            /*
            try
            {
                if (txtCodigo.Text.Trim().Length > 0)
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    dao = new ProdutoDAO();
                    obj = dao.preencher(codigo);
                    if (obj != null)
                    {
                        txtDescr.Text = obj.descr;
                        txtPreco.Text = obj.preco.ToString();
                        txtQtde.Text = obj.qtde.ToString();
                    }
                    else
                    {
                        txtDescr.Clear();
                        txtPreco.Clear();
                        txtQtde.Clear();
                        txtDescr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int linha = 0;
            try
            {
                linha = dgvProduto.SelectedCells[0].RowIndex; //captura a linha selecionada

                if (linha < dgvProduto.RowCount)
                {
                    txtCodigo.Text = dgvProduto.Rows[linha].Cells[0].Value.ToString();
                    txtDescr.Text = dgvProduto.Rows[linha].Cells[1].Value.ToString();
                    txtQtde.Text = dgvProduto.Rows[linha].Cells[2].Value.ToString();
                    txtPreco.Text = dgvProduto.Rows[linha].Cells[3].Value.ToString();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ProdutoDAO dao;

            try
            {
                dao = new ProdutoDAO();
                dgvProduto.DataSource = dao.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            Produto obj;
            ProdutoDAO DAO;
            try
            {
                obj = new Produto();
                obj.setCodigo(txtCodigo.Text);


                DAO = new ProdutoDAO();
                DAO.remover(obj);
                txtCodigo.Clear();
                txtDescr.Clear();
                txtPreco.Clear();
                txtQtde.Clear();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtDescr.Clear();
            txtPreco.Clear();
            txtQtde.Clear();
            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Produto obj;
            ProdutoDAO DAO;

            try
            {
                obj = new Produto();
                obj.setCodigo(txtCodigo.Text);
                obj.setDescr(txtDescr.Text);
                obj.setQtde(txtQtde.Text);
                obj.setPreco(txtPreco.Text);

                DAO = new ProdutoDAO();
                DAO.alterar(obj);
                txtCodigo.Clear();
                txtDescr.Clear();
                txtPreco.Clear();
                txtQtde.Clear();
                txtCodigo.Focus();
                btnListar.PerformClick();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            

        }
    }
}
