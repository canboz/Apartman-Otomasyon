namespace Apartman_Otomasyon
{
    partial class Gelirler
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
            this.lbl_daireno = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.cmb_daire_no = new System.Windows.Forms.ComboBox();
            this.numericUpDown_tutar = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tutar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_daireno
            // 
            this.lbl_daireno.AutoSize = true;
            this.lbl_daireno.Location = new System.Drawing.Point(27, 38);
            this.lbl_daireno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_daireno.Name = "lbl_daireno";
            this.lbl_daireno.Size = new System.Drawing.Size(75, 20);
            this.lbl_daireno.TabIndex = 0;
            this.lbl_daireno.Text = "Daire No:";
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(27, 109);
            this.lbl_tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(50, 20);
            this.lbl_tutar.TabIndex = 1;
            this.lbl_tutar.Text = "Tutar:";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(276, 38);
            this.lbl_tarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(48, 20);
            this.lbl_tarih.TabIndex = 2;
            this.lbl_tarih.Text = "Tarih:";
            // 
            // cmb_daire_no
            // 
            this.cmb_daire_no.FormattingEnabled = true;
            this.cmb_daire_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_daire_no.Location = new System.Drawing.Point(102, 38);
            this.cmb_daire_no.Name = "cmb_daire_no";
            this.cmb_daire_no.Size = new System.Drawing.Size(147, 28);
            this.cmb_daire_no.TabIndex = 3;
            // 
            // numericUpDown_tutar
            // 
            this.numericUpDown_tutar.Location = new System.Drawing.Point(102, 107);
            this.numericUpDown_tutar.Name = "numericUpDown_tutar";
            this.numericUpDown_tutar.Size = new System.Drawing.Size(154, 26);
            this.numericUpDown_tutar.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_daireno);
            this.groupBox1.Controls.Add(this.lbl_tutar);
            this.groupBox1.Controls.Add(this.numericUpDown_tutar);
            this.groupBox1.Controls.Add(this.lbl_tarih);
            this.groupBox1.Controls.Add(this.cmb_daire_no);
            this.groupBox1.Location = new System.Drawing.Point(111, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelirler";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(111, 250);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 224);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(330, 250);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 224);
            this.listBox2.TabIndex = 9;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(545, 250);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(162, 224);
            this.listBox3.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Gelirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 536);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Gelirler";
            this.Text = "Gelirler";
            this.Load += new System.EventHandler(this.Gelirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tutar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_daireno;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.ComboBox cmb_daire_no;
        private System.Windows.Forms.NumericUpDown numericUpDown_tutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}