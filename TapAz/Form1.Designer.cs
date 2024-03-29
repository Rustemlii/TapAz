namespace Tapaz
{
    partial class Form1
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            list1 = new ListBox();
            buttoGonder = new Button();
            textBoxMezmun = new TextBox();
            comboBoxKateqoriya = new ComboBox();
            label2 = new Label();
            cmbxSeher = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxAd = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            cmbZeng = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            buttonYardim = new Button();
            buttonMesaj = new Button();
            buttonSecilmisler = new Button();
            buttonGirish = new Button();
            comboBox1 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(372, 576);
            maskedTextBox1.Mask = "(000) 000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(298, 27);
            maskedTextBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(204, 159);
            label1.Name = "label1";
            label1.Size = new Size(149, 31);
            label1.TabIndex = 10;
            label1.Text = "Kateqoriya *";
            // 
            // list1
            // 
            list1.BackColor = Color.FromArgb(255, 128, 0);
            list1.FormattingEnabled = true;
            list1.ItemHeight = 20;
            list1.Location = new Point(-5, 37);
            list1.Name = "list1";
            list1.Size = new Size(1381, 104);
            list1.TabIndex = 9;
            // 
            // buttoGonder
            // 
            buttoGonder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttoGonder.Location = new Point(431, 622);
            buttoGonder.Name = "buttoGonder";
            buttoGonder.Size = new Size(177, 55);
            buttoGonder.TabIndex = 8;
            buttoGonder.Text = "Davam et";
            buttoGonder.UseVisualStyleBackColor = true;
            buttoGonder.Click += buttoGonder_Click;
            // 
            // textBoxMezmun
            // 
            textBoxMezmun.Location = new Point(372, 260);
            textBoxMezmun.Multiline = true;
            textBoxMezmun.Name = "textBoxMezmun";
            textBoxMezmun.Size = new Size(298, 194);
            textBoxMezmun.TabIndex = 3;
            // 
            // comboBoxKateqoriya
            // 
            comboBoxKateqoriya.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBoxKateqoriya.FormattingEnabled = true;
            comboBoxKateqoriya.Items.AddRange(new object[] { "Avtomobil oturacaqları", "Oyuncaqlar", "Uşaq oturacaqları", "Uşaq avtomobilləri", "Uşaq çarpayıları", "Uşaq daşıyıcıları ", "Uşaq beşikləri və çarpayıları", "Manejlər", "Məktəblilər üçün", "Geyim və ayaqqabılar", "Aksesuar", "Saat və zinət əşyaları" });
            comboBoxKateqoriya.Location = new Point(372, 159);
            comboBoxKateqoriya.Name = "comboBoxKateqoriya";
            comboBoxKateqoriya.Size = new Size(298, 28);
            comboBoxKateqoriya.TabIndex = 0;
            comboBoxKateqoriya.Text = "Siyahıdan seçin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(204, 193);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 11;
            label2.Text = "Şəhər *";
            // 
            // cmbxSeher
            // 
            cmbxSeher.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbxSeher.FormattingEnabled = true;
            cmbxSeher.Items.AddRange(new object[] { "Bakı", "Sumqayıt", "Gəncə", "Goranboy", "Füzuli", "Şamaxı", "İsmayıllı", "Quba", "Qusar", "Lənkəran", "Masallı", "Lerik", "Salyan", "Ağdaş", "Qusar", "Xaçmaz" });
            cmbxSeher.Location = new Point(372, 193);
            cmbxSeher.Name = "cmbxSeher";
            cmbxSeher.Size = new Size(298, 28);
            cmbxSeher.TabIndex = 1;
            cmbxSeher.Text = "Bakı";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(372, 227);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(196, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(204, 223);
            label3.Name = "label3";
            label3.Size = new Size(155, 31);
            label3.TabIndex = 12;
            label3.Text = "Qiymət,Azn *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(574, 224);
            label4.Name = "label4";
            label4.Size = new Size(55, 31);
            label4.TabIndex = 0;
            label4.Text = "Azn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(204, 471);
            label5.Name = "label5";
            label5.Size = new Size(99, 31);
            label5.TabIndex = 14;
            label5.Text = "Adınız *";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(372, 475);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(298, 27);
            textBoxAd.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(204, 507);
            label6.Name = "label6";
            label6.Size = new Size(91, 31);
            label6.TabIndex = 15;
            label6.Text = "Email *";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(372, 508);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(298, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // cmbZeng
            // 
            cmbZeng.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cmbZeng.FormattingEnabled = true;
            cmbZeng.Items.AddRange(new object[] { "Zənglər və Mesajlar", "Ancaq Zənglər", "Ancaq Mesajlar" });
            cmbZeng.Location = new Point(372, 541);
            cmbZeng.Name = "cmbZeng";
            cmbZeng.Size = new Size(298, 28);
            cmbZeng.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(199, 538);
            label7.Name = "label7";
            label7.Size = new Size(96, 31);
            label7.TabIndex = 16;
            label7.Text = "Zənglər";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(199, 572);
            label8.Name = "label8";
            label8.Size = new Size(166, 31);
            label8.TabIndex = 17;
            label8.Text = "Mobil nömrə *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(809, 354);
            label9.Name = "label9";
            label9.Size = new Size(213, 28);
            label9.TabIndex = 24;
            label9.Text = "Saytın tam qaydaları";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(795, 159);
            label10.Name = "label10";
            label10.Size = new Size(286, 31);
            label10.TabIndex = 19;
            label10.Text = "Tap.Az-ın sadə qaydaları";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(795, 201);
            label11.Name = "label11";
            label11.Size = new Size(297, 23);
            label11.TabIndex = 20;
            label11.Text = "* Elanı bir neçə dəfə təqdim etməyin";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(795, 227);
            label12.Name = "label12";
            label12.Size = new Size(306, 46);
            label12.TabIndex = 21;
            label12.Text = "* Təsvir və şəkillərdə telefon,email və\r\n ya sayt ünvanı göstərməyin";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(795, 273);
            label13.Name = "label13";
            label13.Size = new Size(318, 46);
            label13.TabIndex = 22;
            label13.Text = "* Ad yerində qiymət yazmayın--bunun \r\nüçün ayrıca yer var";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(795, 319);
            label14.Name = "label14";
            label14.Size = new Size(333, 23);
            label14.TabIndex = 23;
            label14.Text = "* Qadağan olunmuş məhsulları satmayın";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(199, 603);
            label15.Name = "label15";
            label15.Size = new Size(159, 40);
            label15.TabIndex = 18;
            label15.Text = "Bu nömrəyə Sms-kod\r\ngöndəriləcək";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(661, 9);
            label16.Name = "label16";
            label16.Size = new Size(123, 20);
            label16.TabIndex = 8;
            label16.Text = "(012)505-85-85";
            // 
            // buttonYardim
            // 
            buttonYardim.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonYardim.Location = new Point(795, 5);
            buttonYardim.Name = "buttonYardim";
            buttonYardim.Size = new Size(78, 29);
            buttonYardim.TabIndex = 9;
            buttonYardim.Text = "Yardım";
            buttonYardim.UseVisualStyleBackColor = true;
            // 
            // buttonMesaj
            // 
            buttonMesaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMesaj.Location = new Point(974, 5);
            buttonMesaj.Name = "buttonMesaj";
            buttonMesaj.Size = new Size(78, 29);
            buttonMesaj.TabIndex = 9;
            buttonMesaj.Text = "Mesajlar";
            buttonMesaj.UseVisualStyleBackColor = true;
            // 
            // buttonSecilmisler
            // 
            buttonSecilmisler.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonSecilmisler.Location = new Point(1058, 5);
            buttonSecilmisler.Name = "buttonSecilmisler";
            buttonSecilmisler.Size = new Size(106, 29);
            buttonSecilmisler.TabIndex = 9;
            buttonSecilmisler.Text = "Seçilmişlər";
            buttonSecilmisler.UseVisualStyleBackColor = true;
            // 
            // buttonGirish
            // 
            buttonGirish.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonGirish.Location = new Point(1170, 5);
            buttonGirish.Name = "buttonGirish";
            buttonGirish.Size = new Size(93, 29);
            buttonGirish.TabIndex = 9;
            buttonGirish.Text = "Giriş";
            buttonGirish.UseVisualStyleBackColor = true;
            buttonGirish.Click += buttonGirish_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Az", "Rus", "Eng" });
            comboBox1.Location = new Point(879, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Az";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.Location = new Point(204, 260);
            label17.Name = "label17";
            label17.Size = new Size(106, 31);
            label17.TabIndex = 13;
            label17.Text = "Məzmun";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(255, 128, 0);
            label18.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(191, 63);
            label18.Name = "label18";
            label18.Size = new Size(130, 50);
            label18.TabIndex = 14;
            label18.Text = "tap.az";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 701);
            Controls.Add(label18);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBox1);
            Controls.Add(buttonGirish);
            Controls.Add(buttonSecilmisler);
            Controls.Add(buttonMesaj);
            Controls.Add(buttonYardim);
            Controls.Add(label16);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxAd);
            Controls.Add(numericUpDown1);
            Controls.Add(cmbxSeher);
            Controls.Add(cmbZeng);
            Controls.Add(comboBoxKateqoriya);
            Controls.Add(textBoxMezmun);
            Controls.Add(buttoGonder);
            Controls.Add(list1);
            Controls.Add(label15);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label17);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tap.az";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox list1;
        private Button buttoGonder;
        private TextBox textBoxMezmun;
        private ComboBox comboBoxKateqoriya;
        private Label label2;
        private ComboBox cmbxSeher;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxAd;
        private Label label6;
        private TextBox textBoxEmail;
        private ComboBox cmbZeng;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button buttonYardim;
        private Button buttonMesaj;
        private Button buttonSecilmisler;
        private Button buttonGirish;
        private ComboBox comboBox1;
        private Label label17;
        private MaskedTextBox maskedTextBox1;
        private Label label18;
    }
}