namespace Bancomat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pin_num = new System.Windows.Forms.TextBox();
            this.mesaj = new System.Windows.Forms.TextBox();
            this.pos_pin = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mesaj_confirm_d = new System.Windows.Forms.TextBox();
            this.mesaj_eroare_d = new System.Windows.Forms.TextBox();
            this.cont_iban = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.suma_dep = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.valuta = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mesaj_confirm_r = new System.Windows.Forms.TextBox();
            this.mesaj_fondi = new System.Windows.Forms.TextBox();
            this.mesaj_eroare_r = new System.Windows.Forms.TextBox();
            this.suma_ret = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.sumfix_ret = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sum_tot = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pin_num);
            this.panel1.Controls.Add(this.mesaj);
            this.panel1.Controls.Add(this.pos_pin);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 650);
            this.panel1.TabIndex = 0;
            // 
            // pin_num
            // 
            this.pin_num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pin_num.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pin_num.Location = new System.Drawing.Point(94, 153);
            this.pin_num.MaxLength = 3;
            this.pin_num.Name = "pin_num";
            this.pin_num.ShortcutsEnabled = false;
            this.pin_num.Size = new System.Drawing.Size(276, 43);
            this.pin_num.TabIndex = 19;
            this.pin_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mesaj
            // 
            this.mesaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj.ForeColor = System.Drawing.Color.Red;
            this.mesaj.Location = new System.Drawing.Point(177, 279);
            this.mesaj.Name = "mesaj";
            this.mesaj.ReadOnly = true;
            this.mesaj.Size = new System.Drawing.Size(100, 15);
            this.mesaj.TabIndex = 18;
            this.mesaj.Text = "PIN invalid";
            this.mesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pos_pin
            // 
            this.pos_pin.FormattingEnabled = true;
            this.pos_pin.ItemHeight = 16;
            this.pos_pin.Items.AddRange(new object[] {
            "1234",
            "9367",
            "6298",
            "1526",
            "4729",
            "4920",
            "4526",
            "5761",
            "1008",
            "3229",
            "2287",
            "3324"});
            this.pos_pin.Location = new System.Drawing.Point(479, 346);
            this.pos_pin.Margin = new System.Windows.Forms.Padding(4);
            this.pos_pin.Name = "pos_pin";
            this.pos_pin.Size = new System.Drawing.Size(67, 116);
            this.pos_pin.TabIndex = 17;
            this.pos_pin.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(48, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 32);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Introduceți codul PIN:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(428, 239);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(202, 36);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sold curent";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(428, 182);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(173, 36);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Retrageri";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(428, 124);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 36);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Depuneri";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(299, 560);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(91, 60);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(64, 560);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(91, 60);
            this.button11.TabIndex = 11;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(180, 560);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(91, 60);
            this.button10.TabIndex = 10;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(299, 480);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 60);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(180, 480);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 60);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(64, 480);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 60);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(299, 402);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 60);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(180, 402);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 60);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(64, 402);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 60);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(299, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 60);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(180, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 60);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(64, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 60);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(43, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(373, 274);
            this.Label1.TabIndex = 0;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(656, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 629);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.mesaj_confirm_d);
            this.tabPage1.Controls.Add(this.mesaj_eroare_d);
            this.tabPage1.Controls.Add(this.cont_iban);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.suma_dep);
            this.tabPage1.Controls.Add(this.cont);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.valuta);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(672, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Depuneri";
            // 
            // mesaj_confirm_d
            // 
            this.mesaj_confirm_d.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mesaj_confirm_d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj_confirm_d.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaj_confirm_d.ForeColor = System.Drawing.Color.White;
            this.mesaj_confirm_d.Location = new System.Drawing.Point(217, 47);
            this.mesaj_confirm_d.Name = "mesaj_confirm_d";
            this.mesaj_confirm_d.ReadOnly = true;
            this.mesaj_confirm_d.Size = new System.Drawing.Size(298, 20);
            this.mesaj_confirm_d.TabIndex = 11;
            this.mesaj_confirm_d.Text = "TRANZACȚIE  ACCEPTATĂ";
            this.mesaj_confirm_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesaj_confirm_d.Visible = false;
            // 
            // mesaj_eroare_d
            // 
            this.mesaj_eroare_d.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mesaj_eroare_d.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj_eroare_d.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaj_eroare_d.ForeColor = System.Drawing.Color.Red;
            this.mesaj_eroare_d.Location = new System.Drawing.Point(304, 47);
            this.mesaj_eroare_d.Name = "mesaj_eroare_d";
            this.mesaj_eroare_d.ReadOnly = true;
            this.mesaj_eroare_d.Size = new System.Drawing.Size(100, 20);
            this.mesaj_eroare_d.TabIndex = 10;
            this.mesaj_eroare_d.Text = "INVALID";
            this.mesaj_eroare_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesaj_eroare_d.Visible = false;
            // 
            // cont_iban
            // 
            this.cont_iban.Enabled = false;
            this.cont_iban.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cont_iban.Location = new System.Drawing.Point(373, 309);
            this.cont_iban.Name = "cont_iban";
            this.cont_iban.Size = new System.Drawing.Size(267, 50);
            this.cont_iban.TabIndex = 9;
            this.cont_iban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cont_iban_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(46, 309);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(291, 50);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "IBAN:";
            // 
            // suma_dep
            // 
            this.suma_dep.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suma_dep.Location = new System.Drawing.Point(373, 448);
            this.suma_dep.Name = "suma_dep";
            this.suma_dep.Size = new System.Drawing.Size(267, 50);
            this.suma_dep.TabIndex = 7;
            this.suma_dep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suma_dep_KeyPress);
            // 
            // cont
            // 
            this.cont.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.FormattingEnabled = true;
            this.cont.Items.AddRange(new object[] {
            "cont personal",
            "alt cont"});
            this.cont.Location = new System.Drawing.Point(373, 223);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(267, 51);
            this.cont.TabIndex = 5;
            this.cont.SelectedIndexChanged += new System.EventHandler(this.cont_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(46, 453);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(291, 45);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Introduceți suma:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(46, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(291, 50);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Alegeți contul:";
            // 
            // valuta
            // 
            this.valuta.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuta.FormattingEnabled = true;
            this.valuta.Items.AddRange(new object[] {
            "RON",
            "USD",
            "EUR"});
            this.valuta.Location = new System.Drawing.Point(373, 101);
            this.valuta.Name = "valuta";
            this.valuta.Size = new System.Drawing.Size(267, 51);
            this.valuta.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(46, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(291, 50);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Alegeți valuta:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.mesaj_confirm_r);
            this.tabPage2.Controls.Add(this.mesaj_fondi);
            this.tabPage2.Controls.Add(this.mesaj_eroare_r);
            this.tabPage2.Controls.Add(this.suma_ret);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.sumfix_ret);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(672, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Retrageri";
            // 
            // mesaj_confirm_r
            // 
            this.mesaj_confirm_r.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mesaj_confirm_r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj_confirm_r.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaj_confirm_r.ForeColor = System.Drawing.Color.White;
            this.mesaj_confirm_r.Location = new System.Drawing.Point(215, 72);
            this.mesaj_confirm_r.Name = "mesaj_confirm_r";
            this.mesaj_confirm_r.ReadOnly = true;
            this.mesaj_confirm_r.Size = new System.Drawing.Size(285, 20);
            this.mesaj_confirm_r.TabIndex = 6;
            this.mesaj_confirm_r.Text = "TRANZACȚIE  ACCEPTATĂ";
            this.mesaj_confirm_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesaj_confirm_r.Visible = false;
            // 
            // mesaj_fondi
            // 
            this.mesaj_fondi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mesaj_fondi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj_fondi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaj_fondi.ForeColor = System.Drawing.Color.Red;
            this.mesaj_fondi.Location = new System.Drawing.Point(220, 72);
            this.mesaj_fondi.Name = "mesaj_fondi";
            this.mesaj_fondi.ReadOnly = true;
            this.mesaj_fondi.Size = new System.Drawing.Size(280, 20);
            this.mesaj_fondi.TabIndex = 5;
            this.mesaj_fondi.Text = "FONDURI INSUFICIENTE";
            this.mesaj_fondi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesaj_fondi.Visible = false;
            // 
            // mesaj_eroare_r
            // 
            this.mesaj_eroare_r.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mesaj_eroare_r.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mesaj_eroare_r.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mesaj_eroare_r.ForeColor = System.Drawing.Color.Red;
            this.mesaj_eroare_r.Location = new System.Drawing.Point(301, 72);
            this.mesaj_eroare_r.Name = "mesaj_eroare_r";
            this.mesaj_eroare_r.ReadOnly = true;
            this.mesaj_eroare_r.Size = new System.Drawing.Size(100, 20);
            this.mesaj_eroare_r.TabIndex = 4;
            this.mesaj_eroare_r.Text = "INVALID";
            this.mesaj_eroare_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesaj_eroare_r.Visible = false;
            // 
            // suma_ret
            // 
            this.suma_ret.Enabled = false;
            this.suma_ret.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.suma_ret.Location = new System.Drawing.Point(378, 304);
            this.suma_ret.Name = "suma_ret";
            this.suma_ret.Size = new System.Drawing.Size(267, 50);
            this.suma_ret.TabIndex = 3;
            this.suma_ret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suma_ret_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(43, 309);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(305, 45);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "Introduceți suma:";
            // 
            // sumfix_ret
            // 
            this.sumfix_ret.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumfix_ret.FormattingEnabled = true;
            this.sumfix_ret.Items.AddRange(new object[] {
            "10",
            "50",
            "100",
            "200",
            "500",
            "altă sumă"});
            this.sumfix_ret.Location = new System.Drawing.Point(378, 184);
            this.sumfix_ret.Name = "sumfix_ret";
            this.sumfix_ret.Size = new System.Drawing.Size(267, 50);
            this.sumfix_ret.TabIndex = 1;
            this.sumfix_ret.SelectedIndexChanged += new System.EventHandler(this.sumfix_ret_SelectedIndexChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Georgia", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(43, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(305, 50);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Alegeți suma:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.sum_tot);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(672, 600);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sold curent";
            // 
            // sum_tot
            // 
            this.sum_tot.BackColor = System.Drawing.Color.White;
            this.sum_tot.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sum_tot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sum_tot.Location = new System.Drawing.Point(0, 201);
            this.sum_tot.Name = "sum_tot";
            this.sum_tot.Size = new System.Drawing.Size(672, 172);
            this.sum_tot.TabIndex = 0;
            this.sum_tot.Text = "50";
            this.sum_tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 654);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox pos_pin;
        private System.Windows.Forms.TextBox mesaj;
        private System.Windows.Forms.Label sum_tot;
        private System.Windows.Forms.ComboBox valuta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cont;
        private System.Windows.Forms.ComboBox sumfix_ret;
        private System.Windows.Forms.TextBox suma_dep;
        private System.Windows.Forms.TextBox suma_ret;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox cont_iban;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox mesaj_eroare_d;
        private System.Windows.Forms.TextBox mesaj_confirm_d;
        private System.Windows.Forms.TextBox mesaj_confirm_r;
        private System.Windows.Forms.TextBox mesaj_fondi;
        private System.Windows.Forms.TextBox mesaj_eroare_r;
        private System.Windows.Forms.TextBox pin_num;
    }
}

