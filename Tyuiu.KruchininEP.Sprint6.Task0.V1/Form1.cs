using Tyuiu.KruchininEP.Sprint6.Task0.V1.Lib;
namespace Tyuiu.KruchininEP.Sprint6.Task0.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_KEP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы РППб25-1 Кручинин Евгений Павлович");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBox1.Text = Convert.ToString(ds.Calculate(3));
        }
    }
}
