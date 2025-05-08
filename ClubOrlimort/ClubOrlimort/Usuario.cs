using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubOrlimort
{
    internal class Usuario
    {
        private int idUsuario;
        private string nombreUser, password;
        private bool estado;

        public Usuario(int idUsuario, string nombreUser, string password, bool estado)
        {
            this.idUsuario = idUsuario;
            this.nombreUser = nombreUser;
            this.password = password;
            this.estado = true;
        }
    }
}
