
namespace alphavotingsystem
{
    partial class formRegister
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
            this.adminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.continueButton = new System.Windows.Forms.Button();
            this.studentSectionComboBox = new System.Windows.Forms.ComboBox();
            this.studentStrandComboBox = new System.Windows.Forms.ComboBox();
            this.studentYearComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminLinkLabel
            // 
            this.adminLinkLabel.AutoSize = true;
            this.adminLinkLabel.Location = new System.Drawing.Point(9, 309);
            this.adminLinkLabel.Name = "adminLinkLabel";
            this.adminLinkLabel.Size = new System.Drawing.Size(128, 13);
            this.adminLinkLabel.TabIndex = 34;
            this.adminLinkLabel.TabStop = true;
            this.adminLinkLabel.Text = "go to Admin Page (admin)";
            this.adminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLinkLabel_LinkClicked);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(204, 255);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 33;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // studentSectionComboBox
            // 
            this.studentSectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentSectionComboBox.FormattingEnabled = true;
            this.studentSectionComboBox.Items.AddRange(new object[] {
            "A",
            "B"});
            this.studentSectionComboBox.Location = new System.Drawing.Point(15, 213);
            this.studentSectionComboBox.Name = "studentSectionComboBox";
            this.studentSectionComboBox.Size = new System.Drawing.Size(264, 21);
            this.studentSectionComboBox.TabIndex = 32;
            // 
            // studentStrandComboBox
            // 
            this.studentStrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentStrandComboBox.FormattingEnabled = true;
            this.studentStrandComboBox.Items.AddRange(new object[] {
            "STEM",
            "GAS",
            "ABM",
            "HUMMS",
            "TVL - HE",
            "TVL - ICT",
            "TVL - ELEC TECH"});
            this.studentStrandComboBox.Location = new System.Drawing.Point(147, 166);
            this.studentStrandComboBox.Name = "studentStrandComboBox";
            this.studentStrandComboBox.Size = new System.Drawing.Size(132, 21);
            this.studentStrandComboBox.TabIndex = 31;
            // 
            // studentYearComboBox
            // 
            this.studentYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentYearComboBox.FormattingEnabled = true;
            this.studentYearComboBox.Items.AddRange(new object[] {
            "11",
            "12"});
            this.studentYearComboBox.Location = new System.Drawing.Point(15, 166);
            this.studentYearComboBox.Name = "studentYearComboBox";
            this.studentYearComboBox.Size = new System.Drawing.Size(126, 21);
            this.studentYearComboBox.TabIndex = 30;
            this.studentYearComboBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Strand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Student ID";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(15, 119);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.studentNameTextBox.TabIndex = 23;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(15, 73);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(264, 20);
            this.studentIDTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Voting System";
            // 
            // formRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 333);
            this.Controls.Add(this.adminLinkLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.studentSectionComboBox);
            this.Controls.Add(this.studentStrandComboBox);
            this.Controls.Add(this.studentYearComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel adminLinkLabel;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.ComboBox studentSectionComboBox;
        private System.Windows.Forms.ComboBox studentStrandComboBox;
        private System.Windows.Forms.ComboBox studentYearComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label1;
    }
}