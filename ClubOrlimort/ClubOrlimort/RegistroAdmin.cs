using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubOrlimort
{
    public partial class frmRegistroAdmin : Form
    {
        public frmRegistroAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable tablaRegistro = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaRegistro = dato.Reg_Usu(txtUserNew.Text, txtUserPass.Text);
            if (tablaRegistro.Rows.Count > 0)
            {
                MessageBox.Show("Registrado exitosamente");
            }
                     
        }
    }
}
