namespace Todo_list
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(242, 320);
            button1.Name = "button1";
            button1.Size = new Size(283, 93);
            button1.TabIndex = 0;
            button1.Text = "show list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-16, 31);
            label1.Name = "label1";
            label1.Size = new Size(804, 168);
            label1.TabIndex = 1;
            label1.Text = "todo list app";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 245);
            label2.Name = "label2";
            label2.Size = new Size(775, 42);
            label2.TabIndex = 2;
            label2.Text = "made in visual studio code with .net and windows forms";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(-6, 245);
            label3.Name = "label3";
            label3.Size = new Size(775, 42);
            label3.TabIndex = 2;
            label3.Text = "made in visual studio code with .net and windows forms";
            label3.Click += label2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(556, 429);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(223, 26);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Copyright Mewo Corporation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 454);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "hi MAKE YER TODO LIST";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}
