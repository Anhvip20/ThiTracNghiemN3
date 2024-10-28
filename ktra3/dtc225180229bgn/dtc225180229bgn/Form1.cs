using Dtc225180229;

namespace dtc225180229bgn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new Distributordbcontext())
            {
                var product = context.distributors.Where(p => p.name.Contains(txtsearch.Text)).ToList();
                grvdata.DataSource = product;
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            using (var context = new Distributordbcontext())
            {
                var product = context.distributors.FirstOrDefault(p => p.idnpp == int.Parse(txtid.Text));

                if (product != null)
                {
                    product.name = txtname.Text;
                    product.phone = int.Parse(txtphone.Text);
                    product.email = txtemail.Text;
                    product.address = txtaddress.Text;
                    context.SaveChanges();
                }
            }
            btnload.PerformClick();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (var n = new Distributordbcontext())
            {
                var context = new Distributor
                {
                    name = txtname.Text,
                    phone = int.Parse(txtphone.Text),
                    email = txtemail.Text,
                    address = txtaddress.Text,
                };
                n.distributors.Add(context);
                n.SaveChanges();
            }
            btnload.PerformClick();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            using (var n = new Distributordbcontext())
            {
                txtid.Text = "";
                txtname.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
                txtaddress.Text = "";

                var context = n.distributors.ToList();
                grvdata.DataSource = context;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnload.PerformClick();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (var context = new Distributordbcontext())
            {
                var product = context.distributors.FirstOrDefault(p => p.idnpp == int.Parse(txtid.Text));
                if (product != null)
                {
                    context.distributors.Remove(product);
                    context.SaveChanges();
                }
            }
            btnload.PerformClick();
        }
        
        private void grvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int stt = grvdata.CurrentCell.RowIndex;
            txtid.Text = grvdata.Rows[stt].Cells[0].Value.ToString();
            txtname.Text = grvdata.Rows[stt].Cells[1].Value.ToString();
            txtaddress.Text = grvdata.Rows[stt].Cells[3].Value.ToString();
            txtphone.Text = grvdata.Rows[stt].Cells[3].Value.ToString();
            txtemail.Text = grvdata.Rows[stt].Cells[4].Value.ToString();
        }
    }
}
