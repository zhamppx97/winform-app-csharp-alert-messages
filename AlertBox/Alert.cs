using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlertBox
{
    public partial class Alert : Form
    {
        private Alert.Action action;

        private enum Action
        {
            Wait, Start, Close
        }

        public enum AlertType
        {
            Success, Info, Warning, Error
        }

        public Alert()
        {
            InitializeComponent();
        }

        private int x, y;
        public void Show(string message, AlertType alertType)
        {
            Alert alert = new Alert
            {
                Opacity = 0.0,
                StartPosition = FormStartPosition.Manual
            };

            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert frm = (Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    alert.Name = fname;
                    alert.x = Screen.PrimaryScreen.WorkingArea.Width - alert.Width + 15;
                    alert.y = Screen.PrimaryScreen.WorkingArea.Height - alert.Height * i - 5 * i;
                    alert.Location = new Point(alert.x, alert.y);
                    break;
                }
            }
            alert.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (alertType)
            {
                case AlertType.Success:
                    alert.BackColor = Color.SeaGreen;
                    alert.LabelMessages.Text = message;
                    alert.AlertImage.Image = Properties.Resources.icons8_success_64;
                    break;
                case AlertType.Info:
                    alert.BackColor = Color.LightSkyBlue;
                    alert.LabelMessages.Text = message;
                    alert.AlertImage.Image = Properties.Resources.icons8_info_64;
                    break;
                case AlertType.Warning:
                    alert.BackColor = Color.Orange;
                    alert.LabelMessages.Text = message;
                    alert.AlertImage.Image = Properties.Resources.icons8_warning_64;
                    break;
                case AlertType.Error:
                    alert.BackColor = Color.Crimson;
                    alert.LabelMessages.Text = message;
                    alert.AlertImage.Image = Properties.Resources.icons8_error_64;
                    break;
                default:
                    break;
            }

            alert.Show();
            alert.action = Action.Start;
            alert.TimerAlertShow.Interval = 1;
            alert.TimerAlertShow.Start();
        }

        private void TimerAlertShow_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Action.Wait:
                    TimerAlertShow.Interval = 5000;
                    action = Action.Close;
                    break;
                case Alert.Action.Start:
                    this.TimerAlertShow.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Alert.Action.Wait;
                        }
                    }
                    break;
                case Action.Close:
                    TimerAlertShow.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
