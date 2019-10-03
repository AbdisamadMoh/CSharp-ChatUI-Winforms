using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chat.Properties;
using Shaping;
using System.Drawing.Drawing2D;

namespace chat
{
    public partial class ChatHeader : UserControl
    {
        public ChatHeader()
        {
            InitializeComponent();
        }

        public string UserTitle
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public string UserStatusText
        {
            get
            {
                return label2.Text;
            }
            set
            {
                label2.Text = value;
            }
        }

        public Image UserImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public delegate void VideoCallClick(object sender, EventArgs e);
        public delegate void CallClick(object sender, EventArgs e);
        public delegate void MenuDotClick(object sender, EventArgs e);

        public delegate void UserTitleTextClick(object sender, EventArgs e);
        public delegate void UserStatusTextClick(object sender, EventArgs e);
        public delegate void UserImageClick(object sender, EventArgs e);

        public event VideoCallClick OnVideoCallClick;
        public event CallClick OnCallClick;
        public event MenuDotClick OnMenuDotClick;

        public event UserTitleTextClick OnUserTitleTextClick;
        public event UserStatusTextClick OnUserStatusTextClick;
        public event UserImageClick OnUserImageClick;

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(panel2.ClientRectangle, 19, RoundedRectangle.RectangleCorners.All);
            panel2.Region = new Region(gr);

            GraphicsPath gr1 = RoundedRectangle.Create(pictureBox1.ClientRectangle, 19, RoundedRectangle.RectangleCorners.All);
            pictureBox1.Region = new Region(gr1);

            base.OnPaint(e);
        }


        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.icons8_Call_32;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.icons8_Call_white_32;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.icons8_Video_Call_32;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.icons8_Video_Call_white_32;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.icons8_Menu_Vertical_32;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.icons8_Menu_Vertical_white_32;
        }

        private void ChatHeader_Load(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OnUserImageClick != null)
            {
                OnUserImageClick.Invoke(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (OnUserTitleTextClick != null)
            {
                OnUserTitleTextClick.Invoke(sender, e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (OnUserStatusTextClick != null)
            {
                OnUserStatusTextClick.Invoke(sender, e);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (OnCallClick != null)
            {
                OnCallClick.Invoke(sender, e);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (OnVideoCallClick != null)
            {
                OnVideoCallClick.Invoke(sender, e);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (OnMenuDotClick != null)
            {
                OnMenuDotClick.Invoke(sender, e);
            }
        }
    }
}
