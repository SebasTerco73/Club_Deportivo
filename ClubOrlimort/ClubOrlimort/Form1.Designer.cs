namespace ClubOrlimort
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lblLogin = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(83, 157);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(174, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(83, 199);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(174, 23);
            txtPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(112, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(103, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = SystemColors.ActiveCaption;
            lblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Crimson;
            lblLogin.Location = new Point(49, 245);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(245, 21);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Usuario y/o contraseña incorrecto";
            lblLogin.Visible = false;
            lblLogin.Click += lblLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 360);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "¿No posee usuario?";
            // 
            // button1
            // 
            button1.Location = new Point(112, 395);
            button1.Name = "button1";
            button1.Size = new Size(103, 22);
            button1.TabIndex = 6;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 487);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Ingreso Orlimort";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Label lblLogin;
        private Label label1;
        private Button button1;
    }
}
