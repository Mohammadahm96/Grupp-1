namespace WinFormsApp1
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Focus();
            txtUserName.Clear();
            txtpassword.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text=="Grupp1" && txtpassword.Text == "12345")

            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password or username");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
                txtUserName.Focus();
            }
        }


        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
   
    }
}