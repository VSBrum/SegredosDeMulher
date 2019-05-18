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
    public partial class Cliente : Form {
        public Cliente() {
            InitializeComponent();
        }


        SqlConnection conexao = new SqlConnection("Data Source=.\\SEGREDOSDEMULHER;Initial Catalog=SegredosDeMulher;" +
            "Persist Security Info=True;User ID=sa;Password=123456");
        SqlDataAdapter select;
        DataTable table;

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segredosDeMulherDataSet);

        }

        private void Cliente_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'segredosDeMulherDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.segredosDeMulherDataSet.cliente);

            nomeclienteTextBox.Enabled = false;
            telefoneMaskedTextBox.Enabled = false;
            bairroTextBox.Enabled = false;
            ruaTextBox.Enabled = false;
            numeroTextBox.Enabled = false;
            cidadeTextBox.Enabled = false;

        }

        private void btnSalvarCliente_Click(object sender, EventArgs e) {

            if (nomeclienteTextBox.Enabled == false || telefoneMaskedTextBox.Enabled == false || bairroTextBox.Enabled == false
                || ruaTextBox.Enabled == false || numeroTextBox.Enabled == false || cidadeTextBox.Enabled == false) {
                MessageBox.Show("Não foi digitado todos dados necessáarios, por favor preencha os campos obrigatórios!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {


                SqlCommand insert = new SqlCommand("INSERT INTO cliente (nomecliente,telefone,bairro,rua,numero,cidade) " +
                    "VALUES (@nomecliente,@telefone,@bairro,@rua,@numero,@cidade)");
                insert.Connection = conexao;

                SqlParameter nomecliente = new SqlParameter("@nomecliente", SqlDbType.VarChar);
                SqlParameter telefone = new SqlParameter("@telefone", SqlDbType.VarChar);
                SqlParameter bairro = new SqlParameter("@bairro", SqlDbType.VarChar);
                SqlParameter rua = new SqlParameter("@rua", SqlDbType.VarChar);
                SqlParameter numero = new SqlParameter("@numero", SqlDbType.Int);
                SqlParameter cidade = new SqlParameter("@cidade", SqlDbType.VarChar);

                nomecliente.Value = nomeclienteTextBox.Text;
                telefone.Value = telefoneMaskedTextBox.Text;
                bairro.Value = bairroTextBox.Text;
                rua.Value = ruaTextBox.Text;
                numero.Value = numeroTextBox.Text;
                cidade.Value = cidadeTextBox.Text;

                insert.Parameters.Add(nomecliente);
                insert.Parameters.Add(telefone);
                insert.Parameters.Add(bairro);
                insert.Parameters.Add(rua);
                insert.Parameters.Add(numero);
                insert.Parameters.Add(cidade);

                try {

                    conexao.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exe) {
                    MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    if (dgvCliente.Rows.Count > 1) {
                        select = new SqlDataAdapter("SELECT * FROM cliente", conexao);
                        table = new DataTable();
                        select.Fill(table);
                        dgvCliente.DataSource = table;
                        DataGridViewRow linhaAtual = dgvCliente.CurrentRow;
                        int indice = linhaAtual.Index;
                        int cod = Convert.ToInt32(dgvCliente.Rows[indice].Cells[0].Value);

                        if (dgvCliente.Rows.Count > 0) {
                            SqlCommand slcTXT = new SqlCommand("SELECT nomecliente,telefone,bairro,rua,numero,cidade FROM cliente WHERE id_cliente = @indice");
                            slcTXT.Connection = conexao;
                            slcTXT.Parameters.AddWithValue("@indice", cod);
                            SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                            if (leitorPreencher.Read()) {

                                string name = (string)leitorPreencher["nomecliente"];
                                string phone = (string)leitorPreencher["telefone"];
                                string b = (string)leitorPreencher["bairro"];
                                string logradouro = (string)leitorPreencher["rua"];
                                int n = (int)leitorPreencher["numero"];
                                string city = (string)leitorPreencher["cidade"];

                                nomeclienteTextBox.Text = name;
                                telefoneMaskedTextBox.Text = phone.ToString();
                                bairroTextBox.Text = b.ToString();
                                ruaTextBox.Text = logradouro.ToString();
                                numeroTextBox.Text = n.ToString();
                                cidadeTextBox.Text = city.ToString();
                            }


                            leitorPreencher.Close();
                        }
                    
                    }

                    nomeclienteTextBox.Enabled = false;
                    telefoneMaskedTextBox.Enabled = false;
                    bairroTextBox.Enabled = false;
                    ruaTextBox.Enabled = false;
                    numeroTextBox.Enabled = false;
                    cidadeTextBox.Enabled = false;

                    conexao.Close();
                }
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e) {
        
            nomeclienteTextBox.Enabled = true;
            telefoneMaskedTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            ruaTextBox.Enabled = true;
            numeroTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            nomeclienteTextBox.Text = string.Empty;
            telefoneMaskedTextBox.Text = string.Empty;
            bairroTextBox.Text = string.Empty;
            ruaTextBox.Text = string.Empty;
            numeroTextBox.Text = string.Empty;
            cidadeTextBox.Text = string.Empty;

        }

        private void btnExcluirCliente_Click(object sender, EventArgs e) {
            try {
                conexao.Open();
                DataGridViewRow linhaAtual = dgvCliente.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(dgvCliente.Rows[indice].Cells[0].Value);

                if (MessageBox.Show("Tem certeza que deseja excluir o cliente?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) {

                    SqlCommand delete = new SqlCommand("DELETE FROM cliente where id_cliente = @id", conexao);
                    delete.Parameters.AddWithValue("@id", cod);
                    delete.ExecuteNonQuery();
                }

            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
                select = new SqlDataAdapter("SELECT * FROM cliente", conexao);
                table = new DataTable();
                select.Fill(table);
                dgvCliente.DataSource = table;

            }
        }

        private void btnFecharProd_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e) {
            if (btnEditarCliente.Text.Equals("Editar")) {
                dgvCliente.EditingPanel.Enabled = true;
                btnEditarCliente.Text = "Salvar Edição";
                btnEditarCliente.TextAlign = ContentAlignment.MiddleRight;
            }

            else if (btnEditarCliente.Text.Equals("Salvar Edição")) {
                conexao.Open();
                DataGridViewRow linhaAtual = dgvCliente.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(dgvCliente.Rows[indice].Cells[0].Value);

                

                SqlCommand update = new SqlCommand("UPDATE cliente SET nomecliente = @name, telefone = @phone, bairro = @b, " +
                    "rua = @logradouro, " + "numero = @n, " + "cidade = @city WHERE id_cliente = @id", conexao);

                update.Parameters.AddWithValue("@name", dgvCliente.CurrentRow.Cells[1].Value);
                update.Parameters.AddWithValue("@phone", dgvCliente.CurrentRow.Cells[2].Value);
                update.Parameters.AddWithValue("@city", dgvCliente.CurrentRow.Cells[3].Value);
                update.Parameters.AddWithValue("@b", dgvCliente.CurrentRow.Cells[4].Value);
                update.Parameters.AddWithValue("@logradouro", dgvCliente.CurrentRow.Cells[5].Value);
                update.Parameters.AddWithValue("@n", dgvCliente.CurrentRow.Cells[6].Value);
                update.Parameters.AddWithValue("@id", cod);

                try {
                    update.ExecuteNonQuery();
                }
                catch (Exception exe) {
                    MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    conexao.Close();
                    select = new SqlDataAdapter("SELECT * FROM cliente", conexao);
                    table = new DataTable();
                    select.Fill(table);
                    dgvCliente.DataSource = table;
                    Button clickedButton = (Button)sender;

                    if (clickedButton.Enabled && btnEditarCliente.Text.Equals("Salvar Edição")) {
                        MessageBox.Show("Edição salva com sucesso", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEditarCliente.Text = "Editar";
                        btnEditarCliente.TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
        }
    }
}
