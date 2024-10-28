namespace dtc225180314
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSearch = new TextBox();
            txtname = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label3 = new Label();
            txtsdt = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            btnadd = new Button();
            btnup = new Button();
            btndelete = new Button();
            btnload = new Button();
            btnsearch = new Button();
            grvdata = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grvdata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 20);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm Kiếm";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(101, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(564, 23);
            txtSearch.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.Location = new Point(99, 111);
            txtname.Name = "txtname";
            txtname.Size = new Size(240, 23);
            txtname.TabIndex = 3;
            txtname.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "NCC";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(99, 62);
            txtid.Name = "txtid";
            txtid.Size = new Size(240, 23);
            txtid.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 62);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 4;
            label3.Text = "Mã NCC";
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(488, 62);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(177, 23);
            txtsdt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 62);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 8;
            label4.Text = "SDT";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(488, 111);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(177, 23);
            txtemail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 119);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(99, 170);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(605, 23);
            txtaddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 170);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Địa Chỉ";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(99, 222);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 12;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnup
            // 
            btnup.Location = new Point(264, 222);
            btnup.Name = "btnup";
            btnup.Size = new Size(75, 23);
            btnup.TabIndex = 13;
            btnup.Text = "Update";
            btnup.UseVisualStyleBackColor = true;
            btnup.Click += btnup_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(454, 222);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 14;
            btndelete.Text = "delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnload
            // 
            btnload.Location = new Point(600, 222);
            btnload.Name = "btnload";
            btnload.Size = new Size(75, 23);
            btnload.TabIndex = 15;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(697, 20);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 23);
            btnsearch.TabIndex = 16;
            btnsearch.Text = "Tìm Kiếm";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // grvdata
            // 
            grvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvdata.Location = new Point(12, 251);
            grvdata.Name = "grvdata";
            grvdata.Size = new Size(747, 173);
            grvdata.TabIndex = 17;
            grvdata.CellClick += grvdata_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grvdata);
            Controls.Add(btnsearch);
            Controls.Add(btnload);
            Controls.Add(btndelete);
            Controls.Add(btnup);
            Controls.Add(btnadd);
            Controls.Add(txtaddress);
            Controls.Add(label6);
            Controls.Add(txtsdt);
            Controls.Add(label4);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private TextBox txtname;
        private Label label2;
        private TextBox txtid;
        private Label label3;
        private TextBox txtsdt;
        private Label label4;
        private TextBox txtemail;
        private Label label5;
        private TextBox txtaddress;
        private Label label6;
        private Button btnadd;
        private Button btnup;
        private Button btndelete;
        private Button btnload;
        private Button btnsearch;
        private DataGridView grvdata;
    }
}
