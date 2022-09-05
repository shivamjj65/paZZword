using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paZZword
{
    public partial class Home : UserControl
    {
        //  PaZZwordValidator Instance   //
        PaZZwordValidator PV = new PaZZwordValidator();
        HomeValidator HV = new HomeValidator();
        
        public Home()
        {
            bool t = false;
            InitializeComponent();

            if (t==true)
            {
                LabelWelcome.Text = "Thankyou for using paZZword,\nyour personal password manager !\nPlease Sign Up to use app";
            }
            else
            {
                LabelWelcome.Text = "Thankyou for using paZZword,\nyour personal password manager !";
            }
            HV.ChangePicState(PicApp,false);
            HV.ChangeLabelState(LabelAppName,false);
            HV.ChangeLabelState(LabelExistData, false);
            HV.ChangeLabelState(LabelUsername, false);
            HV.ChangeLabelState(LabelPassword, false);
            HV.ChangeButtonState(BtnViewExist,false);
            HV.ChangeButtonState(BtnDelete, false);
            HV.ChangeButtonState(BtnAddNew, false);
            HV.ChangeButtonState(BtnSave,false);
            HV.ChangeTextBoxState(InputUser,false);
            HV.ChangeTextBoxState(InputPass, false);
        }

        private string CurrentAppName = "";
        private void changeOnMenuButtonClick(string n)
        {
            CurrentAppName = null;
            // Actions to perform when Menu buttons clicked //
            // Only PicApp, LabelAppName, BtnViewExist, BtnAddNew, BtnDelete visible //
            HV.ChangeLabelState(LabelWelcome, false);
            HV.ChangePicState(PicApp, true);
            HV.ChangeLabelState(LabelAppName, true);
            HV.ChangeButtonState(BtnViewExist, true);
            HV.ChangeButtonState(BtnAddNew, true);
            HV.ChangeButtonState(BtnDelete, true);
            HV.ChangeLabelState(LabelExistData,false);
            HV.ChangeLabelState(LabelUsername,false);
            HV.ChangeLabelState(LabelPassword, false);
            HV.ChangeTextBoxState(InputUser, false);
            HV.ChangeTextBoxState(InputPass, false);
            LabelAppName.Text = n;
            CurrentAppName = n;
            InputUser.Clear();
            InputPass.Clear();
        }


        public void changeAppLogo(string pic)
        {
            // PicApp.
            string currentAppPath = Application.StartupPath;
            currentAppPath = currentAppPath.Substring(0, currentAppPath.IndexOf("paZZword"));
            currentAppPath = currentAppPath + @"paZZword\data\assets\" + pic + ".png";

            PicApp.ImageLocation = currentAppPath;
        }

        private void adobe_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(adobe.Text);
            changeAppLogo(adobe.Text);
        }

        private void amazon_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(amazon.Text);
            changeAppLogo(amazon.Text);
        }

        private void discord_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(discord.Text);
            changeAppLogo(discord.Text);
        }

        private void flipkart_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(flipkart.Text);
            changeAppLogo(flipkart.Text);
        }

        private void google_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(google.Text);
            changeAppLogo(google.Text);
        }

        private void instagram_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(instagram.Text);
            changeAppLogo(instagram.Text);
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(facebook.Text);
            changeAppLogo(facebook.Text);
        }

        private void reddit_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(reddit.Text);
            changeAppLogo(reddit.Text);
        }

        private void snapchat_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(snapchat.Text);
            changeAppLogo(snapchat.Text);
        }

        private void twitter_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(twitter.Text);
            changeAppLogo(twitter.Text);
        }

        private void mobile_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(mobile.Text);
        }

        private void pc_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(pc.Text);
        }

        private void personal_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(personal.Text);
        }

        private void others_Click(object sender, EventArgs e)
        {
            changeOnMenuButtonClick(others.Text);
        }


        //    View Exist and Add New Controls    //
        private void changeOnAddNewClick()
        {
            HV.ChangeLabelState(LabelWelcome, false);
            HV.ChangeLabelState(LabelExistData, false);
            HV.ChangeLabelState(LabelUsername, true);
            HV.ChangeLabelState(LabelPassword, true);
            HV.ChangeTextBoxState(InputUser, true);
            HV.ChangeTextBoxState(InputPass, true);
            HV.ChangeButtonState(BtnSave, true);
        }
        private void changeOnViewExistClick()
        {
            HV.ChangeLabelState(LabelWelcome, false);
            HV.ChangeLabelState(LabelExistData, true);
            HV.ChangeLabelState(LabelUsername, false);
            HV.ChangeLabelState(LabelPassword, false);
            HV.ChangeTextBoxState(InputUser, false);
            HV.ChangeTextBoxState(InputPass, false);
            HV.ChangeButtonState(BtnSave, false);
        }

        // BUTTON CLICK FUNCTIONS for VIEW EXISTING, ADD NEW, DELETE BUTTONS
        private void BtnViewExist_Click(object sender, EventArgs e)
        {
            LabelExistData.Text = "";
            changeOnViewExistClick();
            HV.ViewData(LabelExistData, CurrentAppName);
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            HV.DeleteData(LabelExistData,CurrentAppName);
        }
        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            changeOnAddNewClick();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            HV.SaveData(InputUser.Text,InputPass.Text,CurrentAppName);
        }

    }
}
