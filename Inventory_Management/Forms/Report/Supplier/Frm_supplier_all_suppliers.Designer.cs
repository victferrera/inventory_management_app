namespace Inventory_Management.Forms.Report.Supplier
{
    partial class Frm_supplier_all_suppliers
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
            grid_suppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid_suppliers).BeginInit();
            SuspendLayout();
            // 
            // grid_suppliers
            // 
            grid_suppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_suppliers.Location = new Point(12, 12);
            grid_suppliers.Name = "grid_suppliers";
            grid_suppliers.RowHeadersWidth = 51;
            grid_suppliers.Size = new Size(776, 426);
            grid_suppliers.TabIndex = 0;
            // 
            // Frm_supplier_all_suppliers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grid_suppliers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Frm_supplier_all_suppliers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)grid_suppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grid_suppliers;
    }
}