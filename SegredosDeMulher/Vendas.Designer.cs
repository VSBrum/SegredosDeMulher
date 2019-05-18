namespace SegredosDeMulher {
    partial class Vendas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nomeprodutoLabel;
            System.Windows.Forms.Label qtdprodutoLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.segredosDeMulherDataSet = new SegredosDeMulher.SegredosDeMulherDataSet();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaTableAdapter = new SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.vendaTableAdapter();
            this.tableAdapterManager = new SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.TableAdapterManager();
            this.novaVenda = new System.Windows.Forms.Button();
            this.qtdTextBox = new System.Windows.Forms.TextBox();
            this.disponivelTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeprodutoComboBox = new System.Windows.Forms.ComboBox();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.qtdTextBox2 = new System.Windows.Forms.TextBox();
            this.disponivelTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeprodutoComboBox2 = new System.Windows.Forms.ComboBox();
            this.btnFecharVenda = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            nomeprodutoLabel = new System.Windows.Forms.Label();
            qtdprodutoLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.segredosDeMulherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label3.Location = new System.Drawing.Point(91, 183);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 13);
            label3.TabIndex = 48;
            label3.Text = "Cliente:";
            // 
            // nomeprodutoLabel
            // 
            nomeprodutoLabel.AutoSize = true;
            nomeprodutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeprodutoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeprodutoLabel.Location = new System.Drawing.Point(86, 221);
            nomeprodutoLabel.Name = "nomeprodutoLabel";
            nomeprodutoLabel.Size = new System.Drawing.Size(55, 13);
            nomeprodutoLabel.TabIndex = 41;
            nomeprodutoLabel.Text = "Produto:";
            // 
            // qtdprodutoLabel
            // 
            qtdprodutoLabel.AutoSize = true;
            qtdprodutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdprodutoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            qtdprodutoLabel.Location = new System.Drawing.Point(86, 248);
            qtdprodutoLabel.Name = "qtdprodutoLabel";
            qtdprodutoLabel.Size = new System.Drawing.Size(76, 13);
            qtdprodutoLabel.TabIndex = 43;
            qtdprodutoLabel.Text = "Quantidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label6.Location = new System.Drawing.Point(376, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 13);
            label6.TabIndex = 58;
            label6.Text = "Produto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label7.Location = new System.Drawing.Point(376, 248);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(76, 13);
            label7.TabIndex = 60;
            label7.Text = "Quantidade:";
            // 
            // segredosDeMulherDataSet
            // 
            this.segredosDeMulherDataSet.DataSetName = "SegredosDeMulherDataSet";
            this.segredosDeMulherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.segredosDeMulherDataSet;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = this.vendaTableAdapter;
            // 
            // novaVenda
            // 
            this.novaVenda.BackColor = System.Drawing.Color.Brown;
            this.novaVenda.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.novaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novaVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.novaVenda.Image = global::SegredosDeMulher.Properties.Resources.icons8_plus_32;
            this.novaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novaVenda.Location = new System.Drawing.Point(306, 119);
            this.novaVenda.Name = "novaVenda";
            this.novaVenda.Size = new System.Drawing.Size(222, 28);
            this.novaVenda.TabIndex = 55;
            this.novaVenda.Text = "Cadastrar nova Venda";
            this.novaVenda.UseVisualStyleBackColor = false;
            this.novaVenda.Click += new System.EventHandler(this.novaVenda_Click_1);
            // 
            // qtdTextBox
            // 
            this.qtdTextBox.Location = new System.Drawing.Point(161, 242);
            this.qtdTextBox.Name = "qtdTextBox";
            this.qtdTextBox.Size = new System.Drawing.Size(55, 20);
            this.qtdTextBox.TabIndex = 54;
            // 
            // disponivelTextBox
            // 
            this.disponivelTextBox.Location = new System.Drawing.Point(306, 242);
            this.disponivelTextBox.Name = "disponivelTextBox";
            this.disponivelTextBox.Size = new System.Drawing.Size(55, 20);
            this.disponivelTextBox.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(231, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Disponível:";
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.Brown;
            this.btnEditarProd.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProd.Image")));
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProd.Location = new System.Drawing.Point(306, 310);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(136, 27);
            this.btnEditarProd.TabIndex = 51;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.BackColor = System.Drawing.Color.Brown;
            this.btnExcluirProd.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnExcluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirProd.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProd.Image")));
            this.btnExcluirProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProd.Location = new System.Drawing.Point(226, 310);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(117, 27);
            this.btnExcluirProd.TabIndex = 50;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = false;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.Brown;
            this.btnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCliente.Image = global::SegredosDeMulher.Properties.Resources.shopping_cart_3_icon_icons_com_63429;
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliente.Location = new System.Drawing.Point(379, 175);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(264, 28);
            this.btnAddCliente.TabIndex = 47;
            this.btnAddCliente.Text = "Adicionar Produto ao Carrinho";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.BackColor = System.Drawing.Color.Brown;
            this.btnSalvarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnSalvarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCliente.Image")));
            this.btnSalvarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCliente.Location = new System.Drawing.Point(226, 120);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(117, 27);
            this.btnSalvarCliente.TabIndex = 46;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = false;
            this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cadastro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(76, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vendas:";
            // 
            // nomeprodutoComboBox
            // 
            this.nomeprodutoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "nomeproduto", true));
            this.nomeprodutoComboBox.FormattingEnabled = true;
            this.nomeprodutoComboBox.Location = new System.Drawing.Point(161, 215);
            this.nomeprodutoComboBox.Name = "nomeprodutoComboBox";
            this.nomeprodutoComboBox.Size = new System.Drawing.Size(200, 21);
            this.nomeprodutoComboBox.TabIndex = 42;
            this.nomeprodutoComboBox.SelectedIndexChanged += new System.EventHandler(this.nomeprodutoComboBox_SelectedIndexChanged_1);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "nomecliente", true));
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(161, 180);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(200, 21);
            this.clienteComboBox.TabIndex = 57;
            // 
            // qtdTextBox2
            // 
            this.qtdTextBox2.Location = new System.Drawing.Point(451, 242);
            this.qtdTextBox2.Name = "qtdTextBox2";
            this.qtdTextBox2.Size = new System.Drawing.Size(55, 20);
            this.qtdTextBox2.TabIndex = 63;
            // 
            // disponivelTextBox2
            // 
            this.disponivelTextBox2.Location = new System.Drawing.Point(596, 242);
            this.disponivelTextBox2.Name = "disponivelTextBox2";
            this.disponivelTextBox2.Size = new System.Drawing.Size(55, 20);
            this.disponivelTextBox2.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(521, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Disponível:";
            // 
            // nomeprodutoComboBox2
            // 
            this.nomeprodutoComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "nomeproduto", true));
            this.nomeprodutoComboBox2.FormattingEnabled = true;
            this.nomeprodutoComboBox2.Location = new System.Drawing.Point(451, 215);
            this.nomeprodutoComboBox2.Name = "nomeprodutoComboBox2";
            this.nomeprodutoComboBox2.Size = new System.Drawing.Size(200, 21);
            this.nomeprodutoComboBox2.TabIndex = 59;
            this.nomeprodutoComboBox2.SelectedIndexChanged += new System.EventHandler(this.nomeprodutoComboBox2_SelectedIndexChanged);
            // 
            // btnFecharVenda
            // 
            this.btnFecharVenda.BackColor = System.Drawing.Color.DarkRed;
            this.btnFecharVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFecharVenda.Location = new System.Drawing.Point(778, 46);
            this.btnFecharVenda.Name = "btnFecharVenda";
            this.btnFecharVenda.Size = new System.Drawing.Size(75, 23);
            this.btnFecharVenda.TabIndex = 64;
            this.btnFecharVenda.Text = "Fechar";
            this.btnFecharVenda.UseVisualStyleBackColor = false;
            this.btnFecharVenda.Click += new System.EventHandler(this.btnFecharVenda_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 112;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeproduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeproduto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 112;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomecliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "nomecliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qtdproduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "qtdproduto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 112;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valorproduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "valorproduto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "datavenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "datavenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 112;
            // 
            // vendaDGV
            // 
            this.vendaDGV.AutoGenerateColumns = false;
            this.vendaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendaDGV.BackgroundColor = System.Drawing.Color.Brown;
            this.vendaDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendaDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.vendaDGV.DataSource = this.vendaBindingSource;
            this.vendaDGV.Location = new System.Drawing.Point(80, 343);
            this.vendaDGV.Name = "vendaDGV";
            this.vendaDGV.Size = new System.Drawing.Size(715, 303);
            this.vendaDGV.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_venda";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nomecliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nomeproduto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Produto(s)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "qtdproduto";
            this.dataGridViewTextBoxColumn10.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "valorvenda";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn11.HeaderText = "Valor da compra";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "datavenda";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn12.HeaderText = "Data da Venda";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(873, 670);
            this.Controls.Add(this.vendaDGV);
            this.Controls.Add(this.btnFecharVenda);
            this.Controls.Add(this.qtdTextBox2);
            this.Controls.Add(this.disponivelTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(label6);
            this.Controls.Add(this.nomeprodutoComboBox2);
            this.Controls.Add(label7);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.novaVenda);
            this.Controls.Add(this.qtdTextBox);
            this.Controls.Add(this.disponivelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(nomeprodutoLabel);
            this.Controls.Add(this.nomeprodutoComboBox);
            this.Controls.Add(qtdprodutoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vendas";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.segredosDeMulherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SegredosDeMulherDataSet segredosDeMulherDataSet;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private SegredosDeMulherDataSetTableAdapters.vendaTableAdapter vendaTableAdapter;
        private SegredosDeMulherDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button novaVenda;
        private System.Windows.Forms.TextBox qtdTextBox;
        private System.Windows.Forms.TextBox disponivelTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nomeprodutoComboBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.TextBox qtdTextBox2;
        private System.Windows.Forms.TextBox disponivelTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox nomeprodutoComboBox2;
        private System.Windows.Forms.Button btnFecharVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView vendaDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}