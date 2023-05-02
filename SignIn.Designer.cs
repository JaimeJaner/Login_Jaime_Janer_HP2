
namespace Login_Jaime_Janer_HP2
{
    partial class SignIn
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
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.Atrás = new System.Windows.Forms.Button();
            this.txt_siUsuario = new System.Windows.Forms.TextBox();
            this.txt_siContraseña = new System.Windows.Forms.TextBox();
            this.lbl_SiUsuario = new System.Windows.Forms.Label();
            this.lbl_SiContraseña = new System.Windows.Forms.Label();
            this.lbl_IniciarSesion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(107, 293);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(165, 25);
            this.btn_SignIn.TabIndex = 0;
            this.btn_SignIn.Text = "Inicia sesion";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // Atrás
            // 
            this.Atrás.Location = new System.Drawing.Point(107, 324);
            this.Atrás.Name = "Atrás";
            this.Atrás.Size = new System.Drawing.Size(165, 25);
            this.Atrás.TabIndex = 1;
            this.Atrás.Text = "Atrás";
            this.Atrás.UseVisualStyleBackColor = true;
            this.Atrás.Click += new System.EventHandler(this.Atrás_Click);
            // 
            // txt_siUsuario
            // 
            this.txt_siUsuario.Location = new System.Drawing.Point(107, 190);
            this.txt_siUsuario.Name = "txt_siUsuario";
            this.txt_siUsuario.Size = new System.Drawing.Size(165, 20);
            this.txt_siUsuario.TabIndex = 2;
            // 
            // txt_siContraseña
            // 
            this.txt_siContraseña.Location = new System.Drawing.Point(107, 229);
            this.txt_siContraseña.Name = "txt_siContraseña";
            this.txt_siContraseña.PasswordChar = '*';
            this.txt_siContraseña.Size = new System.Drawing.Size(165, 20);
            this.txt_siContraseña.TabIndex = 3;
            // 
            // lbl_SiUsuario
            // 
            this.lbl_SiUsuario.AutoSize = true;
            this.lbl_SiUsuario.Location = new System.Drawing.Point(104, 174);
            this.lbl_SiUsuario.Name = "lbl_SiUsuario";
            this.lbl_SiUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_SiUsuario.TabIndex = 4;
            this.lbl_SiUsuario.Text = "Usuario";
            // 
            // lbl_SiContraseña
            // 
            this.lbl_SiContraseña.AutoSize = true;
            this.lbl_SiContraseña.Location = new System.Drawing.Point(104, 213);
            this.lbl_SiContraseña.Name = "lbl_SiContraseña";
            this.lbl_SiContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_SiContraseña.TabIndex = 5;
            this.lbl_SiContraseña.Text = "Contraseña";
            // 
            // lbl_IniciarSesion
            // 
            this.lbl_IniciarSesion.AutoSize = true;
            this.lbl_IniciarSesion.Font = new System.Drawing.Font("Anger Styles", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IniciarSesion.Location = new System.Drawing.Point(43, 38);
            this.lbl_IniciarSesion.Name = "lbl_IniciarSesion";
            this.lbl_IniciarSesion.Size = new System.Drawing.Size(306, 108);
            this.lbl_IniciarSesion.TabIndex = 26;
            this.lbl_IniciarSesion.Text = "Inicia Sesión";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbl_IniciarSesion);
            this.Controls.Add(this.lbl_SiContraseña);
            this.Controls.Add(this.lbl_SiUsuario);
            this.Controls.Add(this.txt_siContraseña);
            this.Controls.Add(this.txt_siUsuario);
            this.Controls.Add(this.Atrás);
            this.Controls.Add(this.btn_SignIn);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button Atrás;
        private System.Windows.Forms.TextBox txt_siUsuario;
        private System.Windows.Forms.TextBox txt_siContraseña;
        private System.Windows.Forms.Label lbl_SiUsuario;
        private System.Windows.Forms.Label lbl_SiContraseña;
        private System.Windows.Forms.Label lbl_IniciarSesion;
    }
}