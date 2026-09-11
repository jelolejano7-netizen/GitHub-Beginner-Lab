namespace StudentProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Connect the button to the Click event
            btnEnter.Click += btnEnter_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string studentProfile = txtStudentProfile.Text;

            if (string.IsNullOrWhiteSpace(studentProfile))
            {
                MessageBox.Show(
                    "Please enter your student profile.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            MessageBox.Show(
                "Student Profile - \n\n" + studentProfile,
                "Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Number: 0908115470");
        }
    }
}
