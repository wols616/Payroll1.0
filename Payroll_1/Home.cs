using Payroll_1.Formularios;

namespace Payroll_1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            agregarDeducciones frm = new agregarDeducciones();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
