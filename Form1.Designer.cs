﻿
namespace Login_Jaime_Janer_HP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Bienvenido = new System.Windows.Forms.Label();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Bienvenido
            // 
            this.lbl_Bienvenido.AutoSize = true;
            this.lbl_Bienvenido.Font = new System.Drawing.Font("Anger Styles", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenido.Location = new System.Drawing.Point(131, 54);
            this.lbl_Bienvenido.Name = "lbl_Bienvenido";
            this.lbl_Bienvenido.Size = new System.Drawing.Size(276, 108);
            this.lbl_Bienvenido.TabIndex = 2;
            this.lbl_Bienvenido.Text = "Bienvenido";
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Location = new System.Drawing.Point(297, 199);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(127, 58);
            this.btn_Registrarse.TabIndex = 4;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(94, 199);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(127, 58);
            this.btn_IniciarSesion.TabIndex = 3;
            this.btn_IniciarSesion.Text = "Inicio de Sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 323);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Bienvenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Bienvenido;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.Button btn_IniciarSesion;
    }
}

