﻿namespace WinFormsApp1
{
    partial class CreateEditForm
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
            lbTitle = new Label();
            label1 = new Label();
            lbid = new Label();
            label2 = new Label();
            tbFirstName = new TextBox();
            label3 = new Label();
            tbLastName = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            tbPhone = new TextBox();
            label6 = new Label();
            tbAddress = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(800, 38);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Create Client";
            lbTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 101);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Client ID";
            // 
            // lbid
            // 
            lbid.AutoSize = true;
            lbid.Location = new Point(278, 101);
            lbid.Name = "lbid";
            lbid.Size = new Size(0, 25);
            lbid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 151);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(278, 145);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(408, 31);
            tbFirstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 208);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(278, 202);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(408, 31);
            tbLastName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 268);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(278, 262);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(408, 31);
            tbEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 326);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(278, 323);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(408, 31);
            tbPhone.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 386);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(278, 383);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(408, 31);
            tbAddress.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(278, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(434, 435);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 515);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbAddress);
            Controls.Add(label6);
            Controls.Add(tbPhone);
            Controls.Add(label5);
            Controls.Add(tbEmail);
            Controls.Add(label4);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(lbid);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Name = "CreateEditForm";
            Text = "Create Client";
            Load += CreateEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label label1;
        private Label lbid;
        private Label label2;
        private TextBox tbFirstName;
        private Label label3;
        private TextBox tbLastName;
        private Label label4;
        private TextBox tbEmail;
        private Label label5;
        private TextBox tbPhone;
        private Label label6;
        private TextBox tbAddress;
        private Button btnSave;
        private Button btnCancel;
    }
}