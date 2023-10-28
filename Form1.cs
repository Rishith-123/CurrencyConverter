namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        string convertfromcurrency, convertintocurrency;
        double currencyfrom, currencyto;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConvertCurrency()
        {
            string value;
            value = textBox1.Text;
            // MessageBox. Show("value: " + value. ToString());

            convertintocurrency = comboBox2.Text;
            if (String.Equals(convertintocurrency, "USD"))
            {
                currencyto = Math.Round((System.Convert.ToDouble(value) / 83.23),3);
                MessageBox.Show("USD Value equvalent to INR is:" + currencyto.ToString());
                if (String.Equals(convertintocurrency, "EUR"))
                {
                    currencyto = Math.Round((System.Convert.ToDouble(value) / 87.73),3);
                    MessageBox.Show("Euro Value equvalent to INR is:" + currencyto.ToString());
                }

                if (String.Equals(convertintocurrency, "SIN"))
                {
                    currencyto =Math.Round((System.Convert.ToDouble(value) / 60.63),3);
                    MessageBox.Show("Singapore dollar Value equvalent to INR is:" + currencyto.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}