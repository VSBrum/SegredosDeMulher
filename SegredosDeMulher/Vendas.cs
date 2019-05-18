using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegredosDeMulher {
    public partial class Vendas : Form {
        public Vendas() {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Data Source=.\\SEGREDOSDEMULHER;Initial Catalog=SegredosDeMulher;" +
            "Persist Security Info=True;User ID=sa;Password=123456");
        SqlDataAdapter selectCliente;
        SqlDataAdapter selectProduto;
        SqlDataAdapter select;
        DataTable table;

        private void vendaBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.vendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segredosDeMulherDataSet);

        }

        private void Vendas_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'segredosDeMulherDataSet.venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.segredosDeMulherDataSet.venda);
            disponivelTextBox.Enabled = false;

            nomeprodutoComboBox.Enabled = false;
            clienteComboBox.Enabled = false;
            qtdTextBox.Enabled = false;

            selectCliente = new SqlDataAdapter("SELECT nomecliente FROM cliente", conexao);
            table = new DataTable("cliente");
            selectCliente.Fill(table);
            clienteComboBox.DataSource = table;
            clienteComboBox.ValueMember = "nomecliente";

            selectProduto = new SqlDataAdapter("SELECT nomeproduto FROM produto", conexao);
            table = new DataTable("produto");
            selectProduto.Fill(table);
            nomeprodutoComboBox.DataSource = table;
            nomeprodutoComboBox.ValueMember = "nomeproduto";

            selectProduto = new SqlDataAdapter("SELECT nomeproduto FROM produto", conexao);
            table = new DataTable("produto");
            selectProduto.Fill(table);
            nomeprodutoComboBox2.DataSource = table;
            nomeprodutoComboBox2.ValueMember = "nomeproduto";

            nomeprodutoComboBox.Text = "[Produto]";
            clienteComboBox.Text = "[Cliente]";
            qtdTextBox.Text = "[0]";

            nomeprodutoComboBox2.Enabled = false;
            qtdTextBox2.Enabled = false;
            disponivelTextBox2.Enabled = false;

            nomeprodutoComboBox2.Text = "";
            qtdTextBox2.Text = "";
            disponivelTextBox2.Text = "";
        }

        private void nomeprodutoComboBox_SelectedIndexChanged(object sender, EventArgs e) {

            try {
                conexao.Open();

                int cont = 1;
                int qtd = 0;

                SqlCommand selectQTD = new SqlCommand("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod");
                selectQTD.Connection = conexao;
                selectQTD.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));
                SqlDataReader leitorPreencher = selectQTD.ExecuteReader();

                if (leitorPreencher.Read()) {
                    qtd = (int)leitorPreencher["qtdproduto"];
                }

                leitorPreencher.Close();
                disponivelTextBox.Text = qtd.ToString();
            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }

        }


        private void vendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                conexao.Open();

                DataGridViewRow linhaAtual = vendaDGV.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(vendaDGV.Rows[indice].Cells[0].Value);

                SqlCommand slcTXT = new SqlCommand("SELECT nomeproduto,nomecliente,qtdproduto FROM venda WHERE id_venda = @indice");
                slcTXT.Connection = conexao;

                slcTXT.Parameters.AddWithValue("@indice", cod);

                SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                if (leitorPreencher.Read()) {
                    string name = (string)leitorPreencher["nomeproduto"];
                    string nameCli = (string)leitorPreencher["nomecliente"];
                    int qtd = (int)leitorPreencher["qtdproduto"];

                    nomeprodutoComboBox.Text = name;
                    clienteComboBox.Text = nameCli;
                    qtdTextBox.Text = qtd.ToString();
                    leitorPreencher.Close();
                }

                nomeprodutoComboBox.Enabled = false;
                clienteComboBox.Enabled = false;
                qtdTextBox.Enabled = false;


            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }
        }

        private void btnSalvarCliente_Click_1(object sender, EventArgs e) {

            try {

                conexao.Open();
                if (nomeprodutoComboBox.Text == string.Empty || clienteComboBox.Text == string.Empty || qtdTextBox.Text == string.Empty) {
                    MessageBox.Show("Não foi digitado todos dados necessáarios, por favor preencha os campos obrigatórios!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {

                    DateTime agora = DateTime.Now;

                    SqlCommand insert = new SqlCommand("INSERT INTO venda (nomeproduto,nomecliente,qtdproduto,valorvenda,datavenda) " +
                        "VALUES (@nomeproduto,@nomecliente,@qtdproduto,@valorvenda,@data)");
                    insert.Connection = conexao;

                    SqlParameter nomeproduto = new SqlParameter("@nomeproduto", SqlDbType.VarChar);
                    SqlParameter nomecliente = new SqlParameter("@nomecliente", SqlDbType.VarChar);
                    SqlParameter qtdproduto = new SqlParameter("@qtdproduto", SqlDbType.VarChar);
                    SqlParameter valorvenda = new SqlParameter("@valorvenda", SqlDbType.Decimal);
                    SqlParameter data = new SqlParameter("@data", SqlDbType.DateTime);
                    
                    nomecliente.Value = clienteComboBox.Text;
                    
                    data.Value = agora;
                    decimal preco = 0;
                    
                    SqlCommand valor = new SqlCommand("SELECT valorproduto FROM produto WHERE nomeproduto = @nomeproduto", conexao);
                    valor.Parameters.AddWithValue("@nomeproduto", nomeprodutoComboBox.Text);
                    SqlDataReader readValor = valor.ExecuteReader();

                    if (readValor.Read()) {
                        preco = (decimal)readValor["valorproduto"];
                    }
                    readValor.Close();
                    
                    decimal preco2 = 0;
                    SqlCommand valor2 = new SqlCommand("SELECT valorproduto FROM produto WHERE nomeproduto = @nomeproduto2", conexao);
                    valor2.Parameters.AddWithValue("@nomeproduto2", nomeprodutoComboBox2.Text);
                    SqlDataReader readValor2 = valor2.ExecuteReader();

                    if (readValor2.Read()) {
                        preco2 = (decimal)readValor2["valorproduto"];
                    }
                    readValor2.Close();

                    decimal precototal;
                    
                    if (nomeprodutoComboBox2.Enabled) {
                        nomeproduto.Value = nomeprodutoComboBox.Text + "/" + nomeprodutoComboBox2.Text;
                        qtdproduto.Value = qtdTextBox.Text + "/" + qtdTextBox2.Text;
                        precototal = preco * (Convert.ToDecimal(qtdTextBox.Text)) + preco2 * (Convert.ToDecimal(qtdTextBox2.Text));
                    }
                    else {
                        precototal = preco * (Convert.ToDecimal(qtdTextBox.Text));
                        nomeproduto.Value = nomeprodutoComboBox.Text;
                        qtdproduto.Value = qtdTextBox.Text;
                    }
                    
                    int disponivel = 0;

                    SqlCommand selectQTD = new SqlCommand("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod");
                    selectQTD.Connection = conexao;
                    selectQTD.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));
                    SqlDataReader leitorPreencher = selectQTD.ExecuteReader();

                    if (leitorPreencher.Read()) {
                        disponivel = (int)leitorPreencher["qtdproduto"];
                    }

                    leitorPreencher.Close();
                    valorvenda.Value = precototal;

                    if (disponivel >= Convert.ToInt32(qtdTextBox.Text)) {
                        
                        insert.Parameters.Add(nomeproduto);
                        insert.Parameters.Add(nomecliente);
                        insert.Parameters.Add(qtdproduto);
                        insert.Parameters.Add(valorvenda);
                        insert.Parameters.Add(data);
                        insert.ExecuteNonQuery();

                        int quantidade = disponivel - Convert.ToInt32(qtdproduto.Value);

                        SqlCommand update = new SqlCommand("UPDATE produto SET qtdproduto = @qtd " +
                                                            "WHERE nomeproduto = @nome", conexao);

                        update.Parameters.AddWithValue("@qtd", quantidade);
                        update.Parameters.AddWithValue("@nome", Convert.ToString(nomeproduto.Value));
                        update.ExecuteNonQuery();


                        MessageBox.Show("Dados salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Quantidade selecionada é maior que a do estoque!", "Quantidade superior ao estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {

                select = new SqlDataAdapter("SELECT * FROM venda", conexao);
                table = new DataTable();
                select.Fill(table);
                vendaDGV.DataSource = table;


                DataGridViewRow linhaAtual = vendaDGV.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(vendaDGV.Rows[indice].Cells[0].Value);

                SqlCommand slcTXT = new SqlCommand("SELECT nomeproduto,nomecliente,qtdproduto FROM venda WHERE id_venda = @indice");
                slcTXT.Connection = conexao;
                slcTXT.Parameters.AddWithValue("@indice", cod);
                SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                if (leitorPreencher.Read()) {
                    string name = (string)leitorPreencher["nomeproduto"];
                    string nameCli = (string)leitorPreencher["nomecliente"];
                    string qtd = (string)leitorPreencher["qtdproduto"];

                    nomeprodutoComboBox.Text = name;
                    clienteComboBox.Text = nameCli;
                    qtdTextBox.Text = qtd.ToString();

                }

                leitorPreencher.Close();
                conexao.Close();

                nomeprodutoComboBox.Enabled = false;
                clienteComboBox.Enabled = false;
                qtdTextBox.Enabled = false;
                disponivelTextBox.Enabled = false;
            }
        }

        private void novaVenda_Click_1(object sender, EventArgs e) {
            nomeprodutoComboBox.Enabled = true;
            clienteComboBox.Enabled = true;
            qtdTextBox.Enabled = true;

            nomeprodutoComboBox.Text = "";
            clienteComboBox.Text = "";
            qtdTextBox.Text = "";


        }

        private void vendaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            try {
                conexao.Open();

                DataGridViewRow linhaAtual = vendaDGV.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(vendaDGV.Rows[indice].Cells[0].Value);

                SqlCommand slcTXT = new SqlCommand("SELECT nomeproduto,nomecliente,qtdproduto FROM venda WHERE id_venda = @indice");
                slcTXT.Connection = conexao;

                slcTXT.Parameters.AddWithValue("@indice", cod);

                SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                if (leitorPreencher.Read()) {
                    string name = (string)leitorPreencher["nomeproduto"];
                    string nameCli = (string)leitorPreencher["nomecliente"];
                    int qtd = (int)leitorPreencher["qtdproduto"];

                    string [] nome = name.Split('a');
                    string[] quantidade = qtd.ToString().Split('/');

                    nomeprodutoComboBox.Text = nome[0];
                    clienteComboBox.Text = nameCli;
                    qtdTextBox.Text = quantidade[0];

                    nomeprodutoComboBox2.Text = nome[1];
                    qtdTextBox2.Text = quantidade[1];

                    leitorPreencher.Close();
                }


                leitorPreencher.Close();

                int disp = 0;

                SqlCommand selectQTD = new SqlCommand("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod");
                selectQTD.Connection = conexao;
                selectQTD.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));
                leitorPreencher = selectQTD.ExecuteReader();

                if (leitorPreencher.Read()) {
                    disp = (int)leitorPreencher["qtdproduto"];
                }

                leitorPreencher.Close();

                disponivelTextBox.Text = disp.ToString();


                nomeprodutoComboBox.Enabled = false;
                clienteComboBox.Enabled = false;
                qtdTextBox.Enabled = false;


            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }
        }

        private void nomeprodutoComboBox_SelectedIndexChanged_1(object sender, EventArgs e) {
            try {
                conexao.Open();

                int qtd = 0;

                SqlCommand selectQTD = new SqlCommand("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod");
                selectQTD.Connection = conexao;
                selectQTD.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));
                SqlDataReader leitorPreencher = selectQTD.ExecuteReader();

                if (leitorPreencher.Read()) {
                    qtd = (int)leitorPreencher["qtdproduto"];
                }

                leitorPreencher.Close();

                disponivelTextBox.Text = qtd.ToString();

                nomeprodutoComboBox.Text = "";
            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }
        }

        private void btnExcluirProd_Click(object sender, EventArgs e) {
            try {
                conexao.Open();
                DataGridViewRow linhaAtual = vendaDGV.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(vendaDGV.Rows[indice].Cells[0].Value);

                if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) {

                    SqlCommand delete = new SqlCommand("DELETE FROM venda where id_venda = @id", conexao);
                    delete.Parameters.AddWithValue("@id", cod);
                    delete.ExecuteNonQuery();
                }

            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
                select = new SqlDataAdapter("SELECT * FROM venda", conexao);
                table = new DataTable();
                select.Fill(table);
                vendaDGV.DataSource = table;

            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e) {
            nomeprodutoComboBox2.Enabled = true;
            qtdTextBox2.Enabled = true;
            disponivelTextBox2.Enabled = true;

        }

        private void nomeprodutoComboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                conexao.Open();

                int cont = 1;
                int qtd = 0;

                SqlCommand selectQTD = new SqlCommand("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod");
                selectQTD.Connection = conexao;
                selectQTD.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox2.SelectedValue));
                SqlDataReader leitorPreencher = selectQTD.ExecuteReader();

                if (leitorPreencher.Read()) {
                    qtd = (int)leitorPreencher["qtdproduto"];
                }

                leitorPreencher.Close();
                disponivelTextBox2.Text = qtd.ToString();
            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }
        }

        private void btnFecharVenda_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}



