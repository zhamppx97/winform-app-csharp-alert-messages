namespace AlertBox
{
    partial class Alert
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
            this.components = new System.ComponentModel.Container();
            this.TimerAlertShow = new System.Windows.Forms.Timer(this.components);
            this.LabelMessages = new System.Windows.Forms.Label();
            this.AlertImage = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerAlertShow
            // 
            this.TimerAlertShow.Interval = 10;
            this.TimerAlertShow.Tick += new System.EventHandler(this.TimerAlertShow_Tick);
            // 
            // LabelMessages
            // 
            this.LabelMessages.AutoSize = true;
            this.LabelMessages.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessages.ForeColor = System.Drawing.SystemColors.Window;
            this.LabelMessages.Location = new System.Drawing.Point(100, 41);
            this.LabelMessages.Name = "LabelMessages";
            this.LabelMessages.Size = new System.Drawing.Size(147, 33);
            this.LabelMessages.TabIndex = 0;
            this.LabelMessages.Text = "Messages";
            // 
            // AlertImage
            // 
            this.AlertImage.Location = new System.Drawing.Point(12, 27);
            this.AlertImage.Name = "AlertImage";
            this.AlertImage.Size = new System.Drawing.Size(72, 60);
            this.AlertImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AlertImage.TabIndex = 2;
            this.AlertImage.TabStop = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Image = global::AlertBox.Properties.Resources.icons8_close_64;
            this.ButtonClose.Location = new System.Drawing.Point(384, 16);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(16, 14);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 5);
            this.panel1.TabIndex = 3;
            // 
            // Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(412, 112);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AlertImage);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.LabelMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Text = "Alert";
            ((System.ComponentModel.ISupportInitialize)(this.AlertImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelMessages;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.PictureBox AlertImage;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Timer TimerAlertShow;
    }
}

