namespace PrintQueue
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pqListBox = new System.Windows.Forms.ListBox();
            this.totalListBox = new System.Windows.Forms.ListBox();
            this.resetUserButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 506);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Resume";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pqListBox
            // 
            this.pqListBox.FormattingEnabled = true;
            this.pqListBox.ItemHeight = 25;
            this.pqListBox.Location = new System.Drawing.Point(265, 102);
            this.pqListBox.Name = "pqListBox";
            this.pqListBox.Size = new System.Drawing.Size(732, 254);
            this.pqListBox.TabIndex = 3;
            // 
            // totalListBox
            // 
            this.totalListBox.FormattingEnabled = true;
            this.totalListBox.ItemHeight = 25;
            this.totalListBox.Location = new System.Drawing.Point(1125, 102);
            this.totalListBox.Name = "totalListBox";
            this.totalListBox.Size = new System.Drawing.Size(376, 454);
            this.totalListBox.TabIndex = 4;
            // 
            // resetUserButton
            // 
            this.resetUserButton.Location = new System.Drawing.Point(1125, 615);
            this.resetUserButton.Name = "resetUserButton";
            this.resetUserButton.Size = new System.Drawing.Size(132, 87);
            this.resetUserButton.TabIndex = 5;
            this.resetUserButton.Text = "Reset User";
            this.resetUserButton.UseVisualStyleBackColor = true;
            this.resetUserButton.Click += new System.EventHandler(this.resetUserButton_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(1125, 820);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(132, 120);
            this.testButton.TabIndex = 6;
            this.testButton.Text = "Test Features";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 991);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.resetUserButton);
            this.Controls.Add(this.totalListBox);
            this.Controls.Add(this.pqListBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox pqListBox;
        private System.Windows.Forms.ListBox totalListBox;
        private System.Windows.Forms.Button resetUserButton;
        private System.Windows.Forms.Button testButton;
    }
}

