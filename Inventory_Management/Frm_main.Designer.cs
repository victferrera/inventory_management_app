namespace Inventory_Management
{
    partial class Frm_main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            produtoToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            productMenu = new ToolStripMenuItem();
            productSubMenuNew = new ToolStripMenuItem();
            productSubMenuEdit = new ToolStripMenuItem();
            supplierMenu = new ToolStripMenuItem();
            supplierSubMenuNew = new ToolStripMenuItem();
            actionsMenu = new ToolStripMenuItem();
            actionsSubMenuInput = new ToolStripMenuItem();
            actionsSubMenuOutput = new ToolStripMenuItem();
            reportsMenu = new ToolStripMenuItem();
            reportsSubMenuInventory = new ToolStripMenuItem();
            reportsSubMenuSupplier = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { produtoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(132, 28);
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(131, 24);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productMenu, supplierMenu, actionsMenu, reportsMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // productMenu
            // 
            productMenu.DropDownItems.AddRange(new ToolStripItem[] { productSubMenuNew, productSubMenuEdit });
            productMenu.Name = "productMenu";
            productMenu.Size = new Size(76, 24);
            productMenu.Text = "Produto";
            // 
            // productSubMenuNew
            // 
            productSubMenuNew.Name = "productSubMenuNew";
            productSubMenuNew.Size = new Size(131, 26);
            productSubMenuNew.Text = "Novo";
            productSubMenuNew.Click += productSubMenuNew_Click;
            // 
            // productSubMenuEdit
            // 
            productSubMenuEdit.Name = "productSubMenuEdit";
            productSubMenuEdit.Size = new Size(131, 26);
            productSubMenuEdit.Text = "Editar";
            productSubMenuEdit.Click += produtoEditarToolStripMenuItem_Click;
            // 
            // supplierMenu
            // 
            supplierMenu.DropDownItems.AddRange(new ToolStripItem[] { supplierSubMenuNew });
            supplierMenu.Name = "supplierMenu";
            supplierMenu.Size = new Size(112, 24);
            supplierMenu.Text = "Fornecedores";
            // 
            // supplierSubMenuNew
            // 
            supplierSubMenuNew.Name = "supplierSubMenuNew";
            supplierSubMenuNew.Size = new Size(224, 26);
            supplierSubMenuNew.Text = "Novo";
            supplierSubMenuNew.Click += fornecedorNovoToolStripMenuItem1_Click;
            // 
            // actionsMenu
            // 
            actionsMenu.DropDownItems.AddRange(new ToolStripItem[] { actionsSubMenuInput, actionsSubMenuOutput });
            actionsMenu.Name = "actionsMenu";
            actionsMenu.Size = new Size(128, 24);
            actionsMenu.Text = "Movimentações";
            // 
            // actionsSubMenuInput
            // 
            actionsSubMenuInput.Name = "actionsSubMenuInput";
            actionsSubMenuInput.Size = new Size(143, 26);
            actionsSubMenuInput.Text = "Entrada";
            // 
            // actionsSubMenuOutput
            // 
            actionsSubMenuOutput.Name = "actionsSubMenuOutput";
            actionsSubMenuOutput.Size = new Size(143, 26);
            actionsSubMenuOutput.Text = "Saida";
            // 
            // reportsMenu
            // 
            reportsMenu.DropDownItems.AddRange(new ToolStripItem[] { reportsSubMenuInventory, reportsSubMenuSupplier });
            reportsMenu.Name = "reportsMenu";
            reportsMenu.Size = new Size(90, 24);
            reportsMenu.Text = "Relatórios";
            // 
            // reportsSubMenuInventory
            // 
            reportsSubMenuInventory.Name = "reportsSubMenuInventory";
            reportsSubMenuInventory.Size = new Size(224, 26);
            reportsSubMenuInventory.Text = "Estoque";
            reportsSubMenuInventory.Click += estoqueToolStripMenuItem_Click;
            // 
            // reportsSubMenuSupplier
            // 
            reportsSubMenuSupplier.Name = "reportsSubMenuSupplier";
            reportsSubMenuSupplier.Size = new Size(224, 26);
            reportsSubMenuSupplier.Text = "Fornecedores";
            reportsSubMenuSupplier.Click += reportsSubMenuSupplier_Click;
            // 
            // Frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Frm_main";
            Text = "Gerenciamento de Estoque";
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem produtoToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem productMenu;
        private ToolStripMenuItem supplierMenu;
        private ToolStripMenuItem actionsMenu;
        private ToolStripMenuItem reportsMenu;
        private ToolStripMenuItem supplierSubMenuNew;
        private ToolStripMenuItem actionsSubMenuInput;
        private ToolStripMenuItem actionsSubMenuOutput;
        private ToolStripMenuItem reportsSubMenuInventory;
        private ToolStripMenuItem productSubMenuEdit;
        private ToolStripMenuItem productSubMenuNew;
        private ToolStripMenuItem reportsSubMenuSupplier;
    }
}