namespace RandomGenerator
{
    partial class FormWordGenerator
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
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.NumberOfWordsTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generation_attempts = new System.Windows.Forms.Label();
            this.reset_attempts = new System.Windows.Forms.LinkLabel();
            this.reset_list = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(25, 44);
            this.WordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WordTextBox.Multiline = true;
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WordTextBox.Size = new System.Drawing.Size(146, 223);
            this.WordTextBox.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(236, 247);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(98, 19);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Сгенерировать";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // NumberOfWordsTextBox
            // 
            this.NumberOfWordsTextBox.Location = new System.Drawing.Point(441, 114);
            this.NumberOfWordsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberOfWordsTextBox.Name = "NumberOfWordsTextBox";
            this.NumberOfWordsTextBox.Size = new System.Drawing.Size(54, 20);
            this.NumberOfWordsTextBox.TabIndex = 2;
            this.NumberOfWordsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(222, 111);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(130, 119);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество:";
            // 
            // generation_attempts
            // 
            this.generation_attempts.AutoSize = true;
            this.generation_attempts.Location = new System.Drawing.Point(193, 278);
            this.generation_attempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generation_attempts.Name = "generation_attempts";
            this.generation_attempts.Size = new System.Drawing.Size(111, 13);
            this.generation_attempts.TabIndex = 5;
            this.generation_attempts.Text = "Попыток генерации:";
            // 
            // reset_attempts
            // 
            this.reset_attempts.AutoSize = true;
            this.reset_attempts.Location = new System.Drawing.Point(342, 278);
            this.reset_attempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reset_attempts.Name = "reset_attempts";
            this.reset_attempts.Size = new System.Drawing.Size(44, 13);
            this.reset_attempts.TabIndex = 6;
            this.reset_attempts.TabStop = true;
            this.reset_attempts.Text = "(Сброс)";
            this.reset_attempts.Click += new System.EventHandler(this.reset_attempts_Click);
            // 
            // reset_list
            // 
            this.reset_list.AutoSize = true;
            this.reset_list.Location = new System.Drawing.Point(93, 278);
            this.reset_list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reset_list.Name = "reset_list";
            this.reset_list.Size = new System.Drawing.Size(83, 13);
            this.reset_list.TabIndex = 7;
            this.reset_list.TabStop = true;
            this.reset_list.Text = "(Сброс списка)";
            this.reset_list.Click += new System.EventHandler(this.reset_list_Click);
            // 
            // FormWordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 366);
            this.Controls.Add(this.reset_list);
            this.Controls.Add(this.reset_attempts);
            this.Controls.Add(this.generation_attempts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.NumberOfWordsTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.WordTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormWordGenerator";
            this.Text = "FormWordGenerator";
            this.Load += new System.EventHandler(this.FormWordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox NumberOfWordsTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label generation_attempts;
        private System.Windows.Forms.LinkLabel reset_attempts;
        private System.Windows.Forms.LinkLabel reset_list;
    }
}