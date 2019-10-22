using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlertMessages
{
    public partial class Alert : Form
    {
        public Alert(string messages, AlertType alertType)
        {
            InitializeComponent();

            //string messages = "Success!";
            //AlertType alertType = AlertType.success;
            switch (alertType)
            {
                case AlertType.success:
                    this.BackColor = Color.SeaGreen;
                    LabelMessages.Text = messages;
                    AlertImage.Image = Properties.Resources.icons8_success_64;
                    break;
                case AlertType.info:
                    this.BackColor = Color.LightSkyBlue;
                    LabelMessages.Text = messages;
                    AlertImage.Image = Properties.Resources.icons8_info_64;
                    break;
                case AlertType.warning:
                    this.BackColor = Color.Orange;
                    LabelMessages.Text = messages;
                    AlertImage.Image = Properties.Resources.icons8_warning_64;
                    break;
                case AlertType.error:
                    this.BackColor = Color.Crimson;
                    LabelMessages.Text = messages;
                    AlertImage.Image = Properties.Resources.icons8_error_64;
                    break;
                default:
                    break;
            }
        }

        public enum AlertType
        {
            success, info, warning, error
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            TimerAlertShow.Start();
        }

        int interval = 0;
        private void TimerAlertShow_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                TimerAlertShow.Stop();
            }
        }

        private void TimerAlertClose_Tick(object sender, EventArgs e)
        {
            TimerFadeClose.Start();
        }

        private void TimerFadeClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
