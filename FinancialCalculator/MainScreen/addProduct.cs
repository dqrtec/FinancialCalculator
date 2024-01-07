using Domain;

namespace MainScreen
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();

            comboBox1.DataSource = new List<TypeShopping>() { TypeShopping.Me, TypeShopping.House, TypeShopping.Other };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void addProduct_KeyUp(object sender, KeyEventArgs e)
        {
            Save();
        }

        public void Save()
        {
            string name = textBox1.Text.ToUpper();
            DateTime date = dateTimePicker1.Value;
            var typePerson = comboBox1.SelectedValue;
            double valor = Double.Parse(domainUpDown2.Text);
            int parcelas = Int16.Parse(domainUpDown1.Text);

            //Save

            //Add on excel
        }
    }
}
