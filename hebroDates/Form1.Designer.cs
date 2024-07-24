namespace hebroDates
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
            label5 = new Label();
            YearcomboBox1 = new ComboBox();
            MonthcomboBox2 = new ComboBox();
            DayMonthcomboBox3 = new ComboBox();
            DaycomboBox = new ComboBox();
            PrintDatebutton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 83);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "שנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 83);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 2;
            label3.Text = "חודש ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 83);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "היום בחודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 83);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 4;
            label5.Text = "היום בשבוע";
            // 
            // YearcomboBox1
            // 
            YearcomboBox1.FormattingEnabled = true;
            YearcomboBox1.Location = new Point(3, 132);
            YearcomboBox1.Name = "YearcomboBox1";
            YearcomboBox1.Size = new Size(182, 33);
            YearcomboBox1.TabIndex = 5;
            // 
            // MonthcomboBox2
            // 
            MonthcomboBox2.FormattingEnabled = true;
            MonthcomboBox2.Location = new Point(191, 132);
            MonthcomboBox2.Name = "MonthcomboBox2";
            MonthcomboBox2.Size = new Size(182, 33);
            MonthcomboBox2.TabIndex = 6;
            // 
            // DayMonthcomboBox3
            // 
            DayMonthcomboBox3.FormattingEnabled = true;
            DayMonthcomboBox3.Location = new Point(379, 132);
            DayMonthcomboBox3.Name = "DayMonthcomboBox3";
            DayMonthcomboBox3.Size = new Size(182, 33);
            DayMonthcomboBox3.TabIndex = 7;
            // 
            // DaycomboBox
            // 
            DaycomboBox.FormattingEnabled = true;
            DaycomboBox.Location = new Point(593, 132);
            DaycomboBox.Name = "DaycomboBox";
            DaycomboBox.Size = new Size(182, 33);
            DaycomboBox.TabIndex = 8;
            DaycomboBox.SelectedIndexChanged += DaycomboBox_SelectedIndexChanged;
            // 
            // PrintDatebutton1
            // 
            PrintDatebutton1.Location = new Point(334, 263);
            PrintDatebutton1.Name = "PrintDatebutton1";
            PrintDatebutton1.Size = new Size(112, 34);
            PrintDatebutton1.TabIndex = 9;
            PrintDatebutton1.Text = "הצג תאריך";
            PrintDatebutton1.UseVisualStyleBackColor = true;
            PrintDatebutton1.Click += PrintDatebutton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrintDatebutton1);
            Controls.Add(DaycomboBox);
            Controls.Add(DayMonthcomboBox3);
            Controls.Add(MonthcomboBox2);
            Controls.Add(YearcomboBox1);
            Controls.Add(label5);
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
        private Label label5;
        private ComboBox YearcomboBox1;
        private ComboBox MonthcomboBox2;
        private ComboBox DayMonthcomboBox3;
        private ComboBox DaycomboBox;
        private Button PrintDatebutton1;
    }
}
