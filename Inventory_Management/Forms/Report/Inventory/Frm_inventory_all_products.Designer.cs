namespace Forms.Inventory.Reports
{
    partial class Frm_inventory_all_products
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
            grid_produtos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_produtos).BeginInit();
            SuspendLayout();
            // 
            // grid_produtos
            // 
            grid_produtos.AllowUserToDeleteRows = false;
            grid_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_produtos.Location = new Point(12, 44);
            grid_produtos.Name = "grid_produtos";
            grid_produtos.ReadOnly = true;
            grid_produtos.RowHeadersWidth = 51;
            grid_produtos.Size = new Size(776, 394);
            grid_produtos.TabIndex = 0;
            // 
            // Frm_inventory_all_products
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grid_produtos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_inventory_all_products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatório Estoque";
            ((System.ComponentModel.ISupportInitialize)grid_produtos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_produtos;
    }
}