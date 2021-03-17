
namespace WindowsFormsHomeWork_3
{
    partial class ShopForm
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
            this.btnEditShop = new System.Windows.Forms.Button();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.listBoxSelectedProd = new System.Windows.Forms.ListBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.lbShopName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditShop
            // 
            this.btnEditShop.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditShop.Location = new System.Drawing.Point(527, 86);
            this.btnEditShop.Name = "btnEditShop";
            this.btnEditShop.Size = new System.Drawing.Size(254, 41);
            this.btnEditShop.TabIndex = 1;
            this.btnEditShop.Text = "Editor shop";
            this.btnEditShop.UseVisualStyleBackColor = true;
            this.btnEditShop.Click += new System.EventHandler(this.btnEditShop_Click);
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(12, 76);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(198, 24);
            this.comboBoxProd.TabIndex = 2;
            this.comboBoxProd.SelectedIndexChanged += new System.EventHandler(this.comboBoxProd_SelectedIndexChanged);
            // 
            // listBoxSelectedProd
            // 
            this.listBoxSelectedProd.FormattingEnabled = true;
            this.listBoxSelectedProd.ItemHeight = 16;
            this.listBoxSelectedProd.Location = new System.Drawing.Point(242, 86);
            this.listBoxSelectedProd.Name = "listBoxSelectedProd";
            this.listBoxSelectedProd.Size = new System.Drawing.Size(214, 164);
            this.listBoxSelectedProd.TabIndex = 3;
            // 
            // labelCheck
            // 
            this.labelCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCheck.Location = new System.Drawing.Point(242, 9);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(214, 58);
            this.labelCheck.TabIndex = 4;
            this.labelCheck.Text = "Check ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(245, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 41);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPrice.Location = new System.Drawing.Point(12, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(198, 58);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price product ";
            // 
            // lbShopName
            // 
            this.lbShopName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbShopName.Font = new System.Drawing.Font("Gentium Book Basic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShopName.Location = new System.Drawing.Point(523, 9);
            this.lbShopName.Name = "lbShopName";
            this.lbShopName.Size = new System.Drawing.Size(258, 69);
            this.lbShopName.TabIndex = 7;
            this.lbShopName.Text = "ShopName";
            this.lbShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear selected product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditShop);
            this.Controls.Add(this.lbShopName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.listBoxSelectedProd);
            this.Controls.Add(this.comboBoxProd);
            this.Name = "ShopForm";
            this.Text = "EditorShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditShop;
        private System.Windows.Forms.ComboBox comboBoxProd;
        private System.Windows.Forms.ListBox listBoxSelectedProd;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label lbShopName;
        private System.Windows.Forms.Button button1;
    }
}

