using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SegredosDeMulher {
    public partial class Produtos : Form {
        public Produtos() {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection("Data Source=.\\SEGREDOSDEMULHER;Initial Catalog=SegredosDeMulher;" +
            "Persist Security Info=True;User ID=sa;Password=123456");

        SqlDataAdapter select;
        DataTable table;
        Bitmap bmp;
        public static int cont = 0;
        Boolean habilitar = false;
        public static string titulo;


        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.segredosDeMulherDataSet);
        }


        private void Produtos_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'segredosDeMulherDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.segredosDeMulherDataSet.produto);
            dgvProduto.AutoResizeColumns();

            nomeprodutoTextBox.Enabled = false;
            valorprodutoTextBox.Enabled = false;
            qtdprodutoTextBox.Enabled = false;

            dgvProduto.EditingPanel.Enabled = false;
        }

        //Clicar no produto e mostrar imagem dele e os dados no TextBox
        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e) {
           
            try {
                conexao.Open();

                DataGridViewRow linhaAtual = dgvProduto.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(dgvProduto.Rows[indice].Cells[0].Value);
                
                SqlCommand slcTXT = new SqlCommand("SELECT nomeproduto,valorproduto,qtdproduto FROM produto WHERE id_produto = @indice");
                slcTXT.Connection = conexao;

                slcTXT.Parameters.AddWithValue("@indice", cod);

                SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                if (leitorPreencher.Read()) {

                    string name = (string)leitorPreencher["nomeproduto"];
                    decimal valor = (decimal)leitorPreencher["valorproduto"];
                    int qtd = (int)leitorPreencher["qtdproduto"];

                    nomeprodutoTextBox.Text = name;
                    valorprodutoTextBox.Text = valor.ToString();
                    qtdprodutoTextBox.Text = qtd.ToString();

                    leitorPreencher.Close();
                }
                
                SqlCommand slcImagem = new SqlCommand("SELECT imgproduto FROM produto WHERE id_produto = @indice");
                slcImagem.Connection = conexao;

                slcImagem.Parameters.AddWithValue("@indice", cod);

                SqlDataReader leitor = slcImagem.ExecuteReader();

                Image image = null;

                if (leitor.Read()) {
                    byte[] foto = (byte[])leitor["imgproduto"];

                    MemoryStream ms = new MemoryStream(foto);
                    image = Image.FromStream(ms);
                }
                
                imgProdSelecionado.Image = image;

            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }

        }

        //Selecionar imagem ao clicar no picturebox
        private void imgProduto_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione uma Imagem";

            ofd.Filter = "Todos arquivos de imagem (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            if (ofd.ShowDialog() == DialogResult.OK) {
                string nome = ofd.FileName;
                bmp = new Bitmap(nome);
                imgProduto.Image = bmp;
                cont = 1;
            }

        }

        //Botão para fechar a tela de produto
        private void btnFecharProd_Click(object sender, EventArgs e) {
            titulo = "";
            this.Close();
            

        }

        
        //Botão de salvar dados no banco
        private void btnSalvarProd_Click_1(object sender, EventArgs e) {

            if (nomeprodutoTextBox.Enabled == false || valorprodutoTextBox.Enabled == false || qtdprodutoTextBox.Enabled == false) {
                MessageBox.Show("Não foi digitado todos dados necessáarios, por favor preencha os campos obrigatórios!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (cont == 0) {
                    bmp = new Bitmap(imgProdSelecionado.BackgroundImage);
                }

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Bmp);
                byte[] img = memory.ToArray();

                SqlCommand insert = new SqlCommand("INSERT INTO produto (nomeproduto,valorproduto,qtdproduto,imgproduto) " +
                    "VALUES (@nomeproduto,@valorproduto,@qtdproduto,@imgproduto)");
                insert.Connection = conexao;

                SqlParameter nomeproduto = new SqlParameter("@nomeproduto", SqlDbType.VarChar);
                SqlParameter valorproduto = new SqlParameter("@valorproduto", SqlDbType.Decimal);
                SqlParameter qtdproduto = new SqlParameter("@qtdproduto", SqlDbType.Int);
                SqlParameter imgproduto = new SqlParameter("@imgproduto", SqlDbType.Binary);

                if (img == null) {
                    imgproduto.Value = DBNull.Value;
                }
                else {
                    imgproduto.Value = img;
                }
                
                nomeproduto.Value = nomeprodutoTextBox.Text;
                valorproduto.Value = valorprodutoTextBox.Text; ;
                qtdproduto.Value = qtdprodutoTextBox.Text;

                insert.Parameters.Add(nomeproduto);
                insert.Parameters.Add(valorproduto);
                insert.Parameters.Add(qtdproduto);
                insert.Parameters.Add(imgproduto);

                try {

                    conexao.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exe) {
                    MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    select = new SqlDataAdapter("SELECT * FROM produto", conexao);
                    table = new DataTable();
                    select.Fill(table);
                    dgvProduto.DataSource = table;
                    imgProduto.Image = imgProduto.BackgroundImage;
                    DataGridViewRow linhaAtual = dgvProduto.CurrentRow;
                    int indice = linhaAtual.Index;
                    int cod = Convert.ToInt32(dgvProduto.Rows[indice].Cells[0].Value);

                    SqlCommand slcTXT = new SqlCommand("SELECT nomeproduto,valorproduto,qtdproduto FROM produto WHERE id_produto = @indice");
                    slcTXT.Connection = conexao;
                    slcTXT.Parameters.AddWithValue("@indice", cod);
                    SqlDataReader leitorPreencher = slcTXT.ExecuteReader();

                    if (leitorPreencher.Read()) {
                        string name = (string)leitorPreencher["nomeproduto"];
                        decimal valor = (decimal)leitorPreencher["valorproduto"];
                        int qtd = (int)leitorPreencher["qtdproduto"];
                        nomeprodutoTextBox.Text = name;
                        valorprodutoTextBox.Text = valor.ToString();
                        qtdprodutoTextBox.Text = qtd.ToString();
                        leitorPreencher.Close();
                    }

                    nomeprodutoTextBox.Enabled = false;
                    valorprodutoTextBox.Enabled = false;
                    qtdprodutoTextBox.Enabled = false;
                    conexao.Close();
                }
            }

            
        }

        //Botão de adicionar novo produto, habilitando e limpando os TextBoxs 
        private void btnAddProd_Click(object sender, EventArgs e) {

            nomeprodutoTextBox.Enabled = true;
            valorprodutoTextBox.Enabled = true;
            qtdprodutoTextBox.Enabled = true;
            nomeprodutoTextBox.Text = string.Empty;
            valorprodutoTextBox.Text = string.Empty;
            qtdprodutoTextBox.Text = string.Empty;

        }

        //Botão para editar os produtos no datagridview e imagem do produto
        private void btnEditarProd_Click(object sender, EventArgs e) {
           
            if (btnEditarProd.Text.Equals("Editar")) {
                dgvProduto.EditingPanel.Enabled = true;
                habilitar = true;
                btnEditarProd.Text = "Salvar Edição";
                btnEditarProd.TextAlign = ContentAlignment.MiddleRight;
            }

            else if (btnEditarProd.Text.Equals("Salvar Edição")) {
                conexao.Open();
                DataGridViewRow linhaAtual = dgvProduto.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(dgvProduto.Rows[indice].Cells[0].Value);

                MemoryStream memory = new MemoryStream();
                bmp.Save(memory, ImageFormat.Bmp);
                byte[] img = memory.ToArray();

                SqlCommand update = new SqlCommand("UPDATE produto SET nomeproduto = @name, valorproduto = @valor, qtdproduto = @qtd, imgproduto = @img " +
                    "WHERE id_produto = @id", conexao);
                
                update.Parameters.AddWithValue("@name", dgvProduto.CurrentRow.Cells[1].Value);
                update.Parameters.AddWithValue("@valor", dgvProduto.CurrentRow.Cells[2].Value);
                update.Parameters.AddWithValue("@qtd", dgvProduto.CurrentRow.Cells[3].Value);
                update.Parameters.AddWithValue("@img", img);
                update.Parameters.AddWithValue("@id", cod);
                
                try {
                    update.ExecuteNonQuery();
                }
                catch (Exception exe) {
                    MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally {
                    conexao.Close();
                    select = new SqlDataAdapter("SELECT * FROM produto", conexao);
                    table = new DataTable();
                    select.Fill(table);
                    dgvProduto.DataSource = table;
                    Button clickedButton = (Button)sender;

                    if (clickedButton.Enabled && btnEditarProd.Text.Equals("Salvar Edição")) {
                        MessageBox.Show("Edição salva com sucesso", "Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEditarProd.Text = "Editar";
                        btnEditarProd.TextAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
        }

        //Botão para excluir produto no banco
        private void btnExcluirProd_Click(object sender, EventArgs e) {
            try {
                conexao.Open();
                DataGridViewRow linhaAtual = dgvProduto.CurrentRow;
                int indice = linhaAtual.Index;
                int cod = Convert.ToInt32(dgvProduto.Rows[indice].Cells[0].Value);

                if (MessageBox.Show("Tem certeza que deseja excluir o produto?", "Excluir", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) {
               
                    SqlCommand delete = new SqlCommand("DELETE FROM produto where id_produto = @id", conexao);
                    delete.Parameters.AddWithValue("@id", cod);
                    delete.ExecuteNonQuery();
                }

            }
            catch (Exception exe) {
                MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
                select = new SqlDataAdapter("SELECT * FROM produto", conexao);
                table = new DataTable();
                select.Fill(table);
                dgvProduto.DataSource = table;

            }
        }

        //Clicar na picturebox da imagem do produto e selecionar outra para mudar a imagem já cadastrada
        private void imgProdSelecionado_Click(object sender, EventArgs e) {

            if (habilitar) {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Selecione uma Imagem";

                ofd.Filter = "Todos arquivos de imagem (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    string nome = ofd.FileName;
                    bmp = new Bitmap(nome);
                    imgProdSelecionado.Image = bmp;
                }
            }
            
        }
    }
}
