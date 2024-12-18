namespace project_Game_Caro
{
    partial class InputIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputIP));
            label1 = new Label();
            txtIPAddress = new TextBox();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(42, 92);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập IP";
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(146, 97);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(248, 27);
            txtIPAddress.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(193, 172);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // InputIP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 253);
            Controls.Add(btnOK);
            Controls.Add(txtIPAddress);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InputIP";
            Text = "InputIP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIPAddress;
        private Button btnOK;
    }
}