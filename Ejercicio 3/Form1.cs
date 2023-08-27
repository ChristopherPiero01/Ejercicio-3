namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parc1 = int.Parse(this.parc1.Text);
            int parc2 = int.Parse(this.parc2.Text);
            int parc3 = int.Parse(this.parc3.Text);
            int exafinal = int.Parse(this.exaFin.Text);
            int trabfinal = int.Parse(this.traFin.Text);

            double NF = 0.55 * (parc1 + parc2 + parc3) / 3 + 0.30 * exafinal + 0.15 * trabfinal;

            NotaFinal.Text = NF.ToString();
        }
    }
}