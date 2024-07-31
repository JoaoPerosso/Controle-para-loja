using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Trabalho
{
    public partial class FCliente : Form
    {
        public FCliente()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            {
                Cliente obj;
                ClienteDAO DAO;
                try
                {
                    obj = new Cliente();
                    obj.setNome(txtNome.Text);
                    obj.setFone(txtFone.Text);

                    DAO = new ClienteDAO();
                    DAO.gravar(obj);
                    txtCodigo.Clear();
                    txtNome.Clear();
                    txtFone.Clear();
                    txtCodigo.Focus();
                    btnListar.PerformClick();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            ClienteDAO dao;

            try
            {
                dao = new ClienteDAO();
                dgvCliente.DataSource = dao.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            Cliente obj;
            ClienteDAO DAO;
            try
            {
                obj = new Cliente();
                obj.setCodigo(txtCodigo.Text);


                DAO = new ClienteDAO();
                DAO.remover(obj);
                txtCodigo.Clear();
                txtNome.Clear();
                txtFone.Clear();
                txtCodigo.Focus();
                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente obj;
            ClienteDAO DAO;
            try
            {
                obj = new Cliente();
                obj.setNome(txtNome.Text);
                obj.setFone(txtFone.Text);
                obj.setCodigo(txtCodigo.Text);

                DAO = new ClienteDAO();
                DAO.alterar(obj);
                txtCodigo.Clear();
                txtNome.Clear();
                txtFone.Clear();
                txtCodigo.Focus();
                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {

            int linha = 0;
            try
            {
                linha = dgvCliente.SelectedCells[0].RowIndex; //captura a linha selecionada
                if (linha < dgvCliente.RowCount)
                {
                    txtCodigo.Text = dgvCliente.Rows[linha].Cells[0].Value.ToString();
                    txtNome.Text = dgvCliente.Rows[linha].Cells[1].Value.ToString();
                    txtFone.Text = dgvCliente.Rows[linha].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
