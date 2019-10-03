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
using System.Drawing.Design;

namespace chat
{
    public partial class SearchBox : UserControl
    {
        public SearchBox()
        {
            InitializeComponent();
            
        }

        private void SearchBox_Load(object sender, EventArgs e)
        {

        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                richTextBox1.BackColor=   base.BackColor = value;
            }
        }

        //public Color MainColor
        //{
        //    get
        //    {
        //        return this.BackColor;
        //    }
        //    set
        //    {
        //        richTextBox1.BackColor = this.BackColor = value;
          
        //    }
        //}
        public Color TextColor
        {
            get
            {
                return richTextBox1.ForeColor;
            }
            set
            {
                richTextBox1.ForeColor = value;
            }
        }
        Color _FocusedColor = Color.WhiteSmoke;
        Color _UnFocusedColor = SystemColors.GradientActiveCaption;
        public Color UnFocusedColor
        {
            get
            {
                return _UnFocusedColor;
            }
            set
            {
                _UnFocusedColor = value;
            }
        }
        public Color FocusedColor
        {
            get
            {
                return _FocusedColor;
            }
            set
            {
                _FocusedColor = value;
            }
        }
        bool isAddedBorderLabel = false;
        Label BottomBorder = new Label();
        Label paddingLabel = new Label();
        protected override void OnPaint(PaintEventArgs e)
        {
            BottomBorder.Height = 1;
            BottomBorder.Dock = DockStyle.Bottom;
            BottomBorder.BackColor = _UnFocusedColor;
            paddingLabel.Height = 8;
            paddingLabel.Dock = DockStyle.Bottom;
            paddingLabel.BackColor = this.BackColor;
            if (!isAddedBorderLabel)
            {
                this.Controls.Add(BottomBorder);

                
                this.Controls.Add(paddingLabel);

                richTextBox1.Text = "Search...";
                richTextBox1.ForeColor = _UnFocusedColor;
                BottomBorder.BackColor = _UnFocusedColor;
                isSearchEmpty = true;

                isAddedBorderLabel = true;
            }
            base.OnPaint(e);
        }

        bool isSearchEmpty = true;
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (isSearchEmpty || richTextBox1.Text == "Search...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = _FocusedColor;
                BottomBorder.BackColor = _FocusedColor;
            }
            else
            {
                richTextBox1.ForeColor = _FocusedColor;
                BottomBorder.BackColor = _FocusedColor;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text) || richTextBox1.Text== "Search...")
            {
                richTextBox1.Text = "Search...";
                richTextBox1.ForeColor = _UnFocusedColor;
                BottomBorder.BackColor = _UnFocusedColor;
                isSearchEmpty = true;
            }
            else
            {
                richTextBox1.ForeColor = _UnFocusedColor;
                BottomBorder.BackColor = _UnFocusedColor;
                isSearchEmpty = false;
            }
        }
        public delegate void SearchTextChanged(string newVal);
        public delegate void HitEnter(object sender, EventArgs e);

        public event SearchTextChanged OnSearchTextChanged;
        public event HitEnter OnHitEnter;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!isSearchEmpty)
            {
                OnSearchTextChanged?.Invoke(richTextBox1.Text);
            }
        }
       // [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
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

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isSearchEmpty || richTextBox1.Text == "Search...")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = FocusedColor;
                BottomBorder.BackColor = FocusedColor;
            }
            else
            {
                richTextBox1.ForeColor = FocusedColor;
                BottomBorder.BackColor = FocusedColor;
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
   
}
