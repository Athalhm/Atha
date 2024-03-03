using System;
using System.Windows.Forms;

namespace tp_mod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            string inputNama = textBoxNama.Text;

            if (!string.IsNullOrWhiteSpace(inputNama))
            {
                labelHasil.Text = "Halo " + inputNama + " yang tampan dan berani";
            }
            else
            {
                MessageBox.Show("Mohon isi nama praktikan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
