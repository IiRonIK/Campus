namespace Campus
{
    partial class log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pbOpenedEye = new System.Windows.Forms.PictureBox();
            this.pbClosedEye = new System.Windows.Forms.PictureBox();
            this.log_inButton = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosedEye)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pbOpenedEye);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pbClosedEye);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.log_inButton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbPassword);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tbUsername);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(434, 286);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(434, 311);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // pbOpenedEye
            // 
            this.pbOpenedEye.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenedEye.Image")));
            this.pbOpenedEye.Location = new System.Drawing.Point(288, 136);
            this.pbOpenedEye.Name = "pbOpenedEye";
            this.pbOpenedEye.Size = new System.Drawing.Size(20, 20);
            this.pbOpenedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOpenedEye.TabIndex = 10;
            this.pbOpenedEye.TabStop = false;
            this.pbOpenedEye.Click += new System.EventHandler(this.pbOpenedEye_Click);
            // 
            // pbClosedEye
            // 
            this.pbClosedEye.Image = ((System.Drawing.Image)(resources.GetObject("pbClosedEye.Image")));
            this.pbClosedEye.Location = new System.Drawing.Point(288, 136);
            this.pbClosedEye.Name = "pbClosedEye";
            this.pbClosedEye.Size = new System.Drawing.Size(20, 20);
            this.pbClosedEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClosedEye.TabIndex = 9;
            this.pbClosedEye.TabStop = false;
            this.pbClosedEye.Click += new System.EventHandler(this.pbClosedEye_Click_1);
            // 
            // log_inButton
            // 
            this.log_inButton.Location = new System.Drawing.Point(176, 187);
            this.log_inButton.Name = "log_inButton";
            this.log_inButton.Size = new System.Drawing.Size(75, 23);
            this.log_inButton.TabIndex = 4;
            this.log_inButton.Text = "Войти";
            this.log_inButton.UseVisualStyleBackColor = true;
            this.log_inButton.Click += new System.EventHandler(this.log_inButton_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(147, 136);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(135, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(147, 79);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(135, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя:";
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "log_in";
            this.Text = "Окно авторизации";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenedEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosedEye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button log_inButton;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOpenedEye;
        private System.Windows.Forms.PictureBox pbClosedEye;
    }
}