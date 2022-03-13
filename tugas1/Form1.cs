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

            if (tBoxInput.Text.Substring(0, 4).ToLower() == "isi:")
            {
                lblOutput.Text = tBoxInput.Text.Substring(4);
            }
            if (tBoxInput.Text.ToLower() == "hide")
            {
                lblOutput.Hide();
            }
            else if (tBoxInput.Text.ToLower() == "shown")
            {
                lblOutput.Show();
            }

            else if (tBoxInput.Text.Substring(0, 6).ToLower() == "warna:")
            {



                if (tBoxInput.Text.Substring(6) == "default")
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

            }
            
        }
        private void tBoxInput_TextChanged(object sender, EventArgs e)
        {
        }

        
    }
}