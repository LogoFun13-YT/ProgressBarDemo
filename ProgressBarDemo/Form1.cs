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

        private void Button1_Click2(object sender, MouseEventArgs e)
        {
            UpdateProgressBar();
        }

        private void LinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while trying to open the link.\r\n\r\nIf this is the first time you are seeing this error, try clicking on the link again.\r\n\r\nIf you continue to keep getting this message, try one of the following options:\r\n* If the program is running in a partial-trust environment (like on a shared drive), the JIT compiler will fail upon calling the VisitLink method. If that is the case, copy the program to a local drive, and run the program from that drive.\r\n* Check your system or anti-virus settings to make sure that your internet browser isn't blocked. If it is, remove or white-list that program.\r\n* If all else fails, open the following URL in your internet browser:\r\n      github.com/LogoFun13-YT/ProgressBarDemo\r\n\r\nError details: {ex}", "Something unexpected happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}