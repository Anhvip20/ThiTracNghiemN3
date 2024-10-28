namespace dtc225180229bgn
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
            txtname = new TextBox();
            label2 = new Label();
            txtid = new TextBox();
            label3 = new Label();
            txtphone = new TextBox();
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
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(80, 22);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(637, 23);
            txtsearch.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.Location = new Point(104, 146);
            txtname.Name = "txtname";
            txtname.Size = new Size(266, 23);
            txtname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 146);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhà Phân Phối";
            // 
            // txtid
            // 
            txtid.Enabled = false;
            txtid.Location = new Point(98, 69);
            txtid.Name = "txtid";
            txtid.Size = new Size(266, 23);
            txtid.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 75);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Mã Phân Phối";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(490, 72);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(266, 23);
            txtphone.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 72);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 8;
            label4.Text = "SDT";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(490, 135);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(266, 23);
            txtemail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(442, 143);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(104, 197);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(637, 23);
            txtaddress.TabIndex = 11;
            txtaddress.TextChanged += textBox6_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 200);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Địa Chỉ";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(97, 242);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 12;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnup
            // 
            btnup.Location = new Point(250, 242);
            btnup.Name = "btnup";
            btnup.Size = new Size(75, 23);
            btnup.TabIndex = 13;
            btnup.Text = "Update";
            btnup.UseVisualStyleBackColor = true;
            btnup.Click += btnup_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(490, 242);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 14;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnload
            // 
            btnload.Location = new Point(629, 242);
            btnload.Name = "btnload";
            btnload.Size = new Size(75, 23);
            btnload.TabIndex = 15;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(723, 22);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 27);
            btnsearch.TabIndex = 16;
            btnsearch.Text = "Tìm Kiếm";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += button5_Click;
            // 
            // grvdata
            // 
            grvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvdata.Location = new Point(71, 271);
            grvdata.Name = "grvdata";
            grvdata.Size = new Size(670, 167);
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
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(txtemail);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(label3);
            Controls.Add(txtname);
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
        private TextBox txtname;
        private Label label2;
        private TextBox txtid;
        private Label label3;
        private TextBox txtphone;
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
