﻿namespace MegaDesk_3_DalePerreault
{
    partial class AddQuote
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
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.drawTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rushCheckBox = new System.Windows.Forms.CheckBox();
            this.rushComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.surfaceComboBox = new System.Windows.Forms.ComboBox();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(44, 34);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(124, 20);
            this.custNameLabel.TabIndex = 0;
            this.custNameLabel.Text = "Customer Name";
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(282, 31);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(284, 26);
            this.custNameBox.TabIndex = 1;
            // 
            // drawTextBox
            // 
            this.drawTextBox.Location = new System.Drawing.Point(445, 211);
            this.drawTextBox.Name = "drawTextBox";
            this.drawTextBox.Size = new System.Drawing.Size(121, 26);
            this.drawTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "# of Drawers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surface Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rush Order?";
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(445, 151);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(121, 26);
            this.depthTextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desk Depth";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(445, 91);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(121, 26);
            this.widthTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Desk Width";
            // 
            // rushCheckBox
            // 
            this.rushCheckBox.AutoSize = true;
            this.rushCheckBox.Location = new System.Drawing.Point(384, 340);
            this.rushCheckBox.Name = "rushCheckBox";
            this.rushCheckBox.Size = new System.Drawing.Size(22, 21);
            this.rushCheckBox.TabIndex = 6;
            this.rushCheckBox.UseVisualStyleBackColor = true;
            this.rushCheckBox.CheckStateChanged += new System.EventHandler(this.rusCheckBox_click);
            // 
            // rushComboBox
            // 
            this.rushComboBox.DisplayMember = "3,5,7";
            this.rushComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushComboBox.Enabled = false;
            this.rushComboBox.FormattingEnabled = true;
            this.rushComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushComboBox.Location = new System.Drawing.Point(445, 333);
            this.rushComboBox.Name = "rushComboBox";
            this.rushComboBox.Size = new System.Drawing.Size(121, 28);
            this.rushComboBox.TabIndex = 7;
            this.rushComboBox.ValueMember = "3,5,7";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(384, 411);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 18;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(491, 411);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_click);
            // 
            // surfaceComboBox
            // 
            this.surfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceComboBox.FormattingEnabled = true;
            this.surfaceComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceComboBox.Location = new System.Drawing.Point(445, 271);
            this.surfaceComboBox.Name = "surfaceComboBox";
            this.surfaceComboBox.Size = new System.Drawing.Size(121, 28);
            this.surfaceComboBox.TabIndex = 5;
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk_3_DalePerreault.Desk);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 529);
            this.Controls.Add(this.surfaceComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rushComboBox);
            this.Controls.Add(this.rushCheckBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drawTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.custNameLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.TextBox drawTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rushCheckBox;
        private System.Windows.Forms.ComboBox rushComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox surfaceComboBox;
        private System.Windows.Forms.BindingSource deskBindingSource;
    }
}