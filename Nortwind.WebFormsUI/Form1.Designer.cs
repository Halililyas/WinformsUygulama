namespace Nortwind.WebFormsUI
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.gbxKatagori = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblKatagori = new System.Windows.Forms.Label();
            this.gbxIsmeArama = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.gbxUrunEkleme = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.txtUnitPrıce = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnıtStock = new System.Windows.Forms.TextBox();
            this.txtProductname2 = new System.Windows.Forms.TextBox();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lbKatagori = new System.Windows.Forms.Label();
            this.lblUrunAdı = new System.Windows.Forms.Label();
            this.gbxUpdadete = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxUpdateCatagory = new System.Windows.Forms.ComboBox();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdateStock = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbxKatagori.SuspendLayout();
            this.gbxIsmeArama.SuspendLayout();
            this.gbxUrunEkleme.SuspendLayout();
            this.gbxUpdadete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(1, 366);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 102;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.Size = new System.Drawing.Size(1894, 413);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // gbxKatagori
            // 
            this.gbxKatagori.Controls.Add(this.cbxCategory);
            this.gbxKatagori.Controls.Add(this.lblKatagori);
            this.gbxKatagori.Location = new System.Drawing.Point(12, 12);
            this.gbxKatagori.Name = "gbxKatagori";
            this.gbxKatagori.Size = new System.Drawing.Size(1844, 145);
            this.gbxKatagori.TabIndex = 1;
            this.gbxKatagori.TabStop = false;
            this.gbxKatagori.Text = "Katagoriye Göre Arma ";
            this.gbxKatagori.Enter += new System.EventHandler(this.gbxKatagori_Enter);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(203, 72);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(495, 39);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.Text = "SEÇİNİZ..";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblKatagori
            // 
            this.lblKatagori.AutoSize = true;
            this.lblKatagori.Location = new System.Drawing.Point(41, 72);
            this.lblKatagori.Name = "lblKatagori";
            this.lblKatagori.Size = new System.Drawing.Size(121, 32);
            this.lblKatagori.TabIndex = 0;
            this.lblKatagori.Text = "Katagori";
            // 
            // gbxIsmeArama
            // 
            this.gbxIsmeArama.Controls.Add(this.txtProductName);
            this.gbxIsmeArama.Controls.Add(this.lblUrun);
            this.gbxIsmeArama.Location = new System.Drawing.Point(12, 186);
            this.gbxIsmeArama.Name = "gbxIsmeArama";
            this.gbxIsmeArama.Size = new System.Drawing.Size(1844, 174);
            this.gbxIsmeArama.TabIndex = 2;
            this.gbxIsmeArama.TabStop = false;
            this.gbxIsmeArama.Text = "Isme Göre Arama ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(203, 69);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(495, 38);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(41, 75);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(146, 32);
            this.lblUrun.TabIndex = 1;
            this.lblUrun.Text = "Ürün Adı : ";
            // 
            // gbxUrunEkleme
            // 
            this.gbxUrunEkleme.Controls.Add(this.btnAdd);
            this.gbxUrunEkleme.Controls.Add(this.cbxCategoryId);
            this.gbxUrunEkleme.Controls.Add(this.txtUnitPrıce);
            this.gbxUrunEkleme.Controls.Add(this.txtQuantity);
            this.gbxUrunEkleme.Controls.Add(this.txtUnıtStock);
            this.gbxUrunEkleme.Controls.Add(this.txtProductname2);
            this.gbxUrunEkleme.Controls.Add(this.lblBirim);
            this.gbxUrunEkleme.Controls.Add(this.lblStock);
            this.gbxUrunEkleme.Controls.Add(this.lblFiyat);
            this.gbxUrunEkleme.Controls.Add(this.lbKatagori);
            this.gbxUrunEkleme.Controls.Add(this.lblUrunAdı);
            this.gbxUrunEkleme.Location = new System.Drawing.Point(1, 786);
            this.gbxUrunEkleme.Name = "gbxUrunEkleme";
            this.gbxUrunEkleme.Size = new System.Drawing.Size(1894, 394);
            this.gbxUrunEkleme.TabIndex = 3;
            this.gbxUrunEkleme.TabStop = false;
            this.gbxUrunEkleme.Text = "Ürün Ekleme";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(1070, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(326, 51);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(279, 177);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(430, 39);
            this.cbxCategoryId.TabIndex = 9;
            // 
            // txtUnitPrıce
            // 
            this.txtUnitPrıce.Location = new System.Drawing.Point(279, 292);
            this.txtUnitPrıce.Name = "txtUnitPrıce";
            this.txtUnitPrıce.Size = new System.Drawing.Size(430, 38);
            this.txtUnitPrıce.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(1070, 189);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(430, 38);
            this.txtQuantity.TabIndex = 7;
            // 
            // txtUnıtStock
            // 
            this.txtUnıtStock.Location = new System.Drawing.Point(1070, 70);
            this.txtUnıtStock.Name = "txtUnıtStock";
            this.txtUnıtStock.Size = new System.Drawing.Size(430, 38);
            this.txtUnıtStock.TabIndex = 6;
            // 
            // txtProductname2
            // 
            this.txtProductname2.Location = new System.Drawing.Point(279, 70);
            this.txtProductname2.Name = "txtProductname2";
            this.txtProductname2.Size = new System.Drawing.Size(430, 38);
            this.txtProductname2.TabIndex = 5;
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(833, 177);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(182, 32);
            this.lblBirim.TabIndex = 4;
            this.lblBirim.Text = "Birim Adedi : ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(833, 70);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(188, 32);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock Adedi : ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(118, 292);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(98, 32);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fİyat : ";
            // 
            // lbKatagori
            // 
            this.lbKatagori.AutoSize = true;
            this.lbKatagori.Location = new System.Drawing.Point(118, 177);
            this.lbKatagori.Name = "lbKatagori";
            this.lbKatagori.Size = new System.Drawing.Size(136, 32);
            this.lbKatagori.TabIndex = 1;
            this.lbKatagori.Text = "Katagori :";
            // 
            // lblUrunAdı
            // 
            this.lblUrunAdı.AutoSize = true;
            this.lblUrunAdı.Location = new System.Drawing.Point(118, 70);
            this.lblUrunAdı.Name = "lblUrunAdı";
            this.lblUrunAdı.Size = new System.Drawing.Size(146, 32);
            this.lblUrunAdı.TabIndex = 0;
            this.lblUrunAdı.Text = "Ürün Adı : ";
            // 
            // gbxUpdadete
            // 
            this.gbxUpdadete.Controls.Add(this.btnSave);
            this.gbxUpdadete.Controls.Add(this.cbxUpdateCatagory);
            this.gbxUpdadete.Controls.Add(this.txtUpdatePrice);
            this.gbxUpdadete.Controls.Add(this.txtUpdateQuantity);
            this.gbxUpdadete.Controls.Add(this.txtUpdateStock);
            this.gbxUpdadete.Controls.Add(this.txtUpdateName);
            this.gbxUpdadete.Controls.Add(this.label1);
            this.gbxUpdadete.Controls.Add(this.label2);
            this.gbxUpdadete.Controls.Add(this.label3);
            this.gbxUpdadete.Controls.Add(this.label4);
            this.gbxUpdadete.Controls.Add(this.label5);
            this.gbxUpdadete.Location = new System.Drawing.Point(1916, 52);
            this.gbxUpdadete.Name = "gbxUpdadete";
            this.gbxUpdadete.Size = new System.Drawing.Size(784, 489);
            this.gbxUpdadete.TabIndex = 11;
            this.gbxUpdadete.TabStop = false;
            this.gbxUpdadete.Text = "Ürün Güncelleme";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(326, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(326, 51);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Güncelle";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxUpdateCatagory
            // 
            this.cbxUpdateCatagory.FormattingEnabled = true;
            this.cbxUpdateCatagory.Location = new System.Drawing.Point(275, 257);
            this.cbxUpdateCatagory.Name = "cbxUpdateCatagory";
            this.cbxUpdateCatagory.Size = new System.Drawing.Size(430, 39);
            this.cbxUpdateCatagory.TabIndex = 9;
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(275, 318);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(430, 38);
            this.txtUpdatePrice.TabIndex = 8;
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(275, 199);
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(430, 38);
            this.txtUpdateQuantity.TabIndex = 7;
            // 
            // txtUpdateStock
            // 
            this.txtUpdateStock.Location = new System.Drawing.Point(275, 80);
            this.txtUpdateStock.Name = "txtUpdateStock";
            this.txtUpdateStock.Size = new System.Drawing.Size(430, 38);
            this.txtUpdateStock.TabIndex = 6;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(275, 137);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(430, 38);
            this.txtUpdateName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Adedi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fİyat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Katagori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(2258, 598);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(326, 51);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2877, 1281);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdadete);
            this.Controls.Add(this.gbxUrunEkleme);
            this.Controls.Add(this.gbxIsmeArama);
            this.Controls.Add(this.gbxKatagori);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbxKatagori.ResumeLayout(false);
            this.gbxKatagori.PerformLayout();
            this.gbxIsmeArama.ResumeLayout(false);
            this.gbxIsmeArama.PerformLayout();
            this.gbxUrunEkleme.ResumeLayout(false);
            this.gbxUrunEkleme.PerformLayout();
            this.gbxUpdadete.ResumeLayout(false);
            this.gbxUpdadete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gbxKatagori;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblKatagori;
        private System.Windows.Forms.GroupBox gbxIsmeArama;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.GroupBox gbxUrunEkleme;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lbKatagori;
        private System.Windows.Forms.Label lblUrunAdı;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox txtUnitPrıce;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnıtStock;
        private System.Windows.Forms.TextBox txtProductname2;
        private System.Windows.Forms.GroupBox gbxUpdadete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxUpdateCatagory;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.TextBox txtUpdateStock;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

