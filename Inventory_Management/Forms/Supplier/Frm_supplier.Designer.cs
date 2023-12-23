namespace Forms.Suppliers
{
    partial class Frm_supplier
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
            txt_supplierCnpj = new TextBox();
            lbl_supplierCnpj = new Label();
            lbl_supplierName = new Label();
            txt_supplierName = new TextBox();
            grp_supplierInfo = new GroupBox();
            label1 = new Label();
            txt_supplierHouseNumber = new TextBox();
            Frm_supplier_SearchZipCodeBtn = new Button();
            lbl_supplierPhone2 = new Label();
            txt_supplierPhone2 = new TextBox();
            lbl_supplierPhone1 = new Label();
            txt_supplierPhone1 = new TextBox();
            lbl_supplierEmail = new Label();
            txt_supplierEmail = new TextBox();
            cmb_supplierUf = new ComboBox();
            lbl_supplierUf = new Label();
            lbl_supplierCity = new Label();
            txt_supplierCity = new TextBox();
            lbl_supplierBairro = new Label();
            txt_supplierBairro = new TextBox();
            lbl_supplierStreet = new Label();
            txt_supplierStreet = new TextBox();
            lbl_supplierZipCode = new Label();
            txt_supplierZipCode = new TextBox();
            Frm_supplier_saveBtn = new Button();
            chk_supplierStatus = new CheckBox();
            Frm_supplier_search = new Button();
            grp_supplierInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txt_supplierCnpj
            // 
            txt_supplierCnpj.Location = new Point(12, 43);
            txt_supplierCnpj.Name = "txt_supplierCnpj";
            txt_supplierCnpj.Size = new Size(291, 27);
            txt_supplierCnpj.TabIndex = 0;
            txt_supplierCnpj.Leave += txt_supplierCnpj_Leave;
            // 
            // lbl_supplierCnpj
            // 
            lbl_supplierCnpj.AutoSize = true;
            lbl_supplierCnpj.Location = new Point(12, 20);
            lbl_supplierCnpj.Name = "lbl_supplierCnpj";
            lbl_supplierCnpj.Size = new Size(41, 20);
            lbl_supplierCnpj.TabIndex = 1;
            lbl_supplierCnpj.Text = "CNPJ";
            // 
            // lbl_supplierName
            // 
            lbl_supplierName.AutoSize = true;
            lbl_supplierName.Location = new Point(12, 77);
            lbl_supplierName.Name = "lbl_supplierName";
            lbl_supplierName.Size = new Size(50, 20);
            lbl_supplierName.TabIndex = 3;
            lbl_supplierName.Text = "Nome";
            // 
            // txt_supplierName
            // 
            txt_supplierName.Location = new Point(12, 100);
            txt_supplierName.Name = "txt_supplierName";
            txt_supplierName.Size = new Size(291, 27);
            txt_supplierName.TabIndex = 2;
            // 
            // grp_supplierInfo
            // 
            grp_supplierInfo.Controls.Add(label1);
            grp_supplierInfo.Controls.Add(txt_supplierHouseNumber);
            grp_supplierInfo.Controls.Add(Frm_supplier_SearchZipCodeBtn);
            grp_supplierInfo.Controls.Add(lbl_supplierPhone2);
            grp_supplierInfo.Controls.Add(txt_supplierPhone2);
            grp_supplierInfo.Controls.Add(lbl_supplierPhone1);
            grp_supplierInfo.Controls.Add(txt_supplierPhone1);
            grp_supplierInfo.Controls.Add(lbl_supplierEmail);
            grp_supplierInfo.Controls.Add(txt_supplierEmail);
            grp_supplierInfo.Controls.Add(cmb_supplierUf);
            grp_supplierInfo.Controls.Add(lbl_supplierUf);
            grp_supplierInfo.Controls.Add(lbl_supplierCity);
            grp_supplierInfo.Controls.Add(txt_supplierCity);
            grp_supplierInfo.Controls.Add(lbl_supplierBairro);
            grp_supplierInfo.Controls.Add(txt_supplierBairro);
            grp_supplierInfo.Controls.Add(lbl_supplierStreet);
            grp_supplierInfo.Controls.Add(txt_supplierStreet);
            grp_supplierInfo.Controls.Add(lbl_supplierZipCode);
            grp_supplierInfo.Controls.Add(txt_supplierZipCode);
            grp_supplierInfo.Location = new Point(12, 190);
            grp_supplierInfo.Name = "grp_supplierInfo";
            grp_supplierInfo.Size = new Size(746, 425);
            grp_supplierInfo.TabIndex = 4;
            grp_supplierInfo.TabStop = false;
            grp_supplierInfo.Text = "Endereço e Contato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 103);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 22;
            label1.Text = "Numero";
            // 
            // txt_supplierHouseNumber
            // 
            txt_supplierHouseNumber.Location = new Point(6, 126);
            txt_supplierHouseNumber.Name = "txt_supplierHouseNumber";
            txt_supplierHouseNumber.Size = new Size(291, 27);
            txt_supplierHouseNumber.TabIndex = 21;
            // 
            // Frm_supplier_SearchZipCodeBtn
            // 
            Frm_supplier_SearchZipCodeBtn.Location = new Point(150, 56);
            Frm_supplier_SearchZipCodeBtn.Name = "Frm_supplier_SearchZipCodeBtn";
            Frm_supplier_SearchZipCodeBtn.Size = new Size(94, 29);
            Frm_supplier_SearchZipCodeBtn.TabIndex = 20;
            Frm_supplier_SearchZipCodeBtn.Text = "Buscar";
            Frm_supplier_SearchZipCodeBtn.UseVisualStyleBackColor = true;
            Frm_supplier_SearchZipCodeBtn.Click += Frm_supplier_SearchZipCodeBtn_Click;
            // 
            // lbl_supplierPhone2
            // 
            lbl_supplierPhone2.AutoSize = true;
            lbl_supplierPhone2.Location = new Point(449, 234);
            lbl_supplierPhone2.Name = "lbl_supplierPhone2";
            lbl_supplierPhone2.Size = new Size(66, 20);
            lbl_supplierPhone2.TabIndex = 19;
            lbl_supplierPhone2.Text = "Telefone";
            // 
            // txt_supplierPhone2
            // 
            txt_supplierPhone2.Location = new Point(449, 257);
            txt_supplierPhone2.Name = "txt_supplierPhone2";
            txt_supplierPhone2.Size = new Size(291, 27);
            txt_supplierPhone2.TabIndex = 18;
            // 
            // lbl_supplierPhone1
            // 
            lbl_supplierPhone1.AutoSize = true;
            lbl_supplierPhone1.Location = new Point(449, 171);
            lbl_supplierPhone1.Name = "lbl_supplierPhone1";
            lbl_supplierPhone1.Size = new Size(66, 20);
            lbl_supplierPhone1.TabIndex = 17;
            lbl_supplierPhone1.Text = "Telefone";
            // 
            // txt_supplierPhone1
            // 
            txt_supplierPhone1.Location = new Point(449, 194);
            txt_supplierPhone1.Name = "txt_supplierPhone1";
            txt_supplierPhone1.Size = new Size(291, 27);
            txt_supplierPhone1.TabIndex = 16;
            // 
            // lbl_supplierEmail
            // 
            lbl_supplierEmail.AutoSize = true;
            lbl_supplierEmail.Location = new Point(449, 103);
            lbl_supplierEmail.Name = "lbl_supplierEmail";
            lbl_supplierEmail.Size = new Size(46, 20);
            lbl_supplierEmail.TabIndex = 15;
            lbl_supplierEmail.Text = "Email";
            // 
            // txt_supplierEmail
            // 
            txt_supplierEmail.Location = new Point(449, 126);
            txt_supplierEmail.Name = "txt_supplierEmail";
            txt_supplierEmail.Size = new Size(291, 27);
            txt_supplierEmail.TabIndex = 14;
            // 
            // cmb_supplierUf
            // 
            cmb_supplierUf.FormattingEnabled = true;
            cmb_supplierUf.Location = new Point(6, 386);
            cmb_supplierUf.Name = "cmb_supplierUf";
            cmb_supplierUf.Size = new Size(151, 28);
            cmb_supplierUf.TabIndex = 13;
            // 
            // lbl_supplierUf
            // 
            lbl_supplierUf.AutoSize = true;
            lbl_supplierUf.Location = new Point(6, 363);
            lbl_supplierUf.Name = "lbl_supplierUf";
            lbl_supplierUf.Size = new Size(26, 20);
            lbl_supplierUf.TabIndex = 12;
            lbl_supplierUf.Text = "UF";
            // 
            // lbl_supplierCity
            // 
            lbl_supplierCity.AutoSize = true;
            lbl_supplierCity.Location = new Point(6, 301);
            lbl_supplierCity.Name = "lbl_supplierCity";
            lbl_supplierCity.Size = new Size(56, 20);
            lbl_supplierCity.TabIndex = 11;
            lbl_supplierCity.Text = "Cidade";
            // 
            // txt_supplierCity
            // 
            txt_supplierCity.Location = new Point(6, 324);
            txt_supplierCity.Name = "txt_supplierCity";
            txt_supplierCity.Size = new Size(291, 27);
            txt_supplierCity.TabIndex = 10;
            // 
            // lbl_supplierBairro
            // 
            lbl_supplierBairro.AutoSize = true;
            lbl_supplierBairro.Location = new Point(6, 234);
            lbl_supplierBairro.Name = "lbl_supplierBairro";
            lbl_supplierBairro.Size = new Size(49, 20);
            lbl_supplierBairro.TabIndex = 9;
            lbl_supplierBairro.Text = "Bairro";
            // 
            // txt_supplierBairro
            // 
            txt_supplierBairro.Location = new Point(6, 257);
            txt_supplierBairro.Name = "txt_supplierBairro";
            txt_supplierBairro.Size = new Size(291, 27);
            txt_supplierBairro.TabIndex = 8;
            // 
            // lbl_supplierStreet
            // 
            lbl_supplierStreet.AutoSize = true;
            lbl_supplierStreet.Location = new Point(6, 171);
            lbl_supplierStreet.Name = "lbl_supplierStreet";
            lbl_supplierStreet.Size = new Size(34, 20);
            lbl_supplierStreet.TabIndex = 7;
            lbl_supplierStreet.Text = "Rua";
            // 
            // txt_supplierStreet
            // 
            txt_supplierStreet.Location = new Point(6, 194);
            txt_supplierStreet.Name = "txt_supplierStreet";
            txt_supplierStreet.Size = new Size(291, 27);
            txt_supplierStreet.TabIndex = 6;
            // 
            // lbl_supplierZipCode
            // 
            lbl_supplierZipCode.AutoSize = true;
            lbl_supplierZipCode.Location = new Point(6, 35);
            lbl_supplierZipCode.Name = "lbl_supplierZipCode";
            lbl_supplierZipCode.Size = new Size(34, 20);
            lbl_supplierZipCode.TabIndex = 5;
            lbl_supplierZipCode.Text = "CEP";
            // 
            // txt_supplierZipCode
            // 
            txt_supplierZipCode.Location = new Point(6, 58);
            txt_supplierZipCode.Name = "txt_supplierZipCode";
            txt_supplierZipCode.Size = new Size(138, 27);
            txt_supplierZipCode.TabIndex = 4;
            // 
            // Frm_supplier_saveBtn
            // 
            Frm_supplier_saveBtn.Location = new Point(664, 658);
            Frm_supplier_saveBtn.Name = "Frm_supplier_saveBtn";
            Frm_supplier_saveBtn.Size = new Size(94, 29);
            Frm_supplier_saveBtn.TabIndex = 5;
            Frm_supplier_saveBtn.Text = "Salvar";
            Frm_supplier_saveBtn.UseVisualStyleBackColor = true;
            Frm_supplier_saveBtn.Click += Frm_supplier_saveBtn_Click;
            // 
            // chk_supplierStatus
            // 
            chk_supplierStatus.AutoSize = true;
            chk_supplierStatus.Location = new Point(12, 147);
            chk_supplierStatus.Name = "chk_supplierStatus";
            chk_supplierStatus.Size = new Size(66, 24);
            chk_supplierStatus.TabIndex = 7;
            chk_supplierStatus.Text = "Ativo";
            chk_supplierStatus.UseVisualStyleBackColor = true;
            // 
            // Frm_supplier_search
            // 
            Frm_supplier_search.Location = new Point(309, 42);
            Frm_supplier_search.Name = "Frm_supplier_search";
            Frm_supplier_search.Size = new Size(94, 29);
            Frm_supplier_search.TabIndex = 8;
            Frm_supplier_search.Text = "Buscar";
            Frm_supplier_search.UseVisualStyleBackColor = true;
            // 
            // Frm_supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 699);
            Controls.Add(Frm_supplier_search);
            Controls.Add(chk_supplierStatus);
            Controls.Add(Frm_supplier_saveBtn);
            Controls.Add(grp_supplierInfo);
            Controls.Add(lbl_supplierName);
            Controls.Add(txt_supplierName);
            Controls.Add(lbl_supplierCnpj);
            Controls.Add(txt_supplierCnpj);
            Name = "Frm_supplier";
            Text = "Fornecedor";
            Load += Frm_supplier_Load;
            grp_supplierInfo.ResumeLayout(false);
            grp_supplierInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_supplierCnpj;
        private Label lbl_supplierCnpj;
        private Label lbl_supplierName;
        private TextBox txt_supplierName;
        private GroupBox grp_supplierInfo;
        private Button Frm_supplier_saveBtn;
        private CheckBox chk_supplierStatus;
        private Label lbl_supplierCity;
        private TextBox txt_supplierCity;
        private Label lbl_supplierBairro;
        private TextBox txt_supplierBairro;
        private Label lbl_supplierStreet;
        private TextBox txt_supplierStreet;
        private Label lbl_supplierZipCode;
        private TextBox txt_supplierZipCode;
        private ComboBox cmb_supplierUf;
        private Label lbl_supplierUf;
        private Label lbl_supplierPhone2;
        private TextBox txt_supplierPhone2;
        private Label lbl_supplierPhone1;
        private TextBox txt_supplierPhone1;
        private Label lbl_supplierEmail;
        private TextBox txt_supplierEmail;
        private Button Frm_supplier_search;
        private Button Frm_supplier_SearchZipCodeBtn;
        private Label label1;
        private TextBox txt_supplierHouseNumber;
    }
}