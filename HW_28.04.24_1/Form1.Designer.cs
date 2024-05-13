namespace HW_28._04._24_1
{
    partial class Form1
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
            this.lbxProduct = new System.Windows.Forms.ListBox();
            this.lblAllPriceProduct = new System.Windows.Forms.Label();
            this.lblNoProduct = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.tbxPriceProduct = new System.Windows.Forms.TextBox();
            this.cbxProductStock = new System.Windows.Forms.ComboBox();
            this.gbxAction = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxProduct.SuspendLayout();
            this.gbxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxProduct
            // 
            this.lbxProduct.FormattingEnabled = true;
            this.lbxProduct.ItemHeight = 16;
            this.lbxProduct.Location = new System.Drawing.Point(0, 0);
            this.lbxProduct.Name = "lbxProduct";
            this.lbxProduct.Size = new System.Drawing.Size(370, 452);
            this.lbxProduct.TabIndex = 0;
            // 
            // lblAllPriceProduct
            // 
            this.lblAllPriceProduct.AutoSize = true;
            this.lblAllPriceProduct.Location = new System.Drawing.Point(409, 30);
            this.lblAllPriceProduct.Name = "lblAllPriceProduct";
            this.lblAllPriceProduct.Size = new System.Drawing.Size(157, 16);
            this.lblAllPriceProduct.TabIndex = 1;
            this.lblAllPriceProduct.Text = "Цена товаров в списке";
            // 
            // lblNoProduct
            // 
            this.lblNoProduct.AutoSize = true;
            this.lblNoProduct.Location = new System.Drawing.Point(409, 73);
            this.lblNoProduct.Name = "lblNoProduct";
            this.lblNoProduct.Size = new System.Drawing.Size(149, 16);
            this.lblNoProduct.TabIndex = 2;
            this.lblNoProduct.Text = "Товаров в списке нет";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(656, 98);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(35, 16);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "Руб.";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.lblCurrency1);
            this.gbxProduct.Controls.Add(this.btnAddList);
            this.gbxProduct.Controls.Add(this.tbxPriceProduct);
            this.gbxProduct.Controls.Add(this.cbxProductStock);
            this.gbxProduct.Location = new System.Drawing.Point(412, 127);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(288, 126);
            this.gbxProduct.TabIndex = 4;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Товары";
            // 
            // lblCurrency1
            // 
            this.lblCurrency1.AutoSize = true;
            this.lblCurrency1.Location = new System.Drawing.Point(232, 53);
            this.lblCurrency1.Name = "lblCurrency1";
            this.lblCurrency1.Size = new System.Drawing.Size(35, 16);
            this.lblCurrency1.TabIndex = 3;
            this.lblCurrency1.Text = "Руб.";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(7, 82);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(189, 23);
            this.btnAddList.TabIndex = 2;
            this.btnAddList.Text = "Добавить в список";
            this.btnAddList.UseVisualStyleBackColor = true;
            // 
            // tbxPriceProduct
            // 
            this.tbxPriceProduct.Location = new System.Drawing.Point(7, 53);
            this.tbxPriceProduct.Name = "tbxPriceProduct";
            this.tbxPriceProduct.Size = new System.Drawing.Size(189, 22);
            this.tbxPriceProduct.TabIndex = 1;
            // 
            // cbxProductStock
            // 
            this.cbxProductStock.FormattingEnabled = true;
            this.cbxProductStock.Location = new System.Drawing.Point(7, 22);
            this.cbxProductStock.Name = "cbxProductStock";
            this.cbxProductStock.Size = new System.Drawing.Size(189, 24);
            this.cbxProductStock.TabIndex = 0;
            // 
            // gbxAction
            // 
            this.gbxAction.Controls.Add(this.btnEdit);
            this.gbxAction.Controls.Add(this.btnAdd);
            this.gbxAction.Location = new System.Drawing.Point(412, 270);
            this.gbxAction.Name = "gbxAction";
            this.gbxAction.Size = new System.Drawing.Size(288, 134);
            this.gbxAction.TabIndex = 5;
            this.gbxAction.TabStop = false;
            this.gbxAction.Text = "Действия";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(7, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(189, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Редактировать товар";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxAction);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblNoProduct);
            this.Controls.Add(this.lblAllPriceProduct);
            this.Controls.Add(this.lbxProduct);
            this.Name = "Form1";
            this.Text = "Учет продаж";
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProduct;
        private System.Windows.Forms.Label lblAllPriceProduct;
        private System.Windows.Forms.Label lblNoProduct;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.GroupBox gbxAction;
        private System.Windows.Forms.Label lblCurrency1;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.TextBox tbxPriceProduct;
        private System.Windows.Forms.ComboBox cbxProductStock;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}