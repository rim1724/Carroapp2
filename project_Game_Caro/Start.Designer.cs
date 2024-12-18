namespace project_Game_Caro
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cstbtnPlaySameComputer = new Layout.CustomButton();
            cstbtnExit = new Layout.CustomButton();
            cstbtnPlay2 = new Layout.CustomButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cstbtnPlay = new Layout.CustomButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cstbtnPlay);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 501);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(438, 80);
            label2.Name = "label2";
            label2.Size = new Size(229, 76);
            label2.TabIndex = 12;
            label2.Text = "CARO";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(190, 80);
            label1.Name = "label1";
            label1.Size = new Size(234, 76);
            label1.TabIndex = 7;
            label1.Text = "GAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(cstbtnPlaySameComputer);
            panel2.Controls.Add(cstbtnExit);
            panel2.Controls.Add(cstbtnPlay2);
            panel2.Location = new Point(205, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 312);
            panel2.TabIndex = 1;
            // 
            // cstbtnPlaySameComputer
            // 
            cstbtnPlaySameComputer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlaySameComputer.BackColor = Color.Transparent;
            cstbtnPlaySameComputer.Cursor = Cursors.Hand;
            cstbtnPlaySameComputer.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnPlaySameComputer.FlatAppearance.BorderSize = 0;
            cstbtnPlaySameComputer.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlaySameComputer.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlaySameComputer.FlatStyle = FlatStyle.Flat;
            cstbtnPlaySameComputer.Font = new Font("Microsoft Sans Serif", 23F);
            cstbtnPlaySameComputer.ForeColor = Color.RoyalBlue;
            cstbtnPlaySameComputer.Location = new Point(43, 131);
            cstbtnPlaySameComputer.Name = "cstbtnPlaySameComputer";
            cstbtnPlaySameComputer.Size = new Size(371, 69);
            cstbtnPlaySameComputer.TabIndex = 3;
            cstbtnPlaySameComputer.Text = "2 Player is User";
            cstbtnPlaySameComputer.UseVisualStyleBackColor = false;
            // 
            // cstbtnExit
            // 
            cstbtnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnExit.BackColor = Color.Transparent;
            cstbtnExit.Cursor = Cursors.Hand;
            cstbtnExit.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnExit.FlatAppearance.BorderSize = 0;
            cstbtnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnExit.FlatStyle = FlatStyle.Flat;
            cstbtnExit.Font = new Font("Microsoft Sans Serif", 23F);
            cstbtnExit.ForeColor = Color.RoyalBlue;
            cstbtnExit.Location = new Point(96, 224);
            cstbtnExit.Name = "cstbtnExit";
            cstbtnExit.Size = new Size(261, 69);
            cstbtnExit.TabIndex = 2;
            cstbtnExit.Text = "Exit";
            cstbtnExit.UseVisualStyleBackColor = false;
            // 
            // cstbtnPlay2
            // 
            cstbtnPlay2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlay2.BackColor = Color.Transparent;
            cstbtnPlay2.Cursor = Cursors.Hand;
            cstbtnPlay2.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnPlay2.FlatAppearance.BorderSize = 0;
            cstbtnPlay2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlay2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlay2.FlatStyle = FlatStyle.Flat;
            cstbtnPlay2.Font = new Font("Microsoft Sans Serif", 23F);
            cstbtnPlay2.ForeColor = Color.RoyalBlue;
            cstbtnPlay2.Location = new Point(96, 56);
            cstbtnPlay2.Name = "cstbtnPlay2";
            cstbtnPlay2.Size = new Size(261, 69);
            cstbtnPlay2.TabIndex = 1;
            cstbtnPlay2.Text = "2 Player";
            cstbtnPlay2.UseVisualStyleBackColor = false;
            cstbtnPlay2.Click += cstbtnPlay2_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // cstbtnPlay
            // 
            cstbtnPlay.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cstbtnPlay.BackColor = Color.Transparent;
            cstbtnPlay.Cursor = Cursors.Hand;
            cstbtnPlay.FlatAppearance.BorderColor = Color.FromArgb(80, 192, 255, 255);
            cstbtnPlay.FlatAppearance.BorderSize = 0;
            cstbtnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            cstbtnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cstbtnPlay.FlatStyle = FlatStyle.Flat;
            cstbtnPlay.Font = new Font("Microsoft Sans Serif", 23F);
            cstbtnPlay.ForeColor = Color.RoyalBlue;
            cstbtnPlay.Location = new Point(0, 370);
            cstbtnPlay.Name = "cstbtnPlay";
            cstbtnPlay.Size = new Size(23, 69);
            cstbtnPlay.TabIndex = 0;
            cstbtnPlay.UseVisualStyleBackColor = false;
            cstbtnPlay.Click += cstbtnPlay_Click_1;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 501);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Start";
            Text = "Start Game Caro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Layout.CustomButton cstbtnExit;
        private Layout.CustomButton cstbtnPlay2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Layout.CustomButton cstbtnPlaySameComputer;
        private Layout.CustomButton cstbtnPlay;
    }
}