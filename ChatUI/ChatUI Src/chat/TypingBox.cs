using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Shaping;
using System.Drawing.Design;

namespace chat
{
    public partial class TypingBox : UserControl
    {
        public TypingBox()
        {
            InitializeComponent();
        }
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string Value
        {
            get
            {
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }
        public delegate void TypingTextChanged(string newVal);
        public delegate void EmojiClicked(object sender, EventArgs e);
        public delegate void AttachmentClicked(object sender, EventArgs e);
        public delegate void HitEnter(object sender, EventArgs e);

        public event TypingTextChanged OnTypingTextChanged;
        public event EmojiClicked OnEmojiClicked;
        public event AttachmentClicked OnAttachmentClicked;
        public event HitEnter OnHitEnter;

        bool isEmpty = true;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
                OnTypingTextChanged?.Invoke(richTextBox1.Text);
            
        }
     

        protected override void OnPaint(PaintEventArgs e)
        {
           GraphicsPath gr = RoundedRectangle.Create(this.ClientRectangle, 10, RoundedRectangle.RectangleCorners.All);
            this.Region = new Region(gr);

            base.OnPaint(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnAttachmentClicked?.Invoke(sender, e);
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.WhiteSmoke;
            if (isEmpty || richTextBox1.Text == "Type here...")
            {
                richTextBox1.Text = "";
                isEmpty = false;
            }
            else
            {
                isEmpty = false;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = SystemColors.GradientActiveCaption;
            if (string.IsNullOrEmpty(richTextBox1.Text) || richTextBox1.Text=="Type here...")
            {
                isEmpty = true;
                richTextBox1.Text = "Type here...";
                
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OnEmojiClicked?.Invoke(sender, e);
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
           
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.Handled = true;
                OnHitEnter?.Invoke(sender, e);
               
            }
        }
    }
}
