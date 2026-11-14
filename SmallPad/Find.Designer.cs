namespace WindowsFormsApp1
{
    partial class Find
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
            this.RFNCheckBox = new System.Windows.Forms.CheckBox();
            this.MCCheckBox = new System.Windows.Forms.CheckBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplacementText = new System.Windows.Forms.TextBox();
            this.lblReplacementText = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RFNCheckBox
            // 
            this.RFNCheckBox.AutoSize = true;
            this.RFNCheckBox.Location = new System.Drawing.Point(103, 100);
            this.RFNCheckBox.Name = "RFNCheckBox";
            this.RFNCheckBox.Size = new System.Drawing.Size(111, 17);
            this.RFNCheckBox.TabIndex = 5;
            this.RFNCheckBox.Text = "Replace file name";
            this.RFNCheckBox.UseVisualStyleBackColor = true;
            // 
            // MCCheckBox
            // 
            this.MCCheckBox.AutoSize = true;
            this.MCCheckBox.Location = new System.Drawing.Point(15, 100);
            this.MCCheckBox.Name = "MCCheckBox";
            this.MCCheckBox.Size = new System.Drawing.Size(82, 17);
            this.MCCheckBox.TabIndex = 4;
            this.MCCheckBox.Text = "Match case";
            this.MCCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReplace.Location = new System.Drawing.Point(233, 65);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // txtReplacementText
            // 
            this.txtReplacementText.Location = new System.Drawing.Point(15, 65);
            this.txtReplacementText.Name = "txtReplacementText";
            this.txtReplacementText.Size = new System.Drawing.Size(212, 20);
            this.txtReplacementText.TabIndex = 2;
            // 
            // lblReplacementText
            // 
            this.lblReplacementText.AutoSize = true;
            this.lblReplacementText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReplacementText.Location = new System.Drawing.Point(12, 48);
            this.lblReplacementText.Name = "lblReplacementText";
            this.lblReplacementText.Size = new System.Drawing.Size(97, 13);
            this.lblReplacementText.TabIndex = 31;
            this.lblReplacementText.Text = "Replacement Text:";
            // 
            // btnFind
            // 
            this.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFind.Location = new System.Drawing.Point(233, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(15, 25);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(212, 20);
            this.txtSearchText.TabIndex = 0;
            // 
            // lblSearchText
            // 
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearchText.Location = new System.Drawing.Point(12, 9);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(68, 13);
            this.lblSearchText.TabIndex = 29;
            this.lblSearchText.Text = "Search Text:";
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 126);
            this.Controls.Add(this.RFNCheckBox);
            this.Controls.Add(this.MCCheckBox);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplacementText);
            this.Controls.Add(this.lblReplacementText);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.lblSearchText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find & Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox RFNCheckBox;
        internal System.Windows.Forms.CheckBox MCCheckBox;
        internal System.Windows.Forms.Button btnReplace;
        internal System.Windows.Forms.TextBox txtReplacementText;
        internal System.Windows.Forms.Label lblReplacementText;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.TextBox txtSearchText;
        internal System.Windows.Forms.Label lblSearchText;
    }
}