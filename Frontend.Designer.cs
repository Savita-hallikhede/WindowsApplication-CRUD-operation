namespace WindowsFormsApp1
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.First_name = new System.Windows.Forms.Label();
            this.txt_Lname = new System.Windows.Forms.TextBox();
            this.Last_name = new System.Windows.Forms.Label();
            this.txt_Contactno = new System.Windows.Forms.TextBox();
            this.Contact_No = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            this.txt__search = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gv_display = new System.Windows.Forms.DataGridView();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_display)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Fname
            // 
            this.txt_Fname.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.Location = new System.Drawing.Point(270, 175);
            this.txt_Fname.Multiline = true;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(268, 53);
            this.txt_Fname.TabIndex = 4;
            this.txt_Fname.TextChanged += new System.EventHandler(this.txt_Fname_TextChanged);
            // 
            // First_name
            // 
            this.First_name.AutoSize = true;
            this.First_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.First_name.Location = new System.Drawing.Point(6, 162);
            this.First_name.Name = "First_name";
            this.First_name.Size = new System.Drawing.Size(190, 38);
            this.First_name.TabIndex = 3;
            this.First_name.Text = "First_name";
            // 
            // txt_Lname
            // 
            this.txt_Lname.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname.Location = new System.Drawing.Point(270, 266);
            this.txt_Lname.Multiline = true;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.Size = new System.Drawing.Size(268, 48);
            this.txt_Lname.TabIndex = 6;
            // 
            // Last_name
            // 
            this.Last_name.AutoSize = true;
            this.Last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last_name.Location = new System.Drawing.Point(6, 276);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(187, 38);
            this.Last_name.TabIndex = 5;
            this.Last_name.Text = "Last_name";
            // 
            // txt_Contactno
            // 
            this.txt_Contactno.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Contactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contactno.Location = new System.Drawing.Point(270, 357);
            this.txt_Contactno.Multiline = true;
            this.txt_Contactno.Name = "txt_Contactno";
            this.txt_Contactno.Size = new System.Drawing.Size(268, 43);
            this.txt_Contactno.TabIndex = 8;
            // 
            // Contact_No
            // 
            this.Contact_No.AutoSize = true;
            this.Contact_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_No.Location = new System.Drawing.Point(6, 362);
            this.Contact_No.Name = "Contact_No";
            this.Contact_No.Size = new System.Drawing.Size(200, 38);
            this.Contact_No.TabIndex = 7;
            this.Contact_No.Text = "Contact_No";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.SystemColors.Info;
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(270, 466);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(268, 114);
            this.txt_address.TabIndex = 10;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(6, 466);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(145, 38);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(6, 638);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(132, 38);
            this.Gender.TabIndex = 11;
            this.Gender.Text = "Gender";
            // 
            // combo_gender
            // 
            this.combo_gender.BackColor = System.Drawing.SystemColors.Info;
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "--Select--",
            "Male",
            "Female",
            "Others"});
            this.combo_gender.Location = new System.Drawing.Point(270, 638);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.Size = new System.Drawing.Size(286, 24);
            this.combo_gender.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(147, 728);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(121, 65);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.ADD_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Red;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(322, 728);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 65);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.UseWaitCursor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Yellow;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(522, 728);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 65);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(705, 728);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(125, 65);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(559, 175);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 25);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            // 
            // txt__search
            // 
            this.txt__search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt__search.Location = new System.Drawing.Point(640, 169);
            this.txt__search.Multiline = true;
            this.txt__search.Name = "txt__search";
            this.txt__search.Size = new System.Drawing.Size(257, 38);
            this.txt__search.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1029, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // gv_display
            // 
            this.gv_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_display.Location = new System.Drawing.Point(564, 230);
            this.gv_display.Name = "gv_display";
            this.gv_display.RowHeadersWidth = 51;
            this.gv_display.RowTemplate.Height = 24;
            this.gv_display.Size = new System.Drawing.Size(503, 418);
            this.gv_display.TabIndex = 21;
            this.gv_display.SelectionChanged += new System.EventHandler(this.gv_display_SelectionChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(283, 127);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(12, 16);
            this.lbl_id.TabIndex = 22;
            this.lbl_id.Text = "*";
            this.lbl_id.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Red;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(322, 728);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(132, 65);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.UseWaitCursor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(147, 728);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 65);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(903, 168);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 40);
            this.btn_search.TabIndex = 25;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Econtact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 862);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.gv_display);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt__search);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.txt_Contactno);
            this.Controls.Add(this.Contact_No);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.Last_name);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.First_name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Econtact";
            this.Text = "Econtact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.Label First_name;
        private System.Windows.Forms.TextBox txt_Lname;
        private System.Windows.Forms.Label Last_name;
        private System.Windows.Forms.TextBox txt_Contactno;
        private System.Windows.Forms.Label Contact_No;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TextBox txt__search;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView gv_display;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
    }
}

