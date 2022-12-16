namespace ProgressBarDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateProgressBar();
        }

        private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Visit the project online:\r\n https://github.com/LogoFun13-YT/ProgressBarDemo\r\nYou can then fork the project and make your own changes to it!\r\n\r\n\r\nPlease note: You will need Visual Studio to edit and build the forked project, you can get it from Microsoft through this URL: https://visualstudio.microsoft.com/downloads/", "Visit the Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help for the program, Progress Bar Demo Program\r\n\r\nThis program was designed for you to have a progress bar that you can control.\r\n\r\nTo change the current value of the progress bar, Click and Drag the track bar to the value you want to set it to, then click on the button labeled \"Change Progress Bar Value\" and the progress bar will update with the new value you have set on the track bar.\r\n\r\nIf you want to play around with the source code, click the link to visit the GitHub repository.", "Help - Progress Bar Demo Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}