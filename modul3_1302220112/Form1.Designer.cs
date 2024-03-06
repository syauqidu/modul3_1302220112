namespace modul3_1302220112
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
            but1 = new Button();
            but2 = new Button();
            but3 = new Button();
            butPlus = new Button();
            butEqual = new Button();
            but0 = new Button();
            but4 = new Button();
            but5 = new Button();
            but6 = new Button();
            but7 = new Button();
            but8 = new Button();
            but9 = new Button();
            txtBoxOut = new TextBox();
            SuspendLayout();
            // 
            // but1
            // 
            but1.Location = new Point(178, 234);
            but1.Name = "but1";
            but1.Size = new Size(48, 33);
            but1.TabIndex = 3;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = true;
            but1.Click += but1_Click;
            // 
            // but2
            // 
            but2.Location = new Point(223, 234);
            but2.Name = "but2";
            but2.Size = new Size(48, 33);
            but2.TabIndex = 4;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = true;
            but2.Click += but2_Click;
            // 
            // but3
            // 
            but3.Location = new Point(266, 234);
            but3.Name = "but3";
            but3.Size = new Size(48, 33);
            but3.TabIndex = 5;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = true;
            but3.Click += but3_Click;
            // 
            // butPlus
            // 
            butPlus.Location = new Point(178, 195);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(48, 33);
            butPlus.TabIndex = 6;
            butPlus.Text = "+";
            butPlus.UseVisualStyleBackColor = true;
            butPlus.Click += button3_Click;
            // 
            // butEqual
            // 
            butEqual.Location = new Point(223, 195);
            butEqual.Name = "butEqual";
            butEqual.Size = new Size(48, 33);
            butEqual.TabIndex = 7;
            butEqual.Text = "=";
            butEqual.UseVisualStyleBackColor = true;
            butEqual.Click += butEqual_Click;
            // 
            // but0
            // 
            but0.Location = new Point(266, 195);
            but0.Name = "but0";
            but0.Size = new Size(48, 33);
            but0.TabIndex = 8;
            but0.Text = "0";
            but0.UseVisualStyleBackColor = true;
            but0.Click += button6_Click;
            // 
            // but4
            // 
            but4.Location = new Point(178, 273);
            but4.Name = "but4";
            but4.Size = new Size(48, 33);
            but4.TabIndex = 9;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += but4_Click;
            // 
            // but5
            // 
            but5.Location = new Point(223, 273);
            but5.Name = "but5";
            but5.Size = new Size(48, 33);
            but5.TabIndex = 10;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = true;
            but5.Click += but5_Click;
            // 
            // but6
            // 
            but6.Location = new Point(266, 273);
            but6.Name = "but6";
            but6.Size = new Size(48, 33);
            but6.TabIndex = 11;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = true;
            but6.Click += but6_Click;
            // 
            // but7
            // 
            but7.Location = new Point(178, 312);
            but7.Name = "but7";
            but7.Size = new Size(48, 33);
            but7.TabIndex = 12;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = true;
            but7.Click += but7_Click;
            // 
            // but8
            // 
            but8.Location = new Point(223, 312);
            but8.Name = "but8";
            but8.Size = new Size(48, 33);
            but8.TabIndex = 13;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = true;
            but8.Click += but8_Click;
            // 
            // but9
            // 
            but9.Location = new Point(266, 312);
            but9.Name = "but9";
            but9.Size = new Size(48, 33);
            but9.TabIndex = 14;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = true;
            but9.Click += but9_Click;
            // 
            // txtBoxOut
            // 
            txtBoxOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxOut.Location = new Point(178, 154);
            txtBoxOut.Name = "txtBoxOut";
            txtBoxOut.Size = new Size(136, 29);
            txtBoxOut.TabIndex = 16;
            txtBoxOut.TextChanged += txtBoxOut_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxOut);
            Controls.Add(but9);
            Controls.Add(but8);
            Controls.Add(but7);
            Controls.Add(but6);
            Controls.Add(but5);
            Controls.Add(but4);
            Controls.Add(but0);
            Controls.Add(butEqual);
            Controls.Add(butPlus);
            Controls.Add(but3);
            Controls.Add(but2);
            Controls.Add(but1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button but1;
        private Button but2;
        private Button but3;
        private Button butPlus;
        private Button butEqual;
        private Button but0;
        private Button but4;
        private Button but5;
        private Button but6;
        private Button but7;
        private Button but8;
        private Button but9;
        private TextBox txtBoxOut;
    }
}
