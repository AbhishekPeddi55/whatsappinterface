namespace loginpage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Createanaccount = new LinkLabel();
            Whatsapp = new Label();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            button1 = new Button();
            SuspendLayout();
            // 
            // Createanaccount
            // 
            Createanaccount.AutoSize = true;
            Createanaccount.BackColor = Color.Transparent;
            Createanaccount.DisabledLinkColor = Color.Black;
            Createanaccount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Createanaccount.LinkColor = Color.Black;
            Createanaccount.Location = new Point(107, 203);
            Createanaccount.Name = "Createanaccount";
            Createanaccount.Size = new Size(141, 21);
            Createanaccount.TabIndex = 1;
            Createanaccount.TabStop = true;
            Createanaccount.Text = "Create an account";
            Createanaccount.LinkClicked += Createanaccount_LinkClicked;
            // 
            // Whatsapp
            // 
            Whatsapp.AutoSize = true;
            Whatsapp.BackColor = Color.Transparent;
            Whatsapp.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Whatsapp.ForeColor = SystemColors.ActiveCaptionText;
            Whatsapp.Location = new Point(48, 50);
            Whatsapp.Name = "Whatsapp";
            Whatsapp.Size = new Size(272, 65);
            Whatsapp.TabIndex = 2;
            Whatsapp.Text = "Whatsapp";
            Whatsapp.Click += Whatsapp_Click_1;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(149, 224);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(61, 21);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "sign in ";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(107, 245);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(157, 21);
            linkLabel3.TabIndex = 4;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "log in with fascbook";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BackColor = SystemColors.ActiveCaption;
            linkLabel4.Location = new Point(343, 9);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(12, 15);
            linkLabel4.TabIndex = 5;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "?";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.whatsapp_logo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(367, 307);
            Controls.Add(button1);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(Whatsapp);
            Controls.Add(Createanaccount);
            Name = "Form1";
            Text = "whatsapp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel Createanaccount;
        private Label Whatsapp;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private Button button1;
    }
}
