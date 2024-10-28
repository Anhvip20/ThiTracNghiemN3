namespace dtc225180314
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnload.PerformClick();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbcontexxt())
            {
                var product = context.suppliers.Where(p => p.name.Contains(txtSearch.Text)).ToList();
                grvdata.DataSource = product;
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (var n = new SupplierDbcontexxt())
            {
                txtid.Text = "";
                txtname.Text = "";
                txtsdt.Text = "";
                txtemail.Text = "";
                txtaddress.Text = "";

                var context = n.suppliers.ToList();
                grvdata.DataSource = context;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbcontexxt())
            {
                var product = context.suppliers.FirstOrDefault(p => p.id == int.Parse(txtid.Text));
                if (product != null)
                {
                    context.suppliers.Remove(product);
                    context.SaveChanges();
                }
            }
            btnload.PerformClick();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (var n = new SupplierDbcontexxt())
            {
                var context = new Supplier
                {
                    name = txtname.Text,
                    sdt = int.Parse(txtsdt.Text),
                    email = txtemail.Text,
                    daichi = txtaddress.Text,
                };
                n.suppliers.Add(context);
                n.SaveChanges();
            }
            btnload.PerformClick();
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            using (var context = new SupplierDbcontexxt())
            {
                var product = context.suppliers.FirstOrDefault(p => p.id == int.Parse(txtid.Text));

                if (product != null)
                {
                    product.name = txtname.Text;
                    product.sdt = int.Parse(txtsdt.Text);
                    product.email = txtemail.Text;
                    product.daichi = txtaddress.Text;
                    context.SaveChanges();
                }
                btnload.PerformClick();            }
        }

        private void grvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int stt = grvdata.CurrentCell.RowIndex;
            txtid.Text = grvdata.Rows[stt].Cells[0].Value.ToString();
            txtname.Text = grvdata.Rows[stt].Cells[1].Value.ToString();
            txtsdt.Text = grvdata.Rows[stt].Cells[2].Value.ToString();
            txtemail.Text = grvdata.Rows[stt].Cells[3].Value.ToString();
            txtaddress.Text = grvdata.Rows[stt].Cells[4].Value.ToString();
        }
    }
}
