using Domain;

namespace MainScreen
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();

            comboBox1 = new ComboBox();
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
            var  = comboBox1.
        }
    }
}
