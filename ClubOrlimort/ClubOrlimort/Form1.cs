using System.Data;

namespace ClubOrlimort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLogin.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUser.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                lblLogin.Text = "Usuario y/o password incorrecto";
                lblLogin.Visible = true;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistroAdmin frmRegistroAdmin = new frmRegistroAdmin();
            frmRegistroAdmin.Show();
        }
    }
}
