using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace paZZword
{
    class PaZZwordValidator
    {
        public UserControl SignIn(string userInput, string passInput)
        {
            string path;
            path = Application.StartupPath;
            path = path.Substring(0, path.IndexOf("paZZword"));
            path = path + @"paZZword\data\passwords\";
            path = path+"Master.txt";
            try
            {
                string data = File.ReadAllText(path);

                string ui = data.Substring(data.IndexOf("Userid: ") + 8, data.IndexOf("Password: ") - 10);
                string pi = data.Substring(data.IndexOf("Password: ") + 10);

                if (File.Exists(path))
                {
                    if (userInput==ui && passInput==pi) 
                    {
                        Home h = new Home();
                        return h;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect details !\nPlease enter correct details.","Invalid Username & Password");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("No existing user found !","No Such User Exists");
                    return null;
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Oops an Error Occured. The error is: " + ex);
                return null;
            }
        }

        public UserControl WithoutSignIn()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to continue without signing in?", "Are you sure?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Home h = new Home();
                    return h;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops an Error Occured. The error is: " + ex);
                return null;
            }
        }
    }
}
