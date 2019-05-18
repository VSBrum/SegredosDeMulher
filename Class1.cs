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
    disponivelTextBox.Text = "";
    disponivelTextBox.Enabled = false;

    /*nomeprodutoComboBox.Text = "";
    clienteComboBox.Text = string.Empty;
    disponivelTextBox.Text = string.Empty;
    qtdTextBox.Text = string.Empty;

    nomeprodutoComboBox.Enabled = false;
    clienteComboBox.Enabled = false;
    disponivelTextBox.Enabled = false;
    qtdTextBox.Enabled = false;*/

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



    /*SqlDataAdapter selectQTD = new SqlDataAdapter("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod", conexao);
    selectQTD.SelectCommand.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));
    table = new DataTable("produto");
    selectQTD.Fill(table);
    qtdprodutoComboBox.DataSource = table;
    qtdprodutoComboBox.ValueMember = "qtdproduto";*/
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

        /* SqlDataAdapter selectQTD = new SqlDataAdapter("SELECT qtdproduto FROM produto WHERE nomeproduto = @prod", conexao);
         selectQTD.SelectCommand.Parameters.AddWithValue("@prod", Convert.ToString(nomeprodutoComboBox.SelectedValue));

         // int qtd = Convert.ToInt32(selectQTD.SelectCommand.ExecuteScalar());

         table = new DataTable("produto");
         selectQTD.Fill(table);
         int qtd = Convert.ToInt32(table.ToString());
         qtdprodutoComboBox.DataSource = table;
         qtdprodutoComboBox.ValueMember = "qtdproduto";*/
    }
    catch (Exception exe) {
        MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally {
        conexao.Close();
    }



}

private void btnSalvarCliente_Click(object sender, EventArgs e) {


    try {

        conexao.Open();
        if (nomeprodutoComboBox.Text == string.Empty || clienteComboBox.Text == string.Empty || qtdTextBox.Text == string.Empty) {
            MessageBox.Show("Não foi digitado todos dados necessáarios, por favor preencha os campos obrigatórios!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else {

            DateTime agora = DateTime.Now;

            SqlCommand insert = new SqlCommand("INSERT INTO venda (nomeproduto,nomecliente,qtdproduto,valorproduto,datavenda) " +
                "VALUES (@nomeproduto,@nomecliente,@qtdproduto,@valorproduto,@data)");
            insert.Connection = conexao;

            SqlParameter nomeproduto = new SqlParameter("@nomeproduto", SqlDbType.VarChar);
            SqlParameter nomecliente = new SqlParameter("@nomecliente", SqlDbType.VarChar);
            SqlParameter qtdproduto = new SqlParameter("@qtdproduto", SqlDbType.Int);
            SqlParameter valorproduto = new SqlParameter("@valorproduto", SqlDbType.Decimal);
            SqlParameter data = new SqlParameter("@data", SqlDbType.DateTime);


            nomeproduto.Value = nomeprodutoComboBox.Text;
            nomecliente.Value = clienteComboBox.Text;
            qtdproduto.Value = qtdTextBox.Text;
            data.Value = agora;
            decimal preco = 0;

            /*SqlCommand nameProd = new SqlCommand("SELECT id_produto FROM produto WHERE nomeproduto = @nomeprod", conexao);
            nameProd.Parameters.AddWithValue("@nomeprod", nomeprodutoComboBox.Text);
            SqlDataReader read = nameProd.ExecuteReader();

            int idprod = 0;
            int idCli = 0;


            if (read.Read()) {
                idprod = (int)read["id_produto"];
            }
            read.Close();

            idProduto.Value = idprod;*/

            /*SqlCommand nameCliente = new SqlCommand("SELECT id_cliente FROM cliente WHERE nomecliente = @nomecliente", conexao);
            nameCliente.Parameters.AddWithValue("@nomecliente", clienteComboBox.Text);
            SqlDataReader readCliente = nameCliente.ExecuteReader();

            if (readCliente.Read()) {
                idCli = (int)readCliente["id_cliente"];
            }

            readCliente.Close();
            idCliente.Value = idCli;*/

            SqlCommand valor = new SqlCommand("SELECT valorproduto FROM produto WHERE nomeproduto = @nomeproduto", conexao);
            valor.Parameters.AddWithValue("@nomeproduto", nomeprodutoComboBox.Text);
            SqlDataReader readValor = valor.ExecuteReader();

            if (readValor.Read()) {
                preco = (decimal)readValor["valorproduto"];
            }

            decimal precototal = preco * (Convert.ToInt32(qtdTextBox.Text));

            readValor.Close();

            valorproduto.Value = precototal;

            insert.Parameters.Add(nomeproduto);
            insert.Parameters.Add(nomecliente);
            insert.Parameters.Add(valorproduto);
            insert.Parameters.Add(qtdproduto);
            insert.Parameters.Add(data);
            insert.ExecuteNonQuery();

            MessageBox.Show("Salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    catch (Exception exe) {
        MessageBox.Show(exe.Message, "Erro na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally {
        select = new SqlDataAdapter("SELECT * FROM venda", conexao);
        table = new DataTable();
        select.Fill(table);
        vendaDataGridView.DataSource = table;
        conexao.Close();

        DataGridViewRow linhaAtual = vendaDataGridView.CurrentRow;
        int indice = linhaAtual.Index;
        int cod = Convert.ToInt32(vendaDataGridView.Rows[indice].Cells[0].Value);

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
}

private void vendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
    try {
        conexao.Open();

        DataGridViewRow linhaAtual = vendaDataGridView.CurrentRow;
        int indice = linhaAtual.Index;
        int cod = Convert.ToInt32(vendaDataGridView.Rows[indice].Cells[0].Value);

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

private void novaVenda_Click(object sender, EventArgs e) {

    nomeprodutoComboBox.Enabled = true;
    clienteComboBox.Enabled = true;
    qtdTextBox.Enabled = true;

    nomeprodutoComboBox.Text = "[Produto]";
    clienteComboBox.Text = "[Cliente]";
    qtdTextBox.Text = "[0]";

}

private void clienteComboBox_SelectedIndexChanged(object sender, EventArgs e) {
    nomeprodutoComboBox.Enabled = true;
    clienteComboBox.Enabled = true;
    qtdTextBox.Enabled = true;
}

private void qtdTextBox_TextChanged(object sender, EventArgs e) {

}