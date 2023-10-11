namespace Bank_Interest_Calculation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BankList = new ComboBox();
            year = new TextBox();
            balance = new TextBox();
            totalInterest = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 78);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Bank Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 130);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 0;
            label2.Text = "Time(In Year)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 182);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 0;
            label3.Text = "Balance";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 305);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Interest";
            label4.Click += label4_Click;
            // 
            // BankList
            // 
            BankList.FormattingEnabled = true;
            BankList.Items.AddRange(new object[] { "SONALI BANK", "BRAC BANK", "DBBL BANK", "HSBC BANK" });
            BankList.Location = new Point(269, 70);
            BankList.Name = "BankList";
            BankList.Size = new Size(182, 33);
            BankList.TabIndex = 1;
            // 
            // year
            // 
            year.Location = new Point(269, 124);
            year.Name = "year";
            year.Size = new Size(86, 31);
            year.TabIndex = 2;
            // 
            // balance
            // 
            balance.Location = new Point(269, 176);
            balance.Name = "balance";
            balance.Size = new Size(182, 31);
            balance.TabIndex = 2;
            // 
            // totalInterest
            // 
            totalInterest.Location = new Point(269, 299);
            totalInterest.Name = "totalInterest";
            totalInterest.Size = new Size(182, 31);
            totalInterest.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(282, 237);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 3;
            button1.Text = "Calculate Interest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(button1);
            Controls.Add(totalInterest);
            Controls.Add(balance);
            Controls.Add(year);
            Controls.Add(BankList);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox BankList;
        private TextBox year;
        private TextBox balance;
        private TextBox totalInterest;
        private Button button1;
    }
}