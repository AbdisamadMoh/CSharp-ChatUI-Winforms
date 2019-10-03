namespace chat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBox1 = new chat.SearchBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.users7 = new chat.Users();
            this.users8 = new chat.Users();
            this.users9 = new chat.Users();
            this.users10 = new chat.Users();
            this.users11 = new chat.Users();
            this.users6 = new chat.Users();
            this.users5 = new chat.Users();
            this.users4 = new chat.Users();
            this.users3 = new chat.Users();
            this.users2 = new chat.Users();
            this.users1 = new chat.Users();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.typingBox1 = new chat.TypingBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.meBubble2 = new chat.MeBubble();
            this.youBubble1 = new chat.YouBubble();
            this.meBubble1 = new chat.MeBubble();
            this.meBubble3 = new chat.MeBubble();
            this.meBubble4 = new chat.MeBubble();
            this.meBubble5 = new chat.MeBubble();
            this.chatHeader1 = new chat.ChatHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 24);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownMoveForm);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(904, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "__";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(939, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(35, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 27);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 5);
            this.panel2.Size = new System.Drawing.Size(206, 674);
            this.panel2.TabIndex = 1;
            // 
            // searchBox1
            // 
            this.searchBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.searchBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBox1.FocusedColor = System.Drawing.Color.WhiteSmoke;
            this.searchBox1.Location = new System.Drawing.Point(2, 640);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.searchBox1.Size = new System.Drawing.Size(202, 29);
            this.searchBox1.TabIndex = 2;
            this.searchBox1.TextColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.UnFocusedColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox1.Value = "Search...";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.users7);
            this.panel5.Controls.Add(this.users8);
            this.panel5.Controls.Add(this.users9);
            this.panel5.Controls.Add(this.users10);
            this.panel5.Controls.Add(this.users11);
            this.panel5.Controls.Add(this.users6);
            this.panel5.Controls.Add(this.users5);
            this.panel5.Controls.Add(this.users4);
            this.panel5.Controls.Add(this.users3);
            this.panel5.Controls.Add(this.users2);
            this.panel5.Controls.Add(this.users1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(2, 42);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.panel5.Size = new System.Drawing.Size(202, 578);
            this.panel5.TabIndex = 1;
            // 
            // users7
            // 
            this.users7.BackColor = System.Drawing.Color.Transparent;
            this.users7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users7.Dock = System.Windows.Forms.DockStyle.Top;
            this.users7.Location = new System.Drawing.Point(0, 495);
            this.users7.Margin = new System.Windows.Forms.Padding(0);
            this.users7.Name = "users7";
            this.users7.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users7.Size = new System.Drawing.Size(202, 49);
            this.users7.StatusMessage = "Online";
            this.users7.TabIndex = 10;
            this.users7.UserImage = global::chat.Properties.Resources._2_32;
            this.users7.Username = "Kasimu Da.";
            this.users7.UserStatus = chat.Status.Online;
            // 
            // users8
            // 
            this.users8.BackColor = System.Drawing.Color.Transparent;
            this.users8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users8.Dock = System.Windows.Forms.DockStyle.Top;
            this.users8.Location = new System.Drawing.Point(0, 446);
            this.users8.Margin = new System.Windows.Forms.Padding(0);
            this.users8.Name = "users8";
            this.users8.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users8.Size = new System.Drawing.Size(202, 49);
            this.users8.StatusMessage = "Offline";
            this.users8.TabIndex = 9;
            this.users8.UserImage = global::chat.Properties.Resources._1_32;
            this.users8.Username = "Sacdiyo Xir.";
            this.users8.UserStatus = chat.Status.Offline;
            // 
            // users9
            // 
            this.users9.BackColor = System.Drawing.Color.Transparent;
            this.users9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users9.Dock = System.Windows.Forms.DockStyle.Top;
            this.users9.Location = new System.Drawing.Point(0, 397);
            this.users9.Margin = new System.Windows.Forms.Padding(0);
            this.users9.Name = "users9";
            this.users9.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users9.Size = new System.Drawing.Size(202, 49);
            this.users9.StatusMessage = "Away";
            this.users9.TabIndex = 8;
            this.users9.UserImage = global::chat.Properties.Resources._3_32;
            this.users9.Username = "Isma Ali";
            this.users9.UserStatus = chat.Status.Away;
            // 
            // users10
            // 
            this.users10.BackColor = System.Drawing.Color.Transparent;
            this.users10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users10.Dock = System.Windows.Forms.DockStyle.Top;
            this.users10.Location = new System.Drawing.Point(0, 348);
            this.users10.Margin = new System.Windows.Forms.Padding(0);
            this.users10.Name = "users10";
            this.users10.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users10.Size = new System.Drawing.Size(202, 49);
            this.users10.StatusMessage = "Away";
            this.users10.TabIndex = 7;
            this.users10.UserImage = ((System.Drawing.Image)(resources.GetObject("users10.UserImage")));
            this.users10.Username = "Baba BE.";
            this.users10.UserStatus = chat.Status.Away;
            // 
            // users11
            // 
            this.users11.BackColor = System.Drawing.Color.Transparent;
            this.users11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users11.Dock = System.Windows.Forms.DockStyle.Top;
            this.users11.Location = new System.Drawing.Point(0, 299);
            this.users11.Margin = new System.Windows.Forms.Padding(0);
            this.users11.Name = "users11";
            this.users11.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users11.Size = new System.Drawing.Size(202, 49);
            this.users11.StatusMessage = "Online";
            this.users11.TabIndex = 6;
            this.users11.UserImage = global::chat.Properties.Resources._2_32;
            this.users11.Username = "Kasimu Da.";
            this.users11.UserStatus = chat.Status.Online;
            // 
            // users6
            // 
            this.users6.BackColor = System.Drawing.Color.Transparent;
            this.users6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users6.Dock = System.Windows.Forms.DockStyle.Top;
            this.users6.Location = new System.Drawing.Point(0, 250);
            this.users6.Margin = new System.Windows.Forms.Padding(0);
            this.users6.Name = "users6";
            this.users6.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users6.Size = new System.Drawing.Size(202, 49);
            this.users6.StatusMessage = "Offline";
            this.users6.TabIndex = 5;
            this.users6.UserImage = global::chat.Properties.Resources._2;
            this.users6.Username = "Tusbaxle A.";
            this.users6.UserStatus = chat.Status.Offline;
            this.users6.OnClick += new chat.Users.Clicked(this.OnUserClick);
            // 
            // users5
            // 
            this.users5.BackColor = System.Drawing.Color.Transparent;
            this.users5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users5.Dock = System.Windows.Forms.DockStyle.Top;
            this.users5.Location = new System.Drawing.Point(0, 201);
            this.users5.Margin = new System.Windows.Forms.Padding(0);
            this.users5.Name = "users5";
            this.users5.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users5.Size = new System.Drawing.Size(202, 49);
            this.users5.StatusMessage = "Offline";
            this.users5.TabIndex = 4;
            this.users5.UserImage = global::chat.Properties.Resources._1_32;
            this.users5.Username = "Sacdiyo Xir.";
            this.users5.UserStatus = chat.Status.Offline;
            this.users5.OnClick += new chat.Users.Clicked(this.OnUserClick);
            // 
            // users4
            // 
            this.users4.BackColor = System.Drawing.Color.Transparent;
            this.users4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users4.Dock = System.Windows.Forms.DockStyle.Top;
            this.users4.Location = new System.Drawing.Point(0, 152);
            this.users4.Margin = new System.Windows.Forms.Padding(0);
            this.users4.Name = "users4";
            this.users4.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users4.Size = new System.Drawing.Size(202, 49);
            this.users4.StatusMessage = "Away";
            this.users4.TabIndex = 3;
            this.users4.UserImage = global::chat.Properties.Resources._3_32;
            this.users4.Username = "Isma Ali";
            this.users4.UserStatus = chat.Status.Away;
            this.users4.OnClick += new chat.Users.Clicked(this.OnUserClick);
            // 
            // users3
            // 
            this.users3.BackColor = System.Drawing.Color.Transparent;
            this.users3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users3.Dock = System.Windows.Forms.DockStyle.Top;
            this.users3.Location = new System.Drawing.Point(0, 103);
            this.users3.Margin = new System.Windows.Forms.Padding(0);
            this.users3.Name = "users3";
            this.users3.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users3.Size = new System.Drawing.Size(202, 49);
            this.users3.StatusMessage = "Away";
            this.users3.TabIndex = 2;
            this.users3.UserImage = ((System.Drawing.Image)(resources.GetObject("users3.UserImage")));
            this.users3.Username = "Baba BE.";
            this.users3.UserStatus = chat.Status.Away;
            this.users3.OnClick += new chat.Users.Clicked(this.OnUserClick);
            // 
            // users2
            // 
            this.users2.BackColor = System.Drawing.Color.Transparent;
            this.users2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users2.Dock = System.Windows.Forms.DockStyle.Top;
            this.users2.Location = new System.Drawing.Point(0, 54);
            this.users2.Margin = new System.Windows.Forms.Padding(0);
            this.users2.Name = "users2";
            this.users2.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users2.Size = new System.Drawing.Size(202, 49);
            this.users2.StatusMessage = "Online";
            this.users2.TabIndex = 1;
            this.users2.UserImage = global::chat.Properties.Resources._2_32;
            this.users2.Username = "Kasimu Da.";
            this.users2.UserStatus = chat.Status.Online;
            this.users2.OnClick += new chat.Users.Clicked(this.OnUserClick);
            // 
            // users1
            // 
            this.users1.BackColor = System.Drawing.Color.Transparent;
            this.users1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users1.Dock = System.Windows.Forms.DockStyle.Top;
            this.users1.Location = new System.Drawing.Point(0, 5);
            this.users1.Margin = new System.Windows.Forms.Padding(0);
            this.users1.Name = "users1";
            this.users1.ProfileImageCursor = System.Windows.Forms.Cursors.Hand;
            this.users1.Size = new System.Drawing.Size(202, 49);
            this.users1.StatusMessage = "Online";
            this.users1.TabIndex = 0;
            this.users1.UserImage = global::chat.Properties.Resources._4_32;
            this.users1.Username = "A.Samad M.";
            this.users1.UserStatus = chat.Status.Online;
            this.users1.OnClick += new chat.Users.Clicked(this.OnUserClick);
            this.users1.Load += new System.EventHandler(this.users1_Load);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(202, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recent";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.typingBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(209, 663);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel3.Size = new System.Drawing.Size(768, 38);
            this.panel3.TabIndex = 3;
            // 
            // typingBox1
            // 
            this.typingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.typingBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.typingBox1.Location = new System.Drawing.Point(5, 9);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(758, 24);
            this.typingBox1.TabIndex = 0;
            this.typingBox1.Value = "Type here...";
            this.typingBox1.OnHitEnter += new chat.TypingBox.HitEnter(this.typingBox1_OnHitEnter);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.meBubble2);
            this.panel4.Controls.Add(this.youBubble1);
            this.panel4.Controls.Add(this.meBubble1);
            this.panel4.Controls.Add(this.meBubble3);
            this.panel4.Controls.Add(this.meBubble4);
            this.panel4.Controls.Add(this.meBubble5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(209, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 594);
            this.panel4.TabIndex = 4;
            // 
            // meBubble2
            // 
            this.meBubble2.AutoSize = true;
            this.meBubble2.BackColor = System.Drawing.Color.Transparent;
            this.meBubble2.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. \r\n";
            this.meBubble2.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble2.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble2.Location = new System.Drawing.Point(0, 24);
            this.meBubble2.MinimumSize = new System.Drawing.Size(0, 95);
            this.meBubble2.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble2.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble2.Name = "meBubble2";
            this.meBubble2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble2.Size = new System.Drawing.Size(768, 95);
            this.meBubble2.Status = chat.MessageStatus.Custom;
            this.meBubble2.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble2.StatusImage")));
            this.meBubble2.TabIndex = 2;
            this.meBubble2.Time = "11:44 PM";
            this.meBubble2.TimeColor = System.Drawing.Color.White;
            this.meBubble2.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble2.UserImage")));
            // 
            // youBubble1
            // 
            this.youBubble1.BackColor = System.Drawing.Color.Transparent;
            this.youBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \n\nThis is a sample text message. ";
            this.youBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.youBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.youBubble1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.youBubble1.Location = new System.Drawing.Point(0, 119);
            this.youBubble1.MinimumSize = new System.Drawing.Size(0, 95);
            this.youBubble1.MsgColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.youBubble1.MsgTextColor = System.Drawing.SystemColors.ControlDarkDark;
            this.youBubble1.Name = "youBubble1";
            this.youBubble1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.youBubble1.Size = new System.Drawing.Size(768, 95);
            this.youBubble1.Status = chat.MessageStatus.Custom;
            this.youBubble1.StatusImage = null;
            this.youBubble1.TabIndex = 1;
            this.youBubble1.Time = "11:46 PM";
            this.youBubble1.TimeColor = System.Drawing.Color.White;
            this.youBubble1.UserImage = global::chat.Properties.Resources._2_32;
            // 
            // meBubble1
            // 
            this.meBubble1.AutoSize = true;
            this.meBubble1.BackColor = System.Drawing.Color.Transparent;
            this.meBubble1.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. \r\n";
            this.meBubble1.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble1.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble1.Location = new System.Drawing.Point(0, 214);
            this.meBubble1.MinimumSize = new System.Drawing.Size(0, 95);
            this.meBubble1.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble1.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble1.Name = "meBubble1";
            this.meBubble1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble1.Size = new System.Drawing.Size(768, 95);
            this.meBubble1.Status = chat.MessageStatus.Custom;
            this.meBubble1.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble1.StatusImage")));
            this.meBubble1.TabIndex = 0;
            this.meBubble1.Time = "11:50 PM";
            this.meBubble1.TimeColor = System.Drawing.Color.White;
            this.meBubble1.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble1.UserImage")));
            // 
            // meBubble3
            // 
            this.meBubble3.AutoSize = true;
            this.meBubble3.BackColor = System.Drawing.Color.Transparent;
            this.meBubble3.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. \r\n";
            this.meBubble3.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble3.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble3.Location = new System.Drawing.Point(0, 309);
            this.meBubble3.MinimumSize = new System.Drawing.Size(0, 95);
            this.meBubble3.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble3.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble3.Name = "meBubble3";
            this.meBubble3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble3.Size = new System.Drawing.Size(768, 95);
            this.meBubble3.Status = chat.MessageStatus.Custom;
            this.meBubble3.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble3.StatusImage")));
            this.meBubble3.TabIndex = 3;
            this.meBubble3.Time = "11:52 PM";
            this.meBubble3.TimeColor = System.Drawing.Color.White;
            this.meBubble3.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble3.UserImage")));
            // 
            // meBubble4
            // 
            this.meBubble4.AutoSize = true;
            this.meBubble4.BackColor = System.Drawing.Color.Transparent;
            this.meBubble4.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. \r\n";
            this.meBubble4.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble4.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble4.Location = new System.Drawing.Point(0, 404);
            this.meBubble4.MinimumSize = new System.Drawing.Size(0, 95);
            this.meBubble4.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble4.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble4.Name = "meBubble4";
            this.meBubble4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble4.Size = new System.Drawing.Size(768, 95);
            this.meBubble4.Status = chat.MessageStatus.Custom;
            this.meBubble4.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble4.StatusImage")));
            this.meBubble4.TabIndex = 4;
            this.meBubble4.Time = "11:52 PM";
            this.meBubble4.TimeColor = System.Drawing.Color.White;
            this.meBubble4.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble4.UserImage")));
            // 
            // meBubble5
            // 
            this.meBubble5.AutoSize = true;
            this.meBubble5.BackColor = System.Drawing.Color.Transparent;
            this.meBubble5.Body = " This is a sample text message. This is a sample text message. This is a sample t" +
    "ext message. \r\n\r\nThis is a sample text message. \r\n";
            this.meBubble5.ChatImageCursor = System.Windows.Forms.Cursors.Default;
            this.meBubble5.ChatTextCursor = System.Windows.Forms.Cursors.IBeam;
            this.meBubble5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.meBubble5.Location = new System.Drawing.Point(0, 499);
            this.meBubble5.MinimumSize = new System.Drawing.Size(0, 95);
            this.meBubble5.MsgColor = System.Drawing.Color.DodgerBlue;
            this.meBubble5.MsgTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.meBubble5.Name = "meBubble5";
            this.meBubble5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.meBubble5.Size = new System.Drawing.Size(768, 95);
            this.meBubble5.Status = chat.MessageStatus.Custom;
            this.meBubble5.StatusImage = ((System.Drawing.Image)(resources.GetObject("meBubble5.StatusImage")));
            this.meBubble5.TabIndex = 5;
            this.meBubble5.Time = "11:52 PM";
            this.meBubble5.TimeColor = System.Drawing.Color.White;
            this.meBubble5.UserImage = ((System.Drawing.Image)(resources.GetObject("meBubble5.UserImage")));
            // 
            // chatHeader1
            // 
            this.chatHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.chatHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatHeader1.Location = new System.Drawing.Point(209, 27);
            this.chatHeader1.Name = "chatHeader1";
            this.chatHeader1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.chatHeader1.Size = new System.Drawing.Size(768, 42);
            this.chatHeader1.TabIndex = 2;
            this.chatHeader1.UserImage = global::chat.Properties.Resources._2_32;
            this.chatHeader1.UserStatusText = "Typing...";
            this.chatHeader1.UserTitle = "Kassimu Da.";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(980, 704);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chatHeader1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ChatHeader chatHeader1;
        private System.Windows.Forms.Panel panel3;
        private TypingBox typingBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private SearchBox searchBox1;
        private Users users6;
        private Users users5;
        private Users users4;
        private Users users3;
        private Users users2;
        private Users users1;
        private MeBubble meBubble2;
        private YouBubble youBubble1;
        private MeBubble meBubble1;
        private MeBubble meBubble3;
        private MeBubble meBubble4;
        private MeBubble meBubble5;
        private Users users7;
        private Users users8;
        private Users users9;
        private Users users10;
        private Users users11;
    }
}