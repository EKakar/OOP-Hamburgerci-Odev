namespace OOP_Hamburgerci_Odev
{
    partial class extraMalzeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExtraMalzeme = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtMenüAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExtraMalzeme);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtMenüAdı);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Malzeme Bilgileri";
            // 
            // btnExtraMalzeme
            // 
            this.btnExtraMalzeme.Location = new System.Drawing.Point(148, 150);
            this.btnExtraMalzeme.Name = "btnExtraMalzeme";
            this.btnExtraMalzeme.Size = new System.Drawing.Size(256, 49);
            this.btnExtraMalzeme.TabIndex = 4;
            this.btnExtraMalzeme.Text = "Extra Malzeme Kaydet";
            this.btnExtraMalzeme.UseVisualStyleBackColor = true;
            this.btnExtraMalzeme.Click += new System.EventHandler(this.btnExtraMalzeme_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(148, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(256, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // txtMenüAdı
            // 
            this.txtMenüAdı.Location = new System.Drawing.Point(148, 32);
            this.txtMenüAdı.Name = "txtMenüAdı";
            this.txtMenüAdı.Size = new System.Drawing.Size(256, 22);
            this.txtMenüAdı.TabIndex = 2;
            this.txtMenüAdı.TextChanged += new System.EventHandler(this.txtMenüAdı_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extra Malzeme Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat : ";
            // 
            // extraMalzeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 247);
            this.Controls.Add(this.groupBox1);
            this.Name = "extraMalzeme";
            this.Text = "Extra Malzeme Ekle";
            this.Load += new System.EventHandler(this.extraMalzeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExtraMalzeme;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtMenüAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}