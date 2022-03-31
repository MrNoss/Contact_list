namespace Contact_list
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
            this.Add_contact = new System.Windows.Forms.Button();
            this.Delete_contact = new System.Windows.Forms.Button();
            this.Show_contact = new System.Windows.Forms.Button();
            this.Clear_Text = new System.Windows.Forms.Button();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.contacts_data = new System.Windows.Forms.DataGridView();
            this.Edit_contact = new System.Windows.Forms.Button();
            this.Type_lable = new System.Windows.Forms.Label();
            this.Type_menu = new System.Windows.Forms.ComboBox();
            this.Search_bar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contacts_data)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_contact
            // 
            this.Add_contact.Location = new System.Drawing.Point(242, 47);
            this.Add_contact.Name = "Add_contact";
            this.Add_contact.Size = new System.Drawing.Size(75, 23);
            this.Add_contact.TabIndex = 0;
            this.Add_contact.Text = "Add contact";
            this.Add_contact.UseVisualStyleBackColor = true;
            this.Add_contact.Click += new System.EventHandler(this.Add_contact_Click);
            // 
            // Delete_contact
            // 
            this.Delete_contact.Location = new System.Drawing.Point(326, 83);
            this.Delete_contact.Name = "Delete_contact";
            this.Delete_contact.Size = new System.Drawing.Size(75, 23);
            this.Delete_contact.TabIndex = 1;
            this.Delete_contact.Text = "Delete";
            this.Delete_contact.UseVisualStyleBackColor = true;
            this.Delete_contact.Click += new System.EventHandler(this.Delete_contact_Click);
            // 
            // Show_contact
            // 
            this.Show_contact.Location = new System.Drawing.Point(326, 48);
            this.Show_contact.Name = "Show_contact";
            this.Show_contact.Size = new System.Drawing.Size(75, 23);
            this.Show_contact.TabIndex = 2;
            this.Show_contact.Text = "See...";
            this.Show_contact.UseVisualStyleBackColor = true;
            this.Show_contact.Click += new System.EventHandler(this.Show_contact_Click);
            // 
            // Clear_Text
            // 
            this.Clear_Text.Location = new System.Drawing.Point(242, 78);
            this.Clear_Text.Name = "Clear_Text";
            this.Clear_Text.Size = new System.Drawing.Size(75, 23);
            this.Clear_Text.TabIndex = 3;
            this.Clear_Text.Text = "Clear";
            this.Clear_Text.UseVisualStyleBackColor = true;
            this.Clear_Text.Click += new System.EventHandler(this.Clear_Text_Click);
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(118, 50);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(100, 20);
            this.Name_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number";
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(117, 76);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(100, 20);
            this.Phone_text.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // Email_text
            // 
            this.Email_text.Location = new System.Drawing.Point(117, 102);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(100, 20);
            this.Email_text.TabIndex = 8;
            // 
            // contacts_data
            // 
            this.contacts_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contacts_data.Location = new System.Drawing.Point(36, 217);
            this.contacts_data.Name = "contacts_data";
            this.contacts_data.Size = new System.Drawing.Size(400, 150);
            this.contacts_data.TabIndex = 10;
            // 
            // Edit_contact
            // 
            this.Edit_contact.Location = new System.Drawing.Point(242, 109);
            this.Edit_contact.Name = "Edit_contact";
            this.Edit_contact.Size = new System.Drawing.Size(75, 23);
            this.Edit_contact.TabIndex = 11;
            this.Edit_contact.Text = "Edit contact";
            this.Edit_contact.UseVisualStyleBackColor = true;
            this.Edit_contact.Click += new System.EventHandler(this.Edit_contact_Click);
            // 
            // Type_lable
            // 
            this.Type_lable.AutoSize = true;
            this.Type_lable.Location = new System.Drawing.Point(36, 138);
            this.Type_lable.Name = "Type_lable";
            this.Type_lable.Size = new System.Drawing.Size(31, 13);
            this.Type_lable.TabIndex = 12;
            this.Type_lable.Text = "Type";
            // 
            // Type_menu
            // 
            this.Type_menu.FormattingEnabled = true;
            this.Type_menu.Items.AddRange(new object[] {
            "Friends",
            "Family",
            "Work"});
            this.Type_menu.Location = new System.Drawing.Point(117, 135);
            this.Type_menu.Name = "Type_menu";
            this.Type_menu.Size = new System.Drawing.Size(101, 21);
            this.Type_menu.TabIndex = 14;
            // 
            // Search_bar
            // 
            this.Search_bar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Search_bar.Location = new System.Drawing.Point(326, 191);
            this.Search_bar.Name = "Search_bar";
            this.Search_bar.Size = new System.Drawing.Size(100, 20);
            this.Search_bar.TabIndex = 15;
            this.Search_bar.TextChanged += new System.EventHandler(this.Search_bar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Search by name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Search_bar);
            this.Controls.Add(this.Type_menu);
            this.Controls.Add(this.Type_lable);
            this.Controls.Add(this.Edit_contact);
            this.Controls.Add(this.contacts_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Phone_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.Clear_Text);
            this.Controls.Add(this.Show_contact);
            this.Controls.Add(this.Delete_contact);
            this.Controls.Add(this.Add_contact);
            this.Name = "Form1";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contacts_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_contact;
        private System.Windows.Forms.Button Delete_contact;
        private System.Windows.Forms.Button Show_contact;
        private System.Windows.Forms.Button Clear_Text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.DataGridView contacts_data;
        private System.Windows.Forms.Button Edit_contact;
        private System.Windows.Forms.Label Type_lable;
        private System.Windows.Forms.ComboBox Type_menu;
        private System.Windows.Forms.TextBox Search_bar;
        private System.Windows.Forms.Label label4;
    }
}

