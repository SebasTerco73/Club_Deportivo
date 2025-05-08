namespace ClubOrlimort
{
    partial class frmRegistroAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUserPass = new TextBox();
            txtUserNew = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtUserPass
            // 
            txtUserPass.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUserPass.Location = new Point(77, 96);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PlaceholderText = "Ingrese su Contraseña";
            txtUserPass.Size = new Size(186, 30);
            txtUserPass.TabIndex = 2;
            // 
            // txtUserNew
            // 
            txtUserNew.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUserNew.Location = new Point(77, 43);
            txtUserNew.Name = "txtUserNew";
            txtUserNew.PlaceholderText = "Ingrese su Usuario";
            txtUserNew.Size = new Size(186, 30);
            txtUserNew.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Desktop;
            btnLogin.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(104, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Registrarme";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmRegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 232);
            Controls.Add(btnLogin);
            Controls.Add(txtUserNew);
            Controls.Add(txtUserPass);
            Name = "frmRegistroAdmin";
            Text = "RegistroAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserPass;
        private TextBox txtUserNew;
        private Button btnLogin;
    }
}