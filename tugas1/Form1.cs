namespace tugas1
{
    public partial class FormAturWarna : Form
    {
        public FormAturWarna()
        {
            InitializeComponent();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void FormAturWarna_Load(object sender, EventArgs e)
        {
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            try
            { 
            if (tBoxInput.Text.Substring(0, 4).ToLower() == "isi:")
            {
                lblOutput.Text = tBoxInput.Text.Substring(4);
            }
           else if (tBoxInput.Text.ToLower() == "hide")
            {
                lblOutput.Hide();
            }
            else if (tBoxInput.Text.ToLower() == "shown")
            {
                lblOutput.Show();
            }
            else if (tBoxInput.Text.ToLower() == "perbesar")
            {
                lblOutput.Font = new Font(lblOutput.Font.Name, lblOutput.Font.Size + 1);
            }
            else if (tBoxInput.Text.ToLower() == "perkecil")
            {
                lblOutput.Font = new Font(lblOutput.Font.Name, lblOutput.Font.Size - 1);
            }
            else if (tBoxInput.Text.Substring(0, 6).ToLower() == "warna:")
            {
            }
            else if (tBoxInput.Text.Substring(6) == "default")
            {
                lblOutput.ForeColor = Color.Black;
            }
            else if (tBoxInput.Text.Substring(6) == "red")
            {
                lblOutput.ForeColor = Color.Red;
            }
            else if (tBoxInput.Text.Substring(6) == "blue")
            {
                lblOutput.ForeColor = Color.Blue;
            }
            else if (tBoxInput.Text.Substring(6) == "green")
            {
                lblOutput.ForeColor = Color.Green;
            }

            else if (tBoxInput.Text.ToLower() == "restart")
            {
                Application.Restart();
            }
        }
             catch (Exception keluar)
            {
                MessageBox.Show("Sytax Tidak Ditemukan!");
            } //
        }
        private void tBoxInput_TextChanged(object sender, EventArgs e)
        {
        }
       
    }
}



