namespace Todo_list
{
    partial class Form2
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
            urgent = new TextBox();
            label1 = new Label();
            label2 = new Label();
            important = new TextBox();
            label3 = new Label();
            week = new TextBox();
            save = new Button();
            SuspendLayout();
            // 
            // urgent
            // 
            urgent.Location = new Point(12, 92);
            urgent.Multiline = true;
            urgent.Name = "urgent";
            urgent.Size = new Size(221, 297);
            urgent.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 1;
            label1.Text = "absolutely frikin urgent";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 61);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 3;
            label2.Text = "kinda important";
            // 
            // important
            // 
            important.Location = new Point(264, 92);
            important.Multiline = true;
            important.Name = "important";
            important.Size = new Size(221, 297);
            important.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 61);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 5;
            label3.Text = "can do next week";
            // 
            // week
            // 
            week.Location = new Point(528, 92);
            week.Multiline = true;
            week.Name = "week";
            week.Size = new Size(260, 297);
            week.TabIndex = 4;
            // 
            // save
            // 
            save.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save.Location = new Point(728, 428);
            save.Name = "save";
            save.Size = new Size(94, 34);
            save.TabIndex = 6;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 474);
            Controls.Add(save);
            Controls.Add(label3);
            Controls.Add(week);
            Controls.Add(label2);
            Controls.Add(important);
            Controls.Add(label1);
            Controls.Add(urgent);
            Name = "Form2";
            Text = "heloo noo i want to dieee";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urgent;
        private Label label1;
        private Label label2;
        private TextBox important;
        private Label label3;
        private TextBox week;
        private Button save;
    }
}