
namespace Login_Jaime_Janer_HP2
{
    partial class SignUp
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
            this.lbl_confirmar = new System.Windows.Forms.Label();
            this.txt_Confirmar = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.btn_SuAtras = new System.Windows.Forms.Button();
            this.lbl_Registro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_confirmar
            // 
            this.lbl_confirmar.AutoSize = true;
            this.lbl_confirmar.Location = new System.Drawing.Point(87, 215);
            this.lbl_confirmar.Name = "lbl_confirmar";
            this.lbl_confirmar.Size = new System.Drawing.Size(108, 13);
            this.lbl_confirmar.TabIndex = 23;
            this.lbl_confirmar.Text = "Confirmar Contraseña";
            // 
            // txt_Confirmar
            // 
            this.txt_Confirmar.Location = new System.Drawing.Point(90, 231);
            this.txt_Confirmar.Name = "txt_Confirmar";
            this.txt_Confirmar.PasswordChar = '*';
            this.txt_Confirmar.Size = new System.Drawing.Size(210, 20);
            this.txt_Confirmar.TabIndex = 22;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(87, 176);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(61, 13);
            this.lbl_Password.TabIndex = 20;
            this.lbl_Password.Text = "Contraseña";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(87, 137);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(43, 13);
            this.lbl_User.TabIndex = 19;
            this.lbl_User.Text = "Usuario";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(90, 192);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(210, 20);
            this.txt_Password.TabIndex = 18;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(90, 153);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(210, 20);
            this.txt_User.TabIndex = 17;
            // 
            // btn_Registro
            // 
            this.btn_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registro.Location = new System.Drawing.Point(90, 278);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(210, 23);
            this.btn_Registro.TabIndex = 16;
            this.btn_Registro.Text = "Registrarse";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // btn_SuAtras
            // 
            this.btn_SuAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SuAtras.Location = new System.Drawing.Point(90, 317);
            this.btn_SuAtras.Name = "btn_SuAtras";
            this.btn_SuAtras.Size = new System.Drawing.Size(210, 23);
            this.btn_SuAtras.TabIndex = 24;
            this.btn_SuAtras.Text = "Atrás";
            this.btn_SuAtras.UseVisualStyleBackColor = true;
            this.btn_SuAtras.Click += new System.EventHandler(this.btn_SuAtras_Click);
            // 
            // lbl_Registro
            // 
            this.lbl_Registro.AutoSize = true;
            this.lbl_Registro.Font = new System.Drawing.Font("Anger Styles", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Registro.Location = new System.Drawing.Point(85, 9);
            this.lbl_Registro.Name = "lbl_Registro";
            this.lbl_Registro.Size = new System.Drawing.Size(240, 108);
            this.lbl_Registro.TabIndex = 25;
            this.lbl_Registro.Text = "Registro";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbl_Registro);
            this.Controls.Add(this.btn_SuAtras);
            this.Controls.Add(this.lbl_confirmar);
            this.Controls.Add(this.txt_Confirmar);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.btn_Registro);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_confirmar;
        private System.Windows.Forms.TextBox txt_Confirmar;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_Registro;
        private System.Windows.Forms.Button btn_SuAtras;
        private System.Windows.Forms.Label lbl_Registro;
    }
}