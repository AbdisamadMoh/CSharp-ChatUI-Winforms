using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shaping;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Reflection;

namespace chat
{
    public partial class Form1 : BeautyForm //Inherited from Beauty, which a custom form.
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Move Form with the mouse. This method is available in BeautyForm that this form inherits
        protected override void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            base.OnMouseDownMoveForm(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void typingBox1_OnTypingTextChanged(string newVal)
        {
            // When you type something this fires... From 'typingBox11.OnTypingTextChanged'
            //'NewVal' is the new value... also can be gotten from 'typingBox1.Value'

        }

        private void typingBox1_OnHitEnter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(typingBox1.Value))
            {
                MeBubble bubble = new MeBubble();
                bubble.Dock = DockStyle.Bottom;//Dock to bottom  so that the bubbles can align themselves in a horizontal grid. You dont have to worry about responsiveness when window resizes.
                bubble.SendToBack();//Send back so that it will be lowest control... Use bubble.BringToFront() if u r docking up.
               
                bubble.Body = typingBox1.Value;

                panel4.Controls.Add(bubble);

                typingBox1.Value = "";

                FakeRecieving();
               
            }
        }

        private void FakeRecieving()
        {
            YouBubble bubble = new YouBubble();
            bubble.Dock = DockStyle.Bottom;
            bubble.SendToBack();
            bubble.Body = "This is a message received.";
            panel4.Controls.Add(bubble);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnUserClick(object sender, EventArgs e)
        {
            var ClickedUser = ((Users)sender);

            string name = ClickedUser.Username;
            string statusText = ClickedUser.StatusMessage;
            Image profileImage = ClickedUser.UserImage;

            this.chatHeader1.UserTitle = name;
            this.chatHeader1.UserStatusText = statusText;
            this.chatHeader1.UserImage = profileImage;
        }

        private void users1_Load(object sender, EventArgs e)
        {

        }

        private void meBubble2_Load(object sender, EventArgs e)
        {

        }
    }
}
