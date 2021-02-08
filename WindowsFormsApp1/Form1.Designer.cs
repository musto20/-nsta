namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SifreTBox = new System.Windows.Forms.TextBox();
            this.NicknameTBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FacePassTxt = new System.Windows.Forms.TextBox();
            this.FaceMailTxt = new System.Windows.Forms.TextBox();
            this.Lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Takipci_SayisiTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(121, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş Yap ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Resimleri İsimlendir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SifreTBox);
            this.panel2.Controls.Add(this.NicknameTBox);
            this.panel2.Location = new System.Drawing.Point(64, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 298);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // SifreTBox
            // 
            this.SifreTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTBox.Location = new System.Drawing.Point(144, 89);
            this.SifreTBox.Margin = new System.Windows.Forms.Padding(2);
            this.SifreTBox.Name = "SifreTBox";
            this.SifreTBox.PasswordChar = '*';
            this.SifreTBox.Size = new System.Drawing.Size(158, 24);
            this.SifreTBox.TabIndex = 1;
            // 
            // NicknameTBox
            // 
            this.NicknameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NicknameTBox.Location = new System.Drawing.Point(144, 30);
            this.NicknameTBox.Margin = new System.Windows.Forms.Padding(2);
            this.NicknameTBox.Name = "NicknameTBox";
            this.NicknameTBox.Size = new System.Drawing.Size(158, 24);
            this.NicknameTBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.FacePassTxt);
            this.panel1.Controls.Add(this.FaceMailTxt);
            this.panel1.Controls.Add(this.Lb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(390, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 298);
            this.panel1.TabIndex = 7;
            // 
            // FacePassTxt
            // 
            this.FacePassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FacePassTxt.Location = new System.Drawing.Point(119, 108);
            this.FacePassTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FacePassTxt.Name = "FacePassTxt";
            this.FacePassTxt.PasswordChar = '*';
            this.FacePassTxt.Size = new System.Drawing.Size(208, 24);
            this.FacePassTxt.TabIndex = 6;
            // 
            // FaceMailTxt
            // 
            this.FaceMailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FaceMailTxt.Location = new System.Drawing.Point(119, 19);
            this.FaceMailTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FaceMailTxt.Name = "FaceMailTxt";
            this.FaceMailTxt.Size = new System.Drawing.Size(208, 24);
            this.FaceMailTxt.TabIndex = 5;
            // 
            // Lb
            // 
            this.Lb.AutoSize = true;
            this.Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lb.Location = new System.Drawing.Point(25, 108);
            this.Lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb.Name = "Lb";
            this.Lb.Size = new System.Drawing.Size(42, 20);
            this.Lb.TabIndex = 4;
            this.Lb.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E Posta";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(128, 168);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Giriş Yap ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(171, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hesap Girişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(505, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Facebook Girişi";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 63);
            this.button4.TabIndex = 10;
            this.button4.Text = "Klasöre seç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 71);
            this.button5.TabIndex = 11;
            this.button5.Text = "Paylaşmaya başla ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 42);
            this.button6.TabIndex = 12;
            this.button6.Text = "Gönderi Zamanla";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(149, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 40);
            this.button7.TabIndex = 13;
            this.button7.Text = "Takip Et ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-2, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1332, 618);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Takipci_SayisiTB);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Location = new System.Drawing.Point(733, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 298);
            this.panel4.TabIndex = 14;
            // 
            // Takipci_SayisiTB
            // 
            this.Takipci_SayisiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Takipci_SayisiTB.Location = new System.Drawing.Point(210, 106);
            this.Takipci_SayisiTB.Name = "Takipci_SayisiTB";
            this.Takipci_SayisiTB.Size = new System.Drawing.Size(100, 23);
            this.Takipci_SayisiTB.TabIndex = 15;
            this.Takipci_SayisiTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Takipci_SayisiTB_KeyDown);
            this.Takipci_SayisiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Takipci_SayisiTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kaç Takipçi Takip Edilecek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1325, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SifreTBox;
        private System.Windows.Forms.TextBox NicknameTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FacePassTxt;
        private System.Windows.Forms.TextBox FaceMailTxt;
        private System.Windows.Forms.Label Lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Takipci_SayisiTB;
    }
}

