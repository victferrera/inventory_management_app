namespace Forms.Products.Edit
{
    partial class Frm_product_edit
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
            txt_edit_productId = new TextBox();
            btn_edit_searchBtn = new Button();
            grp_edit_productInfo = new GroupBox();
            frm_edit_removeBtn = new Button();
            frm_edit_saveBtn = new Button();
            lbl_edit_productDesc = new Label();
            txt_edit_desc = new TextBox();
            lbl_edit_productName = new Label();
            txt_edit_name = new TextBox();
            lbl_edit_productId = new Label();
            grp_edit_productInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txt_edit_productId
            // 
            txt_edit_productId.Location = new Point(12, 25);
            txt_edit_productId.Name = "txt_edit_productId";
            txt_edit_productId.Size = new Size(225, 27);
            txt_edit_productId.TabIndex = 0;
            // 
            // btn_edit_searchBtn
            // 
            btn_edit_searchBtn.Location = new Point(243, 23);
            btn_edit_searchBtn.Name = "btn_edit_searchBtn";
            btn_edit_searchBtn.Size = new Size(94, 29);
            btn_edit_searchBtn.TabIndex = 1;
            btn_edit_searchBtn.Text = "Buscar";
            btn_edit_searchBtn.UseVisualStyleBackColor = true;
            btn_edit_searchBtn.Click += btn_frmedit_buscar_Click;
            // 
            // grp_edit_productInfo
            // 
            grp_edit_productInfo.Controls.Add(frm_edit_removeBtn);
            grp_edit_productInfo.Controls.Add(frm_edit_saveBtn);
            grp_edit_productInfo.Controls.Add(lbl_edit_productDesc);
            grp_edit_productInfo.Controls.Add(txt_edit_desc);
            grp_edit_productInfo.Controls.Add(lbl_edit_productName);
            grp_edit_productInfo.Controls.Add(txt_edit_name);
            grp_edit_productInfo.Location = new Point(12, 58);
            grp_edit_productInfo.Name = "grp_edit_productInfo";
            grp_edit_productInfo.Size = new Size(553, 307);
            grp_edit_productInfo.TabIndex = 2;
            grp_edit_productInfo.TabStop = false;
            grp_edit_productInfo.Text = "Informações Produto";
            // 
            // frm_edit_removeBtn
            // 
            frm_edit_removeBtn.Cursor = Cursors.Hand;
            frm_edit_removeBtn.Location = new Point(137, 260);
            frm_edit_removeBtn.Name = "frm_edit_removeBtn";
            frm_edit_removeBtn.Size = new Size(94, 29);
            frm_edit_removeBtn.TabIndex = 10;
            frm_edit_removeBtn.Text = "Deletar";
            frm_edit_removeBtn.UseVisualStyleBackColor = true;
            frm_edit_removeBtn.Click += btn_frmedit_remover_Click;
            // 
            // frm_edit_saveBtn
            // 
            frm_edit_saveBtn.Cursor = Cursors.Hand;
            frm_edit_saveBtn.Location = new Point(6, 260);
            frm_edit_saveBtn.Name = "frm_edit_saveBtn";
            frm_edit_saveBtn.Size = new Size(94, 29);
            frm_edit_saveBtn.TabIndex = 9;
            frm_edit_saveBtn.Text = "Salvar";
            frm_edit_saveBtn.UseVisualStyleBackColor = true;
            frm_edit_saveBtn.Click += btn_frmedit_salvar_Click;
            // 
            // lbl_edit_productDesc
            // 
            lbl_edit_productDesc.AutoSize = true;
            lbl_edit_productDesc.Location = new Point(6, 86);
            lbl_edit_productDesc.Name = "lbl_edit_productDesc";
            lbl_edit_productDesc.Size = new Size(74, 20);
            lbl_edit_productDesc.TabIndex = 4;
            lbl_edit_productDesc.Text = "Descrição";
            // 
            // txt_edit_desc
            // 
            txt_edit_desc.Location = new Point(6, 109);
            txt_edit_desc.Name = "txt_edit_desc";
            txt_edit_desc.Size = new Size(225, 27);
            txt_edit_desc.TabIndex = 3;
            // 
            // lbl_edit_productName
            // 
            lbl_edit_productName.AutoSize = true;
            lbl_edit_productName.Location = new Point(6, 33);
            lbl_edit_productName.Name = "lbl_edit_productName";
            lbl_edit_productName.Size = new Size(50, 20);
            lbl_edit_productName.TabIndex = 2;
            lbl_edit_productName.Text = "Nome";
            // 
            // txt_edit_name
            // 
            txt_edit_name.Location = new Point(6, 56);
            txt_edit_name.Name = "txt_edit_name";
            txt_edit_name.Size = new Size(225, 27);
            txt_edit_name.TabIndex = 1;
            // 
            // lbl_edit_productId
            // 
            lbl_edit_productId.AutoSize = true;
            lbl_edit_productId.Location = new Point(12, 2);
            lbl_edit_productId.Name = "lbl_edit_productId";
            lbl_edit_productId.Size = new Size(104, 20);
            lbl_edit_productId.TabIndex = 10;
            lbl_edit_productId.Text = "ID do produto";
            // 
            // Frm_product_edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 377);
            Controls.Add(lbl_edit_productId);
            Controls.Add(grp_edit_productInfo);
            Controls.Add(btn_edit_searchBtn);
            Controls.Add(txt_edit_productId);
            Name = "Frm_product_edit";
            Text = "Editar produto";
            grp_edit_productInfo.ResumeLayout(false);
            grp_edit_productInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_edit_productId;
        private Button btn_edit_searchBtn;
        private GroupBox grp_edit_productInfo;
        private Button frm_edit_saveBtn;
        private Label lbl_edit_productDesc;
        private TextBox txt_edit_desc;
        private Label lbl_edit_productName;
        private TextBox txt_edit_name;
        private Label lbl_edit_productId;
        private Button frm_edit_removeBtn;
    }
}