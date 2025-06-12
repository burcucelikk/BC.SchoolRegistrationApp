namespace BC.SchoolRegistrationApp.UI
{
    public partial class Home : Form
    {
        Students students;
        Teachers teachers;
        public Home()
        {
            InitializeComponent();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (students == null || students.IsDisposed)
            {
                students = new Students();
                this.Hide();
                students.Show();
            }
            else
                students.BringToFront();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (teachers == null || teachers.IsDisposed)
            {
                teachers = new Teachers();
                this.Hide();
                teachers.Show();
            }
            else
                teachers.BringToFront();
        }
    }
}
