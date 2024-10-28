namespace Dtc225180229
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
            txtsearch = new TextBox();
            txtid = new TextBox();
            label2 = new Label();
            txtphone = new TextBox();
            label3 = new Label();
            txtemail = new TextBox();
            label4 = new Label();
            txtname = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            btnadd = new Button();
            btnupdate = new Button();
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
            label1.Location = new Point(9, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm KIếm";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(73, 9);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(599, 23);
            txtsearch.TabIndex = 1;
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(124, 61);
            txtid.Name = "txtid";
            txtid.Size = new Size(177, 23);
            txtid.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã Nhà phân Phối";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(445, 61);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(194, 23);
            txtphone.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 64);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Điện Thoại";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(445, 113);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(194, 23);
            txtemail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 126);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Emai";
            // 
            // txtname
            // 
            txtname.Location = new Point(124, 118);
            txtname.Name = "txtname";
            txtname.Size = new Size(177, 23);
            txtname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 118);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 6;
            label5.Text = "Nhà Phân Phối";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(76, 173);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(658, 23);
            txtaddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 181);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Địa Chỉ";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(95, 221);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 12;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(256, 221);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 23);
            btnupdate.TabIndex = 13;
            btnupdate.Text = "sửa";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(490, 221);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 14;
            btndelete.Text = "Xóa";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnload
            // 
            btnload.Location = new Point(659, 221);
            btnload.Name = "btnload";
            btnload.Size = new Size(75, 23);
            btnload.TabIndex = 15;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(697, 12);
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
            grvdata.Location = new Point(57, 253);
            grvdata.Name = "grvdata";
            grvdata.Size = new Size(704, 185);
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
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtaddress);
            Controls.Add(label6);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(label2);
            Controls.Add(txtsearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dtc225180229";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtsearch;
        private TextBox txtid;
        private Label label2;
        private TextBox txtphone;
        private Label label3;
        private TextBox txtemail;
        private Label label4;
        private TextBox txtname;
        private Label label5;
        private TextBox txtaddress;
        private Label label6;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private Button btnload;
        private Button btnsearch;
        private DataGridView grvdata;
    }
}
