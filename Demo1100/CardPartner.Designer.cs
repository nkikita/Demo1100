namespace Demo1100
{
    partial class CardPartner
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
            TypeL = new Label();
            NameL = new Label();
            DirektorL = new Label();
            PhoneL = new Label();
            RankL = new Label();
            SaleL = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // TypeL
            // 
            TypeL.AutoSize = true;
            TypeL.Location = new Point(19, 17);
            TypeL.Name = "TypeL";
            TypeL.Size = new Size(50, 20);
            TypeL.TabIndex = 0;
            TypeL.Text = "label1";
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Location = new Point(75, 17);
            NameL.Name = "NameL";
            NameL.Size = new Size(50, 20);
            NameL.TabIndex = 1;
            NameL.Text = "label2";
            // 
            // DirektorL
            // 
            DirektorL.AutoSize = true;
            DirektorL.Location = new Point(19, 56);
            DirektorL.Name = "DirektorL";
            DirektorL.Size = new Size(50, 20);
            DirektorL.TabIndex = 2;
            DirektorL.Text = "label3";
            // 
            // PhoneL
            // 
            PhoneL.AutoSize = true;
            PhoneL.Location = new Point(19, 76);
            PhoneL.Name = "PhoneL";
            PhoneL.Size = new Size(50, 20);
            PhoneL.TabIndex = 3;
            PhoneL.Text = "label4";
            // 
            // RankL
            // 
            RankL.AutoSize = true;
            RankL.Location = new Point(19, 96);
            RankL.Name = "RankL";
            RankL.Size = new Size(50, 20);
            RankL.TabIndex = 4;
            RankL.Text = "label5";
            // 
            // SaleL
            // 
            SaleL.AutoSize = true;
            SaleL.Location = new Point(395, 17);
            SaleL.Name = "SaleL";
            SaleL.Size = new Size(50, 20);
            SaleL.TabIndex = 5;
            SaleL.Text = "label6";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 186, 128);
            button1.Location = new Point(284, 96);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 6;
            button1.Text = "История партнера";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CardPartner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 232, 211);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(SaleL);
            Controls.Add(RankL);
            Controls.Add(PhoneL);
            Controls.Add(DirektorL);
            Controls.Add(NameL);
            Controls.Add(TypeL);
            Name = "CardPartner";
            Size = new Size(478, 139);
            Load += CardPartner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TypeL;
        private Label NameL;
        private Label DirektorL;
        private Label PhoneL;
        private Label RankL;
        private Label SaleL;
        private Button button1;
    }
}