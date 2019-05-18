namespace SegredosDeMulher {
    partial class Produtos {
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
            System.Windows.Forms.Label nomeprodutoLabel;
            System.Windows.Forms.Label valorprodutoLabel;
            System.Windows.Forms.Label qtdprodutoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.segredosDeMulherDataSet = new SegredosDeMulher.SegredosDeMulherDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.TableAdapterManager();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeprodutoTextBox = new System.Windows.Forms.TextBox();
            this.valorprodutoTextBox = new System.Windows.Forms.TextBox();
            this.qtdprodutoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFecharProd = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.imgProdSelecionado = new System.Windows.Forms.PictureBox();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            nomeprodutoLabel = new System.Windows.Forms.Label();
            valorprodutoLabel = new System.Windows.Forms.Label();
            qtdprodutoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.segredosDeMulherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeprodutoLabel
            // 
            nomeprodutoLabel.AutoSize = true;
            nomeprodutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeprodutoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            nomeprodutoLabel.Location = new System.Drawing.Point(238, 153);
            nomeprodutoLabel.Name = "nomeprodutoLabel";
            nomeprodutoLabel.Size = new System.Drawing.Size(43, 13);
            nomeprodutoLabel.TabIndex = 3;
            nomeprodutoLabel.Text = "Nome:";
            // 
            // valorprodutoLabel
            // 
            valorprodutoLabel.AutoSize = true;
            valorprodutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorprodutoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            valorprodutoLabel.Location = new System.Drawing.Point(241, 184);
            valorprodutoLabel.Name = "valorprodutoLabel";
            valorprodutoLabel.Size = new System.Drawing.Size(40, 13);
            valorprodutoLabel.TabIndex = 5;
            valorprodutoLabel.Text = "Valor:";
            // 
            // qtdprodutoLabel
            // 
            qtdprodutoLabel.AutoSize = true;
            qtdprodutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtdprodutoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            qtdprodutoLabel.Location = new System.Drawing.Point(239, 219);
            qtdprodutoLabel.Name = "qtdprodutoLabel";
            qtdprodutoLabel.Size = new System.Drawing.Size(76, 13);
            qtdprodutoLabel.TabIndex = 7;
            qtdprodutoLabel.Text = "Quantidade:";
            // 
            // segredosDeMulherDataSet
            // 
            this.segredosDeMulherDataSet.DataSetName = "SegredosDeMulherDataSet";
            this.segredosDeMulherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.segredosDeMulherDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SegredosDeMulher.SegredosDeMulherDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.nomeprodutoDataGridViewTextBoxColumn,
            this.valorprodutoDataGridViewTextBoxColumn,
            this.qtdprodutoDataGridViewTextBoxColumn});
            this.dgvProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProduto.DataSource = this.produtoBindingSource1;
            this.dgvProduto.Location = new System.Drawing.Point(31, 341);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(521, 293);
            this.dgvProduto.TabIndex = 11;
            this.dgvProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellContentClick);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeprodutoDataGridViewTextBoxColumn
            // 
            this.nomeprodutoDataGridViewTextBoxColumn.DataPropertyName = "nomeproduto";
            this.nomeprodutoDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeprodutoDataGridViewTextBoxColumn.Name = "nomeprodutoDataGridViewTextBoxColumn";
            // 
            // valorprodutoDataGridViewTextBoxColumn
            // 
            this.valorprodutoDataGridViewTextBoxColumn.DataPropertyName = "valorproduto";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorprodutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorprodutoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorprodutoDataGridViewTextBoxColumn.Name = "valorprodutoDataGridViewTextBoxColumn";
            // 
            // qtdprodutoDataGridViewTextBoxColumn
            // 
            this.qtdprodutoDataGridViewTextBoxColumn.DataPropertyName = "qtdproduto";
            this.qtdprodutoDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.qtdprodutoDataGridViewTextBoxColumn.Name = "qtdprodutoDataGridViewTextBoxColumn";
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            this.produtoBindingSource1.DataSource = this.segredosDeMulherDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Script MT Bold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(600, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Imagem Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(116, -59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Estoque:";
            // 
            // nomeprodutoTextBox
            // 
            this.nomeprodutoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.nomeprodutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nomeproduto", true));
            this.nomeprodutoTextBox.Location = new System.Drawing.Point(321, 146);
            this.nomeprodutoTextBox.Name = "nomeprodutoTextBox";
            this.nomeprodutoTextBox.Size = new System.Drawing.Size(231, 20);
            this.nomeprodutoTextBox.TabIndex = 4;
            // 
            // valorprodutoTextBox
            // 
            this.valorprodutoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.valorprodutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "valorproduto", true));
            this.valorprodutoTextBox.Location = new System.Drawing.Point(321, 181);
            this.valorprodutoTextBox.Name = "valorprodutoTextBox";
            this.valorprodutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorprodutoTextBox.TabIndex = 6;
            // 
            // qtdprodutoTextBox
            // 
            this.qtdprodutoTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.qtdprodutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "qtdproduto", true));
            this.qtdprodutoTextBox.Location = new System.Drawing.Point(321, 216);
            this.qtdprodutoTextBox.Name = "qtdprodutoTextBox";
            this.qtdprodutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtdprodutoTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cadastro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 38);
            this.label4.TabIndex = 19;
            this.label4.Text = "Estoque:";
            // 
            // btnFecharProd
            // 
            this.btnFecharProd.BackColor = System.Drawing.Color.DarkRed;
            this.btnFecharProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFecharProd.Location = new System.Drawing.Point(764, 57);
            this.btnFecharProd.Name = "btnFecharProd";
            this.btnFecharProd.Size = new System.Drawing.Size(75, 23);
            this.btnFecharProd.TabIndex = 26;
            this.btnFecharProd.Text = "Fechar";
            this.btnFecharProd.UseVisualStyleBackColor = false;
            this.btnFecharProd.Click += new System.EventHandler(this.btnFecharProd_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.BackColor = System.Drawing.Color.Brown;
            this.btnAddProd.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnAddProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProd.Image = global::SegredosDeMulher.Properties.Resources.icons8_plus_32;
            this.btnAddProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProd.Location = new System.Drawing.Point(302, 79);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(170, 28);
            this.btnAddProd.TabIndex = 23;
            this.btnAddProd.Text = "Novo Produto";
            this.btnAddProd.UseVisualStyleBackColor = false;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
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
            this.btnEditarProd.Location = new System.Drawing.Point(302, 310);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(136, 27);
            this.btnEditarProd.TabIndex = 22;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.Brown;
            this.btnSalvarProd.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProd.Image")));
            this.btnSalvarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProd.Location = new System.Drawing.Point(221, 80);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(117, 27);
            this.btnSalvarProd.TabIndex = 20;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click_1);
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
            this.btnExcluirProd.Location = new System.Drawing.Point(222, 310);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(117, 27);
            this.btnExcluirProd.TabIndex = 21;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = false;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // imgProdSelecionado
            // 
            this.imgProdSelecionado.BackColor = System.Drawing.SystemColors.Menu;
            this.imgProdSelecionado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgProdSelecionado.BackgroundImage")));
            this.imgProdSelecionado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProdSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgProdSelecionado.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProdSelecionado.Location = new System.Drawing.Point(576, 341);
            this.imgProdSelecionado.Name = "imgProdSelecionado";
            this.imgProdSelecionado.Size = new System.Drawing.Size(251, 255);
            this.imgProdSelecionado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProdSelecionado.TabIndex = 14;
            this.imgProdSelecionado.TabStop = false;
            this.imgProdSelecionado.Click += new System.EventHandler(this.imgProdSelecionado_Click);
            // 
            // imgProduto
            // 
            this.imgProduto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imgProduto.BackgroundImage = global::SegredosDeMulher.Properties.Resources.icone_imagem;
            this.imgProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProduto.Location = new System.Drawing.Point(41, 125);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(177, 155);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduto.TabIndex = 10;
            this.imgProduto.TabStop = false;
            this.imgProduto.Click += new System.EventHandler(this.imgProduto_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 670);
            this.Controls.Add(this.btnFecharProd);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.btnExcluirProd);
            this.Controls.Add(nomeprodutoLabel);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.imgProdSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgProduto);
            this.Controls.Add(this.valorprodutoTextBox);
            this.Controls.Add(qtdprodutoLabel);
            this.Controls.Add(valorprodutoLabel);
            this.Controls.Add(this.nomeprodutoTextBox);
            this.Controls.Add(this.qtdprodutoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.segredosDeMulherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SegredosDeMulherDataSet segredosDeMulherDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private SegredosDeMulherDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private SegredosDeMulherDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox imgProdSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.TextBox nomeprodutoTextBox;
        private System.Windows.Forms.TextBox valorprodutoTextBox;
        private System.Windows.Forms.TextBox qtdprodutoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarProd;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnEditarProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnFecharProd;
    }
}