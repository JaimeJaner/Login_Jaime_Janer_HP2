using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_Jaime_Janer_HP2
{
    public partial class SignUp : Form
    {
        List<User> users = User.usuarios;
        public SignUp()
        {
            InitializeComponent();
            leerArc();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            int id = 0;
            bool idRepetido = false;
            bool userRepetido = false;

            if (txt_User.Text.Trim() != "" && txt_Password.Text.Trim() != "")
            {
                /* do
                 {
                     id = n.Next(1000000, 9999999);

                     if (users.Count > 0)
                     {
                         foreach (User u in users)
                         {

                             if (id == u.id)
                             {
                                 idRepetido = true;
                                 break;
                             }


                         }
                     }

                 } while (idRepetido == true);
                */




                if (txt_Confirmar.Text == txt_Password.Text)
                {
                    foreach (User u in users)
                    {
                        if (txt_User.Text.Equals(u.user))
                        {
                            userRepetido = true;
                            MessageBox.Show("El nombre de usuario ya existe, prueba con otro.");
                            txt_User.Clear();
                            txt_User.Focus();
                            txt_Password.Clear();
                            txt_Confirmar.Clear();
                            break;
                        }
                    }


                    if (userRepetido == false)
                    {
                        users.Add(new User(id, txt_User.Text, txt_Password.Text));
                        llenarArc();
                        MessageBox.Show("Te has registrado correctamente.");
                        txt_User.Clear();
                        txt_Password.Clear();
                        txt_Confirmar.Clear();

                        SignIn si = new SignIn();
                        si.Show();
                        Hide();

                    }
                }

                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir; inténtalo de nuevo.");
                    txt_Password.Clear();
                    txt_Confirmar.Clear();
                }


            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Usuario y contraseña válida.");
                txt_Password.Clear();
                txt_User.Clear();
                txt_Confirmar.Clear();
                txt_User.Focus();
            }
        }

        public void llenarArc()
        {
            StreamWriter sw = new StreamWriter("..\\..\\users.txt");

            foreach (User u in users)
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
                    foreach (User u in users)
                    {
                        if (u.user == vec[1])
                        {
                            usuarioRepetido = true;
                        }
                    }

                    if (usuarioRepetido == false)
                    {
                        users.Add(new User(Convert.ToInt32(vec[0]), vec[1], vec[2]));
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

        private void btn_SuAtras_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            Hide();
        }
    }
}
