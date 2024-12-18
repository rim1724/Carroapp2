namespace project_Game_Caro
{
    partial class GameCaro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCaro));
            pn_GameBoard = new Panel();
            panel1 = new Panel();
            pb_Logo = new PictureBox();
            panel2 = new Panel();
            Grb_About = new GroupBox();
            panel3 = new Panel();
            lbl_About = new Label();
            txt_PlayerName = new TextBox();
            pb_Avatar = new PictureBox();
            tm_About = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            txt_IP = new TextBox();
            btn_Undo = new Button();
            pgb_CountDown = new ProgressBar();
            btn_Redo = new Button();
            btn_AI = new Button();
            pictureBox1 = new PictureBox();
            btn_SameCom = new Button();
            btn_LAN = new Button();
            txt_Chat = new TextBox();
            tm_CountDown = new System.Windows.Forms.Timer(components);
            txt_Message = new TextBox();
            btn_Send = new Button();
            menuStrip = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem2 = new ToolStripMenuItem();
            ViaLANToolStripMenuItem = new ToolStripMenuItem();
            SameComToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            howToPlayToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            aboutThisGameToolStripMenuItem = new ToolStripMenuItem();
            contactMeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pb_Logo).BeginInit();
            panel2.SuspendLayout();
            Grb_About.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Avatar).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pn_GameBoard
            // 
            pn_GameBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_GameBoard.BackColor = Color.DeepSkyBlue;
            pn_GameBoard.BorderStyle = BorderStyle.FixedSingle;
            pn_GameBoard.Location = new Point(15, 50);
            pn_GameBoard.Name = "pn_GameBoard";
            pn_GameBoard.Size = new Size(915, 750);
            pn_GameBoard.TabIndex = 0;
            pn_GameBoard.Paint += pn_GameBoard_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(969, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 180);
            panel1.TabIndex = 1;
            // 
            // pb_Logo
            // 
            pb_Logo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_Logo.BackColor = Color.Transparent;
            pb_Logo.BackgroundImageLayout = ImageLayout.Stretch;
            pb_Logo.InitialImage = null;
            pb_Logo.Location = new Point(969, 47);
            pb_Logo.Name = "pb_Logo";
            pb_Logo.Size = new Size(400, 300);
            pb_Logo.TabIndex = 0;
            pb_Logo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(Grb_About);
            panel2.Controls.Add(txt_PlayerName);
            panel2.Controls.Add(pb_Avatar);
            panel2.Location = new Point(969, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 150);
            panel2.TabIndex = 1;
            // 
            // Grb_About
            // 
            Grb_About.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Grb_About.BackColor = Color.Transparent;
            Grb_About.Controls.Add(panel3);
            Grb_About.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Grb_About.ForeColor = Color.Lime;
            Grb_About.Location = new Point(207, 5);
            Grb_About.Name = "Grb_About";
            Grb_About.Size = new Size(193, 100);
            Grb_About.TabIndex = 0;
            Grb_About.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_About);
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(193, 146);
            panel3.TabIndex = 0;
            // 
            // lbl_About
            // 
            lbl_About.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_About.ForeColor = Color.Lime;
            lbl_About.Location = new Point(0, 0);
            lbl_About.Name = "lbl_About";
            lbl_About.Size = new Size(193, 138);
            lbl_About.TabIndex = 4;
            lbl_About.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_PlayerName
            // 
            txt_PlayerName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_PlayerName.BackColor = Color.LimeGreen;
            txt_PlayerName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_PlayerName.ForeColor = Color.DarkBlue;
            txt_PlayerName.Location = new Point(207, 110);
            txt_PlayerName.Name = "txt_PlayerName";
            txt_PlayerName.ReadOnly = true;
            txt_PlayerName.Size = new Size(193, 30);
            txt_PlayerName.TabIndex = 1;
            txt_PlayerName.TextAlign = HorizontalAlignment.Center;
            // 
            // pb_Avatar
            // 
            pb_Avatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb_Avatar.BackgroundImageLayout = ImageLayout.Stretch;
            pb_Avatar.Location = new Point(45, 25);
            pb_Avatar.Name = "pb_Avatar";
            pb_Avatar.Size = new Size(100, 100);
            pb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Avatar.TabIndex = 0;
            pb_Avatar.TabStop = false;
            // 
            // tm_About
            // 
            tm_About.Interval = 70;
            tm_About.Tick += Tm_About_Tick;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(txt_IP);
            panel4.Controls.Add(btn_Undo);
            panel4.Controls.Add(pgb_CountDown);
            panel4.Controls.Add(btn_Redo);
            panel4.Controls.Add(btn_AI);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(btn_SameCom);
            panel4.Controls.Add(btn_LAN);
            panel4.Location = new Point(969, 520);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 34);
            panel4.TabIndex = 1;
            // 
            // txt_IP
            // 
            txt_IP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_IP.BackColor = Color.White;
            txt_IP.BorderStyle = BorderStyle.FixedSingle;
            txt_IP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_IP.ForeColor = Color.Blue;
            txt_IP.Location = new Point(207, 2);
            txt_IP.Name = "txt_IP";
            txt_IP.Size = new Size(193, 30);
            txt_IP.TabIndex = 1;
            txt_IP.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Undo
            // 
            btn_Undo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Undo.BackColor = Color.RoyalBlue;
            btn_Undo.Cursor = Cursors.Hand;
            btn_Undo.FlatAppearance.BorderColor = Color.Black;
            btn_Undo.FlatAppearance.BorderSize = 0;
            btn_Undo.FlatStyle = FlatStyle.Popup;
            btn_Undo.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Undo.ForeColor = Color.White;
            btn_Undo.Location = new Point(0, 128);
            btn_Undo.Name = "btn_Undo";
            btn_Undo.Size = new Size(96, 35);
            btn_Undo.TabIndex = 3;
            btn_Undo.Text = "Undo";
            btn_Undo.UseVisualStyleBackColor = false;
            btn_Undo.Visible = false;
            btn_Undo.Click += Btn_Undo_Click;
            // 
            // pgb_CountDown
            // 
            pgb_CountDown.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pgb_CountDown.BackColor = Color.Lime;
            pgb_CountDown.ForeColor = Color.FromArgb(0, 192, 0);
            pgb_CountDown.Location = new Point(0, 2);
            pgb_CountDown.Name = "pgb_CountDown";
            pgb_CountDown.Size = new Size(199, 30);
            pgb_CountDown.TabIndex = 2;
            // 
            // btn_Redo
            // 
            btn_Redo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Redo.BackColor = Color.LimeGreen;
            btn_Redo.Cursor = Cursors.Hand;
            btn_Redo.FlatAppearance.BorderColor = Color.Black;
            btn_Redo.FlatAppearance.BorderSize = 0;
            btn_Redo.FlatStyle = FlatStyle.Popup;
            btn_Redo.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Redo.ForeColor = Color.White;
            btn_Redo.Location = new Point(103, 129);
            btn_Redo.Name = "btn_Redo";
            btn_Redo.Size = new Size(96, 34);
            btn_Redo.TabIndex = 3;
            btn_Redo.Text = "Redo";
            btn_Redo.UseVisualStyleBackColor = false;
            btn_Redo.Visible = false;
            btn_Redo.Click += Btn_Redo_Click;
            // 
            // btn_AI
            // 
            btn_AI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AI.BackColor = Color.Crimson;
            btn_AI.Cursor = Cursors.Hand;
            btn_AI.FlatAppearance.BorderColor = Color.Black;
            btn_AI.FlatAppearance.BorderSize = 0;
            btn_AI.FlatStyle = FlatStyle.Popup;
            btn_AI.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AI.ForeColor = Color.White;
            btn_AI.Location = new Point(207, 129);
            btn_AI.Name = "btn_AI";
            btn_AI.Size = new Size(193, 34);
            btn_AI.TabIndex = 3;
            btn_AI.Text = "Player vs Com";
            btn_AI.UseVisualStyleBackColor = false;
            btn_AI.Visible = false;
            btn_AI.Click += Btn_AI_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // btn_SameCom
            // 
            btn_SameCom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_SameCom.BackColor = Color.Crimson;
            btn_SameCom.Cursor = Cursors.Help;
            btn_SameCom.FlatAppearance.BorderColor = Color.Black;
            btn_SameCom.FlatAppearance.BorderSize = 0;
            btn_SameCom.FlatStyle = FlatStyle.Popup;
            btn_SameCom.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_SameCom.ForeColor = Color.White;
            btn_SameCom.Location = new Point(207, 88);
            btn_SameCom.Name = "btn_SameCom";
            btn_SameCom.Size = new Size(193, 34);
            btn_SameCom.TabIndex = 3;
            btn_SameCom.Text = "2 Players / Com";
            btn_SameCom.UseVisualStyleBackColor = false;
            btn_SameCom.Visible = false;
            btn_SameCom.Click += Btn_SameCom_Click;
            // 
            // btn_LAN
            // 
            btn_LAN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_LAN.BackColor = Color.Crimson;
            btn_LAN.Cursor = Cursors.Hand;
            btn_LAN.FlatAppearance.BorderColor = Color.Black;
            btn_LAN.FlatAppearance.BorderSize = 0;
            btn_LAN.FlatStyle = FlatStyle.Popup;
            btn_LAN.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LAN.ForeColor = Color.White;
            btn_LAN.Location = new Point(207, 48);
            btn_LAN.Name = "btn_LAN";
            btn_LAN.Size = new Size(193, 34);
            btn_LAN.TabIndex = 3;
            btn_LAN.Text = "2 Players in LAN";
            btn_LAN.UseVisualStyleBackColor = false;
            btn_LAN.Visible = false;
            btn_LAN.Click += Btn_LAN_Click;
            // 
            // txt_Chat
            // 
            txt_Chat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Chat.BackColor = Color.White;
            txt_Chat.Font = new Font("Arial", 11F);
            txt_Chat.ForeColor = Color.DarkBlue;
            txt_Chat.Location = new Point(969, 560);
            txt_Chat.Multiline = true;
            txt_Chat.Name = "txt_Chat";
            txt_Chat.ReadOnly = true;
            txt_Chat.ScrollBars = ScrollBars.Vertical;
            txt_Chat.Size = new Size(400, 200);
            txt_Chat.TabIndex = 4;
            txt_Chat.TextChanged += txt_Chat_TextChanged;
            // 
            // tm_CountDown
            // 
            tm_CountDown.Tick += Tm_CountDown_Tick;
            // 
            // txt_Message
            // 
            txt_Message.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_Message.Font = new Font("Arial", 12F);
            txt_Message.Location = new Point(969, 769);
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(323, 30);
            txt_Message.TabIndex = 4;
            // 
            // btn_Send
            // 
            btn_Send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Send.BackColor = Color.RoyalBlue;
            btn_Send.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Send.Cursor = Cursors.Hand;
            btn_Send.FlatAppearance.BorderColor = Color.Black;
            btn_Send.FlatAppearance.BorderSize = 0;
            btn_Send.FlatStyle = FlatStyle.Popup;
            btn_Send.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            btn_Send.ForeColor = Color.White;
            btn_Send.Location = new Point(1298, 769);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(70, 30);
            btn_Send.TabIndex = 3;
            btn_Send.Text = "Send";
            btn_Send.UseVisualStyleBackColor = false;
            btn_Send.Click += Btn_Send_Click;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, optionsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 3, 0, 3);
            menuStrip.Size = new Size(1387, 30);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator1, quitToolStripMenuItem });
            menuToolStripMenuItem.ForeColor = Color.Black;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(218, 26);
            newGameToolStripMenuItem.Text = "&New Game";
            newGameToolStripMenuItem.Click += NewGameToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(218, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(218, 26);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += RedoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(215, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            quitToolStripMenuItem.Size = new Size(218, 26);
            quitToolStripMenuItem.Text = "&Quit";
            quitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem2, toolStripSeparator2, settingsToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // playerToolStripMenuItem2
            // 
            playerToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ViaLANToolStripMenuItem, SameComToolStripMenuItem });
            playerToolStripMenuItem2.Name = "playerToolStripMenuItem2";
            playerToolStripMenuItem2.Size = new Size(224, 26);
            playerToolStripMenuItem2.Text = "2 Players";
            // 
            // ViaLANToolStripMenuItem
            // 
            ViaLANToolStripMenuItem.Name = "ViaLANToolStripMenuItem";
            ViaLANToolStripMenuItem.Size = new Size(224, 26);
            ViaLANToolStripMenuItem.Text = "2 Players";
            ViaLANToolStripMenuItem.Click += ViaLANToolStripMenuItem_Click;
            // 
            // SameComToolStripMenuItem
            // 
            SameComToolStripMenuItem.Name = "SameComToolStripMenuItem";
            SameComToolStripMenuItem.Size = new Size(224, 26);
            SameComToolStripMenuItem.Text = "2 Players is User";
            SameComToolStripMenuItem.Click += SameComToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(221, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(224, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Visible = false;
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howToPlayToolStripMenuItem, toolStripSeparator3, aboutThisGameToolStripMenuItem, contactMeToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            howToPlayToolStripMenuItem.ShortcutKeys = Keys.F1;
            howToPlayToolStripMenuItem.Size = new Size(202, 26);
            howToPlayToolStripMenuItem.Text = "How to play";
            howToPlayToolStripMenuItem.Click += HowToPlayToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(199, 6);
            // 
            // aboutThisGameToolStripMenuItem
            // 
            aboutThisGameToolStripMenuItem.Name = "aboutThisGameToolStripMenuItem";
            aboutThisGameToolStripMenuItem.Size = new Size(202, 26);
            aboutThisGameToolStripMenuItem.Text = "About this game";
            aboutThisGameToolStripMenuItem.Click += AboutThisGameToolStripMenuItem_Click;
            // 
            // contactMeToolStripMenuItem
            // 
            contactMeToolStripMenuItem.Name = "contactMeToolStripMenuItem";
            contactMeToolStripMenuItem.Size = new Size(202, 26);
            contactMeToolStripMenuItem.Text = "Contact me";
            contactMeToolStripMenuItem.Visible = false;
            contactMeToolStripMenuItem.Click += ContactMeToolStripMenuItem_Click;
            // 
            // GameCaro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1387, 889);
            Controls.Add(pb_Logo);
            Controls.Add(txt_Chat);
            Controls.Add(txt_Message);
            Controls.Add(panel4);
            Controls.Add(btn_Send);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pn_GameBoard);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameCaro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Caro ";
            FormClosing += GameCaro_FormClosing;
            Load += GameCaro_Load;
            Shown += GameCaro_Shown;
            ((System.ComponentModel.ISupportInitialize)pb_Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Grb_About.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_Avatar).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel pn_GameBoard;

        #region MenuStrip
        private System.Windows.Forms.MenuStrip menuStrip;

        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ViaLANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SameComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutThisGameToolStripMenuItem;
        #endregion

        #region Panel 1
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Logo;
        #endregion

        #region Panel 2 + 3
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.GroupBox Grb_About;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_About;
        private System.Windows.Forms.Timer tm_About;
        private System.Windows.Forms.TextBox txt_PlayerName;
        #endregion

        #region Panel 4
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer tm_CountDown;
        private System.Windows.Forms.ProgressBar pgb_CountDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Button btn_LAN;
        private System.Windows.Forms.Button btn_SameCom;
        private System.Windows.Forms.Button btn_AI;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Redo;
        #endregion

        #region LAN Chat
        private System.Windows.Forms.TextBox txt_Chat;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Button btn_Send;
        #endregion
    }
}