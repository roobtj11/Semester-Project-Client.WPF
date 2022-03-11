namespace Semester_Project_Client.WPF
{
    partial class WelcomePage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.WelcomeTab = new System.Windows.Forms.TabPage();
            this.Quit = new System.Windows.Forms.Button();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.NewUserTab = new System.Windows.Forms.TabPage();
            this.WelcomeText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.WelcomeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.WelcomeTab);
            this.tabControl1.Controls.Add(this.LoginTab);
            this.tabControl1.Controls.Add(this.NewUserTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1532, 783);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // WelcomeTab
            // 
            this.WelcomeTab.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WelcomeTab.Controls.Add(this.WelcomeText);
            this.WelcomeTab.Controls.Add(this.Quit);
            this.WelcomeTab.Location = new System.Drawing.Point(4, 5);
            this.WelcomeTab.Name = "WelcomeTab";
            this.WelcomeTab.Size = new System.Drawing.Size(1524, 774);
            this.WelcomeTab.TabIndex = 0;
            this.WelcomeTab.Text = "tabPage1";
            this.WelcomeTab.Click += new System.EventHandler(this.WelcomeTab_Click);
            // 
            // Quit
            // 
            this.Quit.AccessibleName = "Quit";
            this.Quit.Location = new System.Drawing.Point(1446, 3);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginTab.Location = new System.Drawing.Point(4, 5);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(1524, 774);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "tabPage1";
            // 
            // NewUserTab
            // 
            this.NewUserTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewUserTab.Location = new System.Drawing.Point(4, 5);
            this.NewUserTab.Name = "NewUserTab";
            this.NewUserTab.Size = new System.Drawing.Size(1524, 774);
            this.NewUserTab.TabIndex = 2;
            this.NewUserTab.Text = "tabPage1";
            // 
            // WelcomeText
            // 
            this.WelcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.Location = new System.Drawing.Point(629, 278);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.ReadOnly = true;
            this.WelcomeText.Size = new System.Drawing.Size(365, 44);
            this.WelcomeText.TabIndex = 1;
            this.WelcomeText.Text = "Connecting To The Server";
            this.WelcomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WelcomePage
            // 
            this.AccessibleName = "WelcomePage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 779);
            this.Controls.Add(this.tabControl1);
            this.Name = "WelcomePage";
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.WelcomeTab.ResumeLayout(false);
            this.WelcomeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage WelcomeTab;
        private TabPage LoginTab;
        private TabPage NewUserTab;
        private Button Quit;
        private TextBox WelcomeText;
    }
}