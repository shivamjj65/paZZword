using System.IO;
using System.Windows.Forms;
using System;

namespace paZZword
{
    class HomeValidator
    {

        public void ChangeButtonState(Button ob, bool v)
        {
            ob.Visible = v;
        }
        public void ChangeLabelState(Label ob, bool v)
        {
            ob.Visible = v;
        }
        public void ChangePicState(PictureBox ob, bool v)
        {
            ob.Visible = v;
        }
        public void ChangeTextBoxState(RichTextBox ob, bool v)
        {
            ob.Visible = v;
        }


        private string path = "";
        public void SetPath(string AppName)
        {
            path = Application.StartupPath;
            path = path.Substring(0, path.IndexOf("paZZword"));
            path = path + @"paZZword\data\passwords\";
            path = path + AppName + ".txt";
        }

        // SAVING DATA
        public void SaveData(string uid, string pass, string AppName)
        {
            SetPath(AppName);
            try
            {
                if (AppName!=null)
                {
                    File.WriteAllText(path,AppName+"\nUsername: "+uid+"\nPassword: "+pass);
                }
                else
                {
                    MessageBox.Show("Unable to save data", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops some error occured !" + ex, "Error");
            }
        }

        // VIEWING DATA
        public void ViewData(Label l,string AppName)
        {
            SetPath(AppName);
            try
            {
                if (File.Exists(path))
                {
                    l.Text = File.ReadAllText(path);
                }
                else
                {
                    l.Text = "No existing data found";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops some error occured !"+ex, "Error");
            }
        }

        // DELETING DATA
        public void DeleteData(Label l, string Appname)
        {
            SetPath(Appname);
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    l.Text = "Data deleted successfully.";
                }
                else
                {
                    l.Text = "No existing data found to be deleted.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops some error occured !" + ex, "Error");
            }
        }
    }
}
