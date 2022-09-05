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
    public partial class paZZword : Form
    {
        //
        // Variables for rounded corners of window
        //
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRighttRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );

        public paZZword()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        
        ToolTip t = new ToolTip();

        //
        // For dragging the window
        //
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        //
        // Drag bar
        //
        private void Bar_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Bar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        //
        // Nav Buttons
        //
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        


        private void changeScreen(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        PaZZwordValidator PV = new PaZZwordValidator();

        private void cont_Click(object sender, EventArgs e)
        {
            UserControl h = PV.WithoutSignIn();
            if (h != null)
            {
                changeScreen(h);
                Bar.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        private void SignIn_Click(object sender, EventArgs e)
        {
            UserControl h = PV.SignIn(userInput.Text,passInput.Text);
            if (h != null)
            {
                changeScreen(h);
                Bar.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
