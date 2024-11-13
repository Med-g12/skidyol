namespace WinFormsApp1
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox10 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(61, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(84, 92);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(61, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(151, 92);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(44, 23);
            comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 96);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 4;
            label1.Text = ":";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(12, 41);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(72, 23);
            comboBox7.TabIndex = 7;
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Location = new Point(90, 41);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(38, 23);
            comboBox8.TabIndex = 8;
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Location = new Point(134, 41);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(61, 23);
            comboBox9.TabIndex = 9;
            // 
            // comboBox10
            // 
            comboBox10.FormattingEnabled = true;
            comboBox10.Location = new Point(12, 148);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(183, 23);
            comboBox10.TabIndex = 10;
            comboBox10.SelectedIndexChanged += comboBox10_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 11;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 12;
            label3.Text = "Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(172, 21);
            label4.TabIndex = 13;
            label4.Text = "Type of Appointment";
            // 
            // button1
            // 
            button1.Location = new Point(12, 177);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
            button1.TabIndex = 14;
            button1.Text = "Set Schedule";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 233);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox10);
            Controls.Add(comboBox9);
            Controls.Add(comboBox8);
            Controls.Add(comboBox7);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label1;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
