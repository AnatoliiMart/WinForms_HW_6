namespace WinForms_HW_6
{
    public partial class Form2 : Form
    {
        public Product _product = new();


        public Form? MainForm { get; set; }
        

        public Form2() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFormCorrect())
            {
                _product = new Product(textBox_description.Text, Convert.ToDouble(textBox_price.Text),
                                         textBox_characteristics.Text, textBox_productName.Text);
                Close();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Неверно введенные данные!!!", "Предупреждение!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool IsFormCorrect() => textBox_description.Text != string.Empty &&
                                        textBox_price.Text != string.Empty &&
                                        textBox_characteristics.Text != string.Empty &&
                                        textBox_productName.Text != string.Empty;
        
    }
}
