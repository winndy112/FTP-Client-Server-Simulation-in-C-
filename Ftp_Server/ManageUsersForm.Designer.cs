namespace Ftp_Server
{
    partial class ManageUsersForm
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.virtualPathLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.virtualPathTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.passwordTextBox);
            this.mainContainer.Panel2.Controls.Add(this.passwordLabel);
            this.mainContainer.Panel2.Controls.Add(this.locationTextBox);
            this.mainContainer.Panel2.Controls.Add(this.virtualPathTextBox);
            this.mainContainer.Panel2.Controls.Add(this.locationLabel);
            this.mainContainer.Panel2.Controls.Add(this.virtualPathLabel);
            this.mainContainer.Panel2.Controls.Add(this.applyButton);
            this.mainContainer.Panel2.Controls.Add(this.usernameTextBox);
            this.mainContainer.Panel2.Controls.Add(this.usernameLabel);
            this.mainContainer.Panel2.Controls.Add(this.roleComboBox);
            this.mainContainer.Panel2.Controls.Add(this.roleLabel);
            this.mainContainer.Size = new System.Drawing.Size(800, 450);
            this.mainContainer.SplitterDistance = 266;
            this.mainContainer.TabIndex = 0;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Read Only",
            "Read and Write"});
            this.roleComboBox.Location = new System.Drawing.Point(182, 180);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(192, 33);
            this.roleComboBox.TabIndex = 1;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(39, 186);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(137, 25);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "User access:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(39, 85);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 25);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(182, 79);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(192, 31);
            this.usernameTextBox.TabIndex = 4;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(207, 349);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(138, 53);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // virtualPathLabel
            // 
            this.virtualPathLabel.AutoSize = true;
            this.virtualPathLabel.Location = new System.Drawing.Point(39, 239);
            this.virtualPathLabel.Name = "virtualPathLabel";
            this.virtualPathLabel.Size = new System.Drawing.Size(129, 25);
            this.virtualPathLabel.TabIndex = 6;
            this.virtualPathLabel.Text = "Virtual Path:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(39, 291);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(100, 25);
            this.locationLabel.TabIndex = 7;
            this.locationLabel.Text = "Location:";
            // 
            // virtualPathTextBox
            // 
            this.virtualPathTextBox.Location = new System.Drawing.Point(182, 236);
            this.virtualPathTextBox.Name = "virtualPathTextBox";
            this.virtualPathTextBox.Size = new System.Drawing.Size(192, 31);
            this.virtualPathTextBox.TabIndex = 8;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(182, 288);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(192, 31);
            this.locationTextBox.TabIndex = 9;
            this.locationTextBox.Enter += new System.EventHandler(this.locationTextBox_Enter);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(182, 127);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(192, 31);
            this.passwordTextBox.TabIndex = 11;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(39, 133);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 25);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainContainer);
            this.Name = "ManageUsersForm";
            this.Text = "Manage Users Form";
            this.Load += new System.EventHandler(this.ManageUsersForm_Load);
            this.mainContainer.Panel2.ResumeLayout(false);
            this.mainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label virtualPathLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox virtualPathTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
    }
}