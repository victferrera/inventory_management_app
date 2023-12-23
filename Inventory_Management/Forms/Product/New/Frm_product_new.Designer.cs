namespace Forms.Products.New
{
    partial class Frm_product_new
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
            txt_new_productName = new TextBox();
            lbl_new_name = new Label();
            lbl_new_desc = new Label();
            txt_new_productDesc = new TextBox();
            frm_new_saveBtn = new Button();
            frm_new_cancelBtn = new Button();
            SuspendLayout();
            // 
            // txt_new_productName
            // 
            txt_new_productName.Location = new Point(12, 35);
            txt_new_productName.Name = "txt_new_productName";
            txt_new_productName.Size = new Size(350, 27);
            txt_new_productName.TabIndex = 0;
            // 
            // lbl_new_name
            // 
            lbl_new_name.AutoSize = true;
            lbl_new_name.Location = new Point(12, 12);
            lbl_new_name.Name = "lbl_new_name";
            lbl_new_name.Size = new Size(50, 20);
            lbl_new_name.TabIndex = 1;
            lbl_new_name.Text = "Nome";
            // 
            // lbl_new_desc
            // 
            lbl_new_desc.AutoSize = true;
            lbl_new_desc.Location = new Point(12, 72);
            lbl_new_desc.Name = "lbl_new_desc";
            lbl_new_desc.Size = new Size(74, 20);
            lbl_new_desc.TabIndex = 3;
            lbl_new_desc.Text = "Descrição";
            // 
            // txt_new_productDesc
            // 
            txt_new_productDesc.Location = new Point(12, 95);
            txt_new_productDesc.Name = "txt_new_productDesc";
            txt_new_productDesc.Size = new Size(350, 27);
            txt_new_productDesc.TabIndex = 2;
            // 
            // frm_new_saveBtn
            // 
            frm_new_saveBtn.Location = new Point(12, 293);
            frm_new_saveBtn.Name = "frm_new_saveBtn";
            frm_new_saveBtn.Size = new Size(94, 29);
            frm_new_saveBtn.TabIndex = 8;
            frm_new_saveBtn.Text = "Salvar";
            frm_new_saveBtn.UseVisualStyleBackColor = true;
            frm_new_saveBtn.Click += frm_novo_btn_salvar_Click;
            // 
            // frm_new_cancelBtn
            // 
            frm_new_cancelBtn.Location = new Point(137, 293);
            frm_new_cancelBtn.Name = "frm_new_cancelBtn";
            frm_new_cancelBtn.Size = new Size(94, 29);
            frm_new_cancelBtn.TabIndex = 9;
            frm_new_cancelBtn.Text = "Cancelar";
            frm_new_cancelBtn.UseVisualStyleBackColor = true;
            frm_new_cancelBtn.Click += button2_Click;
            // 
            // Frm_product_new
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 339);
            Controls.Add(frm_new_cancelBtn);
            Controls.Add(frm_new_saveBtn);
            Controls.Add(lbl_new_desc);
            Controls.Add(txt_new_productDesc);
            Controls.Add(lbl_new_name);
            Controls.Add(txt_new_productName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_product_new";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_new_productName;
        private Label lbl_new_name;
        private Label lbl_new_desc;
        private TextBox txt_new_productDesc;
        private Button frm_new_saveBtn;
        private Button frm_new_cancelBtn;
    }
}