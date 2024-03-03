namespace TP03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OUTPUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void INPUT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            OUTPUT.Text = "Halo " + INPUT.Text;
        }
    }
}
