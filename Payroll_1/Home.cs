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
            agregarNuevasDeducciones frm = new agregarNuevasDeducciones();
            frm.Show();
            this.Hide();
        }

        private void btnAsignarDeducciones_Click(object sender, EventArgs e)
        {
            asignarDeduccionesEmpleado frm = new asignarDeduccionesEmpleado();
            frm.Show();
            this.Hide();
        }
    }
}
