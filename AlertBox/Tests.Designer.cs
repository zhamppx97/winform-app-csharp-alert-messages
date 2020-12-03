
namespace AlertBox
{
    partial class Tests
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
            this.ButtonSuccess = new System.Windows.Forms.Button();
            this.ButtonInfo = new System.Windows.Forms.Button();
            this.ButtonWarning = new System.Windows.Forms.Button();
            this.ButtonError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSuccess
            // 
            this.ButtonSuccess.Location = new System.Drawing.Point(13, 13);
            this.ButtonSuccess.Name = "ButtonSuccess";
            this.ButtonSuccess.Size = new System.Drawing.Size(75, 23);
            this.ButtonSuccess.TabIndex = 0;
            this.ButtonSuccess.Text = "Success";
            this.ButtonSuccess.UseVisualStyleBackColor = true;
            this.ButtonSuccess.Click += new System.EventHandler(this.ButtonSuccess_Click);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Location = new System.Drawing.Point(94, 13);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(75, 23);
            this.ButtonInfo.TabIndex = 1;
            this.ButtonInfo.Text = "Info";
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // ButtonWarning
            // 
            this.ButtonWarning.Location = new System.Drawing.Point(175, 13);
            this.ButtonWarning.Name = "ButtonWarning";
            this.ButtonWarning.Size = new System.Drawing.Size(75, 23);
            this.ButtonWarning.TabIndex = 2;
            this.ButtonWarning.Text = "Warning";
            this.ButtonWarning.UseVisualStyleBackColor = true;
            this.ButtonWarning.Click += new System.EventHandler(this.ButtonWarning_Click);
            // 
            // ButtonError
            // 
            this.ButtonError.Location = new System.Drawing.Point(256, 13);
            this.ButtonError.Name = "ButtonError";
            this.ButtonError.Size = new System.Drawing.Size(75, 23);
            this.ButtonError.TabIndex = 3;
            this.ButtonError.Text = "Error";
            this.ButtonError.UseVisualStyleBackColor = true;
            this.ButtonError.Click += new System.EventHandler(this.ButtonError_Click);
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 50);
            this.Controls.Add(this.ButtonError);
            this.Controls.Add(this.ButtonWarning);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.ButtonSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tests";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSuccess;
        private System.Windows.Forms.Button ButtonInfo;
        private System.Windows.Forms.Button ButtonWarning;
        private System.Windows.Forms.Button ButtonError;
    }
}