namespace Yapılacaklar_Listesi
{
    partial class yapilacaklarlistesi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yapilacaklarlistesi));
            this.grvlistbox = new System.Windows.Forms.ListBox();
            this.grvmtntxt = new System.Windows.Forms.TextBox();
            this.chckbx = new System.Windows.Forms.CheckBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.trhsec = new System.Windows.Forms.DateTimePicker();
            this.btnsil = new System.Windows.Forms.Button();
            this.btntmnsil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grvlistbox
            // 
            this.grvlistbox.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvlistbox.FormattingEnabled = true;
            this.grvlistbox.HorizontalScrollbar = true;
            this.grvlistbox.ItemHeight = 24;
            this.grvlistbox.Location = new System.Drawing.Point(52, 109);
            this.grvlistbox.Name = "grvlistbox";
            this.grvlistbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.grvlistbox.Size = new System.Drawing.Size(607, 244);
            this.grvlistbox.TabIndex = 0;
            this.grvlistbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.grvlistbox_DrawItem);
            this.grvlistbox.SelectedIndexChanged += new System.EventHandler(this.grvlistbox_SelectedIndexChanged);
            // 
            // grvmtntxt
            // 
            this.grvmtntxt.Location = new System.Drawing.Point(52, 81);
            this.grvmtntxt.Name = "grvmtntxt";
            this.grvmtntxt.Size = new System.Drawing.Size(170, 22);
            this.grvmtntxt.TabIndex = 1;
            this.grvmtntxt.TextChanged += new System.EventHandler(this.grvmtntxt_TextChanged);
            this.grvmtntxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grvmtntxt_KeyDown);
            this.grvmtntxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grvmtntxt_KeyPress);
            // 
            // chckbx
            // 
            this.chckbx.AutoSize = true;
            this.chckbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckbx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chckbx.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckbx.Location = new System.Drawing.Point(52, 359);
            this.chckbx.Name = "chckbx";
            this.chckbx.Size = new System.Drawing.Size(129, 25);
            this.chckbx.TabIndex = 2;
            this.chckbx.Text = "Tamamlandı";
            this.chckbx.UseVisualStyleBackColor = true;
            this.chckbx.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Gray;
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnekle.Location = new System.Drawing.Point(682, 109);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(91, 58);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // trhsec
            // 
            this.trhsec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trhsec.Location = new System.Drawing.Point(444, 81);
            this.trhsec.Name = "trhsec";
            this.trhsec.Size = new System.Drawing.Size(171, 22);
            this.trhsec.TabIndex = 4;
            this.trhsec.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DarkGray;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.Location = new System.Drawing.Point(682, 173);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(91, 58);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btntmnsil
            // 
            this.btntmnsil.BackColor = System.Drawing.Color.Red;
            this.btntmnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntmnsil.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntmnsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntmnsil.Location = new System.Drawing.Point(682, 237);
            this.btntmnsil.Name = "btntmnsil";
            this.btntmnsil.Size = new System.Drawing.Size(91, 58);
            this.btntmnsil.TabIndex = 6;
            this.btntmnsil.Text = "Tümünü Sil";
            this.btntmnsil.UseVisualStyleBackColor = false;
            this.btntmnsil.Click += new System.EventHandler(this.btntmnsil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Okul",
            "İş",
            "Ev",
            "Spor",
            "Tatil"});
            this.comboBox1.Location = new System.Drawing.Point(307, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lbltur
            // 
            this.lbltur.AutoSize = true;
            this.lbltur.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltur.Location = new System.Drawing.Point(303, 52);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(96, 24);
            this.lbltur.TabIndex = 8;
            this.lbltur.Text = "Tür Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tarih Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Görevi Yazın";
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.DarkRed;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncikis.Location = new System.Drawing.Point(712, 344);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(91, 58);
            this.btncikis.TabIndex = 11;
            this.btncikis.Text = "Çık";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // yapilacaklarlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltur);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btntmnsil);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.trhsec);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.chckbx);
            this.Controls.Add(this.grvmtntxt);
            this.Controls.Add(this.grvlistbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "yapilacaklarlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yapılacaklar";
            this.Load += new System.EventHandler(this.yapilacaklarlistesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox grvlistbox;
        private System.Windows.Forms.TextBox grvmtntxt;
        private System.Windows.Forms.CheckBox chckbx;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DateTimePicker trhsec;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btntmnsil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncikis;
    }
}

