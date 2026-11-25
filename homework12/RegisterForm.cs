namespace homework12
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Go to register");
            RegisterForm myform = new RegisterForm();
            myform.ShowDialog();
        }
    }
}
