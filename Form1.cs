namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCreateObj_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = txtBrand.Text;
                string model = txtModel.Text;
                decimal price;
                if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Invalid Input!");
                    return;
                }
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Invalid Price!");
                    return;
                }

                CellPhone phone = new CellPhone();
                phone.Brand = brand;
                phone.Model = model;
                phone.Price = price;

                lblBrand.Text = phone.Brand;
                lblModel.Text = phone.Model;
                lblPrice.Text = phone.Price.ToString("c");
            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
