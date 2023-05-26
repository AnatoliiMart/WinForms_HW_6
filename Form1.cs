namespace WinForms_HW_6
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new();
        private List<Product> _salelist = new();


        private double totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox_productsInStock.DisplayMember = "ProductName";
            listBox_selectedProducts.DisplayMember = "ProductName";
        }

        private void button_addToSelection_Click(object sender, EventArgs e)
        {

            if (comboBox_productsInStock.SelectedItem != null)
            {
                _salelist.Add((Product)comboBox_productsInStock.SelectedItem);
                totalPrice += Convert.ToDouble(textBox_productPrice.Text);
                textBox_totalCost.Text = totalPrice.ToString();
                listBox_selectedProducts.Items.Add(comboBox_productsInStock.SelectedItem);
                comboBox_productsInStock.SelectedItem = null;
            }
            else
                MessageBox.Show("Не выбрано ни одного товара!", "Предупреждение",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox_productsInStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = from product in _products
                      where comboBox_productsInStock.SelectedItem == product
                      select product;

            foreach (var item in res)
                textBox_productPrice.Text = item.Price.ToString();
        }

        private void button_addProductToDataBase_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MainForm = this;
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                _products.Add(form2._product);
                comboBox_productsInStock.Items.Add(form2._product);
            }
        }
    }
}