
namespace alphavotingsystem
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingdbDataSet = new alphavotingsystem.votingdbDataSet();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.candidatesTableAdapter = new alphavotingsystem.votingdbDataSetTableAdapters.candidatesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pioComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.projectManagerComboBox = new System.Windows.Forms.ComboBox();
            this.auditorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treasurerComboBox = new System.Windows.Forms.ComboBox();
            this.secretaryComboBox = new System.Windows.Forms.ComboBox();
            this.vicePresidentComboBox = new System.Windows.Forms.ComboBox();
            this.presidentComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingdbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Choose your own candidate.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Voting System";
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "candidates";
            this.candidatesBindingSource.DataSource = this.votingdbDataSet;
            // 
            // votingdbDataSet
            // 
            this.votingdbDataSet.DataSetName = "votingdbDataSet";
            this.votingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(252, 456);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 456);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pioComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.projectManagerComboBox);
            this.panel1.Controls.Add(this.auditorComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.treasurerComboBox);
            this.panel1.Controls.Add(this.secretaryComboBox);
            this.panel1.Controls.Add(this.vicePresidentComboBox);
            this.panel1.Controls.Add(this.presidentComboBox);
            this.panel1.Location = new System.Drawing.Point(5, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 378);
            this.panel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Project Information Officer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Project Manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Auditor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Treasurer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Secretary:";
            // 
            // pioComboBox
            // 
            this.pioComboBox.DisplayMember = "name";
            this.pioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pioComboBox.FormattingEnabled = true;
            this.pioComboBox.Location = new System.Drawing.Point(1, 333);
            this.pioComboBox.Name = "pioComboBox";
            this.pioComboBox.Size = new System.Drawing.Size(319, 21);
            this.pioComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Vice President:";
            // 
            // projectManagerComboBox
            // 
            this.projectManagerComboBox.DisplayMember = "name";
            this.projectManagerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectManagerComboBox.FormattingEnabled = true;
            this.projectManagerComboBox.Location = new System.Drawing.Point(1, 277);
            this.projectManagerComboBox.Name = "projectManagerComboBox";
            this.projectManagerComboBox.Size = new System.Drawing.Size(319, 21);
            this.projectManagerComboBox.TabIndex = 5;
            // 
            // auditorComboBox
            // 
            this.auditorComboBox.DisplayMember = "name";
            this.auditorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auditorComboBox.FormattingEnabled = true;
            this.auditorComboBox.Location = new System.Drawing.Point(1, 228);
            this.auditorComboBox.Name = "auditorComboBox";
            this.auditorComboBox.Size = new System.Drawing.Size(319, 21);
            this.auditorComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "President:";
            // 
            // treasurerComboBox
            // 
            this.treasurerComboBox.DisplayMember = "name";
            this.treasurerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.treasurerComboBox.FormattingEnabled = true;
            this.treasurerComboBox.Location = new System.Drawing.Point(1, 175);
            this.treasurerComboBox.Name = "treasurerComboBox";
            this.treasurerComboBox.Size = new System.Drawing.Size(319, 21);
            this.treasurerComboBox.TabIndex = 3;
            // 
            // secretaryComboBox
            // 
            this.secretaryComboBox.DisplayMember = "name";
            this.secretaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secretaryComboBox.FormattingEnabled = true;
            this.secretaryComboBox.Location = new System.Drawing.Point(1, 127);
            this.secretaryComboBox.Name = "secretaryComboBox";
            this.secretaryComboBox.Size = new System.Drawing.Size(319, 21);
            this.secretaryComboBox.TabIndex = 2;
            // 
            // vicePresidentComboBox
            // 
            this.vicePresidentComboBox.DisplayMember = "name";
            this.vicePresidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vicePresidentComboBox.FormattingEnabled = true;
            this.vicePresidentComboBox.Location = new System.Drawing.Point(3, 78);
            this.vicePresidentComboBox.Name = "vicePresidentComboBox";
            this.vicePresidentComboBox.Size = new System.Drawing.Size(319, 21);
            this.vicePresidentComboBox.TabIndex = 1;
            // 
            // presidentComboBox
            // 
            this.presidentComboBox.DisplayMember = "name";
            this.presidentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presidentComboBox.FormattingEnabled = true;
            this.presidentComboBox.Location = new System.Drawing.Point(3, 32);
            this.presidentComboBox.Name = "presidentComboBox";
            this.presidentComboBox.Size = new System.Drawing.Size(319, 21);
            this.presidentComboBox.TabIndex = 0;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(339, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting System";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingdbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private votingdbDataSet votingdbDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private votingdbDataSetTableAdapters.candidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pioComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox projectManagerComboBox;
        private System.Windows.Forms.ComboBox auditorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox treasurerComboBox;
        private System.Windows.Forms.ComboBox secretaryComboBox;
        private System.Windows.Forms.ComboBox vicePresidentComboBox;
        private System.Windows.Forms.ComboBox presidentComboBox;
    }
}