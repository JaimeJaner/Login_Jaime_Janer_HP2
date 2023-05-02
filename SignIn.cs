using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Jaime_Janer_HP2
{
    public partial class SignIn : Form
    {

        int intentos = 0;
        List<User> usuarios = User.usuarios;
        User user;

        public SignIn()
        {
            InitializeComponent();
            leerArc();
            
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            bool ok = false;


            foreach (User u in usuarios)
            {
                if (txt_siUsuario.Text.Trim() == u.user)
                {
                    if (txt_siContraseña.Text.Trim() == u.password)
                    {
                        user = u;
                        ok = true;
                        break;
                    }
                    else
                    {
                        ok = false;


                    }
                }
                else
                {
                    ok = false;
                }
            }

            if (ok)
            {

                MessageBox.Show("Bienvenido");
                Application.Exit();


            }
            else
            {
                intentos++;

                if (intentos >= 3)
                {
                    MessageBox.Show("CUENTA BLOQUEADA.");
                    Application.Exit();
                }

                MessageBox.Show("El usuario o la contraseña estan incorrectas");
            }

        }

        private void Atrás_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }

        public void llenarArc()
        {

            StreamWriter sw = new StreamWriter("..\\..\\users.txt");

            foreach (User u in usuarios)
            {
                sw.WriteLine($"{u.id}|{u.user}|{u.password}");
            }
            sw.Close();

        }

        public void leerArc()
        {
            StreamReader sr = new StreamReader("..\\..\\users.txt");
            string linea;
            linea = sr.ReadLine();
            bool usuarioRepetido = false;
            while (linea != null)
            {
                string[] vec = linea.Split('|');
                try
                {
                    foreach (User u in usuarios)
                    {
                        if (u.user == vec[1])
                        {
                            usuarioRepetido = true;
                        }
                    }

                    if (usuarioRepetido == false)
                    {
                        usuarios.Add(new User(Convert.ToInt32(vec[0]), vec[1], vec[2]));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }

                linea = sr.ReadLine();
            }
            sr.Close();
        }
    }
}
