namespace Inventory_Management.Forms.Inventory
{
    partial class Frm_inventory_input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_saveProduct = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grpBoxSupplier = new GroupBox();
            lbl_supplierName = new Label();
            txt_supplierName = new TextBox();
            btn_searchSupplier = new Button();
            lbl_supplierCnpj = new Label();
            txt_supplierCnpj = new TextBox();
            grpBoxDocument = new GroupBox();
            lbl_docIdentifier = new Label();
            txt_docIdentifier = new TextBox();
            tabPage2 = new TabPage();
            grd_productToSave = new DataGridView();
            groupBox3 = new GroupBox();
            btn_addProductToList = new Button();
            lbl_productName = new Label();
            txt_productName = new TextBox();
            btn_searchProduct = new Button();
            lbl_productId = new Label();
            txt_productId = new TextBox();
            txt_inputQtd = new TextBox();
            txt_inputPrice = new TextBox();
            lbl_inputQtd = new Label();
            lbl_inputPrice = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpBoxSupplier.SuspendLayout();
            grpBoxDocument.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_productToSave).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_saveProduct
            // 
            btn_saveProduct.Location = new Point(793, 469);
            btn_saveProduct.Name = "btn_saveProduct";
            btn_saveProduct.Size = new Size(94, 29);
            btn_saveProduct.TabIndex = 6;
            btn_saveProduct.Text = "Salvar";
            btn_saveProduct.UseVisualStyleBackColor = true;
            btn_saveProduct.Click += button3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 451);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(grpBoxSupplier);
            tabPage1.Controls.Add(grpBoxDocument);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(867, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Documento e Fornecedor";
            // 
            // grpBoxSupplier
            // 
            grpBoxSupplier.Controls.Add(lbl_supplierName);
            grpBoxSupplier.Controls.Add(txt_supplierName);
            grpBoxSupplier.Controls.Add(btn_searchSupplier);
            grpBoxSupplier.Controls.Add(lbl_supplierCnpj);
            grpBoxSupplier.Controls.Add(txt_supplierCnpj);
            grpBoxSupplier.Location = new Point(6, 131);
            grpBoxSupplier.Name = "grpBoxSupplier";
            grpBoxSupplier.Size = new Size(855, 115);
            grpBoxSupplier.TabIndex = 3;
            grpBoxSupplier.TabStop = false;
            grpBoxSupplier.Text = "Fornecedor";
            // 
            // lbl_supplierName
            // 
            lbl_supplierName.AutoSize = true;
            lbl_supplierName.Location = new Point(337, 47);
            lbl_supplierName.Name = "lbl_supplierName";
            lbl_supplierName.Size = new Size(50, 20);
            lbl_supplierName.TabIndex = 4;
            lbl_supplierName.Text = "Nome";
            // 
            // txt_supplierName
            // 
            txt_supplierName.Location = new Point(337, 70);
            txt_supplierName.Name = "txt_supplierName";
            txt_supplierName.Size = new Size(433, 27);
            txt_supplierName.TabIndex = 3;
            // 
            // btn_searchSupplier
            // 
            btn_searchSupplier.Location = new Point(237, 68);
            btn_searchSupplier.Name = "btn_searchSupplier";
            btn_searchSupplier.Size = new Size(94, 29);
            btn_searchSupplier.TabIndex = 2;
            btn_searchSupplier.Text = "Buscar";
            btn_searchSupplier.UseVisualStyleBackColor = true;
            btn_searchSupplier.Click += btn_searchSupplier_Click;
            // 
            // lbl_supplierCnpj
            // 
            lbl_supplierCnpj.AutoSize = true;
            lbl_supplierCnpj.Location = new Point(6, 44);
            lbl_supplierCnpj.Name = "lbl_supplierCnpj";
            lbl_supplierCnpj.Size = new Size(41, 20);
            lbl_supplierCnpj.TabIndex = 1;
            lbl_supplierCnpj.Text = "CNPJ";
            // 
            // txt_supplierCnpj
            // 
            txt_supplierCnpj.Location = new Point(6, 70);
            txt_supplierCnpj.Name = "txt_supplierCnpj";
            txt_supplierCnpj.Size = new Size(225, 27);
            txt_supplierCnpj.TabIndex = 0;
            // 
            // grpBoxDocument
            // 
            grpBoxDocument.Controls.Add(lbl_docIdentifier);
            grpBoxDocument.Controls.Add(txt_docIdentifier);
            grpBoxDocument.Location = new Point(6, 10);
            grpBoxDocument.Name = "grpBoxDocument";
            grpBoxDocument.Size = new Size(855, 115);
            grpBoxDocument.TabIndex = 2;
            grpBoxDocument.TabStop = false;
            grpBoxDocument.Text = "Documento";
            // 
            // lbl_docIdentifier
            // 
            lbl_docIdentifier.AutoSize = true;
            lbl_docIdentifier.Location = new Point(6, 44);
            lbl_docIdentifier.Name = "lbl_docIdentifier";
            lbl_docIdentifier.Size = new Size(94, 20);
            lbl_docIdentifier.TabIndex = 1;
            lbl_docIdentifier.Text = "Identificador";
            // 
            // txt_docIdentifier
            // 
            txt_docIdentifier.Location = new Point(6, 70);
            txt_docIdentifier.Name = "txt_docIdentifier";
            txt_docIdentifier.ReadOnly = true;
            txt_docIdentifier.Size = new Size(325, 27);
            txt_docIdentifier.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(grd_productToSave);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(867, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Produto";
            // 
            // grd_productToSave
            // 
            grd_productToSave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_productToSave.Location = new Point(6, 198);
            grd_productToSave.Name = "grd_productToSave";
            grd_productToSave.RowHeadersWidth = 51;
            grd_productToSave.Size = new Size(858, 214);
            grd_productToSave.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbl_inputPrice);
            groupBox3.Controls.Add(lbl_inputQtd);
            groupBox3.Controls.Add(txt_inputPrice);
            groupBox3.Controls.Add(txt_inputQtd);
            groupBox3.Controls.Add(btn_addProductToList);
            groupBox3.Controls.Add(lbl_productName);
            groupBox3.Controls.Add(txt_productName);
            groupBox3.Controls.Add(btn_searchProduct);
            groupBox3.Controls.Add(lbl_productId);
            groupBox3.Controls.Add(txt_productId);
            groupBox3.Location = new Point(6, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(855, 186);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Produto";
            // 
            // btn_addProductToList
            // 
            btn_addProductToList.Location = new Point(9, 141);
            btn_addProductToList.Name = "btn_addProductToList";
            btn_addProductToList.Size = new Size(102, 29);
            btn_addProductToList.TabIndex = 6;
            btn_addProductToList.Text = "Adicionar";
            btn_addProductToList.UseVisualStyleBackColor = true;
            btn_addProductToList.Click += btn_addProductToList_Click;
            // 
            // lbl_productName
            // 
            lbl_productName.AutoSize = true;
            lbl_productName.Location = new Point(9, 85);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(50, 20);
            lbl_productName.TabIndex = 4;
            lbl_productName.Text = "Nome";
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(9, 108);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(433, 27);
            txt_productName.TabIndex = 3;
            // 
            // btn_searchProduct
            // 
            btn_searchProduct.Location = new Point(237, 47);
            btn_searchProduct.Name = "btn_searchProduct";
            btn_searchProduct.Size = new Size(94, 29);
            btn_searchProduct.TabIndex = 2;
            btn_searchProduct.Text = "Buscar";
            btn_searchProduct.UseVisualStyleBackColor = true;
            btn_searchProduct.Click += btn_addProduct_Click;
            // 
            // lbl_productId
            // 
            lbl_productId.AutoSize = true;
            lbl_productId.Location = new Point(6, 21);
            lbl_productId.Name = "lbl_productId";
            lbl_productId.Size = new Size(24, 20);
            lbl_productId.TabIndex = 1;
            lbl_productId.Text = "ID";
            // 
            // txt_productId
            // 
            txt_productId.Location = new Point(6, 47);
            txt_productId.Name = "txt_productId";
            txt_productId.Size = new Size(225, 27);
            txt_productId.TabIndex = 0;
            // 
            // txt_inputQtd
            // 
            txt_inputQtd.Location = new Point(486, 49);
            txt_inputQtd.Name = "txt_inputQtd";
            txt_inputQtd.Size = new Size(225, 27);
            txt_inputQtd.TabIndex = 7;
            // 
            // txt_inputPrice
            // 
            txt_inputPrice.Location = new Point(486, 108);
            txt_inputPrice.Name = "txt_inputPrice";
            txt_inputPrice.Size = new Size(225, 27);
            txt_inputPrice.TabIndex = 8;
            // 
            // lbl_inputQtd
            // 
            lbl_inputQtd.AutoSize = true;
            lbl_inputQtd.Location = new Point(486, 21);
            lbl_inputQtd.Name = "lbl_inputQtd";
            lbl_inputQtd.Size = new Size(87, 20);
            lbl_inputQtd.TabIndex = 9;
            lbl_inputQtd.Text = "Quantidade";
            // 
            // lbl_inputPrice
            // 
            lbl_inputPrice.AutoSize = true;
            lbl_inputPrice.Location = new Point(486, 85);
            lbl_inputPrice.Name = "lbl_inputPrice";
            lbl_inputPrice.Size = new Size(46, 20);
            lbl_inputPrice.TabIndex = 10;
            lbl_inputPrice.Text = "Preço";
            // 
            // Frm_inventory_input
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 510);
            Controls.Add(tabControl1);
            Controls.Add(btn_saveProduct);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_inventory_input";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimentação entrada";
            Load += Frm_inventory_input_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpBoxSupplier.ResumeLayout(false);
            grpBoxSupplier.PerformLayout();
            grpBoxDocument.ResumeLayout(false);
            grpBoxDocument.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd_productToSave).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_saveProduct;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox grpBoxSupplier;
        private Label lbl_supplierName;
        private TextBox txt_supplierName;
        private Button btn_searchSupplier;
        private Label lbl_supplierCnpj;
        private TextBox txt_supplierCnpj;
        private GroupBox grpBoxDocument;
        private Label lbl_docIdentifier;
        private TextBox txt_docIdentifier;
        private TabPage tabPage2;
        private DataGridView grd_productToSave;
        private GroupBox groupBox3;
        private Button btn_addProductToList;
        private Label lbl_productName;
        private TextBox txt_productName;
        private Button btn_searchProduct;
        private Label lbl_productId;
        private TextBox txt_productId;
        private Label lbl_inputPrice;
        private Label lbl_inputQtd;
        private TextBox txt_inputPrice;
        private TextBox txt_inputQtd;
    }
}