using Npgsql.Internal.TypeHandlers.LTreeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvVenda.Columns.Add("codigoProduto", "Codigo Produto");
            dgvVenda.Columns.Add("descricao", "Descrição");
            dgvVenda.Columns.Add("quantidade", "Quantidade");
            dgvVenda.Columns.Add("valorUnitario", "Valor Unitário");
            dgvVenda.Columns.Add("total", "Total");

        }
        
        public double TOTAL = 0;

        private void inserirExcluirAlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCliente fCliente= new FCliente();
            this.Hide();
            fCliente.ShowDialog();
        }

        private void inserirExcluirAlterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FProduto fProduto= new FProduto();
            this.Hide();
            fProduto.ShowDialog();
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEstoque fEstoque = new FEstoque();
            this.Hide();
            fEstoque.ShowDialog();
        }

        

        

       

        

        private int cont;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int linha = 0;
            try
            {
                if (txtQtde.Text.Trim().Length > 0 && (Convert.ToInt32(txtQtde.Text)!=0))
                {
                    if (txtValor.Text.Trim().Length > 0 && (Convert.ToInt32(txtValor.Text) != 0))
                    {
                        
                            cont++;
                            dgvVenda.Rows.Add();//Adicionando uma linha
                            linha = dgvVenda.Rows.Count - 1; //Fala qual é a nova linha
                        
                            dgvVenda.Rows[linha].Cells[0].Value = txtCodPro.Text;
                        dgvVenda.Rows[linha].Cells[1].Value = txtDescr.Text;
                        dgvVenda.Rows[linha].Cells[2].Value = txtValor.Text;
                        dgvVenda.Rows[linha].Cells[3].Value = txtQtde.Text;
                        dgvVenda.Rows[linha].Cells[4].Value = txtTotal.Text;
                        TOTAL += Convert.ToDouble(txtTotal.Text);
                        txtTotalCompra.Text = Convert.ToString(TOTAL);
                    }
                    else
                        MessageBox.Show("Produto inválido");
                }
                else
                    MessageBox.Show("Quantidade inválida");

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtCodPro_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (txtCodPro.Text.Trim().Length > 0)
                {
                    ProdutoDAO dao;
                    dao = new ProdutoDAO();
                    Produto obj;
                    obj = new Produto();

                    int codPro = 0;
                    codPro = Convert.ToInt32(txtCodPro.Text);
                    // obj.setCodigo(codPro);
                    obj = dao.preencher(codPro);

                    if (obj != null)
                    {

                        string descr = obj.descr.ToString();
                        //MessageBox.Show(descr);
                        txtDescr.Text = descr;
                        txtValor.Text = obj.preco.ToString();
                        txtQtde.Text = 1.ToString();
                        txtTotal.Text= txtValor.Text;
                        txtQtde.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Produto Não encontrado", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescr.Clear();
                        txtTotal.Clear();
                        txtQtde.Clear();
                        txtDescr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtCodCli_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (txtCodCli.Text.Trim().Length > 0)
                {
                    ClienteDAO dao;
                    dao = new ClienteDAO();
                    Cliente obj;
                    obj = new Cliente();

                    int codCli;
                    codCli = Convert.ToInt32(txtCodCli.Text);
                    // obj.setCodigo(codPro);
                    obj = dao.preencher(codCli);

                    if (obj != null)
                    {

                        string nome = obj.nome.ToString();
                        //MessageBox.Show(descr);
                        lblNome.Text = nome;
                        txtQtde.Focus();
                        //MessageBox.Show(nome);

                    }
                    else
                    {
                        MessageBox.Show("Cliente Não encontrado", "Informação",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescr.Clear();
                        txtTotal.Clear();
                        txtQtde.Clear();
                        txtDescr.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtQtde_KeyUp(object sender, KeyEventArgs e)
        {
            
                Produto obj;
                obj = new Produto();
                Venda Vobj;
                Vobj = new Venda();
                ProdutoDAO Pdao;
                Pdao = new ProdutoDAO();

                int qtde = Pdao.getQtde(obj);

                if (txtQtde.Text.Trim().Length > 0)
                {
                    if (txtCodPro.Text.Trim().Length > 0)
                    {
                        if (Convert.ToInt32(txtQtde.Text)> qtde)
                        {
                        MessageBox.Show("Não há estoque suficiente, temos apenas: " + qtde);
                        txtQtde.Clear();
                        }
                        else {
                            double v = 0, tota;
                            int qt;
                            qt = Convert.ToInt32(txtQtde.Text.Trim());
                            int codPro = 0;
                            codPro = Convert.ToInt32(txtCodPro.Text);
                            obj = Pdao.preencher(codPro);
                            if (obj != null)
                                v = Convert.ToDouble(obj.preco);
                            tota = (double)v * (double)qt;
                            txtTotal.Text = Convert.ToString(tota);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Coloque um produto primeiro");
                        txtQtde.Clear();
                        txtCodPro.Focus();
                    }
                }
            
        }
        
        private void dgvVenda_DoubleClick(object sender, EventArgs e)
        {
            int linha = 0;
            try
            {
                linha = dgvVenda.SelectedCells[0].RowIndex; //captura a linha selecionada
                if (linha < dgvVenda.RowCount)
                {
                    txtCodPro.Text = dgvVenda.Rows[linha].Cells[0].Value.ToString();
                    txtDescr.Text = dgvVenda.Rows[linha].Cells[1].Value.ToString();
                    txtValor.Text = dgvVenda.Rows[linha].Cells[2].Value.ToString();
                    txtQtde.Text = dgvVenda.Rows[linha].Cells[3].Value.ToString();
                    txtTotal.Text = dgvVenda.Rows[linha].Cells[4].Value.ToString();
                    TOTAL -= Convert.ToDouble(dgvVenda.Rows[linha].Cells[4].Value);
                    dgvVenda.Rows.RemoveAt(linha);
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Venda obj;
            Item obji;
            ItemDAO daoi;
            VendaDAO dao;

            try
            {
                
                obj = new Venda();
                obj.setcodigoCli(Convert.ToInt32(txtCodCli.Text));
                obj.setcodigoProduto(Convert.ToInt32(txtCodPro.Text));
                obj.setdata(DateTime.Now.Date);
                //MessageBox.Show(Convert.ToString(obj.data));
                obj.setTotal(TOTAL);

                
                dao = new VendaDAO();
                dao.gravarGetCodigo(obj);
                //MessageBox.Show(obj.codigo.ToString());
                
                obji= new Item();
                daoi = new ItemDAO();
                
                obji.setQtde(Convert.ToInt32(txtQtde.Text));
                obji.setPrecounit(Convert.ToInt32(txtValor.Text));
                obji.setcodVenda(obj.codigo);
                obji.setcodigoProduto(Convert.ToInt32(txtCodPro.Text));
                daoi.gravar(obji);
                MessageBox.Show("Venda realizada com sucesso");

            
            }
            catch (Exception ex)
            {

                throw new Exception("Erro de Inserção no banco quando a venda é finalizada: " +ex.Message);
            }


            dgvVenda.Rows.Clear();
            txtCodCli.Clear();
            lblNome.ResetText();
            txtCodPro.Clear();
            txtDescr.Clear();
            txtValor.Clear();
            txtQtde.ResetText();
            txtTotal.Clear();
            txtTotalCompra.Text = "0,0";
            txtCodCli.Focus();


        }
    }
}
