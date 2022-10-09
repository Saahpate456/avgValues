namespace avgValues
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
            this.numInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(309, 130);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(57, 20);
            this.numInput.TabIndex = 0;
            this.numInput.TextChanged += new System.EventHandler(this.numInput_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(382, 119);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 41);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(325, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(120, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Average Number Solver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter a number and Press Add";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Enter 0 and press Add to calculate average)";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(580, 323);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(92, 47);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.outputLabel.Location = new System.Drawing.Point(293, 265);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 443);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

